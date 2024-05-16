using Microsoft.VisualBasic.ApplicationServices;

namespace Log_and_Sign_Up
{
    public partial class Sign_up_form : Form
    {
        public Sign_up_form()
        {
            InitializeComponent();
        }


        // Shows the user-typed password

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This event will be triggered once the user interacts with the submit button 
        /// The event will validate if the user_name and password prompted by the user is apllicable 
        /// </summary>


        private void button1_Click(object sender, EventArgs e)
        {
            // Values to be use for the validation
            string userName = userName_TextBox.Text;
            string userPassword = passWord_TextBox.Text;

            int Validator_Username = userName.Length < 8 ? 1 : 2;
            int Validator_UserPassword = userPassword.Length < 8 ? 1 : 2;

            if (Validator_Username == 1 || Validator_UserPassword == 1)
            {
                // Shows a message pop-up and clears the content of the text boxes
                MessageBox.Show("Pls use an appropriate lenght of characters (at least 8 characters for User Name and Password)");
                userName_TextBox.Text = "";
                passWord_TextBox.Text = "";
            }
            else
            {
                Program.UserPassword = userPassword;
                Program.UserName = userName;
                login_form logIn = new login_form();
                logIn.Show();
                this.Hide();
            }

        }

        private void ShowPassword_chBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassword_chBox.Checked == true) { passWord_TextBox.UseSystemPasswordChar = false; }
            else { passWord_TextBox.UseSystemPasswordChar = true; }

        }

        // Pls delete this
        private void passWord_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form login = new login_form();
            login.ShowDialog();
        }
    }

}
