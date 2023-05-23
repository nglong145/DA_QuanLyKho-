namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbCustommer = new System.Windows.Forms.ToolStripButton();
            this.tsbManufacture = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPermission = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1343, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUser,
            this.tsmUnit});
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(171, 29);
            this.tsmAdmin.Text = "Chức năng Admin";
            // 
            // tsmUser
            // 
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(274, 34);
            this.tsmUser.Text = "Quản lý người dùng";
            this.tsmUser.Click += new System.EventHandler(this.tsmUser_Click);
            // 
            // tsmUnit
            // 
            this.tsmUnit.Name = "tsmUnit";
            this.tsmUnit.Size = new System.Drawing.Size(274, 34);
            this.tsmUnit.Text = "Quản lý đơn vị tính";
            this.tsmUnit.Click += new System.EventHandler(this.tsmUnit_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(109, 29);
            this.tsmLogout.Text = "Đăng xuất";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb,
            this.toolStripButton2,
            this.toolStripButton3,
            this.tsbCustommer,
            this.tsbManufacture});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1343, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb
            // 
            this.tsb.AutoSize = false;
            this.tsb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb.Image = ((System.Drawing.Image)(resources.GetObject("tsb.Image")));
            this.tsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb.Name = "tsb";
            this.tsb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsb.Size = new System.Drawing.Size(150, 50);
            this.tsb.Text = "kho hang";
            this.tsb.Click += new System.EventHandler(this.tsb_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.CheckOnClick = true;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(161, 50);
            this.toolStripButton2.Text = "Nhap hang";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(143, 50);
            this.toolStripButton3.Text = "ban hang";
            // 
            // tsbCustommer
            // 
            this.tsbCustommer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbCustommer.Image = ((System.Drawing.Image)(resources.GetObject("tsbCustommer.Image")));
            this.tsbCustommer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustommer.Name = "tsbCustommer";
            this.tsbCustommer.Size = new System.Drawing.Size(166, 50);
            this.tsbCustommer.Text = "khach hang";
            this.tsbCustommer.Click += new System.EventHandler(this.tsbCustommer_Click);
            // 
            // tsbManufacture
            // 
            this.tsbManufacture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbManufacture.Image = ((System.Drawing.Image)(resources.GetObject("tsbManufacture.Image")));
            this.tsbManufacture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManufacture.Name = "tsbManufacture";
            this.tsbManufacture.Size = new System.Drawing.Size(190, 50);
            this.tsbManufacture.Text = "Nha cung cap";
            this.tsbManufacture.Click += new System.EventHandler(this.tsbManufacture_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsDisplay,
            this.tslPermission});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1343, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsDisplay
            // 
            this.stsDisplay.Name = "stsDisplay";
            this.stsDisplay.Size = new System.Drawing.Size(0, 15);
            // 
            // tslPermission
            // 
            this.tslPermission.Name = "tslPermission";
            this.tslPermission.Size = new System.Drawing.Size(0, 15);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 613);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý kho";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsbCustommer;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmUnit;
        private System.Windows.Forms.ToolStripButton tsbManufacture;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsDisplay;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripStatusLabel tslPermission;
    }
}