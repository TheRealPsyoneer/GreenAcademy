using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputPhepTinh.Text = "";
            ketQua.Text = "";
            squareRoot.Text = $"{(char)0x221A}";
        }
        private void number0_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "0";
        }
        private void number1_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "1";
        }
        private void number2_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "2";
        }
        private void number3_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "3";
        }
        private void number4_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "4";
        }
        private void number5_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "5";
        }
        private void number6_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "6";
        }
        private void number7_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "7";
        }
        private void number8_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "8";
        }
        private void number9_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "9";
        }
        private void dot_Click(object sender, EventArgs e)
        {
            if (inputPhepTinh.Text == "")
            {
                inputPhepTinh.Text += "0.";
            }
            else if (inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] != '.')
            {
                inputPhepTinh.Text += ".";
            }
            else
            {
                inputPhepTinh.Text = inputPhepTinh.Text.Remove(inputPhepTinh.Text.Length - 1);
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (inputPhepTinh.Text != "")
            {
                if (inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] >= 48 && inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] <= 57)
                {
                    inputPhepTinh.Text += "+";
                }
                else
                {
                    inputPhepTinh.Text = inputPhepTinh.Text.Remove(inputPhepTinh.Text.Length - 1);
                    inputPhepTinh.Text += "+";
                }
            }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (inputPhepTinh.Text != "")
            {
                if (inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] >= 48 && inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] <= 57)
                {
                    inputPhepTinh.Text += "-";
                }
                else
                {
                    inputPhepTinh.Text = inputPhepTinh.Text.Remove(inputPhepTinh.Text.Length - 1);
                    inputPhepTinh.Text += "-";
                }
            }
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            if (inputPhepTinh.Text != "")
            {
                if (inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] >= 48 && inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] <= 57)
                {
                    inputPhepTinh.Text += "*";
                }
                else
                {
                    inputPhepTinh.Text = inputPhepTinh.Text.Remove(inputPhepTinh.Text.Length - 1);
                    inputPhepTinh.Text += "*";
                }
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (inputPhepTinh.Text != "")
            {
                if (inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] >= 48 && inputPhepTinh.Text[inputPhepTinh.Text.Length - 1] <= 57)
                {
                    inputPhepTinh.Text += "/";
                }
                else
                {
                    inputPhepTinh.Text = inputPhepTinh.Text.Remove(inputPhepTinh.Text.Length - 1);
                    inputPhepTinh.Text += "/";
                }
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calculate = new DataTable();
                ketQua.Text = $"= {Calculate.Compute(inputPhepTinh.Text, null).ToString()}";
            }
            catch
            {
                ketQua.Text = "Phép tính nhập sai, hãy nhập lại";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (inputPhepTinh.Text.Length > 0)
            {
                inputPhepTinh.Text = inputPhepTinh.Text.Remove(inputPhepTinh.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text = "";
            ketQua.Text = "";
        }

        private void moNgoac_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += "(";
        }

        private void dongNgoac_Click(object sender, EventArgs e)
        {
            inputPhepTinh.Text += ")";
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            if (inputPhepTinh.Text != "")
            {
                try
                {
                    DataTable Calculate = new DataTable();
                    ketQua.Text = $"= {Math.Sqrt(Convert.ToDouble(Calculate.Compute(inputPhepTinh.Text, null).ToString())).ToString()}";
                }
                catch
                {
                    ketQua.Text = "Phép tính nhập sai, hãy nhập lại";
                }
            }
        }
    }
}