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
    public partial class frmExportForm : Form
    {
        public frmExportForm()
        {
            InitializeComponent();
        }

        IBUS_CTHDXuat busctx=new BUS_CTHDXuat();

        private void frmExportForm_Load(object sender, EventArgs e)
        {
            cboExportID.DataSource = busctx.GetExportID();
            cboExportID.DisplayMember = "MaHDXuat";

            cboWareHouse.DataSource = busctx.GetWareHouse();
            cboWareHouse.DisplayMember = "TenKho";

            cboProduct.DataSource = busctx.GetProduct();
            cboProduct.DisplayMember = "TenSP";

            cboUnit.DataSource = busctx.GetUnit();
            cboUnit.DisplayMember = "TenDVT";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int val = busctx.Insert(new DTO_CTHDXuat(txtEDetailID.Text, cboExportID.Text, cboProduct.Text, cboWareHouse.Text, cboUnit.Text, int.Parse(txtAmount.Text), int.Parse(txtPrice.Text)));
            if (txtEDetailID.Text == "" || txtAmount.Text == "" || txtPrice.Text == "")
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
            frmExportForm_Load(sender, e);
        }
    }
}
