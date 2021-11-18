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
    public partial class FrmDoiMK : Form
    {
        public FrmDoiMK()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            kn.KetNoi_CSDL();
            String TN = txtUsername.Text;
            String MK = txtPassword.Text;

            String sql_login = "Select TENDN, MATKHAU from HETHONG WHERE TENDN='" + TN + "'and MATKHAU='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRead = cmd.ExecuteReader();
            if (datRead.Read() == true) { 
                String sql_sua = "Update HETHONG Set MATKHAU='" + txtMKMoi.Text+ "'where TENDN='"+txtUsername.Text+"'";
                kn.Execute(sql_sua);
                DialogResult thongbao1;
                thongbao1 = MessageBox.Show("Đổi Mật Khẩu thành công");
            }
            else
            {
                DialogResult thongbao1;
                thongbao1 = MessageBox.Show("Sai Mật Khẩu!");
            }
        }
    }
}
