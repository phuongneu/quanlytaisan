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
    public partial class FrmDieuChuyen : Form
    {
        ketnoi ketnoi = new ketnoi();
        public void load_Dulieu_Dieuchuyen()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * from DIEUCHUYEN");
            dtagridDieuChuyen.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMDC.DataBindings.Clear();
            txtMDC.DataBindings.Add("Text", dtagridDieuChuyen.DataSource, "MADC");

            txtNoiNhan.DataBindings.Clear();
            txtNoiNhan.DataBindings.Add("Text", dtagridDieuChuyen.DataSource, "NOINHAN");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dtagridDieuChuyen.DataSource, "SOLUONG");

            txtTenTS.DataBindings.Clear();
            txtTenTS.DataBindings.Add("Text", dtagridDieuChuyen.DataSource, "TENTAISAN");

            txtMaTS.DataBindings.Clear();
            txtMaTS.DataBindings.Add("Text", dtagridDieuChuyen.DataSource, "MATAISAN");

            txtNoiDC.DataBindings.Clear();
            txtNoiDC.DataBindings.Add("Text", dtagridDieuChuyen.DataSource, "NOIBANGIAO");

            dateNgay.DataBindings.Clear();
            dateNgay.DataBindings.Add("Text", dtagridDieuChuyen.DataSource, "NGAYGIAO");
        }

        public FrmDieuChuyen()
        {
            InitializeComponent();
        }

        private void FrmDieuChuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.DIEUCHUYEN' table. You can move, or remove it, as needed.
            this.dIEUCHUYENTableAdapter.Fill(this.qLTS_PROJECTDataSet1.DIEUCHUYEN);
            load_Dulieu_Dieuchuyen();
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
                string sql_them = "Insert into DIEUCHUYEN Values('" + txtMDC.Text + "' , '" + txtMaTS.Text + "' , N'" + txtTenTS.Text + "' , " + txtSoLuong.Text + " , '" + txtNoiDC.Text + "' , '" + txtNoiNhan.Text + "' ,'" + dateNgay.Value.ToShortDateString() + "')";
                ketnoi.Execute(sql_them);
                load_Dulieu_Dieuchuyen();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn sửa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                String sql_sua = "Update DIEUCHUYEN Set MATAISAN='" + txtMaTS.Text + "' , TENTAISAN=N'" + txtTenTS.Text + "' , SOLUONG=" + txtSoLuong.Text + ", NOIBANGIAO='" + txtNoiDC.Text + "', NOINHAN='" + txtNoiNhan.Text + "', NGAYGIAO='" + dateNgay.Value.ToShortDateString() + "' Where MADC= '" + txtMDC.Text + "'";
                ketnoi.Execute(sql_sua);
                load_Dulieu_Dieuchuyen();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao1;
            thongbao1 = MessageBox.Show("Bạn có thực sự muốn xóa không", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao1 == DialogResult.Yes)
            {
                ketnoi.Execute("Delete DIEUCHUYEN Where MADC ='" + txtMDC.Text + "'");
                load_Dulieu_Dieuchuyen();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboMucTK.Text == "Mã điều chuyển")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From DIEUCHUYEN where MADC like '" + txtThongTinTK.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtagridDieuChuyen.DataSource = dta;
            }

            else if (cboMucTK.Text == "Mã tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From DIEUCHUYEN where MATAISAN like '" + txtThongTinTK.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtagridDieuChuyen.DataSource = dta;
            }

            else if (cboMucTK.Text == "Tên tài sản")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From DIEUCHUYEN where TENTAISAN like '" + txtThongTinTK.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtagridDieuChuyen.DataSource = dta;
            }

            else if (cboMucTK.Text == "Nơi điều chuyển")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From DIEUCHUYEN where NOIBANGIAO like '" + txtThongTinTK.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtagridDieuChuyen.DataSource = dta;
            }

            else if (cboMucTK.Text == "Nơi nhận")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From DIEUCHUYEN where NOINHAN like '" + txtThongTinTK.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtagridDieuChuyen.DataSource = dta;
            }

            else if (cboMucTK.Text == "Ngày điều chuyển")
            {
                DataTable dta = new DataTable();
                string sqltk = "Select * From DIEUCHUYEN where NGAYGIAO between '" + dateTimePicker1.Value.ToShortDateString() + "'and'"+dateTimePicker2.Value.ToShortDateString()+"'";
                dta = ketnoi.Lay_Dulieu(sqltk);
                dtagridDieuChuyen.DataSource = dta;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            load_Dulieu_Dieuchuyen();
        }
    }
}
