﻿using System;
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
        int value;
        private string command,login,password,ip;//"mpstat 1 1 | awk '$3 ~ /CPU/ { for(i=1;i<=NF;i++) { if ($i ~ /%idle/) field=i } } $3 ~ /all/ { printf(" % d",100 - $field) }'";
        private int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            value = 30;
            i = 0;
            command = "./mpstat.sh";
            changeProgressBar(null, null);
            ShowMyDialogBox();
        }

        public void ShowMyDialogBox()
        {
            Form2 testDialog = new Form2();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                //this.textBoxCommand.Text = testDialog.pass;
                this.textBoxCommand.Text = "OK";
            }
            else
            {
                //this.textBoxCommand.Text = "Login: " +  testDialog.LOGIN + " Hasło: " + testDialog.PASSWORD + " Ip: " + testDialog.IP;
                this.textBoxCommand.Text = testDialog.LOGIN + testDialog.PASSWORD + testDialog.IP;
                this.login = testDialog.LOGIN;
                this.password = testDialog.PASSWORD;
                this.ip= testDialog.IP;
                //this.textBoxCommand.Text = "Cancelled";
            }
            testDialog.Dispose();
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void circularProgressBarCPU_Click(object sender, EventArgs e)
        {

        }

        private void buttonValuePlus_Click(object sender, EventArgs e)
        {
            value += 5;
            changeProgressBar(null, null);
        }

        private void buttonValueMinus_Click(object sender, EventArgs e)
        {
            value -= 5;
            changeProgressBar(null, null);
        }

        private void changeProgressBar(object sender, EventArgs e)
        {
            circularProgressBarCPU.Value = value;
            circularProgressBarCPU.SubscriptText = value.ToString();
        }

        private void connnectToServer(object sender, EventArgs e)
        {
            var client = new SshClient("80.211.255.150", "usage", "test1234");
            client.Connect();
            {
                Thread thread = new Thread(
                    new ThreadStart(() =>
                    {
                        for(; ; )
                        {
                            i++;
                            var cmd = client.RunCommand(command); // mpstat 1 1 | awk '$3 ~ /CPU/ { for(i=1;i<=NF;i++) { if ($i ~ /%idle/) field=i } } $3 ~ /all/ { printf("%d",100 - $field) }'
                            var result = cmd.Execute();
                            value = Convert.ToInt16(result);
                            Invoke(new Action(() =>
                            {
                                changeProgressBar(null, null);
                                textBoxValue.Text = "CPU usage: " + result +"%"  + " steps: " + i;
                            }));
                            //System.Threading.Thread.Sleep(1000);
                        }                      
                    }));
                thread.Start();
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connnectToServer(null, null);
        }

        private void textBoxCommand_TextChanged(object sender, EventArgs e)
        {
            command = textBoxCommand.Text;
        }
    }
}