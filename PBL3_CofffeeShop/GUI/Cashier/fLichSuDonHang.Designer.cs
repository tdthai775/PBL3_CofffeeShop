﻿namespace PBL3_CofffeeShop.GUI
{
    partial class fLichSuDonHang
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "2510271804",
            "18/04/2025 10:27",
            "42.000"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "0510241804",
            "18/04/2025 10:24",
            "75.000"}, 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1710181804",
            "18/04/2025 10:18",
            "80.000"}, 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLichSuDonHang));
            this.label10 = new System.Windows.Forms.Label();
            this.dateDotNhap = new System.Windows.Forms.DateTimePicker();
            this.listDonHang = new System.Windows.Forms.ListView();
            this.cMaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cThoiGian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGiaTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "Ngày";
            // 
            // dateDotNhap
            // 
            this.dateDotNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDotNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDotNhap.Location = new System.Drawing.Point(88, 26);
            this.dateDotNhap.Name = "dateDotNhap";
            this.dateDotNhap.Size = new System.Drawing.Size(132, 27);
            this.dateDotNhap.TabIndex = 107;
            this.dateDotNhap.Value = new System.DateTime(2025, 4, 18, 7, 34, 0, 0);
            // 
            // listDonHang
            // 
            this.listDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cMaDon,
            this.cThoiGian,
            this.cGiaTri});
            this.listDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDonHang.FullRowSelect = true;
            this.listDonHang.HideSelection = false;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem1.Tag = "";
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem2.Tag = "";
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            listViewItem3.Tag = "";
            this.listDonHang.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listDonHang.Location = new System.Drawing.Point(37, 76);
            this.listDonHang.Name = "listDonHang";
            this.listDonHang.Size = new System.Drawing.Size(536, 339);
            this.listDonHang.TabIndex = 110;
            this.listDonHang.UseCompatibleStateImageBehavior = false;
            this.listDonHang.View = System.Windows.Forms.View.Details;
            // 
            // cMaDon
            // 
            this.cMaDon.Text = "Mã đơn";
            this.cMaDon.Width = 120;
            // 
            // cThoiGian
            // 
            this.cThoiGian.Text = "Thời gian";
            this.cThoiGian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cThoiGian.Width = 160;
            // 
            // cGiaTri
            // 
            this.cGiaTri.Text = "Giá trị";
            this.cGiaTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cGiaTri.Width = 120;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.btnInHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(143)))), ((int)(((byte)(95)))));
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Image = global::PBL3_CofffeeShop.Properties.Resources.In;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.Location = new System.Drawing.Point(424, 429);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(149, 60);
            this.btnInHoaDon.TabIndex = 109;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // fLichSuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 513);
            this.Controls.Add(this.listDonHang);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateDotNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLichSuDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử đơn hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDotNhap;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.ListView listDonHang;
        private System.Windows.Forms.ColumnHeader cMaDon;
        private System.Windows.Forms.ColumnHeader cThoiGian;
        private System.Windows.Forms.ColumnHeader cGiaTri;
    }
}