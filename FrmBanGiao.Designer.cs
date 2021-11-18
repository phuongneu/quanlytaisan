
namespace PROJECT_BTL
{
    partial class FrmBanGiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanGiao));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtaGridBanGiao = new System.Windows.Forms.DataGridView();
            this.mABANGIAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATAISANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTAISANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOIBANGIAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOINHANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYGIAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGUOIQUANLYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTS_PROJECTDataSet1 = new PROJECT_BTL.QLTS_PROJECTDataSet1();
            this.bANGIAOTableAdapter = new PROJECT_BTL.QLTS_PROJECTDataSet1TableAdapters.BANGIAOTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMucTimKiem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.nguoiquanlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTS_PROJECTDataSet2 = new PROJECT_BTL.QLTS_PROJECTDataSet2();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNoiBanGiao = new System.Windows.Forms.TextBox();
            this.txtMaTaiSan = new System.Windows.Forms.TextBox();
            this.dateNgayBanGIao = new System.Windows.Forms.DateTimePicker();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoiTiepNhan = new System.Windows.Forms.TextBox();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nguoiquanlyTableAdapter = new PROJECT_BTL.QLTS_PROJECTDataSet2TableAdapters.nguoiquanlyTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridBanGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGIAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiquanlyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(950, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(239, 298);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLammoi.Location = new System.Drawing.Point(15, 212);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(77, 82);
            this.btnLammoi.TabIndex = 5;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(157, 212);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 82);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTim.Location = new System.Drawing.Point(159, 119);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(76, 82);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(15, 119);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 82);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(157, 20);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 83);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(13, 20);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 83);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.groupBox3.Controls.Add(this.dtaGridBanGiao);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1174, 296);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dtaGridBanGiao
            // 
            this.dtaGridBanGiao.AutoGenerateColumns = false;
            this.dtaGridBanGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridBanGiao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mABANGIAODataGridViewTextBoxColumn,
            this.mATAISANDataGridViewTextBoxColumn,
            this.tENTAISANDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.nOIBANGIAODataGridViewTextBoxColumn,
            this.nOINHANDataGridViewTextBoxColumn,
            this.nGAYGIAODataGridViewTextBoxColumn,
            this.nGUOIQUANLYDataGridViewTextBoxColumn});
            this.dtaGridBanGiao.DataSource = this.bANGIAOBindingSource;
            this.dtaGridBanGiao.Location = new System.Drawing.Point(96, 18);
            this.dtaGridBanGiao.Margin = new System.Windows.Forms.Padding(2);
            this.dtaGridBanGiao.Name = "dtaGridBanGiao";
            this.dtaGridBanGiao.RowHeadersWidth = 51;
            this.dtaGridBanGiao.RowTemplate.Height = 24;
            this.dtaGridBanGiao.Size = new System.Drawing.Size(1022, 257);
            this.dtaGridBanGiao.TabIndex = 27;
            // 
            // mABANGIAODataGridViewTextBoxColumn
            // 
            this.mABANGIAODataGridViewTextBoxColumn.DataPropertyName = "MABANGIAO";
            this.mABANGIAODataGridViewTextBoxColumn.HeaderText = "MABANGIAO";
            this.mABANGIAODataGridViewTextBoxColumn.Name = "mABANGIAODataGridViewTextBoxColumn";
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
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // nOIBANGIAODataGridViewTextBoxColumn
            // 
            this.nOIBANGIAODataGridViewTextBoxColumn.DataPropertyName = "NOIBANGIAO";
            this.nOIBANGIAODataGridViewTextBoxColumn.HeaderText = "NOIBANGIAO";
            this.nOIBANGIAODataGridViewTextBoxColumn.Name = "nOIBANGIAODataGridViewTextBoxColumn";
            // 
            // nOINHANDataGridViewTextBoxColumn
            // 
            this.nOINHANDataGridViewTextBoxColumn.DataPropertyName = "NOINHAN";
            this.nOINHANDataGridViewTextBoxColumn.HeaderText = "NOINHAN";
            this.nOINHANDataGridViewTextBoxColumn.Name = "nOINHANDataGridViewTextBoxColumn";
            // 
            // nGAYGIAODataGridViewTextBoxColumn
            // 
            this.nGAYGIAODataGridViewTextBoxColumn.DataPropertyName = "NGAYGIAO";
            this.nGAYGIAODataGridViewTextBoxColumn.HeaderText = "NGAYGIAO";
            this.nGAYGIAODataGridViewTextBoxColumn.Name = "nGAYGIAODataGridViewTextBoxColumn";
            // 
            // nGUOIQUANLYDataGridViewTextBoxColumn
            // 
            this.nGUOIQUANLYDataGridViewTextBoxColumn.DataPropertyName = "NGUOIQUANLY";
            this.nGUOIQUANLYDataGridViewTextBoxColumn.HeaderText = "NGUOIQUANLY";
            this.nGUOIQUANLYDataGridViewTextBoxColumn.Name = "nGUOIQUANLYDataGridViewTextBoxColumn";
            // 
            // bANGIAOBindingSource
            // 
            this.bANGIAOBindingSource.DataMember = "BANGIAO";
            this.bANGIAOBindingSource.DataSource = this.qLTS_PROJECTDataSet1;
            // 
            // qLTS_PROJECTDataSet1
            // 
            this.qLTS_PROJECTDataSet1.DataSetName = "QLTS_PROJECTDataSet1";
            this.qLTS_PROJECTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bANGIAOTableAdapter
            // 
            this.bANGIAOTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.cbMucTimKiem);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboNguoiQuanLy);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtNoiBanGiao);
            this.groupBox1.Controls.Add(this.txtMaTaiSan);
            this.groupBox1.Controls.Add(this.dateNgayBanGIao);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNoiTiepNhan);
            this.groupBox1.Controls.Add(this.txtTenTaiSan);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(916, 298);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbMucTimKiem
            // 
            this.cbMucTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMucTimKiem.FormattingEnabled = true;
            this.cbMucTimKiem.Items.AddRange(new object[] {
            "",
            "Mã bàn giao",
            "Mã tài sản",
            "Tên tài sản",
            "Nơi bàn giao",
            "Nơi nhận",
            "Người quản lý",
            "Ngày bàn giao"});
            this.cbMucTimKiem.Location = new System.Drawing.Point(279, 176);
            this.cbMucTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cbMucTimKiem.Name = "cbMucTimKiem";
            this.cbMucTimKiem.Size = new System.Drawing.Size(154, 25);
            this.cbMucTimKiem.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(634, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Người Quản Lý";
            // 
            // cboNguoiQuanLy
            // 
            this.cboNguoiQuanLy.DataSource = this.nguoiquanlyBindingSource;
            this.cboNguoiQuanLy.DisplayMember = "hoten";
            this.cboNguoiQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiQuanLy.FormattingEnabled = true;
            this.cboNguoiQuanLy.Location = new System.Drawing.Point(758, 71);
            this.cboNguoiQuanLy.Name = "cboNguoiQuanLy";
            this.cboNguoiQuanLy.Size = new System.Drawing.Size(153, 25);
            this.cboNguoiQuanLy.TabIndex = 30;
            this.cboNguoiQuanLy.ValueMember = "hoten";
            // 
            // nguoiquanlyBindingSource
            // 
            this.nguoiquanlyBindingSource.DataMember = "nguoiquanly";
            this.nguoiquanlyBindingSource.DataSource = this.qLTS_PROJECTDataSet2;
            // 
            // qLTS_PROJECTDataSet2
            // 
            this.qLTS_PROJECTDataSet2.DataSetName = "QLTS_PROJECTDataSet2";
            this.qLTS_PROJECTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(378, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(452, 71);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(154, 23);
            this.txtDonGia.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(613, 221);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Đến";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(613, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Từ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(668, 217);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(668, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // txtNoiBanGiao
            // 
            this.txtNoiBanGiao.Location = new System.Drawing.Point(452, 101);
            this.txtNoiBanGiao.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiBanGiao.Name = "txtNoiBanGiao";
            this.txtNoiBanGiao.Size = new System.Drawing.Size(154, 23);
            this.txtNoiBanGiao.TabIndex = 22;
            // 
            // txtMaTaiSan
            // 
            this.txtMaTaiSan.Location = new System.Drawing.Point(452, 35);
            this.txtMaTaiSan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTaiSan.Name = "txtMaTaiSan";
            this.txtMaTaiSan.Size = new System.Drawing.Size(154, 23);
            this.txtMaTaiSan.TabIndex = 21;
            // 
            // dateNgayBanGIao
            // 
            this.dateNgayBanGIao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBanGIao.Location = new System.Drawing.Point(147, 103);
            this.dateNgayBanGIao.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgayBanGIao.Name = "dateNgayBanGIao";
            this.dateNgayBanGIao.Size = new System.Drawing.Size(154, 23);
            this.dateNgayBanGIao.TabIndex = 20;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(279, 216);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(154, 23);
            this.txtTim.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Thông tin cần tìm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mục tìm kiếm:";
            // 
            // txtNoiTiepNhan
            // 
            this.txtNoiTiepNhan.Location = new System.Drawing.Point(758, 103);
            this.txtNoiTiepNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiTiepNhan.Name = "txtNoiTiepNhan";
            this.txtNoiTiepNhan.Size = new System.Drawing.Size(154, 23);
            this.txtNoiTiepNhan.TabIndex = 12;
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Location = new System.Drawing.Point(758, 35);
            this.txtTenTaiSan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(154, 23);
            this.txtTenTaiSan.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(147, 71);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(154, 23);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(147, 35);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(154, 23);
            this.txtMaPhieu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Bàn Giao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nơi nhận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nơi Bàn Giao:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên tài sản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã tài sản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bàn Giao";
            // 
            // nguoiquanlyTableAdapter
            // 
            this.nguoiquanlyTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBanGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1216, 659);
            this.MinimumSize = new System.Drawing.Size(1216, 659);
            this.Name = "FrmBanGiao";
            this.Text = "FrmBanGiao";
            this.Load += new System.EventHandler(this.FrmBanGiao_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridBanGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGIAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiquanlyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTS_PROJECTDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtaGridBanGiao;
        private QLTS_PROJECTDataSet1 qLTS_PROJECTDataSet1;
        private System.Windows.Forms.BindingSource bANGIAOBindingSource;
        private QLTS_PROJECTDataSet1TableAdapters.BANGIAOTableAdapter bANGIAOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mABANGIAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATAISANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTAISANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOIBANGIAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOINHANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYGIAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGUOIQUANLYDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNoiBanGiao;
        private System.Windows.Forms.TextBox txtMaTaiSan;
        private System.Windows.Forms.DateTimePicker dateNgayBanGIao;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoiTiepNhan;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboNguoiQuanLy;
        private System.Windows.Forms.Label label4;
        private QLTS_PROJECTDataSet2 qLTS_PROJECTDataSet2;
        private System.Windows.Forms.BindingSource nguoiquanlyBindingSource;
        private QLTS_PROJECTDataSet2TableAdapters.nguoiquanlyTableAdapter nguoiquanlyTableAdapter;
        private System.Windows.Forms.ComboBox cbMucTimKiem;
    }
}