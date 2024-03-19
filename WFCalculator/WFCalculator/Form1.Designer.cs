namespace WFCalculator
{
    partial class Form1
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
            label2 = new Label();
            txbEmail = new TextBox();
            txbPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(134, 19);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(315, 31);
            txbEmail.TabIndex = 2;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(134, 75);
            txbPass.Name = "txbPass";
            txbPass.PasswordChar = '*';
            txbPass.Size = new Size(315, 31);
            txbPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(134, 159);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(337, 159);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nhan_vat_nu_anime_cute_1920x1080;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txbPass);
            Controls.Add(txbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbEmail;
        private TextBox txbPass;
        private Button btnLogin;
        private Button btnExit;
    }
}
