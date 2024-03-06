namespace DAM
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 60);
            label1.Name = "label1";
            label1.Size = new Size(151, 31);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu cũ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(450, 60);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(276, 39);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 140);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 220);
            label3.Name = "label3";
            label3.Size = new Size(214, 31);
            label3.TabIndex = 3;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 300);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 140);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(276, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(450, 220);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(276, 39);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(450, 300);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 39);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(312, 400);
            button1.Name = "button1";
            button1.Size = new Size(171, 46);
            button1.TabIndex = 8;
            button1.Text = "Xác nhận";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(647, 400);
            button2.Name = "button2";
            button2.Size = new Size(142, 46);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 513);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}