
namespace PROJECT_BTL
{
    partial class DMTS_CNPM
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
            this.btnReload = new System.Windows.Forms.Button();
            this.dataGridViewCNPM = new System.Windows.Forms.DataGridView();
            this.dMTAISANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTS_PROJECTDataSet1 = new PROJECT_BTL.QLTS_PROJECTDataSet1();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dMTAISANTableAdapter = new PROJECT_BTL.QLTS_PROJECTDataSet1TableAdapters.DMTAISANTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTTS = new System.Windows.Forms.TextBox();
            this.txtMTS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMucTK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qLTS_PROJECTDataSet4 = new PROJECT_BTL.QLTS_PROJECTDataSet4();
            this.dMTAISANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dMTAISANTableAdapter1 = new PROJECT_BTL.QLTS_PROJECTDataSet4TableAdapters.DMTAISANTableAdapter();
            this.mATAISANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTAISANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCNPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReload.FlatAppearance.BorderSize = 2;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(249, 195);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(202, 54);
            this.btnReload.TabIndex = 38;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // dataGridViewCNPM
            // 
            this.dataGridViewCNPM.AutoGenerateColumns = false;
            this.dataGridViewCNPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCNPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATAISANDataGridViewTextBoxColumn,
            this.tENTAISANDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.STATUS});
            this.dataGridViewCNPM.DataSource = this.dMTAISANBindingSource1;
            this.dataGridViewCNPM.Location = new System.Drawing.Point(81, 19);
            this.dataGridViewCNPM.Name = "dataGridViewCNPM";
            this.dataGridViewCNPM.Size = new System.Drawing.Size(474, 588);
            this.dataGridViewCNPM.TabIndex = 37;
            // 
            // dMTAISANBindingSource
            // 
            this.dMTAISANBindingSource.DataMember = "DMTAISAN";
            this.dMTAISANBindingSource.DataSource = this.qLTS_PROJECTDataSet1;
            // 
            // qLTS_PROJECTDataSet1
            // 
            this.qLTS_PROJECTDataSet1.DataSetName = "QLTS_PROJECTDataSet1";
            this.qLTS_PROJECTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(82, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 47);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnChen
            // 
            this.btnChen.BackColor = System.Drawing.Color.White;
            this.btnChen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChen.Location = new System.Drawing.Point(274, 73);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(147, 47);
            this.btnChen.TabIndex = 32;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = false;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click_1);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.White;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(82, 73);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(147, 47);
            this.btnTao.TabIndex = 33;
            this.btnTao.Text = "Tạo Mới";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(274, 153);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 47);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(190, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 46);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimkiem.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimkiem.FlatAppearance.BorderSize = 2;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(25, 195);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(202, 54);
            this.btnTimkiem.TabIndex = 40;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click_1);
            // 
            // dMTAISANTableAdapter
            // 
            this.dMTAISANTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.txtTTS);
            this.groupBox2.Controls.Add(this.txtMTS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Location = new System.Drawing.Point(30, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 284);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // txtTTS
            // 
            this.txtTTS.Location = new System.Drawing.Point(211, 114);
            this.txtTTS.Name = "txtTTS";
            this.txtTTS.Size = new System.Drawing.Size(217, 20);
            this.txtTTS.TabIndex = 50;
            // 
            // txtMTS
            // 
            this.txtMTS.Location = new System.Drawing.Point(211, 46);
            this.txtMTS.Name = "txtMTS";
            this.txtMTS.Size = new System.Drawing.Size(217, 20);
            this.txtMTS.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã tài sản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tên tài sản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Số lượng:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(211, 182);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(217, 20);
            this.txtSL.TabIndex = 49;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.groupBox4.Controls.Add(this.cbMucTK);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Controls.Add(this.btnTimkiem);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnReload);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(676, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 268);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TÌM KIẾM";
            // 
            // cbMucTK
            // 
            this.cbMucTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMucTK.FormattingEnabled = true;
            this.cbMucTK.Items.AddRange(new object[] {
            "Mã tài sản",
            "Tên tài sản",
            "Số lượng",
            "Tình Trạng"});
            this.cbMucTK.Location = new System.Drawing.Point(139, 72);
            this.cbMucTK.Name = "cbMucTK";
            this.cbMucTK.Size = new System.Drawing.Size(243, 21);
            this.cbMucTK.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mục tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(139, 142);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(243, 20);
            this.txtTimKiem.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tìm kiếm:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnTao);
            this.groupBox3.Controls.Add(this.btnChen);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(676, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 284);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THAO TÁC";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.dataGridViewCNPM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 268);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BÀNG DANH MỤC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(546, 37);
            this.label6.TabIndex = 63;
            this.label6.Text = "DANH MỤC TÀI SẢN PHÒNG CNPM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 16);
            this.panel1.TabIndex = 70;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(211, 235);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(217, 20);
            this.txtStatus.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tình Trạng:";
            // 
            // qLTS_PROJECTDataSet4
            // 
            this.qLTS_PROJECTDataSet4.DataSetName = "QLTS_PROJECTDataSet4";
            this.qLTS_PROJECTDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMTAISANBindingSource1
            // 
            this.dMTAISANBindingSource1.DataMember = "DMTAISAN";
            this.dMTAISANBindingSource1.DataSource = this.qLTS_PROJECTDataSet4;
            // 
            // dMTAISANTableAdapter1
            // 
            this.dMTAISANTableAdapter1.ClearBeforeFill = true;
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
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // DMTS_CNPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1170, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(30, 60);
            this.Name = "DMTS_CNPM";
            this.Text = "Danh mục tài sản khoa CNPM";
            this.Load += new System.EventHandler(this.DMTS_CNPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCNPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTAISANBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dataGridViewCNPM;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimkiem;

        private System.Windows.Forms.BindingSource bindingSource1;
        private QLTS_PROJECTDataSet1 qLTS_PROJECTDataSet1;
        private System.Windows.Forms.BindingSource dMTAISANBindingSource;
        private QLTS_PROJECTDataSet1TableAdapters.DMTAISANTableAdapter dMTAISANTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTTS;
        private System.Windows.Forms.TextBox txtMTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbMucTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
        private QLTS_PROJECTDataSet4 qLTS_PROJECTDataSet4;
        private System.Windows.Forms.BindingSource dMTAISANBindingSource1;
        private QLTS_PROJECTDataSet4TableAdapters.DMTAISANTableAdapter dMTAISANTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATAISANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTAISANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}