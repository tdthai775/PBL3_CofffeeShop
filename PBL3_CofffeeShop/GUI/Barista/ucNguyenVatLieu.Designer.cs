namespace PBL3_CofffeeShop.GUI
{
    partial class ucNguyenVatLieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cBNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cBDanhMuc = new System.Windows.Forms.ComboBox();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.cMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.btnLichSuBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(778, 153);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 28);
            this.btnXoa.TabIndex = 147;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(143)))), ((int)(((byte)(95)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(778, 101);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 28);
            this.btnThem.TabIndex = 146;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // numSoLuong
            // 
            this.numSoLuong.DecimalPlaces = 2;
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numSoLuong.Location = new System.Drawing.Point(596, 104);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(65, 27);
            this.numSoLuong.TabIndex = 144;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(507, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 20);
            this.label16.TabIndex = 142;
            this.label16.Text = "Số lượng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(137, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 136;
            this.label15.Text = "Nguyên liệu";
            // 
            // cBNguyenLieu
            // 
            this.cBNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBNguyenLieu.FormattingEnabled = true;
            this.cBNguyenLieu.Location = new System.Drawing.Point(261, 152);
            this.cBNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBNguyenLieu.Name = "cBNguyenLieu";
            this.cBNguyenLieu.Size = new System.Drawing.Size(210, 28);
            this.cBNguyenLieu.TabIndex = 137;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(137, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 134;
            this.label19.Text = "Danh mục";
            // 
            // cBDanhMuc
            // 
            this.cBDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDanhMuc.FormattingEnabled = true;
            this.cBDanhMuc.Location = new System.Drawing.Point(261, 103);
            this.cBDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBDanhMuc.Name = "cBDanhMuc";
            this.cBDanhMuc.Size = new System.Drawing.Size(210, 28);
            this.cBDanhMuc.TabIndex = 135;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoCao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoCao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.ColumnHeadersHeight = 30;
            this.dgvBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNL,
            this.cTenNguyenLieu,
            this.cSoLuong,
            this.cDonVi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.EnableHeadersVisualStyles = false;
            this.dgvBaoCao.Location = new System.Drawing.Point(137, 205);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 30;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(734, 510);
            this.dgvBaoCao.TabIndex = 133;
            // 
            // cMaNL
            // 
            this.cMaNL.HeaderText = "Mã NL";
            this.cMaNL.MinimumWidth = 6;
            this.cMaNL.Name = "cMaNL";
            this.cMaNL.Width = 125;
            // 
            // cTenNguyenLieu
            // 
            this.cTenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.cTenNguyenLieu.MinimumWidth = 6;
            this.cTenNguyenLieu.Name = "cTenNguyenLieu";
            this.cTenNguyenLieu.Width = 240;
            // 
            // cSoLuong
            // 
            this.cSoLuong.HeaderText = "Số lượng";
            this.cSoLuong.MinimumWidth = 6;
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.Width = 92;
            // 
            // cDonVi
            // 
            this.cDonVi.HeaderText = "Đơn vị";
            this.cDonVi.MinimumWidth = 6;
            this.cDonVi.Name = "cDonVi";
            this.cDonVi.Width = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(518, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 141;
            this.label13.Text = "Ngày";
            // 
            // dateNgay
            // 
            this.dateNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgay.Location = new System.Drawing.Point(596, 153);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(132, 27);
            this.dateNgay.TabIndex = 139;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(423, 38);
            this.label14.TabIndex = 150;
            this.label14.Text = "Báo cáo sử dụng hàng ngày";
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.White;
            this.btnTaoBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaoBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoBaoCao.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnTaoBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTaoBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTaoBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnTaoBaoCao.Image = global::PBL3_CofffeeShop.Properties.Resources.BaoCao;
            this.btnTaoBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(916, 205);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(202, 39);
            this.btnTaoBaoCao.TabIndex = 149;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnLichSuBaoCao
            // 
            this.btnLichSuBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLichSuBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLichSuBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSuBaoCao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLichSuBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLichSuBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnLichSuBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuBaoCao.Image = global::PBL3_CofffeeShop.Properties.Resources.LichSu;
            this.btnLichSuBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSuBaoCao.Location = new System.Drawing.Point(916, 269);
            this.btnLichSuBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuBaoCao.Name = "btnLichSuBaoCao";
            this.btnLichSuBaoCao.Size = new System.Drawing.Size(202, 39);
            this.btnLichSuBaoCao.TabIndex = 148;
            this.btnLichSuBaoCao.Text = "Lịch sử báo cáo";
            this.btnLichSuBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuBaoCao.UseVisualStyleBackColor = false;
            this.btnLichSuBaoCao.Click += new System.EventHandler(this.btnLichSuBaoCao_Click);
            // 
            // ucNguyenVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.btnLichSuBaoCao);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateNgay);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cBNguyenLieu);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cBDanhMuc);
            this.Controls.Add(this.dgvBaoCao);
            this.Name = "ucNguyenVatLieu";
            this.Size = new System.Drawing.Size(1351, 799);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.Button btnLichSuBaoCao;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cBNguyenLieu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cBDanhMuc;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi;
    }
}
