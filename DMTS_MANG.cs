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
    public partial class DMTS_MANG : Form
    {
        ketnoi kn = new ketnoi();
        public DMTS_MANG()
        {
            InitializeComponent();
        }

        private void DMTS_MANG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet4.DMTAISAN' table. You can move, or remove it, as needed.
            this.dMTAISANTableAdapter.Fill(this.qLTS_PROJECTDataSet4.DMTAISAN);

            dulieu_DMTS();
        }

        public void HienThi_DuLieu()
        {
            txtMTS.DataBindings.Clear();
            txtMTS.DataBindings.Add("Text", dataGridViewMANG.DataSource, "MATAISAN");
            txtTTS.DataBindings.Clear();
            txtTTS.DataBindings.Add("Text", dataGridViewMANG.DataSource, "TENTAISAN");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dataGridViewMANG.DataSource, "SOLUONG");
            txtStatus.DataBindings.Clear();
            txtStatus.DataBindings.Add("Text", dataGridViewMANG.DataSource, "STATUS");
        }
        public void dulieu_DMTS()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select MATAISAN,TENTAISAN, SOLUONG,STATUS from DMTAISAN WHERE MAPHONG='MANG'");
            dataGridViewMANG.DataSource = dta;
            HienThi_DuLieu();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMTS.Text = "";
            txtSL.Text = "";
            txtTTS.Text = "";
            txtStatus.Text = "";

        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String cnpm = "MANG";
            String sql_chen = "Insert into DMTAISAN values('" + txtMTS.Text + "','" + txtTTS.Text + "','" + txtSL.Text + "','" + cnpm + "','" + txtStatus.Text + "')";
            kn.Execute(sql_chen);
            dulieu_DMTS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql_sua = "Update DMTAISAN Set TENTAISAN=N'" + txtTTS.Text + "',SOLUONG='" + txtSL.Text + "',STATUS=N'" + txtStatus.Text + "'Where MATAISAN='" + txtMTS.Text + "'";
            kn.Execute(sql_sua);
            dulieu_DMTS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete DMTAISAN Where MATAISAN='" + txtMTS.Text + "'");
            dulieu_DMTS();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sqltk;
            if (cbMucTK.Text == "Mã tài sản")
            {
                sqltk = "Select * From DMTAISAN where MATAISAN like'%" + txtTimKiem.Text + "%' AND MAPHONG ='MANG'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (cbMucTK.Text == "Tên tài sản")
            {
                sqltk = "Select * From DMTAISAN where TENTAISAN like'%" + txtTimKiem.Text + "%'AND MAPHONG ='MANG'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (cbMucTK.Text == "Số lượng")
            {
                sqltk = "Select * From DMTAISAN where SOLUONG like'" + txtTimKiem.Text + "'AND MAPHONG ='MANG'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (cbMucTK.Text == "Tình Trạng")
            {
                sqltk = "Select * From DMTAISAN where STATUS like N'" + txtTimKiem.Text + "'AND MAPHONG ='MANG'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            dataGridViewMANG.DataSource = dta;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select MATAISAN,TENTAISAN, SOLUONG,STATUS from DMTAISAN WHERE MAPHONG='MANG'");
            dataGridViewMANG.DataSource = dta;
            HienThi_DuLieu();
            txtTimKiem.Text = "";
        }

        private void dataGridViewMANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
