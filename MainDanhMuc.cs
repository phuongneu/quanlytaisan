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
    public partial class MainDanhMuc : Form
    {
        public MainDanhMuc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCNPM_Click(object sender, EventArgs e)
        {
            DMTS_CNPM dmtscntt = new DMTS_CNPM();
            dmtscntt.Show();
        }

        private void btnKHMT_Click(object sender, EventArgs e)
        {
            DMTS_KHMT dmtscntt = new DMTS_KHMT();
            dmtscntt.Show();
        }

        private void btnMang_Click(object sender, EventArgs e)
        {
            DMTS_MANG dmtscntt = new DMTS_MANG();
            dmtscntt.Show();
        }

        private void btnCNTT_Click(object sender, EventArgs e)
        {
            DMTS_CNTT dmtscntt = new DMTS_CNTT();
            dmtscntt.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TongDMTS test = new TongDMTS();
            test.Show();
        }
    }
}
