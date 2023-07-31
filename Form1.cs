using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDPCMD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void ShowAndHidePassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowAndHidePassWord.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= false;
            }
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            string un = txtUserName.Text;
            string pw = txtPassword.Text;
            if (un != "RongYuMo" && pw != "YuMoROng")
            {
                txtOutput.Text = "Wrong Both";
            }
            else if (un != "RongYuMo")
            {
                txtOutput.Text = "Try to do it again";
            }
            else if (pw != "YuMoRong")
            {
                txtOutput.Text = "Try to do it again";
            }
            this.Hide();
            new Form2().Show();
            txtOutput.BackColor = Color.Red;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
