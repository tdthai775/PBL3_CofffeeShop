using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_CofffeeShop.GUI
{
    public partial class ucDonHang: UserControl
    {
        public ucDonHang()
        {
            InitializeComponent();
        }

        private void btnLichSuDon_Click(object sender, EventArgs e)
        {
            fLichSuDonHang f = new fLichSuDonHang();
            f.Show();
        }
    }
}
