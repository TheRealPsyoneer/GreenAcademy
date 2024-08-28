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
            inputThuTu = new NumericUpDown();
            hienThi = new Button();
            maSo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            code = new Label();
            name = new Label();
            lop = new Label();
            toan = new Label();
            anhvan = new Label();
            tin = new Label();
            dtb = new Label();
            xeploai = new Label();
            ((System.ComponentModel.ISupportInitialize)inputThuTu).BeginInit();
            SuspendLayout();
            // 
            // inputThuTu
            // 
            inputThuTu.Location = new Point(36, 12);
            inputThuTu.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            inputThuTu.Name = "inputThuTu";
            inputThuTu.Size = new Size(120, 23);
            inputThuTu.TabIndex = 0;
            // 
            // hienThi
            // 
            hienThi.Location = new Point(300, 12);
            hienThi.Name = "hienThi";
            hienThi.Size = new Size(175, 46);
            hienThi.TabIndex = 1;
            hienThi.Text = "Hiển Thị Thông Tin";
            hienThi.UseVisualStyleBackColor = true;
            hienThi.Click += hienThi_Click;
            // 
            // maSo
            // 
            maSo.AutoSize = true;
            maSo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            maSo.Location = new Point(61, 112);
            maSo.Name = "maSo";
            maSo.Size = new Size(123, 25);
            maSo.TabIndex = 2;
            maSo.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 137);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 3;
            label1.Text = "Họ và Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(137, 162);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 4;
            label2.Text = "Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 187);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "Điểm Toán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 212);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 6;
            label4.Text = "Điểm Anh Văn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(93, 237);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 7;
            label5.Text = "Điểm Tin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(28, 262);
            label6.Name = "label6";
            label6.Size = new Size(156, 25);
            label6.TabIndex = 8;
            label6.Text = "Điểm Trung Bình:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(100, 287);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 9;
            label7.Text = "Xếp loại:";
            // 
            // code
            // 
            code.AutoSize = true;
            code.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            code.Location = new Point(190, 112);
            code.Name = "code";
            code.Size = new Size(53, 25);
            code.TabIndex = 10;
            code.Text = "code";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(190, 137);
            name.Name = "name";
            name.Size = new Size(59, 25);
            name.TabIndex = 11;
            name.Text = "name";
            // 
            // lop
            // 
            lop.AutoSize = true;
            lop.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lop.Location = new Point(190, 162);
            lop.Name = "lop";
            lop.Size = new Size(52, 25);
            lop.TabIndex = 12;
            lop.Text = "class";
            // 
            // toan
            // 
            toan.AutoSize = true;
            toan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toan.Location = new Point(190, 187);
            toan.Name = "toan";
            toan.Size = new Size(50, 25);
            toan.TabIndex = 13;
            toan.Text = "toan";
            // 
            // anhvan
            // 
            anhvan.AutoSize = true;
            anhvan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            anhvan.Location = new Point(190, 212);
            anhvan.Name = "anhvan";
            anhvan.Size = new Size(74, 25);
            anhvan.TabIndex = 14;
            anhvan.Text = "anhvan";
            // 
            // tin
            // 
            tin.AutoSize = true;
            tin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tin.Location = new Point(190, 237);
            tin.Name = "tin";
            tin.Size = new Size(34, 25);
            tin.TabIndex = 15;
            tin.Text = "tin";
            // 
            // dtb
            // 
            dtb.AutoSize = true;
            dtb.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtb.Location = new Point(190, 262);
            dtb.Name = "dtb";
            dtb.Size = new Size(40, 25);
            dtb.TabIndex = 16;
            dtb.Text = "dtb";
            // 
            // xeploai
            // 
            xeploai.AutoSize = true;
            xeploai.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            xeploai.Location = new Point(190, 287);
            xeploai.Name = "xeploai";
            xeploai.Size = new Size(73, 25);
            xeploai.TabIndex = 17;
            xeploai.Text = "xeploai";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(xeploai);
            Controls.Add(dtb);
            Controls.Add(tin);
            Controls.Add(anhvan);
            Controls.Add(toan);
            Controls.Add(lop);
            Controls.Add(name);
            Controls.Add(code);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maSo);
            Controls.Add(hienThi);
            Controls.Add(inputThuTu);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)inputThuTu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown inputThuTu;
        private Button hienThi;
        private Label maSo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label code;
        private Label name;
        private Label lop;
        private Label toan;
        private Label anhvan;
        private Label tin;
        private Label dtb;
        private Label xeploai;
    }
}