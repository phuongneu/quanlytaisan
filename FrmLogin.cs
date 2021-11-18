using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PROJECT_BTL
{
    public partial class FrmLogin : Form
    {
        ketnoi kn = new ketnoi();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy TEST = new FrmDangKy();
            TEST.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            kn.KetNoi_CSDL();
            String TN = txtUsername.Text;
            String MK = txtPassword.Text;

            String sql_login = "Select TENDN, MATKHAU from HETHONG WHERE TENDN='" + TN + "'and MATKHAU='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRead = cmd.ExecuteReader();

            if (String.IsNullOrEmpty(TN) || String.IsNullOrEmpty(MK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

            }
            else if (datRead.Read() == true)
            {
                DialogResult thongbao1;
                thongbao1=MessageBox.Show("Đăng nhập thành công");
                if (thongbao1 == DialogResult.OK)
                {
                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();
                }
            }
            else
            {


                MessageBox.Show("Tên TK hoặc MK không chính xác!");

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
