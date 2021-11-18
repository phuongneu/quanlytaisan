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
    public partial class BaoDuongReport : Form
    {
        private int childFormNumber = 0;
        ketnoi kn = new ketnoi();
        public BaoDuongReport()
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
        public void delete()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
            SqlCommand cmdDelete = new SqlCommand(@"Delete BAODUONGFILTER");
            cmdDelete.Connection = con2;
            con2.Open();
            cmdDelete.ExecuteNonQuery();
            con2.Close();
        }
        public void Loc_DuLieuDate()
        {
            string StartDate = dtpStart1.Value.ToShortDateString();
            string endDate = dtpEnd1.Value.ToShortDateString();
            DataTable dta = new DataTable();
            String sqltk;
            sqltk = "Select * From BAODUONG where NGAYCHUYENDEN between  '" + StartDate + "'and '" + endDate + "'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGridView1.DataSource = dta;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkNgayDen.Checked == true)
            {
                Loc_DuLieuDate();
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BAODUONGFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value +  "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            if (checkNgayXong.Checked == true)
            {
                string StartDate = dtpStart2.Value.ToShortDateString();
                string endDate = dtpEnd2.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BAODUONG where NGAYBAODUONGXONG between  '" + StartDate + "'and '" + endDate + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete(); 
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BAODUONGFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if(checkNgayDen.Checked==true && checkNgayXong.Checked == true)
            {
                string StartDate1 = dtpStart1.Value.ToShortDateString();
                string endDate1 = dtpEnd1.Value.ToShortDateString();
                string StartDate = dtpStart2.Value.ToShortDateString();
                string endDate = dtpEnd2.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BAODUONG where NGAYBAODUONGXONG between  '" + StartDate + "'and '" + endDate + "'and NGAYCHUYENDEN between '"+StartDate1+"'and'"+endDate1+"'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BAODUONGFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            if (checkTinhTrang.Checked == true)
            {
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BAODUONG where TINHTRANG like  N'" + cboTinhTrang.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BAODUONGFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (checkTinhTrang.Checked == true && checkNgayDen.Checked == true)
            
            {
                string StartDate1 = dtpStart1.Value.ToShortDateString();
                string endDate1 = dtpEnd1.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BAODUONG where TINHTRANG like  N'" + cboTinhTrang.Text + "'and NGAYCHUYENDEN between N'"+StartDate1+"'and'"+endDate1+"'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BAODUONGFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            if (checkTinhTrang.Checked == true && checkNgayDen.Checked == true)

            {
                string StartDate1 = dtpStart2.Value.ToShortDateString();
                string endDate1 = dtpEnd2.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BAODUONG where TINHTRANG like  N'" + cboTinhTrang.Text + "'and NGAYBAODUONGXONG between N'" + StartDate1 + "'and'" + endDate1 + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BAODUONGFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            if (checkTinhTrang.Checked == true && checkNgayDen.Checked == true && checkNgayXong.Checked == true)
            {
                string StartDate1 = dtpStart1.Value.ToShortDateString();
                string endDate1 = dtpEnd1.Value.ToShortDateString();
                string StartDate = dtpStart2.Value.ToShortDateString();
                string endDate = dtpEnd2.Value.ToShortDateString();
                DataTable dta = new DataTable();
                String sqltk;
                sqltk = "Select * From BAODUONG where TINHTRANG like  N'" + cboTinhTrang.Text + "'and NGAYBAODUONGXONG between  '" + StartDate + "'and '" + endDate + "'and NGAYCHUYENDEN between '" + StartDate1 + "'and'" + endDate1 + "'";
                dta = kn.Lay_Dulieu(sqltk);
                dataGridView1.DataSource = dta;
                delete();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BAODUONGFILTER VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

                BAODUONGFILTER test = new BAODUONGFILTER();
            test.Show();
        }

        private void BaoDuongReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.BAODUONG' table. You can move, or remove it, as needed.
            this.bAODUONGTableAdapter.Fill(this.qLTS_PROJECTDataSet1.BAODUONG);

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
