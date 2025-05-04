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
    public partial class ucNguyenVatLieu: UserControl
    {
        public ucNguyenVatLieu()
        {
            InitializeComponent();
        }

        private void btnLichSuBaoCao_Click(object sender, EventArgs e)
        {
            fLichSuBaoCao f = new fLichSuBaoCao();
            f.Show();
        }
    }
}
