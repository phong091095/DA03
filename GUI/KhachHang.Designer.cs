namespace DAM
{
    partial class KhachHang
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            TK_Button = new Button();
            Add_Bt = new Button();
            Del_Bt = new Button();
            Update_Bt = new Button();
            Save_Bt = new Button();
            Reset_Bt = new Button();
            Close_Bt = new Button();
            DS_Bt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 102);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 1;
            label1.Text = "Điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 202);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(768, 102);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(768, 202);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 4;
            label4.Text = "Giới tính";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(286, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(941, 99);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(388, 72);
            textBox3.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(982, 198);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 35);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(1135, 198);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 35);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1132, 257);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(528, 629);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(351, 39);
            textBox4.TabIndex = 11;
            // 
            // TK_Button
            // 
            TK_Button.Location = new Point(941, 624);
            TK_Button.Name = "TK_Button";
            TK_Button.Size = new Size(150, 46);
            TK_Button.TabIndex = 12;
            TK_Button.Text = "Tìm kiếm";
            TK_Button.UseVisualStyleBackColor = true;
            TK_Button.Click += TK_Button_Click;
            // 
            // Add_Bt
            // 
            Add_Bt.Location = new Point(75, 710);
            Add_Bt.Name = "Add_Bt";
            Add_Bt.Size = new Size(150, 46);
            Add_Bt.TabIndex = 13;
            Add_Bt.Text = "Thêm";
            Add_Bt.UseVisualStyleBackColor = true;
            Add_Bt.Click += Add_Bt_Click;
            // 
            // Del_Bt
            // 
            Del_Bt.Location = new Point(295, 710);
            Del_Bt.Name = "Del_Bt";
            Del_Bt.Size = new Size(150, 46);
            Del_Bt.TabIndex = 14;
            Del_Bt.Text = "Xóa";
            Del_Bt.UseVisualStyleBackColor = true;
            Del_Bt.Click += Del_Bt_Click;
            // 
            // Update_Bt
            // 
            Update_Bt.Location = new Point(515, 710);
            Update_Bt.Name = "Update_Bt";
            Update_Bt.Size = new Size(150, 46);
            Update_Bt.TabIndex = 15;
            Update_Bt.Text = "Sửa";
            Update_Bt.UseVisualStyleBackColor = true;
            Update_Bt.Click += Update_Bt_Click;
            // 
            // Save_Bt
            // 
            Save_Bt.Location = new Point(730, 710);
            Save_Bt.Name = "Save_Bt";
            Save_Bt.Size = new Size(150, 46);
            Save_Bt.TabIndex = 16;
            Save_Bt.Text = "Lưu";
            Save_Bt.UseVisualStyleBackColor = true;
            Save_Bt.Click += Save_Bt_Click;
            // 
            // Reset_Bt
            // 
            Reset_Bt.Location = new Point(955, 710);
            Reset_Bt.Name = "Reset_Bt";
            Reset_Bt.Size = new Size(150, 46);
            Reset_Bt.TabIndex = 17;
            Reset_Bt.Text = "Bỏ qua";
            Reset_Bt.UseVisualStyleBackColor = true;
            Reset_Bt.Click += Reset_Bt_Click;
            // 
            // Close_Bt
            // 
            Close_Bt.Location = new Point(1395, 710);
            Close_Bt.Name = "Close_Bt";
            Close_Bt.Size = new Size(150, 46);
            Close_Bt.TabIndex = 18;
            Close_Bt.Text = "Đóng";
            Close_Bt.UseVisualStyleBackColor = true;
            Close_Bt.Click += Close_Bt_Click;
            // 
            // DS_Bt
            // 
            DS_Bt.Location = new Point(1175, 710);
            DS_Bt.Name = "DS_Bt";
            DS_Bt.Size = new Size(150, 46);
            DS_Bt.TabIndex = 19;
            DS_Bt.Text = "Danh sách";
            DS_Bt.UseVisualStyleBackColor = true;
            DS_Bt.Click += DS_Bt_Click;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 821);
            Controls.Add(DS_Bt);
            Controls.Add(Close_Bt);
            Controls.Add(Reset_Bt);
            Controls.Add(Save_Bt);
            Controls.Add(Update_Bt);
            Controls.Add(Del_Bt);
            Controls.Add(Add_Bt);
            Controls.Add(TK_Button);
            Controls.Add(textBox4);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "KhachHang";
            Text = "KhachHang";
            Load += KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Button TK_Button;
        private Button Add_Bt;
        private Button Del_Bt;
        private Button Update_Bt;
        private Button Save_Bt;
        private Button Reset_Bt;
        private Button Close_Bt;
        private Button DS_Bt;
    }
}