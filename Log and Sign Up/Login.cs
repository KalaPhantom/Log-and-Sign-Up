using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_and_Sign_Up
{
    public partial class login_form : Form
    {
        public login_form()
        {

            InitializeComponent();
        }

        private void ShowPassword_chBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_chBox.Checked)
            {
                passWord_TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passWord_TextBox.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.UserName == userName_TextBox.Text && Program.UserPassword == passWord_TextBox.Text)
            {
               Form1 form = new Form1();
                form.Show();
                Hide();
            }
            else
            {
                passWord_TextBox.Clear();
                userName_TextBox.Clear();
                MessageBox.Show($"Wrong User name or Password, Please try again..");
            }


        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }

        private void login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
