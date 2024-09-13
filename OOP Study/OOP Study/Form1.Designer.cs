namespace OOP_Study
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            maSinhVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoTenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lopDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anhVanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diemTrungBinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xepLoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            txb_code = new TextBox();
            txb_name = new TextBox();
            txb_class = new TextBox();
            num_toan = new NumericUpDown();
            num_anhvan = new NumericUpDown();
            num_tin = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_toan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_anhvan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_tin).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maSinhVienDataGridViewTextBoxColumn, hoTenDataGridViewTextBoxColumn, lopDataGridViewTextBoxColumn, toanDataGridViewTextBoxColumn, anhVanDataGridViewTextBoxColumn, tinDataGridViewTextBoxColumn, diemTrungBinhDataGridViewTextBoxColumn, xepLoaiDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(12, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(951, 150);
            dataGridView1.TabIndex = 18;
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            maSinhVienDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            maSinhVienDataGridViewTextBoxColumn.ReadOnly = true;
            maSinhVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            hoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            lopDataGridViewTextBoxColumn.HeaderText = "Lớp";
            lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            lopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toanDataGridViewTextBoxColumn
            // 
            toanDataGridViewTextBoxColumn.DataPropertyName = "Toan";
            toanDataGridViewTextBoxColumn.HeaderText = "Toán";
            toanDataGridViewTextBoxColumn.Name = "toanDataGridViewTextBoxColumn";
            toanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anhVanDataGridViewTextBoxColumn
            // 
            anhVanDataGridViewTextBoxColumn.DataPropertyName = "AnhVan";
            anhVanDataGridViewTextBoxColumn.HeaderText = "Anh Văn";
            anhVanDataGridViewTextBoxColumn.Name = "anhVanDataGridViewTextBoxColumn";
            anhVanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinDataGridViewTextBoxColumn
            // 
            tinDataGridViewTextBoxColumn.DataPropertyName = "Tin";
            tinDataGridViewTextBoxColumn.HeaderText = "Tin";
            tinDataGridViewTextBoxColumn.Name = "tinDataGridViewTextBoxColumn";
            tinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemTrungBinhDataGridViewTextBoxColumn
            // 
            diemTrungBinhDataGridViewTextBoxColumn.DataPropertyName = "DiemTrungBinh";
            diemTrungBinhDataGridViewTextBoxColumn.HeaderText = "Điểm Trung Bình";
            diemTrungBinhDataGridViewTextBoxColumn.Name = "diemTrungBinhDataGridViewTextBoxColumn";
            diemTrungBinhDataGridViewTextBoxColumn.ReadOnly = true;
            diemTrungBinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // xepLoaiDataGridViewTextBoxColumn
            // 
            xepLoaiDataGridViewTextBoxColumn.DataPropertyName = "XepLoai";
            xepLoaiDataGridViewTextBoxColumn.HeaderText = "Xếp Loại";
            xepLoaiDataGridViewTextBoxColumn.Name = "xepLoaiDataGridViewTextBoxColumn";
            xepLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // txb_code
            // 
            txb_code.Location = new Point(140, 61);
            txb_code.Name = "txb_code";
            txb_code.Size = new Size(100, 23);
            txb_code.TabIndex = 19;
            // 
            // txb_name
            // 
            txb_name.Location = new Point(269, 61);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(100, 23);
            txb_name.TabIndex = 20;
            // 
            // txb_class
            // 
            txb_class.Location = new Point(397, 61);
            txb_class.Name = "txb_class";
            txb_class.Size = new Size(100, 23);
            txb_class.TabIndex = 21;
            // 
            // num_toan
            // 
            num_toan.Location = new Point(529, 62);
            num_toan.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_toan.Name = "num_toan";
            num_toan.Size = new Size(98, 23);
            num_toan.TabIndex = 22;
            // 
            // num_anhvan
            // 
            num_anhvan.Location = new Point(661, 61);
            num_anhvan.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_anhvan.Name = "num_anhvan";
            num_anhvan.Size = new Size(98, 23);
            num_anhvan.TabIndex = 23;
            // 
            // num_tin
            // 
            num_tin.Location = new Point(792, 61);
            num_tin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_tin.Name = "num_tin";
            num_tin.Size = new Size(98, 23);
            num_tin.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 25;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 32);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 26;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 32);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 27;
            label3.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 32);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 28;
            label4.Text = "Toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 32);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 29;
            label5.Text = "Anh Văn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(792, 32);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 30;
            label6.Text = "Tin";
            // 
            // button1
            // 
            button1.Location = new Point(437, 115);
            button1.Name = "button1";
            button1.Size = new Size(155, 54);
            button1.TabIndex = 31;
            button1.Text = "Thêm sinh viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 526);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num_tin);
            Controls.Add(num_anhvan);
            Controls.Add(num_toan);
            Controls.Add(txb_class);
            Controls.Add(txb_name);
            Controls.Add(txb_code);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_toan).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_anhvan).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_tin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anhVanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diemTrungBinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xepLoaiDataGridViewTextBoxColumn;
        private TextBox txb_code;
        private TextBox txb_name;
        private TextBox txb_class;
        private NumericUpDown num_toan;
        private NumericUpDown num_anhvan;
        private NumericUpDown num_tin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}