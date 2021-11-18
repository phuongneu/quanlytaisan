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

    public partial class FrmThanhLy : Form
    {
        ketnoi ketnoi = new ketnoi();
        public FrmThanhLy()
        {
            InitializeComponent();
        }
        public void load_Dulieu_ThanhLy()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * from THANHLY");
            dtaGridThanhLy.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", dtaGridThanhLy.DataSource, "MATHANHLY");

            txtMaTaiSan.DataBindings.Clear();
            txtMaTaiSan.DataBindings.Add("Text", dtaGridThanhLy.DataSource, "MATAISAN");

            txtTenTaiSan.DataBindings.Clear();
            txtTenTaiSan.DataBindings.Add("Text", dtaGridThanhLy.DataSource, "TENTAISAN");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dtaGridThanhLy.DataSource, "SOLUONG");

            cbMaPhong.DataBindings.Clear();
            cbMaPhong.DataBindings.Add("Text", dtaGridThanhLy.DataSource, "MAPHONG");

            dateNgayThanhLy.DataBindings.Clear();
            dateNgayThanhLy.DataBindings.Add("Text", dtaGridThanhLy.DataSource, "NGAYTHANHLY");
        }
        private void FrmThanhLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.THANHLY' table. You can move, or remove it, as needed.
            this.tHANHLYTableAdapter.Fill(this.qLTS_PROJECTDataSet1.THANHLY);
            load_Dulieu_ThanhLy();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn thêm không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                string sql_them = "Insert into THANHLY Values('" + txtMaPhieu.Text + "' , '" + txtMaTaiSan.Text + "' , N'" + txtTenTaiSan.Text + "' , " + txtSoLuong.Text + " , '" + cbMaPhong.Text + "' ,'" + dateNgayThanhLy.Value.ToShortDateString() + "')";
                ketnoi.Execute(sql_them);
                load_Dulieu_ThanhLy();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn sửa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                String sql_sua = "Update THANHLY Set MATAISAN='" + txtMaTaiSan.Text + "' , TENTAISAN=N'" + txtTenTaiSan.Text + "' , SOLUONG=" + txtSoLuong.Text + ", MAPHONG='" + cbMaPhong.Text + "', NGAYTHANHLY='" + dateNgayThanhLy.Value.ToShortDateString() + "' Where MATHANHLY= '" + txtMaPhieu.Text + "'";
                ketnoi.Execute(sql_sua);
                load_Dulieu_ThanhLy();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn xóa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                ketnoi.Execute("Delete THANHLY Where MATHANHLY ='" + txtMaPhieu.Text + "'");
                load_Dulieu_ThanhLy();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            load_Dulieu_ThanhLy();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbMucTimKiem.Text == "Mã thanh lý")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From THANHLY where MATHANHLY like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridThanhLy.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Mã tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From THANHLY where MATAISAN like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridThanhLy.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Tên tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From THANHLY where TENTAISAN like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridThanhLy.DataSource = dta;
            }

            else if (cbMucTimKiem.Text == "Mã phòng")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From THANHLY where MAPHONG like '" + txtTim.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridThanhLy.DataSource = dta;
            }
            else if (cbMucTimKiem.Text == "Ngày thanh lý")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From THANHLY where NGAYTHANHLY between '" + dateTimePicker1.Value.ToShortDateString() + "'and'" + dateTimePicker2.Value.ToShortDateString() + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtaGridThanhLy.DataSource = dta;
            }
        }
    }
}
