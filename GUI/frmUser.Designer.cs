namespace GUI
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.clUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPermission = new System.Windows.Forms.ComboBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.txbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.txtWord = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUserID,
            this.clName,
            this.clPhone,
            this.clEmail,
            this.clUserName,
            this.clPassWord,
            this.clPermission});
            this.dgvUser.Location = new System.Drawing.Point(6, 25);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 28;
            this.dgvUser.Size = new System.Drawing.Size(1135, 336);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // clUserID
            // 
            this.clUserID.DataPropertyName = "MaND";
            this.clUserID.HeaderText = "Mã người dùng";
            this.clUserID.MinimumWidth = 8;
            this.clUserID.Name = "clUserID";
            this.clUserID.Width = 110;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "TenND";
            this.clName.HeaderText = "Tên người dùng";
            this.clName.MinimumWidth = 8;
            this.clName.Name = "clName";
            this.clName.Width = 150;
            // 
            // clPhone
            // 
            this.clPhone.DataPropertyName = "SODT";
            this.clPhone.HeaderText = "Số điện thoại";
            this.clPhone.MinimumWidth = 8;
            this.clPhone.Name = "clPhone";
            this.clPhone.Width = 150;
            // 
            // clEmail
            // 
            this.clEmail.DataPropertyName = "Email";
            this.clEmail.HeaderText = "Email";
            this.clEmail.MinimumWidth = 8;
            this.clEmail.Name = "clEmail";
            this.clEmail.Width = 150;
            // 
            // clUserName
            // 
            this.clUserName.DataPropertyName = "TaiKhoan";
            this.clUserName.HeaderText = "Tài khoản";
            this.clUserName.MinimumWidth = 8;
            this.clUserName.Name = "clUserName";
            this.clUserName.Width = 150;
            // 
            // clPassWord
            // 
            this.clPassWord.DataPropertyName = "MatKhau";
            this.clPassWord.HeaderText = "Mật khẩu";
            this.clPassWord.MinimumWidth = 8;
            this.clPassWord.Name = "clPassWord";
            this.clPassWord.Width = 150;
            // 
            // clPermission
            // 
            this.clPermission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPermission.DataPropertyName = "TrangThai";
            this.clPermission.HeaderText = "Trạng thái";
            this.clPermission.MinimumWidth = 8;
            this.clPermission.Name = "clPermission";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người dùng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cboPermission);
            this.groupBox2.Controls.Add(this.txtPassWord);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtUserID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1147, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người dùng";
            // 
            // cboPermission
            // 
            this.cboPermission.FormattingEnabled = true;
            this.cboPermission.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cboPermission.Location = new System.Drawing.Point(897, 81);
            this.cboPermission.Name = "cboPermission";
            this.cboPermission.Size = new System.Drawing.Size(217, 28);
            this.cboPermission.TabIndex = 2;
            this.cboPermission.SelectedIndexChanged += new System.EventHandler(this.cboPermission_SelectedIndexChanged);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(604, 128);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(217, 26);
            this.txtPassWord.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(604, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(217, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(604, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(183, 131);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 26);
            this.txtPhone.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(183, 40);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(217, 26);
            this.txtUserID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(968, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên người dùng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người dùng:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbUpdate,
            this.tsbDelete,
            this.txtWord,
            this.txbSearch,
            this.tsbReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1171, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(183, 29);
            this.tsbAdd.Text = "Thêm người dùng";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(210, 29);
            this.tsbUpdate.Text = "Cập nhật người dùng";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(170, 29);
            this.tsbDelete.Text = "Xóa người dùng";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Image = ((System.Drawing.Image)(resources.GetObject("txbSearch.Image")));
            this.txbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(112, 29);
            this.txbSearch.Text = "Tìm kiếm";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            // 
            // tsbReset
            // 
            this.tsbReset.Image = ((System.Drawing.Image)(resources.GetObject("tsbReset.Image")));
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(109, 29);
            this.tsbReset.Text = "Làm mới";
            this.tsbReset.Click += new System.EventHandler(this.tsbReset_Click);
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 34);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 632);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton txbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPermission;
        private System.Windows.Forms.ComboBox cboPermission;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.ToolStripTextBox txtWord;
    }
}