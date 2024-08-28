namespace OOP_Study
{
    public partial class Form1 : Form
    {
        List<IStudent> lopA = new List<IStudent>();
        public Form1()
        {
            InitializeComponent();
            
            lopA.Add(new Student("213001", "Nguyen Van A", "QL131", 8, 8.8, 6.8));
            lopA.Add(new Student("213002", "Nguyen Van B", "QL141", 4, 5, 7));
            lopA.Add(new Student("213003", "Nguyen Thi C", "QL141", 6, 2, 4));
            code.Text = "";
            name.Text = "";
            lop.Text = "";
            toan.Text = "";
            anhvan.Text = "";
            tin.Text = "";
            dtb.Text = "";
            xeploai.Text = "";

        }

        private void hienThi_Click(object sender, EventArgs e)
        {
            code.Text = lopA[(int)inputThuTu.Value].MaSinhVien;
            name.Text = lopA[(int)inputThuTu.Value].HoTen;
            lop.Text = lopA[(int)inputThuTu.Value].Lop;
            toan.Text = lopA[(int)inputThuTu.Value].Toan.ToString();
            anhvan.Text = lopA[(int)inputThuTu.Value].AnhVan.ToString();
            tin.Text = lopA[(int)inputThuTu.Value].Tin.ToString();
            //dtb.Text = lopA[(int)inputThuTu.Value].DiemTrungBinh.ToString("#.#");
            dtb.Text = lopA[(int)inputThuTu.Value].DiemTrungBinh.ToString("#.#");
            xeploai.Text = lopA[(int)inputThuTu.Value].XepLoai;
        }
    }
}