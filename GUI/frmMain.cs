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

namespace GUI
{
    public partial class frmMain : Form
    {
        IBUS_NguoiDung busnd = new BUS_NguoiDung();
        private string quyen;

        public frmMain(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;

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

        private void tsb_Click(object sender, EventArgs e)
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
                frmWareHouse suplier = new frmWareHouse();
                suplier.MdiParent = this;
                suplier.Dock = DockStyle.None;
                suplier.Show();
            }
        }
    }
}
