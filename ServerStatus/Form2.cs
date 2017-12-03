using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerStatus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private string login, pass, ip;

        public string PASSWORD{ get{ return pass; }}
        public string LOGIN { get { return login; } }
        public string IP { get { return ip; } }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelLogin.Text = "Login";
            labelPass.Text = "Password";
            labelIP.Text = "Server IP";
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void labelIP_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login = textBoxLogin.Text;
            pass = textBoxPass.Text;
            ip = textBoxIP.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
