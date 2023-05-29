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
using System.Xml.Linq;
using System.Drawing.Drawing2D;
using BUS.Interface;

namespace GUI
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        IBUS_SANPHAM bussp = new BUS_SANPHAM();

        private void frmProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = bussp.GetList();

            cboUnit.DataSource = bussp.GetUnit();
            cboUnit.DisplayMember = "TenDVT";

            cboCategory.DataSource = bussp.GetCategory();
            cboCategory.DisplayMember = "TenDM";

           
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = dgvProduct[0, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txtProductName.Text = dgvProduct[1, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            cboUnit.Text = dgvProduct[2, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            cboCategory.Text = dgvProduct[3, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txtDescription.Text = dgvProduct[4, dgvProduct.CurrentCell.RowIndex].Value.ToString();
            txtProducer.Text = dgvProduct[5, dgvProduct.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int val = bussp.Insert(new DTO_SanPham(txtProductID.Text, txtProductName.Text, cboUnit.Text, cboCategory.Text, txtDescription.Text, txtProducer.Text));
            if (txtProductID.Text == "" || txtProductName.Text == "" || txtProducer.Text == "")
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
            frmProduct_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int val = bussp.Update(new DTO_SanPham(txtProductID.Text, txtProductName.Text, cboUnit.Text, cboCategory.Text, txtDescription.Text, txtProducer.Text));
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
            frmProduct_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = bussp.Delete(txtProductID.Text);
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
            frmProduct_Load(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            cboUnit.Text = "";
            cboCategory.Text = "";
            txtProducer.Text = "";
            txtDescription.Text = "";
            frmProduct_Load(sender, e);
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            string Word = txtWord.Text;
            IList<DTO_SanPham> list = bussp.Search(Word);
            dgvProduct.DataSource = list;
        }
    }
}
