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
    public partial class ucTaoDon: UserControl
    {
        public ucTaoDon()
        {
            InitializeComponent();
        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("Đang chọn " + btn.Text);
        }

        private void btnLichSuDon_Click(object sender, EventArgs e)
        {
            fLichSuDonHang f = new fLichSuDonHang();
            f.Show();
        }
    }
}
