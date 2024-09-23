using System.ComponentModel;
using System.Text.Json;

namespace OOP_Study
{
    public partial class Form1 : Form
    {
        public BindingList<Student> sinhViens = new();
        private const string DataPath = "data.json";
        public Form1()
        {
            InitializeComponent();

            //sinhViens.Add(new Student("213001", "Nguyễn Văn A", "QL131", 8, 8.8, 6.8));
            //sinhViens.Add(new Student("213002", "Nguyễn Văn B", "QL141", 4, 5, 7));
            //sinhViens.Add(new Student("213003", "Nguyễn Thị C", "QL141", 6, 2, 4));
            LoadData();
            dataGridView1.DataSource = new BindingSource(sinhViens, null);
        }

        private void LoadData()
        {
            if (!File.Exists(DataPath)) return;

            var txtSinhVien = File.ReadAllText(DataPath);
            var data = JsonSerializer.Deserialize<Student[]>(txtSinhVien) ?? Array.Empty<Student>();

            sinhViens.Clear();
            foreach (var sinhvien in data)
            {
                sinhViens.Add(sinhvien);
            }
        }
        private void SaveData()
        {
            var txtSinhVien = JsonSerializer.Serialize(sinhViens.ToArray());
            File.WriteAllText(DataPath, txtSinhVien);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CreateSinhVien();

            var result = form.ShowDialog();

            if (result == DialogResult.OK && form.sinhVienMoi != null)
            {
                if (sinhViens.Any(Student => Student.MaSinhVien == form.sinhVienMoi.MaSinhVien))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại");
                    return;
                }
                sinhViens.Add(form.sinhVienMoi);

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index >= 0)
            {
                string message = $"Bạn chắc chắn muốn xóa thông tin của sinh viên \"{sinhViens[index].HoTen}\" ở lớp {sinhViens[index].Lop} không?";
                var result = MessageBox.Show(message, "Xóa thông tin sinh viên", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    sinhViens.RemoveAt(index);
                    SaveData();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index < 0) return;

            var form = new EditForm(sinhViens[index]);
            var result = form.ShowDialog();

            if (result != DialogResult.OK) return;

            sinhViens[index].Toan = form.Toan;
            sinhViens[index].AnhVan = form.AnhVan;
            sinhViens[index].Tin = form.Tin;

            dataGridView1.Refresh();
            SaveData();
        }
    }
}