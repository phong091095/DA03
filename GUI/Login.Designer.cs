namespace DAM
{
    partial class Login
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
            label2 = new Label();
            txtEmail = new TextBox();
            txtPw = new TextBox();
            LoginBt = new Button();
            CloseBt = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 76);
            label1.Name = "label1";
            label1.Size = new Size(78, 31);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 165);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(430, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 39);
            txtEmail.TabIndex = 2;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(430, 157);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.Size = new Size(234, 39);
            txtPw.TabIndex = 3;
            txtPw.UseSystemPasswordChar = true;
            // 
            // LoginBt
            // 
            LoginBt.Location = new Point(306, 337);
            LoginBt.Name = "LoginBt";
            LoginBt.Size = new Size(150, 46);
            LoginBt.TabIndex = 4;
            LoginBt.Text = "Đăng nhập";
            LoginBt.UseVisualStyleBackColor = true;
            LoginBt.Click += LoginBt_Click;
            // 
            // CloseBt
            // 
            CloseBt.Location = new Point(572, 337);
            CloseBt.Name = "CloseBt";
            CloseBt.Size = new Size(150, 46);
            CloseBt.TabIndex = 5;
            CloseBt.Text = "Thoát";
            CloseBt.UseVisualStyleBackColor = true;
            CloseBt.Click += CloseBt_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(703, 249);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(192, 31);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 533);
            Controls.Add(linkLabel1);
            Controls.Add(CloseBt);
            Controls.Add(LoginBt);
            Controls.Add(txtPw);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPw;
        private Button LoginBt;
        private Button CloseBt;
        private LinkLabel linkLabel1;
    }
}