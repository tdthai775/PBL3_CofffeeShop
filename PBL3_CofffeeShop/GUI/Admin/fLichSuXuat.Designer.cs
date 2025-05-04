namespace PBL3_CofffeeShop.GUI
{
    partial class fLichSuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLichSuXuat));
            this.label15 = new System.Windows.Forms.Label();
            this.cBNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cBDanhMuc = new System.Windows.Forms.ComboBox();
            this.dgvXuatHuy = new System.Windows.Forms.DataGridView();
            this.cMaNL3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNguyenLieu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDotNhap3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatHuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 119;
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
            this.cBNguyenLieu.TabIndex = 120;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 117;
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
            this.cBDanhMuc.TabIndex = 118;
            // 
            // dgvXuatHuy
            // 
            this.dgvXuatHuy.BackgroundColor = System.Drawing.Color.White;
            this.dgvXuatHuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvXuatHuy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXuatHuy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXuatHuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXuatHuy.ColumnHeadersHeight = 30;
            this.dgvXuatHuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNL3,
            this.cTenNguyenLieu3,
            this.cSoLuong3,
            this.cDonVi3,
            this.cDotNhap3,
            this.cLyDo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXuatHuy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXuatHuy.EnableHeadersVisualStyles = false;
            this.dgvXuatHuy.Location = new System.Drawing.Point(0, 128);
            this.dgvXuatHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXuatHuy.Name = "dgvXuatHuy";
            this.dgvXuatHuy.RowHeadersVisible = false;
            this.dgvXuatHuy.RowHeadersWidth = 51;
            this.dgvXuatHuy.RowTemplate.Height = 30;
            this.dgvXuatHuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXuatHuy.Size = new System.Drawing.Size(1041, 442);
            this.dgvXuatHuy.TabIndex = 130;
            // 
            // cMaNL3
            // 
            this.cMaNL3.HeaderText = "Mã NL";
            this.cMaNL3.MinimumWidth = 6;
            this.cMaNL3.Name = "cMaNL3";
            this.cMaNL3.Width = 125;
            // 
            // cTenNguyenLieu3
            // 
            this.cTenNguyenLieu3.HeaderText = "Tên nguyên liệu";
            this.cTenNguyenLieu3.MinimumWidth = 6;
            this.cTenNguyenLieu3.Name = "cTenNguyenLieu3";
            this.cTenNguyenLieu3.Width = 240;
            // 
            // cSoLuong3
            // 
            this.cSoLuong3.HeaderText = "Số lượng";
            this.cSoLuong3.MinimumWidth = 6;
            this.cSoLuong3.Name = "cSoLuong3";
            this.cSoLuong3.Width = 80;
            // 
            // cDonVi3
            // 
            this.cDonVi3.HeaderText = "Đơn vị";
            this.cDonVi3.MinimumWidth = 6;
            this.cDonVi3.Name = "cDonVi3";
            this.cDonVi3.Width = 80;
            // 
            // cDotNhap3
            // 
            this.cDotNhap3.HeaderText = "Đợt nhập";
            this.cDotNhap3.MinimumWidth = 6;
            this.cDotNhap3.Name = "cDotNhap3";
            this.cDotNhap3.Width = 130;
            // 
            // cLyDo
            // 
            this.cLyDo.HeaderText = "Lý do chi tiết";
            this.cLyDo.MinimumWidth = 6;
            this.cLyDo.Name = "cLyDo";
            this.cLyDo.Width = 125;
            // 
            // fLichSuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 570);
            this.Controls.Add(this.dgvXuatHuy);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cBNguyenLieu);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cBDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLichSuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử xuất hủy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatHuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cBNguyenLieu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cBDanhMuc;
        private System.Windows.Forms.DataGridView dgvXuatHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNL3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguyenLieu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDotNhap3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLyDo;
    }
}