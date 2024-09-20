namespace OOP_Study
{
    partial class EditForm
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
            editCode = new TextBox();
            editName = new TextBox();
            editClass = new TextBox();
            editMath = new NumericUpDown();
            editEnglish = new NumericUpDown();
            editTin = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)editMath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editTin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 23);
            label1.Name = "label1";
            label1.Size = new Size(315, 37);
            label1.TabIndex = 0;
            label1.Text = "Hãy nhập dữ liệu cần sửa";
            // 
            // editCode
            // 
            editCode.Location = new Point(45, 143);
            editCode.Name = "editCode";
            editCode.ReadOnly = true;
            editCode.Size = new Size(100, 23);
            editCode.TabIndex = 7;
            // 
            // editName
            // 
            editName.Location = new Point(333, 143);
            editName.Name = "editName";
            editName.ReadOnly = true;
            editName.Size = new Size(100, 23);
            editName.TabIndex = 8;
            // 
            // editClass
            // 
            editClass.Location = new Point(630, 143);
            editClass.Name = "editClass";
            editClass.ReadOnly = true;
            editClass.Size = new Size(100, 23);
            editClass.TabIndex = 9;
            // 
            // editMath
            // 
            editMath.DecimalPlaces = 1;
            editMath.Location = new Point(45, 257);
            editMath.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            editMath.Name = "editMath";
            editMath.Size = new Size(100, 23);
            editMath.TabIndex = 10;
            // 
            // editEnglish
            // 
            editEnglish.DecimalPlaces = 1;
            editEnglish.Location = new Point(333, 257);
            editEnglish.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            editEnglish.Name = "editEnglish";
            editEnglish.Size = new Size(100, 23);
            editEnglish.TabIndex = 11;
            // 
            // editTin
            // 
            editTin.DecimalPlaces = 1;
            editTin.Location = new Point(630, 257);
            editTin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            editTin.Name = "editTin";
            editTin.Size = new Size(100, 23);
            editTin.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 120);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 14;
            label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(333, 120);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 15;
            label3.Text = "Họ và Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(630, 120);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 16;
            label4.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 234);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 17;
            label5.Text = "Điểm Toán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(333, 234);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 18;
            label6.Text = "Điểm Anh Văn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(630, 234);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 19;
            label7.Text = "Điểm Tin";
            // 
            // button1
            // 
            button1.Location = new Point(191, 347);
            button1.Name = "button1";
            button1.Size = new Size(107, 55);
            button1.TabIndex = 20;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(475, 347);
            button2.Name = "button2";
            button2.Size = new Size(107, 55);
            button2.TabIndex = 21;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(editTin);
            Controls.Add(editEnglish);
            Controls.Add(editMath);
            Controls.Add(editClass);
            Controls.Add(editName);
            Controls.Add(editCode);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)editMath).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)editTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox editCode;
        private TextBox editName;
        private TextBox editClass;
        private NumericUpDown editMath;
        private NumericUpDown editEnglish;
        private NumericUpDown editTin;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}