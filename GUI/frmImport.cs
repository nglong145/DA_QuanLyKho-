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

namespace GUI
{
    public partial class frmImport : Form
    {
        private string ten;
        public frmImport(string ten)
        {
            InitializeComponent();
            this.ten = ten;
        }
        IBUS_HDNHAP bushdn = new BUS_HDNHAP();
        IBUS_CTHDNHAP busctn = new BUS_CTHDNHAP();

        private void frmImport_Load(object sender, EventArgs e)
        {
            dgvImport.DataSource = bushdn.GetList();
            txtName.Text = ten;
            cboSuplier.DataSource = bushdn.GetSuplier();
            cboSuplier.DisplayMember = "TenNhaCC";

            dgvIDetail.DataSource = busctn.GetList();
        }

        private void dgvImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtImportID.Text = dgvImport[0, dgvImport.CurrentCell.RowIndex].Value.ToString();
            cboSuplier.Text = dgvImport[1, dgvImport.CurrentCell.RowIndex].Value.ToString();
            txtName.Text = dgvImport[2, dgvImport.CurrentCell.RowIndex].Value.ToString();
            dtpDate.Value = DateTime.Parse(dgvImport[3, dgvImport.CurrentCell.RowIndex].Value.ToString());
            txtNumberBill.Text = dgvImport[4, dgvImport.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int val = bushdn.Insert(new DTO_HDNhap(txtImportID.Text, cboSuplier.Text, txtName.Text, dtpDate.Value, txtNumberBill.Text));
            if (txtImportID.Text == "" || txtNumberBill.Text == "")
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
            frmImport_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int val = bushdn.Update(new DTO_HDNhap(txtImportID.Text, cboSuplier.Text, txtName.Text, dtpDate.Value, txtNumberBill.Text));
                if (val == -1)
                    MessageBox.Show("Sửa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã sửa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmImport_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = bushdn.Delete(txtImportID.Text);
                if (val == -1)
                    MessageBox.Show("Xóa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmImport_Load(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtImportID.Text = "";
            cboSuplier.Text = "";
            txtNumberBill.Text = "";
            frmImport_Load(sender, e);
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmImportCoupon ip = new frmImportCoupon();
            ip.ShowDialog();
        }

        private void dgvIDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTextBox.Text = dgvIDetail[0, dgvIDetail.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busctn.Delete(txtTextBox.Text);
                if (val == -1)
                    MessageBox.Show("Xóa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmImport_Load(sender, e);
        }

        private void btnSearchDetail_Click(object sender, EventArgs e)
        {
            string Word = txtTextBox.Text;
            IList<DTO_CTHDNhap> list = busctn.Search(Word);
            dgvIDetail.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Word = txtTextBox.Text;
            IList<DTO_HDNhap> list = bushdn.Search(Word);
            dgvImport.DataSource = list;
        }
    }
}
