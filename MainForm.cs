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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            MainDanhMuc test = new MainDanhMuc();
            test.Show();
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            MainChucNang test = new MainChucNang();
            test.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainBaoCao test = new MainBaoCao();
            test.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainChucNang test = new MainChucNang();
            test.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDoiMK test = new FrmDoiMK();
            test.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn Có Muốn Đăng Xuất Không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
                this.Close();
            FrmLogin test = new FrmLogin();
            test.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
