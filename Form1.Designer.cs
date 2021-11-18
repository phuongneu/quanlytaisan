
namespace PROJECT_BTL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BaoCaoBaoDuong3 = new PROJECT_BTL.BaoCaoBaoDuong();
            this.BaoCaoBaoDuong1 = new PROJECT_BTL.BaoCaoBaoDuong();
            this.BaoCaoBaoDuong2 = new PROJECT_BTL.BaoCaoBaoDuong();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mATAISANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTAISANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMTAISANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTS_PROJECTDataSet = new PROJECT_BTL.QLTS_PROJECTDataSet();
            this.dMTAISANTableAdapter = new PROJECT_BTL.QLTS_PROJECTDataSetTableAdapters.DMTAISANTableAdapter();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.dMTAISANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new PROJECT_BTL.QLTS_PROJECTDataSetTableAdapters.PHONGTableAdapter();
            this.btnBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATAISANDataGridViewTextBoxColumn,
            this.tENTAISANDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.mAPHONGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dMTAISANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // mATAISANDataGridViewTextBoxColumn
            // 
            this.mATAISANDataGridViewTextBoxColumn.DataPropertyName = "MATAISAN";
            this.mATAISANDataGridViewTextBoxColumn.HeaderText = "MATAISAN";
            this.mATAISANDataGridViewTextBoxColumn.Name = "mATAISANDataGridViewTextBoxColumn";
            // 
            // tENTAISANDataGridViewTextBoxColumn
            // 
            this.tENTAISANDataGridViewTextBoxColumn.DataPropertyName = "TENTAISAN";
            this.tENTAISANDataGridViewTextBoxColumn.HeaderText = "TENTAISAN";
            this.tENTAISANDataGridViewTextBoxColumn.Name = "tENTAISANDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // mAPHONGDataGridViewTextBoxColumn
            // 
            this.mAPHONGDataGridViewTextBoxColumn.DataPropertyName = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.HeaderText = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.Name = "mAPHONGDataGridViewTextBoxColumn";
            // 
            // dMTAISANBindingSource
            // 
            this.dMTAISANBindingSource.DataMember = "DMTAISAN";
            this.dMTAISANBindingSource.DataSource = this.qLTS_PROJECTDataSet;
            // 
            // qLTS_PROJECTDataSet
            // 
            this.qLTS_PROJECTDataSet.DataSetName = "QLTS_PROJECTDataSet";
            this.qLTS_PROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMTAISANTableAdapter
            // 
            this.dMTAISANTableAdapter.ClearBeforeFill = true;
            // 
            // cbo1
            // 
            this.cbo1.DataSource = this.pHONGBindingSource;
            this.cbo1.DisplayMember = "MAPHONG";
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(349, 236);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 21);
            this.cbo1.TabIndex = 1;
            this.cbo1.ValueMember = "MAPHONG";
            // 
            // dMTAISANBindingSource1
            // 
            this.dMTAISANBindingSource1.DataMember = "DMTAISAN";
            this.dMTAISANBindingSource1.DataSource = this.qLTS_PROJECTDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.qLTS_PROJECTDataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(550, 297);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "In Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BaoCaoBaoDuong BaoCaoBaoDuong1;
        private BaoCaoBaoDuong BaoCaoBaoDuong2;
        private BaoCaoBaoDuong BaoCaoBaoDuong3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTS_PROJECTDataSet qLTS_PROJECTDataSet;
        private System.Windows.Forms.BindingSource dMTAISANBindingSource;
        private QLTS_PROJECTDataSetTableAdapters.DMTAISANTableAdapter dMTAISANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATAISANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTAISANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.BindingSource dMTAISANBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private QLTS_PROJECTDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.Button btnBaoCao;
    }
}