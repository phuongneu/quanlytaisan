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
    public partial class FrmBaoDuong : Form
    {
        ketnoi kn = new ketnoi();
        public FrmBaoDuong()
        {
            InitializeComponent();
        }
        public void load_Dulieu_Baoduong()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from BAODUONG");
            dtagridBaoDuong.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMBD.DataBindings.Clear();
            txtMBD.DataBindings.Add("Text", dtagridBaoDuong.DataSource, "MABAODUONG");

            txtMaTS.DataBindings.Clear();
            txtMaTS.DataBindings.Add("Text", dtagridBaoDuong.DataSource, "MATAISAN");

            txtTenTS.DataBindings.Clear();
            txtTenTS.DataBindings.Add("Text", dtagridBaoDuong.DataSource, "TENTAISAN");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dtagridBaoDuong.DataSource, "SOLUONG");

            txtNoiCD.DataBindings.Clear();
            txtNoiCD.DataBindings.Add("Text", dtagridBaoDuong.DataSource, "NOICHUYENDEN");


            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("Text", dtagridBaoDuong.DataSource, "TINHTRANG");

        }
        private void FrmBaoDuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.BAODUONG' table. You can move, or remove it, as needed.
            this.bAODUONGTableAdapter.Fill(this.qLTS_PROJECTDataSet1.BAODUONG);
            load_Dulieu_Baoduong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes) this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn thêm không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                string ngayDen = dateNgayDen.Value.ToShortDateString();
                string ngayXong = dateNgayXong.Value.ToShortDateString();
                string sql_them = "Insert into BAODUONG Values('" + txtMBD.Text + "' , '" + txtMaTS.Text + "' , N'" + txtTenTS.Text + "' , " + txtSoLuong.Text + " , N'" + txtNoiCD.Text + "' , + '"+ngayDen +"'  , N'" + txtTinhTrang.Text + "' ,'" + ngayXong + "')";
                kn.Execute(sql_them);
                load_Dulieu_Baoduong();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn sửa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                String sql_sua = "Update BAODUONG Set MATAISAN='" + txtMaTS.Text + "' , TENTAISAN=N'" + txtTenTS.Text + "' , SOLUONG=" + txtSoLuong.Text + ", NOICHUYENDEN=N'" + txtNoiCD.Text + "', NGAYCHUYENDEN= '" + dateNgayDen.Text + "', TINHTRANG=N'"
                    + txtTinhTrang.Text + "', NGAYBAODUONGXONG='" + dateNgayXong.Text + "' Where MABAODUONG= '" + txtMBD.Text + "'";
                kn.Execute(sql_sua);
                load_Dulieu_Baoduong();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn xóa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
               kn.Execute("Delete BAODUONG Where MABAODUONG ='" + txtMBD.Text + "'");
                load_Dulieu_Baoduong();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboMucTK.Text == "Mã bảo dưỡng")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BAODUONG where MABAODUONG like '" + txtThongTinTK.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dtagridBaoDuong.DataSource = dta;
            }

            else if (cboMucTK.Text == "Mã tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BAODUONG where MATAISAN like '" + txtThongTinTK.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dtagridBaoDuong.DataSource = dta;
            }

            else if (cboMucTK.Text == "Tên tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BAODUONG where TENTAISAN like '" + txtThongTinTK.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dtagridBaoDuong.DataSource = dta;
            }

            else if (cboMucTK.Text == "Nơi chuyển đến")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BAODUONG where NOICHUYENDEN like '" + txtThongTinTK.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dtagridBaoDuong.DataSource = dta;
            }

            else if (cboMucTK.Text == "Tình trạng")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BAODUONG where TINHTRANG like '" + txtThongTinTK.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dtagridBaoDuong.DataSource = dta;
            }

            else if (cboMucTK.Text == "Ngày chuyển đến")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BAODUONG where NGAYCHUYENDEN between '" + dateTimePicker1.Value.ToShortDateString() + "'and '" + dateTimePicker2.Value.ToShortDateString() + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dtagridBaoDuong.DataSource = dta;
            }

            else if (cboMucTK.Text == "Ngày bảo dưỡng xong")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From BAODUONG where NGAYBAODUONGXONG between '" + dateTimePicker1.Value.ToShortDateString() + "'and '"+dateTimePicker2.Value.ToShortDateString()+"'";
                dta = kn.Lay_Dulieu(sqltk);
                dtagridBaoDuong.DataSource = dta;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            load_Dulieu_Baoduong();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
