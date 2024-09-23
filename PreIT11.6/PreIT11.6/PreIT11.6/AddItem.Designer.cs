namespace PreIT11._6
{
    partial class AddItem
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
            txbName = new TextBox();
            txbCode = new TextBox();
            txbQuan = new NumericUpDown();
            txbPrice = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)txbQuan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txbPrice).BeginInit();
            SuspendLayout();
            // 
            // txbName
            // 
            txbName.Location = new Point(87, 73);
            txbName.Name = "txbName";
            txbName.Size = new Size(100, 23);
            txbName.TabIndex = 0;
            // 
            // txbCode
            // 
            txbCode.Location = new Point(336, 73);
            txbCode.Name = "txbCode";
            txbCode.Size = new Size(100, 23);
            txbCode.TabIndex = 1;
            // 
            // txbQuan
            // 
            txbQuan.Location = new Point(87, 181);
            txbQuan.Name = "txbQuan";
            txbQuan.Size = new Size(100, 23);
            txbQuan.TabIndex = 2;
            // 
            // txbPrice
            // 
            txbPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            txbPrice.Location = new Point(336, 181);
            txbPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txbPrice.Name = "txbPrice";
            txbPrice.Size = new Size(100, 23);
            txbPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 50);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên hàng hóa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(336, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 158);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(336, 158);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Đơn giá";
            // 
            // button1
            // 
            button1.Location = new Point(122, 269);
            button1.Name = "button1";
            button1.Size = new Size(94, 51);
            button1.TabIndex = 8;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(304, 269);
            button2.Name = "button2";
            button2.Size = new Size(94, 51);
            button2.TabIndex = 9;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 374);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbPrice);
            Controls.Add(txbQuan);
            Controls.Add(txbCode);
            Controls.Add(txbName);
            Name = "AddItem";
            Text = "Thêm hàng hóa";
            ((System.ComponentModel.ISupportInitialize)txbQuan).EndInit();
            ((System.ComponentModel.ISupportInitialize)txbPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbName;
        private TextBox txbCode;
        private NumericUpDown txbQuan;
        private NumericUpDown txbPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}