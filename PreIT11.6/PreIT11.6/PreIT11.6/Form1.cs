using System.ComponentModel;
using System.Text.Json;

namespace PreIT11._6
{
    public partial class Form1 : Form
    {
        private BindingList<Item> hangHoa = new();

        private const string DataPath = "data.json";
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = new BindingSource(hangHoa, null);
        }
        private void LoadData()
        {
            if (!File.Exists(DataPath)) return;

            var txtHangHoa = File.ReadAllText(DataPath);
            var data = JsonSerializer.Deserialize<Item[]>(txtHangHoa) ?? Array.Empty<Item>();

            hangHoa.Clear();
            foreach (var hanghoa in data)
            {
                hangHoa.Add(hanghoa);
            }
        }
        private void SaveData()
        {
            var txtHangHoa = JsonSerializer.Serialize(hangHoa.ToArray());
            File.WriteAllText(DataPath, txtHangHoa);
        }
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddItem();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                var hh = hangHoa.FirstOrDefault(sinhvien => sinhvien.Code == form.MaHang);
                if (hh != null)
                {
                    MessageBox.Show($"Mã hàng đã tồn tại, Tên hàng hóa là {hh.Name}!");
                }
                else
                {
                    hangHoa.Add(new Item(form.TenHangHoa, form.MaHang, (int)form.SoLuong, (int)form.DonGia);
                    SaveData();
                }
            }
        }
    }
}