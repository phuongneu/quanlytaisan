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
    public partial class FrmBanGiao : Form
    {
        public FrmBanGiao()
        {
            InitializeComponent();
        }
        ketnoi ketnoi = new ketnoi();

        public void load_Dulieu_Bangiao()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * from BANGIAO");
            dtaGridBanGiao.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "MABANGIAO");

            txtMaTaiSan.DataBindings.Clear();
            txtMaTaiSan.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "MATAISAN");

            txtTenTaiSan.DataBindings.Clear();
            txtTenTaiSan.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "TENTAISAN");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "SOLUONG");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "DONGIA");

            txtNoiBanGiao.DataBindings.Clear();
            txtNoiBanGiao.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "NOIBANGIAO");

            txtNoiTiepNhan.DataBindings.Clear();
            txtNoiTiepNhan.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "NOINHAN");

            cboNguoiQuanLy.DataBindings.Clear();
            cboNguoiQuanLy.DataBindings.Add("Text", dtaGridBanGiao.DataSource, "NGUOIQUANLY");
        }
        private void FrmBanGiao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet2.nguoiquanly' table. You can move, or remove it, as needed.
            this.nguoiquanlyTableAdapter.Fill(this.qLTS_PROJECTDataSet2.nguoiquanly);
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.BANGIAO' table. You can move, or remove it, as needed.
            this.bANGIAOTableAdapter.Fill(this.qLTS_PROJECTDataSet1.BANGIAO);
            load_Dulieu_Bangiao();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn thêm không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                string sql_them = "Insert into BANGIAO Values('" + txtMaPhieu.Text + "' , '" + txtMaTaiSan.Text + "' , N'" + txtTenTaiSan.Text + "' , " + txtSoLuong.Text + " , '" + txtDonGia.Text + "' , '" + txtNoiBanGiao.Text + "' , '" + txtNoiTiepNhan.Text + "' ,'" + dateNgayBanGIao.Value.ToShortDateString() + "', N'" + cboNguoiQuanLy.Text + "' )";
                ketnoi.Execute(sql_them);
                load_Dulieu_Bangiao();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn sửa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                String sql_sua = "Update BANGIAO Set MATAISAN='" + txtMaTaiSan.Text + "' , TENTAISAN=N'" + txtTenTaiSan.Text + "' , SOLUONG=" + txtSoLuong.Text + ", DONGIA='" + txtDonGia.Text + "', NOIBANGIAO='" + txtNoiBanGiao.Text + "', NOINHAN='" + txtNoiTiepNhan.Text + "', NGAYGIAO='" + dateNgayBanGIao.Value.ToShortDateString() + "', NGUOIQUANLY=N'" + cboNguoiQuanLy.Text + "'Where MABANGIAO= '" + txtMaPhieu.Text + "'";
                ketnoi.Execute(sql_sua);
                load_Dulieu_Bangiao();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn xóa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                ketnoi.Execute("Delete BANGIAO Where MABANGIAO ='" + txtMaPhieu.Text + "'");
                load_Dulieu_Bangiao();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            load_Dulieu_Bangiao();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbMucTimKiem.Text == "Mã bàn giao")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BANGIAO where MABANGIAO like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridBanGiao.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Mã tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BANGIAO where MATAISAN like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridBanGiao.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Tên tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BANGIAO where TENTAISAN like N'" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridBanGiao.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Nơi bàn giao")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BANGIAO where NOIBANGIAO like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridBanGiao.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Nơi nhận")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BANGIAO where NOINHAN like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridBanGiao.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Người quản lý")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BANGIAO where NGUOIQUANLY like N'" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridBanGiao.DataSource = dta;
            }
            else if (cbMucTimKiem.Text == "Ngày bàn giao")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BANGIAO where NGAYGIAO between '" + dateTimePicker1.Value.ToShortDateString() + "'and'" + dateTimePicker2.Value.ToShortDateString() + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridBanGiao.DataSource = dta;
            }
        }

        private void cbMucTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
