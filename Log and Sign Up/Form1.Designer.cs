namespace Log_and_Sign_Up
{
    partial class Form1
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
            label1 = new Label();
            User_display_label = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Infinite Realities", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 124);
            label1.Name = "label1";
            label1.Size = new Size(387, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome Aboard...";
            // 
            // User_display_label
            // 
            User_display_label.AutoSize = true;
            User_display_label.BackColor = Color.Transparent;
            User_display_label.Font = new Font("Infinite Realities", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_display_label.ForeColor = Color.DarkOrange;
            User_display_label.Location = new Point(26, 184);
            User_display_label.Name = "User_display_label";
            User_display_label.Size = new Size(242, 69);
            User_display_label.TabIndex = 1;
            User_display_label.Text = "User...";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 24);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Saturn;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(User_display_label);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label User_display_label;
        private PictureBox pictureBox1;
    }
}