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
    public partial class BanGiaoReport : Form
    {
        private int childFormNumber = 0;

        public BanGiaoReport()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        ketnoi kn = new ketnoi();
        private void BanGiaoReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.BANGIAO' table. You can move, or remove it, as needed.
            this.bANGIAOTableAdapter.Fill(this.qLTS_PROJECTDataSet1.BANGIAO);
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLTS_PROJECTDataSet1.PHONG);

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void delete()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
            SqlCommand cmdDelete = new SqlCommand(@"Delete BANGIAOFILTER");
            cmdDelete.Connection = con2;
            con2.Open();
            cmdDelete.ExecuteNonQuery();
            con2.Close();
        }
        public void Loc_DuLieuDate()
        {
            string StartDate = dtpStart.Value.ToShortDateString();
            string endDate = dtpEnd.Value.ToShortDateString();
            DataTable dta = new DataTable();
            String sqltk;
            sqltk = "Select * From BANGIAO where NGAYGIAO between  '" + StartDate + "'and '"+endDate+"'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGridView1.DataSource = dta;
        }
        public void Loc_DuLieuQuanLy()
        {
            
            DataTable dta = new DataTable();
            String sqltk;
            sqltk = "Select * From BANGIAO where NGUOIQUANLY like  N'" + cboQuanLy.Text + "'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGridView1.DataSource = dta;
        }
        public void Loc_DuLieuNoiGiao()
        {

            DataTable dta = new DataTable();
            String sqltk;
            sqltk = "Select * From BANGIAO where NOIBANGIAO like  N'" + cboNoiGiao.Text + "'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGridView1.DataSource = dta;
        }
        public void Loc_DuLieuNoiNhan()
        {

            DataTable dta = new DataTable();
            String sqltk;
            sqltk = "Select * From BANGIAO where NOINHAN like  N'" + cboNoiNhan.Text + "'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGridView1.DataSource = dta;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (checkNgayGiao.Checked == true)
            {
                Loc_DuLieuDate();
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            if (checkQuanLy.Checked == true)
            {
                Loc_DuLieuQuanLy();
                delete();
                
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            if (checkNoiGiao.Checked == true)
            {
                Loc_DuLieuNoiGiao();
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            if (checkNoiNhan.Checked == true)
            {
                Loc_DuLieuNoiNhan();
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            if (checkNoiGiao.Checked == true && checkNoiNhan.Checked == true)
            {

                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOIBANGIAO like  N'" + cboNoiGiao.Text + "'and NOINHAN like N'"+cboNoiNhan.Text+"'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            if(checkNoiGiao.Checked==true&& checkNgayGiao.Checked == true)
            {
                string StartDate = dtpStart.Value.ToShortDateString();
                string endDate = dtpEnd.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOIBANGIAO like  N'" + cboNoiGiao.Text + "'and NGAYGIAO between  '" + StartDate + "'and '" + endDate + "'"; 
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkNoiNhan.Checked == true && checkNgayGiao.Checked == true)
            {
                string StartDate = dtpStart.Value.ToShortDateString();
                string endDate = dtpEnd.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOINHAN like  N'" + cboNoiNhan.Text + "'and NGAYGIAO between  '" + StartDate + "'and '" + endDate + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkQuanLy.Checked == true && checkNgayGiao.Checked == true)
            {
                string StartDate = dtpStart.Value.ToShortDateString();
                string endDate = dtpEnd.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NGUOIQUANLY like  N'" + cboQuanLy.Text + "'and NGAYGIAO between  '" + StartDate + "'and '" + endDate + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkQuanLy.Checked == true && checkNoiNhan.Checked == true)
            {
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NGUOIQUANLY like  N'" + cboQuanLy.Text + "'and NOINHAN like   N'" + cboNoiNhan.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkQuanLy.Checked == true && checkNoiGiao.Checked == true)
            {
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NGUOIQUANLY like  N'" + cboQuanLy.Text + "'and NOIBANGIAO like   N'" + cboNoiGiao.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkNoiNhan.Checked == true && checkNgayGiao.Checked == true&&checkNoiGiao.Checked==true)
            {
                string StartDate = dtpStart.Value.ToShortDateString();
                string endDate = dtpEnd.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOINHAN like  N'" + cboNoiNhan.Text + "'and NOIBANGIAO like N'"+cboNoiGiao.Text+"'and NGAYGIAO between  '" + StartDate + "'and '" + endDate + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkNoiNhan.Checked == true && checkQuanLy.Checked == true && checkNoiGiao.Checked == true)
            {

                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOINHAN like  N'" + cboNoiNhan.Text + "'and NOIBANGIAO like N'" + cboNoiGiao.Text + "'and NGUOIQUANLY like  N'" + cboQuanLy.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkNoiNhan.Checked == true && checkNgayGiao.Checked == true && checkQuanLy.Checked == true)
            {
                string StartDate = dtpStart.Value.ToShortDateString();
                string endDate = dtpEnd.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOINHAN like  N'" + cboNoiNhan.Text + "'and NGUOIQUANLY like N'" + cboQuanLy.Text + "'and NGAYGIAO between  '" + StartDate + "'and '" + endDate + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkNoiGiao.Checked == true && checkNgayGiao.Checked == true && checkQuanLy.Checked == true)
            {
                string StartDate = dtpStart.Value.ToShortDateString();
                string endDate = dtpEnd.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOIBANGIAO like  N'" + cboNoiGiao.Text + "'and NGUOIQUANLY like N'" + cboQuanLy.Text + "'and NGAYGIAO between  '" + StartDate + "'and '" + endDate + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkNoiNhan.Checked == true && checkNgayGiao.Checked == true && checkNoiGiao.Checked == true&&checkNoiGiao.Checked==true)
            {
                string StartDate = dtpStart.Value.ToShortDateString();
                string endDate = dtpEnd.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BANGIAO where NOINHAN like  N'" + cboNoiNhan.Text + "'and NOIBANGIAO like N'" + cboNoiGiao.Text + "'and NGUOIQUANLY like N'"+cboQuanLy.Text+"'and NGAYGIAO between  '" + StartDate + "'and '" + endDate + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BANGIAOFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            BANGIAOFILTERED test = new BANGIAOFILTERED();
            test.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
