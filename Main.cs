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
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
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

        private void btnBanGiao_Click(object sender, EventArgs e)
        {
            BanGiaoReport report1 = new BanGiaoReport();
            report1.Show();
        }

        private void btnDieuChuyen_Click(object sender, EventArgs e)
        {
            DIeuChuyenReport report2 = new DIeuChuyenReport();
            report2.Show();
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            ThanhLyReport report3 = new ThanhLyReport();
            report3.Show();
        }

        private void btnBaoDuong_Click(object sender, EventArgs e)
        {
            BaoDuongReport report4 = new BaoDuongReport();
            report4.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucReport report5 = new DanhMucReport();
            report5.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            

        }
        private void SetMyButtonProperties()
        {
            // Assign an image to the button.
            btnBanGiao.Image = Image.FromFile("E:\b.jpg");
            // Align the image and text on the button.
            btnBanGiao.ImageAlign = ContentAlignment.MiddleRight;
            btnBanGiao.TextAlign = ContentAlignment.MiddleLeft;
            // Give the button a flat appearance.
            btnBanGiao.FlatStyle = FlatStyle.Flat;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnCNTT_Click(object sender, EventArgs e)
        {
            DMTS_CNTT dmtscntt = new DMTS_CNTT();
            dmtscntt.Show();
        }

        private void btnMang_Click(object sender, EventArgs e)
        {
            DMTS_MANG dmtscntt = new DMTS_MANG();
            dmtscntt.Show();
        }

        private void btnCNPM_Click(object sender, EventArgs e)
        {
            DMTS_CNPM dmtscntt = new DMTS_CNPM();
            dmtscntt.Show();
        }

        private void btnKHMT_Click(object sender, EventArgs e)
        {
            DMTS_KHMT dmtscntt = new DMTS_KHMT();
            dmtscntt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
