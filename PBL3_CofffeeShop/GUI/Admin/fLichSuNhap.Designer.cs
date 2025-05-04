namespace PBL3_CofffeeShop.GUI
{
    partial class fLichSuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLichSuNhap));
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.cMaNL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNguyenLieu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDotNhap2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dateDotNhap = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cBNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cBDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhapKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhapKho.ColumnHeadersHeight = 30;
            this.dgvNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNL2,
            this.cTenNguyenLieu2,
            this.cSoLuong2,
            this.cDonVi2,
            this.cGiaNhap,
            this.cDotNhap2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhapKho.EnableHeadersVisualStyles = false;
            this.dgvNhapKho.Location = new System.Drawing.Point(0, 128);
            this.dgvNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.RowHeadersVisible = false;
            this.dgvNhapKho.RowHeadersWidth = 51;
            this.dgvNhapKho.RowTemplate.Height = 30;
            this.dgvNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapKho.Size = new System.Drawing.Size(1041, 444);
            this.dgvNhapKho.TabIndex = 85;
            // 
            // cMaNL2
            // 
            this.cMaNL2.HeaderText = "Mã NL";
            this.cMaNL2.MinimumWidth = 6;
            this.cMaNL2.Name = "cMaNL2";
            this.cMaNL2.Width = 125;
            // 
            // cTenNguyenLieu2
            // 
            this.cTenNguyenLieu2.HeaderText = "Tên nguyên liệu";
            this.cTenNguyenLieu2.MinimumWidth = 6;
            this.cTenNguyenLieu2.Name = "cTenNguyenLieu2";
            this.cTenNguyenLieu2.Width = 240;
            // 
            // cSoLuong2
            // 
            this.cSoLuong2.HeaderText = "Số lượng";
            this.cSoLuong2.MinimumWidth = 6;
            this.cSoLuong2.Name = "cSoLuong2";
            this.cSoLuong2.Width = 80;
            // 
            // cDonVi2
            // 
            this.cDonVi2.HeaderText = "Đơn vị";
            this.cDonVi2.MinimumWidth = 6;
            this.cDonVi2.Name = "cDonVi2";
            this.cDonVi2.Width = 80;
            // 
            // cGiaNhap
            // 
            this.cGiaNhap.HeaderText = "Giá nhập";
            this.cGiaNhap.MinimumWidth = 6;
            this.cGiaNhap.Name = "cGiaNhap";
            this.cGiaNhap.Width = 130;
            // 
            // cDotNhap2
            // 
            this.cDotNhap2.HeaderText = "Đợt nhập";
            this.cDotNhap2.MinimumWidth = 6;
            this.cDotNhap2.Name = "cDotNhap2";
            this.cDotNhap2.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 114;
            this.label10.Text = "Đợt nhập";
            // 
            // dateDotNhap
            // 
            this.dateDotNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDotNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDotNhap.Location = new System.Drawing.Point(525, 31);
            this.dateDotNhap.Name = "dateDotNhap";
            this.dateDotNhap.Size = new System.Drawing.Size(132, 27);
            this.dateDotNhap.TabIndex = 112;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 110;
            this.label15.Text = "Nguyên liệu";
            // 
            // cBNguyenLieu
            // 
            this.cBNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBNguyenLieu.FormattingEnabled = true;
            this.cBNguyenLieu.Location = new System.Drawing.Point(150, 78);
            this.cBNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBNguyenLieu.Name = "cBNguyenLieu";
            this.cBNguyenLieu.Size = new System.Drawing.Size(210, 28);
            this.cBNguyenLieu.TabIndex = 111;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 108;
            this.label19.Text = "Danh mục";
            // 
            // cBDanhMuc
            // 
            this.cBDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDanhMuc.FormattingEnabled = true;
            this.cBDanhMuc.Location = new System.Drawing.Point(150, 31);
            this.cBDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBDanhMuc.Name = "cBDanhMuc";
            this.cBDanhMuc.Size = new System.Drawing.Size(210, 28);
            this.cBDanhMuc.TabIndex = 109;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::PBL3_CofffeeShop.Properties.Resources.Filter;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.Location = new System.Drawing.Point(556, 74);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(101, 32);
            this.btnLoc.TabIndex = 115;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // fLichSuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 570);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateDotNhap);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cBNguyenLieu);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cBDanhMuc);
            this.Controls.Add(this.dgvNhapKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLichSuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguyenLieu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDotNhap2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDotNhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cBNguyenLieu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cBDanhMuc;
        private System.Windows.Forms.Button btnLoc;
    }
}