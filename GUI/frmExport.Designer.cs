namespace GUI
{
    partial class frmExport
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
            this.dgvExport = new System.Windows.Forms.DataGridView();
            this.clExportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumberBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExportID = new System.Windows.Forms.TextBox();
            this.txtNumberBill = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnExportBill = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnSearchDetail = new System.Windows.Forms.Button();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.clExportID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEDetaildID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWareHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExport
            // 
            this.dgvExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clExportID,
            this.clCusName,
            this.clUserName,
            this.clDate,
            this.clNumberBill});
            this.dgvExport.Location = new System.Drawing.Point(508, 12);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.RowHeadersWidth = 62;
            this.dgvExport.RowTemplate.Height = 28;
            this.dgvExport.Size = new System.Drawing.Size(940, 390);
            this.dgvExport.TabIndex = 0;
            this.dgvExport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExport_CellClick);
            // 
            // clExportID
            // 
            this.clExportID.DataPropertyName = "MaHDXuat";
            this.clExportID.HeaderText = "Mã Phiếu xuất";
            this.clExportID.MinimumWidth = 8;
            this.clExportID.Name = "clExportID";
            this.clExportID.Width = 150;
            // 
            // clCusName
            // 
            this.clCusName.DataPropertyName = "TenKH";
            this.clCusName.HeaderText = "Tên khách hàng";
            this.clCusName.MinimumWidth = 8;
            this.clCusName.Name = "clCusName";
            this.clCusName.Width = 180;
            // 
            // clUserName
            // 
            this.clUserName.DataPropertyName = "TenND";
            this.clUserName.HeaderText = "Tên người dùng";
            this.clUserName.MinimumWidth = 8;
            this.clUserName.Name = "clUserName";
            this.clUserName.Width = 200;
            // 
            // clDate
            // 
            this.clDate.DataPropertyName = "NgayBan";
            this.clDate.HeaderText = "Ngày xuất kho";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày xuất";
            // 
            // txtExportID
            // 
            this.txtExportID.Location = new System.Drawing.Point(152, 25);
            this.txtExportID.Name = "txtExportID";
            this.txtExportID.Size = new System.Drawing.Size(244, 26);
            this.txtExportID.TabIndex = 3;
            // 
            // txtNumberBill
            // 
            this.txtNumberBill.Location = new System.Drawing.Point(154, 159);
            this.txtNumberBill.Name = "txtNumberBill";
            this.txtNumberBill.Size = new System.Drawing.Size(242, 26);
            this.txtNumberBill.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(152, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 26);
            this.txtName.TabIndex = 6;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(152, 60);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(244, 28);
            this.cboName.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(152, 126);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(244, 26);
            this.dtpDate.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 45);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clExportID1,
            this.clEDetaildID,
            this.clWareHouse,
            this.clProduct,
            this.clUnit,
            this.clAmount,
            this.clPrice});
            this.dgvDetail.Location = new System.Drawing.Point(504, 431);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 62;
            this.dgvDetail.RowTemplate.Height = 28;
            this.dgvDetail.Size = new System.Drawing.Size(944, 400);
            this.dgvDetail.TabIndex = 11;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(78, 579);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(166, 45);
            this.btnAddDetail.TabIndex = 10;
            this.btnAddDetail.Text = "Thêm chi tiết mới";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnExportBill
            // 
            this.btnExportBill.Location = new System.Drawing.Point(170, 666);
            this.btnExportBill.Name = "btnExportBill";
            this.btnExportBill.Size = new System.Drawing.Size(166, 45);
            this.btnExportBill.TabIndex = 12;
            this.btnExportBill.Text = "In hóa đơn";
            this.btnExportBill.UseVisualStyleBackColor = true;
            this.btnExportBill.Click += new System.EventHandler(this.btnExportBill_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(177, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 45);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(177, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 45);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(278, 579);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(166, 45);
            this.btnDeleteDetail.TabIndex = 15;
            this.btnDeleteDetail.Text = "Xóa chi tiết";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnSearchDetail
            // 
            this.btnSearchDetail.Location = new System.Drawing.Point(170, 498);
            this.btnSearchDetail.Name = "btnSearchDetail";
            this.btnSearchDetail.Size = new System.Drawing.Size(166, 45);
            this.btnSearchDetail.TabIndex = 15;
            this.btnSearchDetail.Text = "Tìm kiếm chi tiết";
            this.btnSearchDetail.UseVisualStyleBackColor = true;
            this.btnSearchDetail.Click += new System.EventHandler(this.btnSearchDetail_Click);
            // 
            // txtTextBox
            // 
            this.txtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextBox.Location = new System.Drawing.Point(141, 396);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(276, 37);
            this.txtTextBox.TabIndex = 17;
            this.txtTextBox.TextChanged += new System.EventHandler(this.txtTextBox_TextChanged);
            // 
            // clExportID1
            // 
            this.clExportID1.DataPropertyName = "MAHDXUAT";
            this.clExportID1.HeaderText = "Mã chi tiết";
            this.clExportID1.MinimumWidth = 8;
            this.clExportID1.Name = "clExportID1";
            this.clExportID1.Width = 150;
            // 
            // clEDetaildID
            // 
            this.clEDetaildID.DataPropertyName = "MACTHDXUAT";
            this.clEDetaildID.HeaderText = "Mã phiếu xuất";
            this.clEDetaildID.MinimumWidth = 8;
            this.clEDetaildID.Name = "clEDetaildID";
            this.clEDetaildID.Width = 150;
            // 
            // clWareHouse
            // 
            this.clWareHouse.DataPropertyName = "TENKHO";
            this.clWareHouse.HeaderText = "Tên kho";
            this.clWareHouse.MinimumWidth = 8;
            this.clWareHouse.Name = "clWareHouse";
            this.clWareHouse.Width = 150;
            // 
            // clProduct
            // 
            this.clProduct.DataPropertyName = "TENSP";
            this.clProduct.HeaderText = "Tên sản phẩm";
            this.clProduct.MinimumWidth = 8;
            this.clProduct.Name = "clProduct";
            this.clProduct.Width = 150;
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
            this.clAmount.DataPropertyName = "SLBAN";
            this.clAmount.HeaderText = "Số lượng";
            this.clAmount.MinimumWidth = 8;
            this.clAmount.Name = "clAmount";
            this.clAmount.Width = 150;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "GIABAN";
            this.clPrice.HeaderText = "Giá bán";
            this.clPrice.MinimumWidth = 8;
            this.clPrice.Name = "clPrice";
            this.clPrice.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Từ khóa:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 232);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 45);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 843);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.btnSearchDetail);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExportBill);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumberBill);
            this.Controls.Add(this.txtExportID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExport";
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.frmExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExportID;
        private System.Windows.Forms.TextBox txtNumberBill;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnExportBill;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clExportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumberBill;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Button btnSearchDetail;
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clExportID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEDetaildID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
    }
}