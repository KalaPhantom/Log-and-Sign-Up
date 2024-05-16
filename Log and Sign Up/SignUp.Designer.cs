namespace Log_and_Sign_Up
{
    partial class Sign_up_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            passWord_TextBox = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            userName_TextBox = new TextBox();
            ShowPassword_chBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Infinite Realities", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(211, 34);
            label1.TabIndex = 0;
            label1.Text = "Sign Up ......";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(72, 155);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // passWord_TextBox
            // 
            passWord_TextBox.Location = new Point(138, 153);
            passWord_TextBox.Margin = new Padding(3, 2, 3, 2);
            passWord_TextBox.Name = "passWord_TextBox";
            passWord_TextBox.Size = new Size(302, 23);
            passWord_TextBox.TabIndex = 4;
            passWord_TextBox.TabStop = false;
            passWord_TextBox.UseSystemPasswordChar = true;
            passWord_TextBox.TextChanged += passWord_TextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(62, 117);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(160, 336);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(188, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have an Account? Sign In ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(208, 274);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 28);
            button1.TabIndex = 7;
            button1.Text = "Sign-up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userName_TextBox
            // 
            userName_TextBox.Location = new Point(138, 114);
            userName_TextBox.Margin = new Padding(3, 2, 3, 2);
            userName_TextBox.Name = "userName_TextBox";
            userName_TextBox.Size = new Size(302, 23);
            userName_TextBox.TabIndex = 2;
            // 
            // ShowPassword_chBox
            // 
            ShowPassword_chBox.AutoSize = true;
            ShowPassword_chBox.BackColor = Color.Transparent;
            ShowPassword_chBox.ForeColor = SystemColors.ButtonHighlight;
            ShowPassword_chBox.Location = new Point(138, 195);
            ShowPassword_chBox.Name = "ShowPassword_chBox";
            ShowPassword_chBox.Size = new Size(108, 19);
            ShowPassword_chBox.TabIndex = 8;
            ShowPassword_chBox.Text = "Show Password";
            ShowPassword_chBox.UseVisualStyleBackColor = false;
            ShowPassword_chBox.CheckedChanged += ShowPassword_chBox_CheckedChanged;
            // 
            // Sign_up_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.NewImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(515, 392);
            Controls.Add(ShowPassword_chBox);
            Controls.Add(userName_TextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passWord_TextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Sign_up_form";
            Text = "Sign-up";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox passWord_TextBox;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox userName_TextBox;
        private CheckBox ShowPassword_chBox;
    }
}
