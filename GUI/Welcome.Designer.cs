namespace DAM
{
    partial class Welcome
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpCTRDToolStripMenuItem = new ToolStripMenuItem();
            thoátALTF4ToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, hướngDẫnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1518, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpCTRDToolStripMenuItem, thoátALTF4ToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(135, 38);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpCTRDToolStripMenuItem
            // 
            đăngNhậpCTRDToolStripMenuItem.Name = "đăngNhậpCTRDToolStripMenuItem";
            đăngNhậpCTRDToolStripMenuItem.Size = new Size(382, 44);
            đăngNhậpCTRDToolStripMenuItem.Text = "Đăng nhập    CTR + D";
            đăngNhậpCTRDToolStripMenuItem.Click += đăngNhậpCTRDToolStripMenuItem_Click;
            // 
            // thoátALTF4ToolStripMenuItem
            // 
            thoátALTF4ToolStripMenuItem.Name = "thoátALTF4ToolStripMenuItem";
            thoátALTF4ToolStripMenuItem.Size = new Size(382, 44);
            thoátALTF4ToolStripMenuItem.Text = "Thoát            CTR + X";
            thoátALTF4ToolStripMenuItem.Click += thoátALTF4ToolStripMenuItem_Click;
            // 
            // hướngDẫnToolStripMenuItem
            // 
            hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            hướngDẫnToolStripMenuItem.Size = new Size(154, 38);
            hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(694, 147);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 61);
            label1.TabIndex = 1;
            label1.Text = "SOF205";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(653, 284);
            label2.Name = "label2";
            label2.Size = new Size(283, 61);
            label2.TabIndex = 2;
            label2.Text = "Dự Án Mẫu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1119, 640);
            label3.Name = "label3";
            label3.Size = new Size(387, 36);
            label3.TabIndex = 3;
            label3.Text = "Trần Thanh Phong - PS31516";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 685);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Welcome";
            Text = "Welcome";
            KeyDown += Welcome_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpCTRDToolStripMenuItem;
        private ToolStripMenuItem thoátALTF4ToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}