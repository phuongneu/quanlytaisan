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
    public partial class TongDMTS : Form
    {
        ketnoi kn = new ketnoi();
        public TongDMTS()
        {
            InitializeComponent();
        }
        public void HienThi_DuLieu()
        {
            txtMTS.DataBindings.Clear();
            txtMTS.DataBindings.Add("Text", dataGridViewCNTT.DataSource, "MATAISAN");
            txtTTS.DataBindings.Clear();
            txtTTS.DataBindings.Add("Text", dataGridViewCNTT.DataSource, "TENTAISAN");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dataGridViewCNTT.DataSource, "SOLUONG");
            txtStatus.DataBindings.Clear();
            txtStatus.DataBindings.Add("Text", dataGridViewCNTT.DataSource, "STATUS");
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("Text", dataGridViewCNTT.DataSource, "MAPHONG");
        }
        public void dulieu_DMTS()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from DMTAISAN ");
            dataGridViewCNTT.DataSource = dta;
            HienThi_DuLieu();
        }
        private void TongDMTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet4.DMTAISAN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet3.DMTAISAN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet2.DMTAISAN' table. You can move, or remove it, as needed.

            dulieu_DMTS();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMTS.Text = "";
            txtTTS.Text = "";
            txtSL.Text = "";
            txtStatus.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String sql_chen = "Insert into DMTAISAN values('" + txtMTS.Text + "','" + txtTTS.Text + "','" + txtSL.Text + "','" + txtMaPhong.Text+"','"+txtStatus.Text+"')";
            kn.Execute(sql_chen);
            dulieu_DMTS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql_sua = "Update DMTAISAN Set TENTAISAN=N'" + txtTTS.Text + "'";
            sql_sua = sql_sua + ", SOLUONG='" + txtSL.Text + "',MAPHONG='"+txtMaPhong.Text+"',STATUS='"+txtStatus.Text+"'Where MATAISAN= '" + txtMTS.Text + "'";
            kn.Execute(sql_sua);
            dulieu_DMTS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete from DMTAISAN Where MATAISAN='" + txtMTS.Text + "'");
            dulieu_DMTS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sqltk;
            if (cbMucTK.Text == "Mã tài sản")
            {
                sqltk = "Select * From DMTAISAN where MATAISAN like'%" + txtTimKiem.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (cbMucTK.Text == "Tên tài sản")
            {
                sqltk = "Select * From DMTAISAN where TENTAISAN like N'" + txtTimKiem.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (cbMucTK.Text == "Số lượng")
            {
                sqltk = "Select * From DMTAISAN where SOLUONG like'" + txtTimKiem.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (cbMucTK.Text == "Tình Trạng")
            {
                sqltk = "Select * From DMTAISAN where STATUS like N'" + txtTimKiem.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (cbMucTK.Text == "Mã Phòng")
            {
                sqltk = "Select * From DMTAISAN where MAPHONG like'" + txtMaPhong.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            dataGridViewCNTT.DataSource = dta;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from DMTAISAN ");
            dataGridViewCNTT.DataSource = dta;
            HienThi_DuLieu();
            txtTimKiem.Text = "";
        }
    }
}
