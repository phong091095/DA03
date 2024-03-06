namespace DAM.GUI
{
    partial class Mainform
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
            hệThôngToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpCTRLDToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtCTRLXToolStripMenuItem = new ToolStripMenuItem();
            thoátALTF4ToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            nhânViênALTNToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngALTKToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            thốngKêSảnPhẩmALTPToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnToolStripMenuItem = new ToolStripMenuItem();
            LoginLB = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThôngToolStripMenuItem, danhMụcToolStripMenuItem, thốngKêToolStripMenuItem, hướngDẫnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1462, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThôngToolStripMenuItem
            // 
            hệThôngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpCTRLDToolStripMenuItem, đăngXuấtCTRLXToolStripMenuItem, thoátALTF4ToolStripMenuItem });
            hệThôngToolStripMenuItem.Name = "hệThôngToolStripMenuItem";
            hệThôngToolStripMenuItem.Size = new Size(140, 38);
            hệThôngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpCTRLDToolStripMenuItem
            // 
            đăngNhậpCTRLDToolStripMenuItem.Enabled = false;
            đăngNhậpCTRLDToolStripMenuItem.Name = "đăngNhậpCTRLDToolStripMenuItem";
            đăngNhậpCTRLDToolStripMenuItem.Size = new Size(411, 44);
            đăngNhậpCTRLDToolStripMenuItem.Text = "Đăng Nhập      CTRL + D";
            // 
            // đăngXuấtCTRLXToolStripMenuItem
            // 
            đăngXuấtCTRLXToolStripMenuItem.Name = "đăngXuấtCTRLXToolStripMenuItem";
            đăngXuấtCTRLXToolStripMenuItem.Size = new Size(411, 44);
            đăngXuấtCTRLXToolStripMenuItem.Text = "Đăng Xuất       CTRL + X";
            đăngXuấtCTRLXToolStripMenuItem.Click += đăngXuấtCTRLXToolStripMenuItem_Click;
            // 
            // thoátALTF4ToolStripMenuItem
            // 
            thoátALTF4ToolStripMenuItem.Name = "thoátALTF4ToolStripMenuItem";
            thoátALTF4ToolStripMenuItem.Size = new Size(411, 44);
            thoátALTF4ToolStripMenuItem.Text = "Thoát              ALT + F4";
            thoátALTF4ToolStripMenuItem.Click += thoátALTF4ToolStripMenuItem_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sảnPhẩmToolStripMenuItem, nhânViênALTNToolStripMenuItem, kháchHàngALTKToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(145, 38);
            danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(387, 44);
            sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm       ALT + S";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // nhânViênALTNToolStripMenuItem
            // 
            nhânViênALTNToolStripMenuItem.Name = "nhânViênALTNToolStripMenuItem";
            nhânViênALTNToolStripMenuItem.Size = new Size(387, 44);
            nhânViênALTNToolStripMenuItem.Text = "Nhân Viên      ALT + N";
            nhânViênALTNToolStripMenuItem.Click += nhânViênALTNToolStripMenuItem_Click;
            // 
            // kháchHàngALTKToolStripMenuItem
            // 
            kháchHàngALTKToolStripMenuItem.Name = "kháchHàngALTKToolStripMenuItem";
            kháchHàngALTKToolStripMenuItem.Size = new Size(387, 44);
            kháchHàngALTKToolStripMenuItem.Text = "Khách Hàng    ALT + K";
            kháchHàngALTKToolStripMenuItem.Click += kháchHàngALTKToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêSảnPhẩmALTPToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(137, 38);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // thốngKêSảnPhẩmALTPToolStripMenuItem
            // 
            thốngKêSảnPhẩmALTPToolStripMenuItem.Name = "thốngKêSảnPhẩmALTPToolStripMenuItem";
            thốngKêSảnPhẩmALTPToolStripMenuItem.Size = new Size(471, 44);
            thốngKêSảnPhẩmALTPToolStripMenuItem.Text = "Thống Kê Sản Phẩm    ALT + P";
            thốngKêSảnPhẩmALTPToolStripMenuItem.Click += thốngKêSảnPhẩmALTPToolStripMenuItem_Click;
            // 
            // hướngDẫnToolStripMenuItem
            // 
            hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            hướngDẫnToolStripMenuItem.Size = new Size(157, 38);
            hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            hướngDẫnToolStripMenuItem.Click += hướngDẫnToolStripMenuItem_Click;
            // 
            // LoginLB
            // 
            LoginLB.AutoSize = true;
            LoginLB.Location = new Point(1252, 40);
            LoginLB.Name = "LoginLB";
            LoginLB.Size = new Size(0, 31);
            LoginLB.TabIndex = 1;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 700);
            Controls.Add(LoginLB);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Mainform";
            Text = "Mainform";
            KeyDown += Mainform_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label LoginLB;
        private ToolStripMenuItem hệThôngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpCTRLDToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtCTRLXToolStripMenuItem;
        private ToolStripMenuItem thoátALTF4ToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem nhânViênALTNToolStripMenuItem;
        private ToolStripMenuItem kháchHàngALTKToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thốngKêSảnPhẩmALTPToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
    }
}