﻿namespace PBL3_CofffeeShop.GUI
{
    partial class ucThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.cTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.cBSapXep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBDanhMuc1 = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(449, 152);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 28);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThucDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThucDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThucDon.ColumnHeadersHeight = 30;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenMon,
            this.cDanhMuc,
            this.cGiaBan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThucDon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThucDon.EnableHeadersVisualStyles = false;
            this.dgvThucDon.Location = new System.Drawing.Point(293, 208);
            this.dgvThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 30;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(635, 542);
            this.dgvThucDon.TabIndex = 62;
            // 
            // cTenMon
            // 
            this.cTenMon.HeaderText = "Tên món";
            this.cTenMon.MinimumWidth = 6;
            this.cTenMon.Name = "cTenMon";
            this.cTenMon.Width = 215;
            // 
            // cDanhMuc
            // 
            this.cDanhMuc.HeaderText = "Danh mục";
            this.cDanhMuc.MinimumWidth = 6;
            this.cDanhMuc.Name = "cDanhMuc";
            this.cDanhMuc.Width = 140;
            // 
            // cGiaBan
            // 
            this.cGiaBan.HeaderText = "Giá bán";
            this.cGiaBan.MinimumWidth = 6;
            this.cGiaBan.Name = "cGiaBan";
            this.cGiaBan.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "Sắp xếp theo";
            // 
            // cBSapXep
            // 
            this.cBSapXep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSapXep.FormattingEnabled = true;
            this.cBSapXep.Location = new System.Drawing.Point(412, 152);
            this.cBSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSapXep.Name = "cBSapXep";
            this.cBSapXep.Size = new System.Drawing.Size(210, 28);
            this.cBSapXep.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Danh mục";
            // 
            // cBDanhMuc1
            // 
            this.cBDanhMuc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBDanhMuc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDanhMuc1.FormattingEnabled = true;
            this.cBDanhMuc1.Location = new System.Drawing.Point(412, 101);
            this.cBDanhMuc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBDanhMuc1.Name = "cBDanhMuc1";
            this.cBDanhMuc1.Size = new System.Drawing.Size(210, 28);
            this.cBDanhMuc1.TabIndex = 72;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(686, 97);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 30);
            this.txtTimKiem.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 38);
            this.label14.TabIndex = 101;
            this.label14.Text = "Thực đơn";
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
            this.btnLoc.Location = new System.Drawing.Point(828, 149);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(101, 32);
            this.btnLoc.TabIndex = 83;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PBL3_CofffeeShop.Properties.Resources.TimKiemEnd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(897, 97);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PBL3_CofffeeShop.Properties.Resources.TimKiem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(655, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.White;
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThemMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemMon.Image = global::PBL3_CofffeeShop.Properties.Resources.Add;
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMon.Location = new System.Drawing.Point(968, 205);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(144, 39);
            this.btnThemMon.TabIndex = 11;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Image = global::PBL3_CofffeeShop.Properties.Resources.Cancel;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(968, 328);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 39);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa món";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Orange;
            this.btnSua.Image = global::PBL3_CofffeeShop.Properties.Resources.Edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(968, 268);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 39);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa món";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ucThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBSapXep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBDanhMuc1);
            this.Controls.Add(this.dgvThucDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucThucDon";
            this.Size = new System.Drawing.Size(1351, 799);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGiaBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBSapXep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBDanhMuc1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label14;
    }
}
