namespace DAM
{
    partial class ForgetPassword
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 49);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(435, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 39);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(279, 276);
            button1.Name = "button1";
            button1.Size = new Size(183, 46);
            button1.TabIndex = 4;
            button1.Text = "Lấy mật khẩu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(752, 266);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 552);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Name = "ForgetPassword";
            Text = "ForgetPassword";
            KeyDown += ForgetPassword_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}