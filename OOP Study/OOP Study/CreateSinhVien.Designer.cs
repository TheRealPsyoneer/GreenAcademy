namespace OOP_Study
{
    partial class CreateSinhVien
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
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)num_toan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_anhvan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_tin).BeginInit();
            SuspendLayout();
            // 
            // txb_code
            // 
            txb_code.Location = new Point(67, 80);
            txb_code.Name = "txb_code";
            txb_code.Size = new Size(120, 23);
            txb_code.TabIndex = 0;
            // 
            // txb_name
            // 
            txb_name.Location = new Point(335, 80);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(120, 23);
            txb_name.TabIndex = 1;
            // 
            // txb_class
            // 
            txb_class.Location = new Point(604, 80);
            txb_class.Name = "txb_class";
            txb_class.Size = new Size(120, 23);
            txb_class.TabIndex = 2;
            // 
            // num_toan
            // 
            num_toan.DecimalPlaces = 1;
            num_toan.Location = new Point(67, 209);
            num_toan.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_toan.Name = "num_toan";
            num_toan.Size = new Size(120, 23);
            num_toan.TabIndex = 3;
            // 
            // num_anhvan
            // 
            num_anhvan.DecimalPlaces = 1;
            num_anhvan.Location = new Point(335, 209);
            num_anhvan.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_anhvan.Name = "num_anhvan";
            num_anhvan.Size = new Size(120, 23);
            num_anhvan.TabIndex = 4;
            // 
            // num_tin
            // 
            num_tin.DecimalPlaces = 1;
            num_tin.Location = new Point(604, 209);
            num_tin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_tin.Name = "num_tin";
            num_tin.Size = new Size(120, 23);
            num_tin.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 52);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 52);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 52);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 8;
            label3.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 180);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Điểm Toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 180);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 10;
            label5.Text = "Điểm Anh Văn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(604, 180);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 11;
            label6.Text = "Điểm Tin";
            // 
            // button1
            // 
            button1.Location = new Point(196, 309);
            button1.Name = "button1";
            button1.Size = new Size(116, 62);
            button1.TabIndex = 12;
            button1.Text = "Tạo mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 309);
            button2.Name = "button2";
            button2.Size = new Size(116, 62);
            button2.TabIndex = 13;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CreateSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
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
            Name = "CreateSinhVien";
            Text = "CreateSinhVien";
            ((System.ComponentModel.ISupportInitialize)num_toan).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_anhvan).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_tin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button2;
    }
}