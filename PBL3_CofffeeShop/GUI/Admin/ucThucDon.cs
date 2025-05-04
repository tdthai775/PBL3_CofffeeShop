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
    public partial class ucThucDon: UserControl
    {
        public ucThucDon()
        {
            InitializeComponent();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            fDetailThucDon f = new fDetailThucDon();
            f.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fDetailThucDon f = new fDetailThucDon();
            f.Show();
        }
    }
}
