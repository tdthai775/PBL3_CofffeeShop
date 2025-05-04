namespace PBL3_CofffeeShop.GUI
{
    partial class ucDonHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDonHang));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "2510271804",
            "10:27"}, 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "0510241804",
            "10:24"}, 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "1710181804",
            "10:18"}, 1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageTrangThai = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkTrangThai = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listDonHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvChiTietDon = new System.Windows.Forms.DataGridView();
            this.cTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cXong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLichSuDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).BeginInit();
            this.SuspendLayout();
            // 
            // imageTrangThai
            // 
            this.imageTrangThai.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTrangThai.ImageStream")));
            this.imageTrangThai.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTrangThai.Images.SetKeyName(0, "ChuaHoanThanh.png");
            this.imageTrangThai.Images.SetKeyName(1, "DaHoanThanh.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Đã hoàn thành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Chưa hoàn thành";
            // 
            // checkTrangThai
            // 
            this.checkTrangThai.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkTrangThai.AutoSize = true;
            this.checkTrangThai.BackColor = System.Drawing.Color.White;
            this.checkTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTrangThai.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.checkTrangThai.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.checkTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTrangThai.Location = new System.Drawing.Point(402, 560);
            this.checkTrangThai.Name = "checkTrangThai";
            this.checkTrangThai.Size = new System.Drawing.Size(150, 30);
            this.checkTrangThai.TabIndex = 24;
            this.checkTrangThai.Text = "Chuyển trạng thái";
            this.checkTrangThai.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Đơn hiện có";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Chi tiết đơn";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PBL3_CofffeeShop.Properties.Resources.ChuaHoanThanh;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(119, 592);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL3_CofffeeShop.Properties.Resources.DaHoanThanh;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(119, 560);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // listDonHang
            // 
            this.listDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDonHang.FullRowSelect = true;
            this.listDonHang.HideSelection = false;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 1;
            listViewItem4.Tag = "Chưa hoàn thành";
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 1;
            listViewItem5.Tag = "Chưa hoàn thành";
            listViewItem6.StateImageIndex = 0;
            listViewItem6.Tag = "Đã hoàn thành";
            this.listDonHang.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listDonHang.Location = new System.Drawing.Point(119, 205);
            this.listDonHang.Name = "listDonHang";
            this.listDonHang.Size = new System.Drawing.Size(456, 339);
            this.listDonHang.SmallImageList = this.imageTrangThai;
            this.listDonHang.TabIndex = 27;
            this.listDonHang.UseCompatibleStateImageBehavior = false;
            this.listDonHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trạng thái";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã đơn";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 115;
            // 
            // dgvChiTietDon
            // 
            this.dgvChiTietDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietDon.ColumnHeadersHeight = 30;
            this.dgvChiTietDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenMon,
            this.cSoLuong,
            this.cXong});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietDon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietDon.EnableHeadersVisualStyles = false;
            this.dgvChiTietDon.Location = new System.Drawing.Point(641, 205);
            this.dgvChiTietDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietDon.Name = "dgvChiTietDon";
            this.dgvChiTietDon.RowHeadersVisible = false;
            this.dgvChiTietDon.RowHeadersWidth = 51;
            this.dgvChiTietDon.RowTemplate.Height = 30;
            this.dgvChiTietDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDon.Size = new System.Drawing.Size(474, 451);
            this.dgvChiTietDon.TabIndex = 64;
            // 
            // cTenMon
            // 
            this.cTenMon.HeaderText = "Tên món";
            this.cTenMon.MinimumWidth = 6;
            this.cTenMon.Name = "cTenMon";
            this.cTenMon.Width = 215;
            // 
            // cSoLuong
            // 
            this.cSoLuong.HeaderText = "Số lượng";
            this.cSoLuong.MinimumWidth = 6;
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.Width = 80;
            // 
            // cXong
            // 
            this.cXong.HeaderText = "Xong";
            this.cXong.MinimumWidth = 6;
            this.cXong.Name = "cXong";
            this.cXong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cXong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cXong.Width = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 38);
            this.label14.TabIndex = 103;
            this.label14.Text = "Đơn hàng";
            // 
            // btnLichSuDon
            // 
            this.btnLichSuDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(193)))), ((int)(((byte)(248)))));
            this.btnLichSuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLichSuDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSuDon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLichSuDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLichSuDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnLichSuDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuDon.Image = global::PBL3_CofffeeShop.Properties.Resources.LichSu;
            this.btnLichSuDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSuDon.Location = new System.Drawing.Point(373, 617);
            this.btnLichSuDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuDon.Name = "btnLichSuDon";
            this.btnLichSuDon.Size = new System.Drawing.Size(202, 39);
            this.btnLichSuDon.TabIndex = 104;
            this.btnLichSuDon.Text = "Lịch sử đơn hàng";
            this.btnLichSuDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuDon.UseVisualStyleBackColor = false;
            this.btnLichSuDon.Click += new System.EventHandler(this.btnLichSuDon_Click);
            // 
            // ucDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLichSuDon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvChiTietDon);
            this.Controls.Add(this.listDonHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkTrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucDonHang";
            this.Size = new System.Drawing.Size(1338, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageTrangThai;
        private System.Windows.Forms.CheckBox checkTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listDonHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridView dgvChiTietDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cXong;
        private System.Windows.Forms.Button btnLichSuDon;
    }
}
