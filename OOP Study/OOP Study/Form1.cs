using System.ComponentModel;

namespace OOP_Study
{
    public partial class Form1 : Form
    {
        List<Student> lopA = new List<Student>();
        public BindingList<Student> bindingList;
        public Form1()
        {
            InitializeComponent();

            lopA.Add(new Student("213001", "Nguyen Van A", "QL131", 8, 8.8, 6.8));
            lopA.Add(new Student("213002", "Nguyen Van B", "QL141", 4, 5, 7));
            lopA.Add(new Student("213003", "Nguyen Thi C", "QL141", 6, 2, 4));
            bindingList = new BindingList<Student>(lopA);
            var bindingSource = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource;
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

            if (bindingList.Any(lopA => lopA.MaSinhVien == txb_code.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại. Hãy nhập mã khác!");
                return;
            }

            bindingList.Add(new Student(txb_code.Text, txb_name.Text, txb_class.Text, (double)num_toan.Value, (double)num_anhvan.Value, (double)num_tin.Value));
        }
    }
}