namespace GUI
{
    partial class frmWareHouse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtWHInfoID = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtWareHouseName = new System.Windows.Forms.TextBox();
            this.txtWareHouseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvWareHouse = new System.Windows.Forms.DataGridView();
            this.clWarehID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWarehName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWareAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvWHInfo = new System.Windows.Forms.DataGridView();
            this.clWareHInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWareHID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWareHouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExWord = new System.Windows.Forms.Button();
            this.btnSearchWD = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateWareHouse = new System.Windows.Forms.Button();
            this.btnDeleteWHInfo = new System.Windows.Forms.Button();
            this.btnDelelteWareHouse = new System.Windows.Forms.Button();
            this.btnUpdateWHInfo = new System.Windows.Forms.Button();
            this.btnAddWHInfo = new System.Windows.Forms.Button();
            this.btnAddWareHouse = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblw = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareHouse)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWHInfo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.cboProductName);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtWHInfoID);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtWareHouseName);
            this.groupBox1.Controls.Add(this.txtWareHouseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(339, 146);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(27, 26);
            this.txtProductID.TabIndex = 7;
            this.txtProductID.Visible = false;
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(452, 72);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(217, 28);
            this.cboProductName.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(452, 109);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 26);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "0";
            // 
            // txtWHInfoID
            // 
            this.txtWHInfoID.Location = new System.Drawing.Point(452, 38);
            this.txtWHInfoID.Name = "txtWHInfoID";
            this.txtWHInfoID.Size = new System.Drawing.Size(217, 26);
            this.txtWHInfoID.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(514, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 48);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 109);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 80);
            this.txtAddress.TabIndex = 1;
            // 
            // txtWareHouseName
            // 
            this.txtWareHouseName.Location = new System.Drawing.Point(84, 74);
            this.txtWareHouseName.Name = "txtWareHouseName";
            this.txtWareHouseName.Size = new System.Drawing.Size(217, 26);
            this.txtWareHouseName.TabIndex = 1;
            // 
            // txtWareHouseID
            // 
            this.txtWareHouseID.Location = new System.Drawing.Point(84, 35);
            this.txtWareHouseID.Name = "txtWareHouseID";
            this.txtWareHouseID.Size = new System.Drawing.Size(217, 26);
            this.txtWareHouseID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã chi tiết kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dgvWareHouse);
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 509);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách kho hàng";
            // 
            // dgvWareHouse
            // 
            this.dgvWareHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWareHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWareHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWarehID,
            this.clWarehName,
            this.clWareAddress});
            this.dgvWareHouse.Location = new System.Drawing.Point(7, 26);
            this.dgvWareHouse.Name = "dgvWareHouse";
            this.dgvWareHouse.RowHeadersWidth = 62;
            this.dgvWareHouse.RowTemplate.Height = 28;
            this.dgvWareHouse.Size = new System.Drawing.Size(435, 477);
            this.dgvWareHouse.TabIndex = 0;
            this.dgvWareHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWareHouse_CellClick);
            // 
            // clWarehID
            // 
            this.clWarehID.DataPropertyName = "MaKho";
            this.clWarehID.HeaderText = "Mã kho";
            this.clWarehID.MinimumWidth = 8;
            this.clWarehID.Name = "clWarehID";
            this.clWarehID.Width = 150;
            // 
            // clWarehName
            // 
            this.clWarehName.DataPropertyName = "TenKho";
            this.clWarehName.HeaderText = "Tên kho";
            this.clWarehName.MinimumWidth = 8;
            this.clWarehName.Name = "clWarehName";
            this.clWarehName.Width = 200;
            // 
            // clWareAddress
            // 
            this.clWareAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clWareAddress.DataPropertyName = "DiaChi";
            this.clWareAddress.HeaderText = "Địa chỉ";
            this.clWareAddress.MinimumWidth = 8;
            this.clWareAddress.Name = "clWareAddress";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dgvWHInfo);
            this.groupBox3.Location = new System.Drawing.Point(471, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1038, 509);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chi tiết kho";
            // 
            // dgvWHInfo
            // 
            this.dgvWHInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWHInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWHInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWareHInfo,
            this.clWareHID2,
            this.clProductName,
            this.clProdID,
            this.clAmount,
            this.clWareHouseName,
            this.clAddress});
            this.dgvWHInfo.Location = new System.Drawing.Point(9, 22);
            this.dgvWHInfo.Name = "dgvWHInfo";
            this.dgvWHInfo.RowHeadersWidth = 62;
            this.dgvWHInfo.RowTemplate.Height = 28;
            this.dgvWHInfo.Size = new System.Drawing.Size(1026, 481);
            this.dgvWHInfo.TabIndex = 0;
            this.dgvWHInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWHInfo_CellClick);
            // 
            // clWareHInfo
            // 
            this.clWareHInfo.DataPropertyName = "MaCT_Kho";
            this.clWareHInfo.HeaderText = "Mã chi tiết kho";
            this.clWareHInfo.MinimumWidth = 8;
            this.clWareHInfo.Name = "clWareHInfo";
            this.clWareHInfo.Width = 150;
            // 
            // clWareHID2
            // 
            this.clWareHID2.DataPropertyName = "MaKho";
            this.clWareHID2.HeaderText = "Mã kho";
            this.clWareHID2.MinimumWidth = 8;
            this.clWareHID2.Name = "clWareHID2";
            this.clWareHID2.Width = 120;
            // 
            // clProductName
            // 
            this.clProductName.DataPropertyName = "TenSP";
            this.clProductName.HeaderText = "Tên sản phẩm";
            this.clProductName.MinimumWidth = 8;
            this.clProductName.Name = "clProductName";
            this.clProductName.Width = 150;
            // 
            // clProdID
            // 
            this.clProdID.DataPropertyName = "MaSP";
            this.clProdID.HeaderText = "Mã sản phẩm";
            this.clProdID.MinimumWidth = 8;
            this.clProdID.Name = "clProdID";
            this.clProdID.Visible = false;
            this.clProdID.Width = 150;
            // 
            // clAmount
            // 
            this.clAmount.DataPropertyName = "SoLuong";
            this.clAmount.HeaderText = "Số lượng";
            this.clAmount.MinimumWidth = 8;
            this.clAmount.Name = "clAmount";
            this.clAmount.Width = 150;
            // 
            // clWareHouseName
            // 
            this.clWareHouseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clWareHouseName.DataPropertyName = "TenKho";
            this.clWareHouseName.HeaderText = "Tên Kho";
            this.clWareHouseName.MinimumWidth = 8;
            this.clWareHouseName.Name = "clWareHouseName";
            this.clWareHouseName.Visible = false;
            // 
            // clAddress
            // 
            this.clAddress.DataPropertyName = "DiaChi";
            this.clAddress.HeaderText = "Địa chỉ";
            this.clAddress.MinimumWidth = 8;
            this.clAddress.Name = "clAddress";
            this.clAddress.Visible = false;
            this.clAddress.Width = 150;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1091, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExWord);
            this.groupBox4.Controls.Add(this.btnSearchWD);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnUpdateWareHouse);
            this.groupBox4.Controls.Add(this.btnDeleteWHInfo);
            this.groupBox4.Controls.Add(this.btnDelelteWareHouse);
            this.groupBox4.Controls.Add(this.btnUpdateWHInfo);
            this.groupBox4.Controls.Add(this.btnAddWHInfo);
            this.groupBox4.Controls.Add(this.btnAddWareHouse);
            this.groupBox4.Location = new System.Drawing.Point(748, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(758, 223);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác kho/chi tiết kho";
            // 
            // btnExWord
            // 
            this.btnExWord.Location = new System.Drawing.Point(295, 159);
            this.btnExWord.Name = "btnExWord";
            this.btnExWord.Size = new System.Drawing.Size(159, 47);
            this.btnExWord.TabIndex = 14;
            this.btnExWord.Text = "Xuất Word";
            this.btnExWord.UseVisualStyleBackColor = true;
            this.btnExWord.Click += new System.EventHandler(this.btnExWord_Click_1);
            // 
            // btnSearchWD
            // 
            this.btnSearchWD.Location = new System.Drawing.Point(574, 100);
            this.btnSearchWD.Name = "btnSearchWD";
            this.btnSearchWD.Size = new System.Drawing.Size(159, 50);
            this.btnSearchWD.TabIndex = 13;
            this.btnSearchWD.Text = "Tìm CTKho";
            this.btnSearchWD.UseVisualStyleBackColor = true;
            this.btnSearchWD.Click += new System.EventHandler(this.btnSearchWD_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 50);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kho";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdateWareHouse
            // 
            this.btnUpdateWareHouse.Location = new System.Drawing.Point(190, 23);
            this.btnUpdateWareHouse.Name = "btnUpdateWareHouse";
            this.btnUpdateWareHouse.Size = new System.Drawing.Size(159, 50);
            this.btnUpdateWareHouse.TabIndex = 9;
            this.btnUpdateWareHouse.Text = "Cập nhật kho";
            this.btnUpdateWareHouse.UseVisualStyleBackColor = true;
            this.btnUpdateWareHouse.Click += new System.EventHandler(this.btnUpdateWareHouse_Click);
            // 
            // btnDeleteWHInfo
            // 
            this.btnDeleteWHInfo.Location = new System.Drawing.Point(378, 97);
            this.btnDeleteWHInfo.Name = "btnDeleteWHInfo";
            this.btnDeleteWHInfo.Size = new System.Drawing.Size(159, 50);
            this.btnDeleteWHInfo.TabIndex = 10;
            this.btnDeleteWHInfo.Text = "Xóa CTkho";
            this.btnDeleteWHInfo.UseVisualStyleBackColor = true;
            this.btnDeleteWHInfo.Click += new System.EventHandler(this.btnDeleteWHInfo_Click);
            // 
            // btnDelelteWareHouse
            // 
            this.btnDelelteWareHouse.Location = new System.Drawing.Point(378, 23);
            this.btnDelelteWareHouse.Name = "btnDelelteWareHouse";
            this.btnDelelteWareHouse.Size = new System.Drawing.Size(159, 50);
            this.btnDelelteWareHouse.TabIndex = 11;
            this.btnDelelteWareHouse.Text = "Xóa kho";
            this.btnDelelteWareHouse.UseVisualStyleBackColor = true;
            this.btnDelelteWareHouse.Click += new System.EventHandler(this.btnDelelteWareHouse_Click);
            // 
            // btnUpdateWHInfo
            // 
            this.btnUpdateWHInfo.Location = new System.Drawing.Point(190, 94);
            this.btnUpdateWHInfo.Name = "btnUpdateWHInfo";
            this.btnUpdateWHInfo.Size = new System.Drawing.Size(159, 50);
            this.btnUpdateWHInfo.TabIndex = 12;
            this.btnUpdateWHInfo.Text = "Cập nhật CTkho";
            this.btnUpdateWHInfo.UseVisualStyleBackColor = true;
            this.btnUpdateWHInfo.Click += new System.EventHandler(this.btnUpdateWHInfo_Click);
            // 
            // btnAddWHInfo
            // 
            this.btnAddWHInfo.Location = new System.Drawing.Point(6, 94);
            this.btnAddWHInfo.Name = "btnAddWHInfo";
            this.btnAddWHInfo.Size = new System.Drawing.Size(156, 50);
            this.btnAddWHInfo.TabIndex = 7;
            this.btnAddWHInfo.Text = "Thêm CTkho mới";
            this.btnAddWHInfo.UseVisualStyleBackColor = true;
            this.btnAddWHInfo.Click += new System.EventHandler(this.btnAddWHInfo_Click_1);
            // 
            // btnAddWareHouse
            // 
            this.btnAddWareHouse.Location = new System.Drawing.Point(6, 23);
            this.btnAddWareHouse.Name = "btnAddWareHouse";
            this.btnAddWareHouse.Size = new System.Drawing.Size(156, 50);
            this.btnAddWareHouse.TabIndex = 6;
            this.btnAddWareHouse.Text = "Thêm kho mới";
            this.btnAddWareHouse.UseVisualStyleBackColor = true;
            this.btnAddWareHouse.Click += new System.EventHandler(this.btnAddWareHouse_Click_1);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(1303, 241);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(200, 26);
            this.txtWord.TabIndex = 14;
            // 
            // lblw
            // 
            this.lblw.AutoSize = true;
            this.lblw.Location = new System.Drawing.Point(1153, 247);
            this.lblw.Name = "lblw";
            this.lblw.Size = new System.Drawing.Size(132, 20);
            this.lblw.TabIndex = 15;
            this.lblw.Text = "Từ khóa tìm kiếm:";
            // 
            // frmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 792);
            this.Controls.Add(this.lblw);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWareHouse";
            this.Text = "Quản lý kho hàng";
            this.Load += new System.EventHandler(this.frmWareHouse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareHouse)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWHInfo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtWHInfoID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtWareHouseName;
        private System.Windows.Forms.TextBox txtWareHouseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvWareHouse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvWHInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWarehID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWarehName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWareAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWareHInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWareHID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWareHouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddress;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateWareHouse;
        private System.Windows.Forms.Button btnDeleteWHInfo;
        private System.Windows.Forms.Button btnDelelteWareHouse;
        private System.Windows.Forms.Button btnUpdateWHInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddWHInfo;
        private System.Windows.Forms.Button btnAddWareHouse;
        private System.Windows.Forms.Button btnSearchWD;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblw;
        private System.Windows.Forms.Button btnExWord;
    }
}