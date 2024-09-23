using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace PreIT11._6
{
    public partial class AddItem : Form
    {
        public string TenHangHoa => txbName.Text;
        public string Code => txbCode.Text;
        public double Quan => (double)txbQuan.Value;
        public double Price => (double)txbPrice.Value;
        public AddItem()
        {
            InitializeComponent();
        }
    }
}
