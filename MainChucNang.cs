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
    public partial class MainChucNang : Form
    {
        public MainChucNang()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBaoDuong test = new FrmBaoDuong();
            test.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDieuChuyen test = new FrmDieuChuyen();
            test.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmThanhLy test = new FrmThanhLy();
            test.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBanGiao test = new FrmBanGiao();
            test.Show();
        }
    }
}
