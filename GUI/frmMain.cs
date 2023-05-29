using BUS;
using DTO;
using GUI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmMain : Form
    {
        IBUS_NguoiDung busnd = new BUS_NguoiDung();
        private string quyen;
        public string ten;

        public frmMain(string quyen, string ten)
        {
            InitializeComponent();
            this.quyen = quyen;
            this.ten = ten;
        }
        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void tsmUser_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmUser")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmUser frm = new frmUser();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tslPermission.Text = quyen;

            if (quyen == "user")
            {
                tsmUnit.Visible = false;
                tsmUser.Visible = false;
                tsmAdmin.Visible = false;
            }
        }

        private void tsbCustommer_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmCustommer")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmCustommer cus = new frmCustommer();
                cus.MdiParent = this;
                cus.Dock = DockStyle.Fill;
                cus.Show();
            }
        }

        private void tsmUnit_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmUnit")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmUnit unit = new frmUnit();
                unit.MdiParent = this;
                unit.Dock = DockStyle.None;
                unit.Show();
            }
        }

        private void tsbManufacture_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmSuplier")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmSuplier suplier = new frmSuplier();
                suplier.MdiParent = this;
                suplier.Dock = DockStyle.None;
                suplier.Show();
            }
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmImport")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmImport ipo = new frmImport(ten);
                ipo.MdiParent = this;
                ipo.Dock = DockStyle.None;
                ipo.Show();
            }
        }

        private void tsbWareHouse_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmWareHouse")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmWareHouse wh = new frmWareHouse();
                wh.MdiParent = this;
                wh.Dock = DockStyle.None;
                wh.Show();
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmExport")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmExport ex = new frmExport(ten);
                ex.MdiParent = this;
                ex.Dock = DockStyle.None;
                ex.Show();
            }
        }

        private void tsbProduct_Click(object sender, EventArgs e)
        {
            bool inExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmProduct")
                {
                    f.Activate();
                    inExists = true;
                    break;
                }
            }
            if (!inExists)
            {
                frmProduct pr = new frmProduct();
                pr.MdiParent = this;
                pr.Dock = DockStyle.None;
                pr.Show();
            }
        }
    }
}
