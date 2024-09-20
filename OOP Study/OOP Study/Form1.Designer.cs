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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maSinhVienDataGridViewTextBoxColumn, hoTenDataGridViewTextBoxColumn, lopDataGridViewTextBoxColumn, toanDataGridViewTextBoxColumn, anhVanDataGridViewTextBoxColumn, tinDataGridViewTextBoxColumn, diemTrungBinhDataGridViewTextBoxColumn, xepLoaiDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(12, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(951, 397);
            dataGridView1.TabIndex = 18;
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            maSinhVienDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            maSinhVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            hoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            hoTenDataGridViewTextBoxColumn.Width = 150;
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 24);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(68, 20);
            fileToolStripMenuItem.Text = "Sinh Viên";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 526);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}