using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.Threading;
using ServerStatus.Connect___Workers;

namespace ServerStatus
{
    public partial class Form1 : Form
    {
        private int i, cpuValueUsage, ramValueUsage, ramValueMax;
        private string cpuUsageCommand, ramUsageCommand, ramMaxValueCheckCommand, diskUsageCommand, login, password, ip;
        private Thread getValuesThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpuValueUsage = 100;
            ramValueUsage = 16384;
            circularProgressBarRam.Maximum = ramValueMax = 16384; //16GB
            i = 0;
            cpuUsageCommand = "./mpstat.sh"; // mpstat 1 1 | awk '$3 ~ /CPU/ { for(i=1;i<=NF;i++) { if ($i ~ /%idle/) field=i } } $3 ~ /all/ { printf("%d",100 - $field) }'
            ramUsageCommand = "./ramused.sh"; //free - m | awk 'FNR == 2 {print $3}'
            ramMaxValueCheckCommand = "./ramtotal.sh"; //free - m | awk 'FNR == 2 {print $2}'
            changeProgressBar(null, null);
            //showLoginForm();
        }

        public void showLoginForm()
        {
            Form2 loginForm = new Form2();

            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.textBoxCommand.Text = loginForm.LOGIN + " - " + "***********" + " - " + loginForm.IP;
                this.login = loginForm.LOGIN;
                this.password = loginForm.PASSWORD;
                this.ip = loginForm.IP;
                GetValues(null, null);
            }
            else
            {
                this.textBoxCommand.Text = "You must login to server to get usage information from your server.";
            }
            loginForm.Dispose();
        }

        #region buttons to +/- value on progres bars

        private void buttonValuePlus_Click(object sender, EventArgs e)
        {
            if (cpuValueUsage >= 100)
            {
                cpuValueUsage = 100;
            }
            else
            {
                cpuValueUsage += 5;
            }
            if (ramValueUsage >= ramValueMax)
            {
                ramValueUsage = ramValueMax;
            }
            else
            {
                ramValueUsage += 5;
            }
            changeProgressBar(null, null);
        }

        private void buttonValueMinus_Click(object sender, EventArgs e)
        {
            if (cpuValueUsage <= 0)
            {
                cpuValueUsage = 0;
            }
            else
            {
                cpuValueUsage -= 5;
            }

            if (ramValueUsage <= 0)
            {
                ramValueUsage = 0;
            }
            else
            {
                ramValueUsage -= 5;
            }
            changeProgressBar(null, null);
        }

        #endregion

        private void changeProgressBar(object sender, EventArgs e)
        {
            circularProgressBarCPU.Value = cpuValueUsage;
            circularProgressBarCPU.SubscriptText = cpuValueUsage.ToString() + "%";

            circularProgressBarRam.Value = ramValueUsage;
            circularProgressBarRam.SubscriptText = ramValueUsage.ToString() + "\nMB";
        }

        private void GetValues(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;

            getValuesThread = new Thread(
            new ThreadStart(() =>
            {
                ConnectWorkers connectWorkers = new ConnectWorkers(cpuUsageCommand, ramUsageCommand, ramMaxValueCheckCommand, diskUsageCommand, ip, login, password);

                Invoke(new Action(() =>
                {
                    circularProgressBarRam.Maximum = ramValueMax = connectWorkers.GetramMaxValue();
                }));

                for (i = 0; ; i++)
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        cpuValueUsage = connectWorkers.GetcpuValueUsage();
                        ramValueUsage = connectWorkers.GetramValueUsage();
                        textBoxValue.Text = "CONNECTED"
                        + "\nCPU: " + cpuValueUsage.ToString()
                        + "\nRAM: " + ramValueUsage.ToString()
                        + "\nMax RAM: " + ramValueMax
                        + "\nIterations: " + i;
                        changeProgressBar(null, null);

                    }));
                }
            }));

            getValuesThread.Start();
        }

        #region Buttons to connect and disconnect

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            showLoginForm();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            getValuesThread.Abort();
            textBoxValue.Text += "\n\nDISCONNECTED";
            buttonConnect.Enabled = true;
        }

        #endregion
    }
}