namespace Log_and_Sign_Up
{
    partial class login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ShowPassword_chBox = new CheckBox();
            passWord_TextBox = new TextBox();
            label3 = new Label();
            userName_TextBox = new TextBox();
            label2 = new Label();
            log_in_label = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // ShowPassword_chBox
            // 
            ShowPassword_chBox.AutoSize = true;
            ShowPassword_chBox.BackColor = Color.Transparent;
            ShowPassword_chBox.ForeColor = SystemColors.ButtonHighlight;
            ShowPassword_chBox.Location = new Point(141, 191);
            ShowPassword_chBox.Name = "ShowPassword_chBox";
            ShowPassword_chBox.Size = new Size(108, 19);
            ShowPassword_chBox.TabIndex = 14;
            ShowPassword_chBox.Text = "Show Password";
            ShowPassword_chBox.UseVisualStyleBackColor = false;
            ShowPassword_chBox.CheckedChanged += ShowPassword_chBox_CheckedChanged;
            // 
            // passWord_TextBox
            // 
            passWord_TextBox.Location = new Point(141, 149);
            passWord_TextBox.Margin = new Padding(3, 2, 3, 2);
            passWord_TextBox.Name = "passWord_TextBox";
            passWord_TextBox.Size = new Size(302, 23);
            passWord_TextBox.TabIndex = 13;
            passWord_TextBox.TabStop = false;
            passWord_TextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(75, 151);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // userName_TextBox
            // 
            userName_TextBox.Cursor = Cursors.IBeam;
            userName_TextBox.Location = new Point(141, 110);
            userName_TextBox.Margin = new Padding(3, 2, 3, 2);
            userName_TextBox.Name = "userName_TextBox";
            userName_TextBox.Size = new Size(302, 23);
            userName_TextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(64, 112);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 10;
            label2.Text = "User Name";
            // 
            // log_in_label
            // 
            log_in_label.AutoSize = true;
            log_in_label.BackColor = Color.Transparent;
            log_in_label.Font = new Font("Infinite Realities", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_in_label.ForeColor = SystemColors.ButtonFace;
            log_in_label.Location = new Point(24, 29);
            log_in_label.Name = "log_in_label";
            log_in_label.Size = new Size(149, 32);
            log_in_label.TabIndex = 9;
            log_in_label.Text = "Log In ....";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(218, 247);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Log-in ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(189, 367);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Space;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(507, 415);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(ShowPassword_chBox);
            Controls.Add(passWord_TextBox);
            Controls.Add(label3);
            Controls.Add(userName_TextBox);
            Controls.Add(label2);
            Controls.Add(log_in_label);
            Margin = new Padding(3, 2, 3, 2);
            Name = "login_form";
            Text = "Log In";
            FormClosed += login_form_FormClosed;
            Load += login_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ShowPassword_chBox;
        private TextBox passWord_TextBox;
        private Label label3;
        private TextBox userName_TextBox;
        private Label label2;
        private Label log_in_label;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}