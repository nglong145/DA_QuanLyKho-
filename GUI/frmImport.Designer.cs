namespace GUI
{
    partial class frmImport
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
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.txtNumberBill = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboSuplier = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvIDetail = new System.Windows.Forms.DataGridView();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchDetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.clImportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSuplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImportID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWareHosue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPricce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImport
            // 
            this.dgvImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clImportID,
            this.clSuplier,
            this.clName,
            this.clDate,
            this.clNumberBill});
            this.dgvImport.Location = new System.Drawing.Point(419, 12);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.RowHeadersWidth = 62;
            this.dgvImport.RowTemplate.Height = 28;
            this.dgvImport.Size = new System.Drawing.Size(1158, 380);
            this.dgvImport.TabIndex = 0;
            this.dgvImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImport_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên người nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ngày nhâp";
            // 
            // txtImportID
            // 
            this.txtImportID.Location = new System.Drawing.Point(162, 18);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.Size = new System.Drawing.Size(210, 26);
            this.txtImportID.TabIndex = 11;
            // 
            // txtNumberBill
            // 
            this.txtNumberBill.Location = new System.Drawing.Point(162, 185);
            this.txtNumberBill.Name = "txtNumberBill";
            this.txtNumberBill.Size = new System.Drawing.Size(210, 26);
            this.txtNumberBill.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(162, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 26);
            this.txtName.TabIndex = 18;
            // 
            // cboSuplier
            // 
            this.cboSuplier.FormattingEnabled = true;
            this.cboSuplier.Location = new System.Drawing.Point(162, 58);
            this.cboSuplier.Name = "cboSuplier";
            this.cboSuplier.Size = new System.Drawing.Size(210, 28);
            this.cboSuplier.TabIndex = 20;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(162, 141);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(210, 26);
            this.dtpDate.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 49);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 49);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 49);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(146, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 49);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvIDetail
            // 
            this.dgvIDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clImportID1,
            this.clIDetailID,
            this.clWareHosue,
            this.clProduct,
            this.clUnit,
            this.clAmount,
            this.clPricce});
            this.dgvIDetail.Location = new System.Drawing.Point(396, 434);
            this.dgvIDetail.Name = "dgvIDetail";
            this.dgvIDetail.RowHeadersWidth = 62;
            this.dgvIDetail.RowTemplate.Height = 28;
            this.dgvIDetail.Size = new System.Drawing.Size(1181, 371);
            this.dgvIDetail.TabIndex = 30;
            this.dgvIDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIDetail_CellClick);
            // 
            // txtTextBox
            // 
            this.txtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextBox.Location = new System.Drawing.Point(139, 415);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(182, 37);
            this.txtTextBox.TabIndex = 34;
            // 
            // btnSearchDetail
            // 
            this.btnSearchDetail.Location = new System.Drawing.Point(86, 499);
            this.btnSearchDetail.Name = "btnSearchDetail";
            this.btnSearchDetail.Size = new System.Drawing.Size(166, 45);
            this.btnSearchDetail.TabIndex = 32;
            this.btnSearchDetail.Text = "Tìm kiếm chi tiết";
            this.btnSearchDetail.UseVisualStyleBackColor = true;
            this.btnSearchDetail.Click += new System.EventHandler(this.btnSearchDetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(86, 675);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(166, 45);
            this.btnDeleteDetail.TabIndex = 33;
            this.btnDeleteDetail.Text = "Xóa chi tiết";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(86, 589);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(166, 45);
            this.btnAddDetail.TabIndex = 31;
            this.btnAddDetail.Text = "Thêm chi tiết mới";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Từ khóa:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 267);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 49);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // clImportID
            // 
            this.clImportID.DataPropertyName = "MaHDNhap";
            this.clImportID.HeaderText = "Mã phiếu nhập";
            this.clImportID.MinimumWidth = 8;
            this.clImportID.Name = "clImportID";
            this.clImportID.Width = 150;
            // 
            // clSuplier
            // 
            this.clSuplier.DataPropertyName = "TenNhaCC";
            this.clSuplier.HeaderText = "Tên nhà cung cấp";
            this.clSuplier.MinimumWidth = 8;
            this.clSuplier.Name = "clSuplier";
            this.clSuplier.Width = 230;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "TenND";
            this.clName.HeaderText = "Tên người nhập";
            this.clName.MinimumWidth = 8;
            this.clName.Name = "clName";
            this.clName.Width = 180;
            // 
            // clDate
            // 
            this.clDate.DataPropertyName = "NgayNhap";
            this.clDate.HeaderText = "Ngày nhập";
            this.clDate.MinimumWidth = 8;
            this.clDate.Name = "clDate";
            this.clDate.Width = 150;
            // 
            // clNumberBill
            // 
            this.clNumberBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNumberBill.DataPropertyName = "SoHoaDon";
            this.clNumberBill.HeaderText = "Số hóa đơn";
            this.clNumberBill.MinimumWidth = 8;
            this.clNumberBill.Name = "clNumberBill";
            // 
            // clImportID1
            // 
            this.clImportID1.DataPropertyName = "MAHDNHAP";
            this.clImportID1.HeaderText = "Mã phiếu nhập";
            this.clImportID1.MinimumWidth = 8;
            this.clImportID1.Name = "clImportID1";
            this.clImportID1.Width = 150;
            // 
            // clIDetailID
            // 
            this.clIDetailID.DataPropertyName = "MaCTHDNhap";
            this.clIDetailID.HeaderText = "Mã chi tiết";
            this.clIDetailID.MinimumWidth = 8;
            this.clIDetailID.Name = "clIDetailID";
            this.clIDetailID.Width = 130;
            // 
            // clWareHosue
            // 
            this.clWareHosue.DataPropertyName = "TENKHO";
            this.clWareHosue.HeaderText = "Tên kho";
            this.clWareHosue.MinimumWidth = 8;
            this.clWareHosue.Name = "clWareHosue";
            this.clWareHosue.Width = 150;
            // 
            // clProduct
            // 
            this.clProduct.DataPropertyName = "TENSP";
            this.clProduct.HeaderText = "Tên sản phẩm";
            this.clProduct.MinimumWidth = 8;
            this.clProduct.Name = "clProduct";
            this.clProduct.Width = 250;
            // 
            // clUnit
            // 
            this.clUnit.DataPropertyName = "TENDVT";
            this.clUnit.HeaderText = "Đơn vị tính";
            this.clUnit.MinimumWidth = 8;
            this.clUnit.Name = "clUnit";
            this.clUnit.Width = 150;
            // 
            // clAmount
            // 
            this.clAmount.DataPropertyName = "SLNHAP";
            this.clAmount.HeaderText = "Số lượng";
            this.clAmount.MinimumWidth = 8;
            this.clAmount.Name = "clAmount";
            this.clAmount.Width = 150;
            // 
            // clPricce
            // 
            this.clPricce.DataPropertyName = "GIANHAP";
            this.clPricce.HeaderText = "Giá nhập";
            this.clPricce.MinimumWidth = 8;
            this.clPricce.Name = "clPricce";
            this.clPricce.Width = 150;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 817);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.btnSearchDetail);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.dgvIDetail);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboSuplier);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumberBill);
            this.Controls.Add(this.txtImportID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImportID;
        private System.Windows.Forms.TextBox txtNumberBill;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboSuplier;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvIDetail;
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Button btnSearchDetail;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSuplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImportID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWareHosue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPricce;
    }
}