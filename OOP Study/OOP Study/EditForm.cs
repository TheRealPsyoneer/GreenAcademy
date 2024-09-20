using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Study
{
    public partial class EditForm : Form
    {
        private Student data;
        public double Toan => (double)editMath.Value;
        public double AnhVan => (double)editEnglish.Value;
        public double Tin => (double)editTin.Value;


        public EditForm(Student sv)
        {
            InitializeComponent();

            data = sv;

            editCode.Text = sv.MaSinhVien;
            editName.Text = sv.HoTen;
            editClass.Text = sv.Lop;
            editMath.Value = (decimal)sv.Toan;
            editEnglish.Value = (decimal)sv.AnhVan;
            editTin.Value = (decimal)sv.Tin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mess = "";

            if (editMath.Value != (decimal)data.Toan)
            {
                
            }
        }
    }
}
