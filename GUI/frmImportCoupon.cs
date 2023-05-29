using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmImportCoupon : Form
    {
        public frmImportCoupon()
        {
            InitializeComponent();
        }
        IBUS_CTHDNHAP busctn = new BUS_CTHDNHAP();

        private void frmImportCoupon_Load(object sender, EventArgs e)
        {
            cboImportID.DataSource = busctn.GetImportID();
            cboImportID.DisplayMember = "MaHDNhap";

            cboWareHouse.DataSource = busctn.GetWareHouse();
            cboWareHouse.DisplayMember = "TenKho";

            cboProduct.DataSource = busctn.GetProduct();
            cboProduct.DisplayMember = "TenSP";

            cboUnit.DataSource = busctn.GetUnit();
            cboUnit.DisplayMember = "TenDVT";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int val = busctn.Insert(new DTO_CTHDNhap(txtIDetailID.Text, cboImportID.Text, cboProduct.Text, cboWareHouse.Text, cboUnit.Text, int.Parse(txtAmount.Text), int.Parse(txtPrice.Text)));
            if (txtIDetailID.Text == "" || txtAmount.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            frmImportCoupon_Load(sender, e);
        }
    }
}
