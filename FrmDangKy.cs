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
    public partial class FrmDangKy : Form
    {
        ketnoi kn = new ketnoi();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

            }

            else if (txtNhapLai.Text==txtPassword.Text)
            {
                
                string sql_them = "Insert into HETHONG Values('" + txtUsername.Text + "' , '" + txtPassword.Text + "' )";
                kn.Execute(sql_them);
                DialogResult thongbao1;
                thongbao1 = MessageBox.Show("Tạo Tài Khoản Thành Công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else 
            {
                DialogResult thongbao1;
                thongbao1 = MessageBox.Show("Mật Khẩu Không Khớp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
