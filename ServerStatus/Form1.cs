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

namespace ServerStatus
{
    public partial class Form1 : Form
    {
        private int i, cpuValueUsage, ramValueUsage, ramMaxValue;
        private string cpuUsageCommand, ramUsageCommand, ramMaxValueCheckCommand, diskUsageCommand,login,password,ip;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpuValueUsage = 100;
            ramValueUsage = 16384;
            circularProgressBarRam.Maximum = ramMaxValue = 16384; //16GB
            i = 0;
            cpuUsageCommand = "./mpstat.sh"; // mpstat 1 1 | awk '$3 ~ /CPU/ { for(i=1;i<=NF;i++) { if ($i ~ /%idle/) field=i } } $3 ~ /all/ { printf("%d",100 - $field) }'
            ramUsageCommand = "./ramused.sh"; //free - m | awk 'FNR == 2 {print $3}'
            ramMaxValueCheckCommand = "./ramtotal.sh"; //free - m | awk 'FNR == 2 {print $2}'
            changeProgressBar(null, null);
            showLoginForm();
        }

        public void showLoginForm()
        {
            Form2 loginForm = new Form2();

            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.textBoxCommand.Text = loginForm.LOGIN + " - " + loginForm.PASSWORD + " - " + loginForm.IP;
                this.login = loginForm.LOGIN;
                this.password = loginForm.PASSWORD;
                this.ip = loginForm.IP;
            }
            else
            {
                this.textBoxCommand.Text = "NOT OK";
            }
            loginForm.Dispose();
        }

        private void buttonValuePlus_Click(object sender, EventArgs e)
        {            
            if(cpuValueUsage >= 100)
            {
                cpuValueUsage = 100;
            }
            else
            {
                cpuValueUsage += 5;
            }
            if (ramValueUsage >= ramMaxValue)
            {
                ramValueUsage = ramMaxValue;
            }
            else
            {
                ramValueUsage += 5;
            }
            changeProgressBar(null, null);
        }

        private void buttonValueMinus_Click(object sender, EventArgs e)
        {
            if(cpuValueUsage <= 0)
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

        private void changeProgressBar(object sender, EventArgs e)
        {
            circularProgressBarCPU.Value = cpuValueUsage;
            circularProgressBarCPU.SubscriptText = cpuValueUsage.ToString() + "%";

            circularProgressBarRam.Value = ramValueUsage;
            circularProgressBarRam.SubscriptText = ramValueUsage.ToString() + "\nMB";
        }

        private void connnectToServer(object sender, EventArgs e)
        {
            var client = new SshClient(ip, login, password);
            client.Connect();

            var ramValueLimitCmd = client.RunCommand(ramMaxValueCheckCommand);
            var ramValueLimit = ramValueLimitCmd.Execute();
            ramMaxValue = Convert.ToInt16(ramMaxValue);
            circularProgressBarRam.Maximum = Convert.ToInt16(ramValueLimit);

            {
                Thread threadCPU = new Thread(
                    new ThreadStart(() =>
                    {
                        for (; ; )
                        {
                            i++;
                            var cmdCPU = client.RunCommand(cpuUsageCommand);
                            var resultCPU = cmdCPU.Execute();
                            cpuValueUsage = Convert.ToInt16(resultCPU);
                            Invoke(new Action(() =>
                            {
                                changeProgressBar(null, null);
                                textBoxValue.Text = "CPU usage: " + resultCPU + "%" + " steps: " + i;


                            }));
                        }
                    }));
            
                Thread threadRAM = new Thread(
                    new ThreadStart(() =>
                    {
                        for (; ; )
                        {
                            i++;
                            var cmdRAM = client.RunCommand(ramUsageCommand);
                            var resultRAM = cmdRAM.Execute();
                            ramValueUsage = Convert.ToInt16(resultRAM);
                            Invoke(new Action(() =>
                            {
                                //changeProgressBar(null, null);
                                textBoxValue.Text += "\nRAM usage: " + resultRAM + "MB " + "steps: " + i;
                            }));
                            Thread.Sleep(1000);
                        }
                    }));
                threadCPU.Start();
                threadRAM.Start();
            }
        }


        private void buttonDisconnect_Click(Thread ramMeasurement, Thread cpuMeasurement, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connnectToServer(null, null);
        }

        private void textBoxCommand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}