using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_BTL
{
    public partial class MainBaoCao : Form
    {
        public MainBaoCao()
        {
            InitializeComponent();
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            ThanhLyReport report3 = new ThanhLyReport();
            report3.Show();
        }

        private void btnBanGiao_Click(object sender, EventArgs e)
        {
            BanGiaoReport report1 = new BanGiaoReport();
            report1.Show();
        }

        private void btnDieuChuyen_Click(object sender, EventArgs e)
        {
            DIeuChuyenReport report2 = new DIeuChuyenReport();
            report2.Show();
        }

        private void btbBaoDuong_Click(object sender, EventArgs e)
        {
            BaoDuongReport report4 = new BaoDuongReport();
            report4.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucReport report5 = new DanhMucReport();
            report5.Show();
        }
    }
}
