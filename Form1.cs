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
    public partial class Form1 : Form
    {
        ketnoi kn = new ketnoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLTS_PROJECTDataSet.PHONG);
            // TODO: This line of code loads data into the 'qLTS_PROJECTDataSet.DMTAISAN' table. You can move, or remove it, as needed.
            this.dMTAISANTableAdapter.Fill(this.qLTS_PROJECTDataSet.DMTAISAN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sqltk;
            sqltk = "Select * From DMTAISAN where MAPHONG ='" + cbo1.Text + "'";
            dta = kn.Lay_Dulieu(sqltk);
            dataGridView1.DataSource = dta;
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
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
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

