namespace PBL3_CofffeeShop.GUI
{
    partial class fDetailNL
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
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblMinQuantity = new System.Windows.Forms.Label();
            this.numMinQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.numCostPrice = new System.Windows.Forms.NumericUpDown();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostPrice)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(243, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chi tiết nguyên liệu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(50, 80);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(100, 16);
            this.lblItemID.TabIndex = 1;
            this.lblItemID.Text = "Mã nguyên liệu:";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(180, 77);
            this.txtItemID.MaxLength = 10;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(150, 22);
            this.txtItemID.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(350, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên nguyên liệu:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(480, 77);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(50, 130);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(67, 16);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Danh mục:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(180, 127);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(150, 24);
            this.cboCategory.TabIndex = 6;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(50, 180);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 16);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Số lượng:";
            // 
            // numQuantity
            // 
            this.numQuantity.DecimalPlaces = 3;
            this.numQuantity.Location = new System.Drawing.Point(180, 178);
            this.numQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(150, 22);
            this.numQuantity.TabIndex = 8;
            // 
            // lblMinQuantity
            // 
            this.lblMinQuantity.AutoSize = true;
            this.lblMinQuantity.Location = new System.Drawing.Point(350, 180);
            this.lblMinQuantity.Name = "lblMinQuantity";
            this.lblMinQuantity.Size = new System.Drawing.Size(105, 16);
            this.lblMinQuantity.TabIndex = 9;
            this.lblMinQuantity.Text = "Số lượng tối thiểu:";
            // 
            // numMinQuantity
            // 
            this.numMinQuantity.DecimalPlaces = 3;
            this.numMinQuantity.Location = new System.Drawing.Point(480, 178);
            this.numMinQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinQuantity.Name = "numMinQuantity";
            this.numMinQuantity.Size = new System.Drawing.Size(200, 22);
            this.numMinQuantity.TabIndex = 10;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(350, 130);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(51, 16);
            this.lblUnit.TabIndex = 11;
            this.lblUnit.Text = "Đơn vị:";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(480, 127);
            this.txtUnit.MaxLength = 50;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(200, 22);
            this.txtUnit.TabIndex = 12;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(50, 230);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(63, 16);
            this.lblCostPrice.TabIndex = 13;
            this.lblCostPrice.Text = "Giá nhập:";
            // 
            // numCostPrice
            // 
            this.numCostPrice.Location = new System.Drawing.Point(180, 228);
            this.numCostPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCostPrice.Name = "numCostPrice";
            this.numCostPrice.Size = new System.Drawing.Size(150, 22);
            this.numCostPrice.TabIndex = 14;
            this.numCostPrice.ThousandsSeparator = true;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(350, 230);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(85, 16);
            this.lblExpirationDate.TabIndex = 15;
            this.lblExpirationDate.Text = "Hạn sử dụng:";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(480, 228);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(200, 22);
            this.dtpExpirationDate.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(475, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(585, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 403);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblItemID);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.dtpExpirationDate);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblExpirationDate);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.numCostPrice);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblCostPrice);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.txtUnit);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.numQuantity);
            this.panel1.Controls.Add(this.numMinQuantity);
            this.panel1.Controls.Add(this.lblMinQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 397);
            this.panel1.TabIndex = 0;
            // 
            // fDetailNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fDetailNL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết nguyên liệu";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostPrice)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblMinQuantity;
        private System.Windows.Forms.NumericUpDown numMinQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.NumericUpDown numCostPrice;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}