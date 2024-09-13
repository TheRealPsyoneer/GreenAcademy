using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Study
{
    public partial class CreateSinhVien : Form
    {
        public Student? sinhVienMoi = null;
        public CreateSinhVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_code.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống");
                return;
            }

            if (string.IsNullOrEmpty(txb_name.Text))
            {
                MessageBox.Show("Tên sinh viên không được để trống");
                return;
            }

            if (string.IsNullOrEmpty(txb_class.Text))
            {
                MessageBox.Show("Lớp không được để trống");
                return;
            }

            sinhVienMoi = new Student(txb_code.Text, txb_name.Text, txb_class.Text, (double)num_toan.Value, (double)num_anhvan.Value, (double)num_tin.Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
