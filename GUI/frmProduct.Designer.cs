namespace GUI
{
    partial class frmProduct
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.clProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProducer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSerach = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProductID,
            this.clProductName,
            this.clUnit,
            this.clCategory,
            this.clProducer,
            this.clDescription});
            this.dgvProduct.Location = new System.Drawing.Point(13, 324);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(1275, 341);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // clProductID
            // 
            this.clProductID.DataPropertyName = "MaSP";
            this.clProductID.HeaderText = "Mã sản phẩm";
            this.clProductID.MinimumWidth = 8;
            this.clProductID.Name = "clProductID";
            this.clProductID.Width = 150;
            // 
            // clProductName
            // 
            this.clProductName.DataPropertyName = "TenSP";
            this.clProductName.HeaderText = "Tên sản phẩm";
            this.clProductName.MinimumWidth = 8;
            this.clProductName.Name = "clProductName";
            this.clProductName.Width = 180;
            // 
            // clUnit
            // 
            this.clUnit.DataPropertyName = "TenDVT";
            this.clUnit.HeaderText = "Đơn vị tính";
            this.clUnit.MinimumWidth = 8;
            this.clUnit.Name = "clUnit";
            this.clUnit.Width = 150;
            // 
            // clCategory
            // 
            this.clCategory.DataPropertyName = "TenDM";
            this.clCategory.HeaderText = "Danh mục";
            this.clCategory.MinimumWidth = 8;
            this.clCategory.Name = "clCategory";
            this.clCategory.Width = 150;
            // 
            // clProducer
            // 
            this.clProducer.DataPropertyName = "NhaSX";
            this.clProducer.HeaderText = "Nhà sản xuất";
            this.clProducer.MinimumWidth = 8;
            this.clProducer.Name = "clProducer";
            this.clProducer.Width = 200;
            // 
            // clDescription
            // 
            this.clDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDescription.DataPropertyName = "ThongSoDacTa";
            this.clDescription.HeaderText = "Thông số đặc tả";
            this.clDescription.MinimumWidth = 8;
            this.clDescription.Name = "clDescription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thông số đặc tả";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(149, 30);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(243, 26);
            this.txtProductID.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(149, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(243, 26);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(604, 27);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(243, 26);
            this.txtProducer.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(604, 73);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(243, 111);
            this.txtDescription.TabIndex = 2;
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(149, 115);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(243, 28);
            this.cboUnit.TabIndex = 3;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(147, 156);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(243, 28);
            this.cboCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(227, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 45);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(395, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(568, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(921, 230);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(108, 45);
            this.btnSerach.TabIndex = 4;
            this.btnSerach.Text = "Tìm kiếm";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(727, 239);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(169, 26);
            this.txtWord.TabIndex = 5;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 677);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.TextBox txtWord;
    }
}