namespace PBL3_CofffeeShop.GUI
{
    partial class fDetailKiemKho
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblNgayKiem = new System.Windows.Forms.Label();
            this.dtpNgayKiem = new System.Windows.Forms.DateTimePicker();
            this.dgvKiemKe = new System.Windows.Forms.DataGridView();
            this.colMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLHeThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblNguoiKiem = new System.Windows.Forms.Label();
            this.cboNguoiKiem = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongGiaTri = new System.Windows.Forms.Label();
            this.lblTongChenhLech = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemKe)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin kiểm kê";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location = new System.Drawing.Point(30, 30);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(65, 16);
            this.lblMaPhieu.TabIndex = 1;
            this.lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(110, 27);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(150, 22);
            this.txtMaPhieu.TabIndex = 2;
            // 
            // lblNgayKiem
            // 
            this.lblNgayKiem.AutoSize = true;
            this.lblNgayKiem.Location = new System.Drawing.Point(290, 30);
            this.lblNgayKiem.Name = "lblNgayKiem";
            this.lblNgayKiem.Size = new System.Drawing.Size(75, 16);
            this.lblNgayKiem.TabIndex = 3;
            this.lblNgayKiem.Text = "Ngày kiểm:";
            // 
            // dtpNgayKiem
            // 
            this.dtpNgayKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKiem.Location = new System.Drawing.Point(380, 27);
            this.dtpNgayKiem.Name = "dtpNgayKiem";
            this.dtpNgayKiem.Size = new System.Drawing.Size(130, 22);
            this.dtpNgayKiem.TabIndex = 4;
            // 
            // dgvKiemKe
            // 
            this.dgvKiemKe.AllowUserToAddRows = false;
            this.dgvKiemKe.AllowUserToDeleteRows = false;
            this.dgvKiemKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiemKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNL,
            this.colTenNL,
            this.colDonVi,
            this.colSLHeThong,
            this.colSLThucTe,
            this.colChenhLech,
            this.colGhiChu});
            this.dgvKiemKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKiemKe.Location = new System.Drawing.Point(3, 143);
            this.dgvKiemKe.Name = "dgvKiemKe";
            this.dgvKiemKe.RowHeadersWidth = 51;
            this.dgvKiemKe.RowTemplate.Height = 24;
            this.dgvKiemKe.Size = new System.Drawing.Size(944, 334);
            this.dgvKiemKe.TabIndex = 5;
            // 
            // colMaNL
            // 
            this.colMaNL.HeaderText = "Mã NL";
            this.colMaNL.MinimumWidth = 6;
            this.colMaNL.Name = "colMaNL";
            this.colMaNL.ReadOnly = true;
            this.colMaNL.Width = 80;
            // 
            // colTenNL
            // 
            this.colTenNL.HeaderText = "Tên nguyên liệu";
            this.colTenNL.MinimumWidth = 6;
            this.colTenNL.Name = "colTenNL";
            this.colTenNL.ReadOnly = true;
            this.colTenNL.Width = 200;
            // 
            // colDonVi
            // 
            this.colDonVi.HeaderText = "Đơn vị";
            this.colDonVi.MinimumWidth = 6;
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.ReadOnly = true;
            this.colDonVi.Width = 80;
            // 
            // colSLHeThong
            // 
            this.colSLHeThong.HeaderText = "SL hệ thống";
            this.colSLHeThong.MinimumWidth = 6;
            this.colSLHeThong.Name = "colSLHeThong";
            this.colSLHeThong.ReadOnly = true;
            this.colSLHeThong.Width = 120;
            // 
            // colSLThucTe
            // 
            this.colSLThucTe.HeaderText = "SL thực tế";
            this.colSLThucTe.MinimumWidth = 6;
            this.colSLThucTe.Name = "colSLThucTe";
            this.colSLThucTe.Width = 120;
            // 
            // colChenhLech
            // 
            this.colChenhLech.HeaderText = "Chênh lệch";
            this.colChenhLech.MinimumWidth = 6;
            this.colChenhLech.Name = "colChenhLech";
            this.colChenhLech.ReadOnly = true;
            this.colChenhLech.Width = 120;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 200;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnHuy);
            this.panelBottom.Controls.Add(this.btnLuu);
            this.panelBottom.Controls.Add(this.btnXuatBaoCao);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 523);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(944, 54);
            this.panelBottom.TabIndex = 6;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(850, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(750, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 35);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(620, 10);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(120, 35);
            this.btnXuatBaoCao.TabIndex = 0;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(944, 134);
            this.panelTop.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTinhTrang);
            this.groupBox1.Controls.Add(this.cboTinhTrang);
            this.groupBox1.Controls.Add(this.lblNguoiKiem);
            this.groupBox1.Controls.Add(this.cboNguoiKiem);
            this.groupBox1.Controls.Add(this.lblMaPhieu);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.lblNgayKiem);
            this.groupBox1.Controls.Add(this.dtpNgayKiem);
            this.groupBox1.Location = new System.Drawing.Point(17, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu kiểm";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(30, 60);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(69, 16);
            this.lblTinhTrang.TabIndex = 7;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Đang thực hiện",
            "Hoàn thành",
            "Hủy"});
            this.cboTinhTrang.Location = new System.Drawing.Point(110, 57);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(150, 24);
            this.cboTinhTrang.TabIndex = 8;
            // 
            // lblNguoiKiem
            // 
            this.lblNguoiKiem.AutoSize = true;
            this.lblNguoiKiem.Location = new System.Drawing.Point(540, 30);
            this.lblNguoiKiem.Name = "lblNguoiKiem";
            this.lblNguoiKiem.Size = new System.Drawing.Size(78, 16);
            this.lblNguoiKiem.TabIndex = 5;
            this.lblNguoiKiem.Text = "Người kiểm:";
            // 
            // cboNguoiKiem
            // 
            this.cboNguoiKiem.FormattingEnabled = true;
            this.cboNguoiKiem.Location = new System.Drawing.Point(630, 27);
            this.cboNguoiKiem.Name = "cboNguoiKiem";
            this.cboNguoiKiem.Size = new System.Drawing.Size(250, 24);
            this.cboNguoiKiem.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvKiemKe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 580);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTongGiaTri);
            this.panel1.Controls.Add(this.lblTongChenhLech);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 34);
            this.panel1.TabIndex = 8;
            // 
            // lblTongGiaTri
            // 
            this.lblTongGiaTri.AutoSize = true;
            this.lblTongGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGiaTri.Location = new System.Drawing.Point(400, 8);
            this.lblTongGiaTri.Name = "lblTongGiaTri";
            this.lblTongGiaTri.Size = new System.Drawing.Size(234, 20);
            this.lblTongGiaTri.TabIndex = 1;
            this.lblTongGiaTri.Text = "Tổng giá trị chênh lệch: 0đ";
            // 
            // lblTongChenhLech
            // 
            this.lblTongChenhLech.AutoSize = true;
            this.lblTongChenhLech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChenhLech.Location = new System.Drawing.Point(30, 8);
            this.lblTongChenhLech.Name = "lblTongChenhLech";
            this.lblTongChenhLech.Size = new System.Drawing.Size(195, 20);
            this.lblTongChenhLech.TabIndex = 0;
            this.lblTongChenhLech.Text = "Tổng số chênh lệch: 0";
            // 
            // fDetailKiemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "fDetailKiemKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiểm kê kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemKe)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblNgayKiem;
        private System.Windows.Forms.DateTimePicker dtpNgayKiem;
        private System.Windows.Forms.DataGridView dgvKiemKe;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNguoiKiem;
        private System.Windows.Forms.ComboBox cboNguoiKiem;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTongChenhLech;
        private System.Windows.Forms.Label lblTongGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLHeThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChenhLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}