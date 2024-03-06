namespace DAM.GUI
{
    partial class ThongKe
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 19);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1069, 548);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(8, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1053, 495);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nhập kho";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1041, 483);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(8, 45);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1053, 495);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tồn kho";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.RowTemplate.Height = 41;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1044, 483);
            dataGridView2.TabIndex = 0;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 592);
            Controls.Add(tabControl1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ThongKe";
            Text = "ThongKe";
            Load += ThongKe_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}