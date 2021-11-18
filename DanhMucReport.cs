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
    public partial class DanhMucReport : Form
    {
        private int childFormNumber = 0;

        public DanhMucReport()
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

        private void DanhMucReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLTS_PROJECTDataSet1.PHONG);
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet1.test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.qLTS_PROJECTDataSet1.test);

        }
        public void delete()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");
            SqlCommand cmdDelete = new SqlCommand(@"Delete test");
            cmdDelete.Connection = con2;
            con2.Open();
            cmdDelete.ExecuteNonQuery();
            con2.Close();
        }
        ketnoi kn = new ketnoi();
        public void Loc_DuLieu()
        {
            DataTable dta = new DataTable();
            String sqltk;
            sqltk = "Select * From DMTAISAN where MAPHONG ='" + cboLoc.Text + "'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGridView1.DataSource = dta;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_DuLieu();
            delete();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-623RGSB;Initial Catalog=QLTS_PROJECT;Integrated Security=True");



            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                SqlCommand cmd = new SqlCommand(@"INSERT INTO test VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            FormTest test = new FormTest();
            test.Show();
        }
    }
}
