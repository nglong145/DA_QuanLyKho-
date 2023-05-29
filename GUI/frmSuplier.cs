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
    public partial class frmSuplier : Form
    {
        public frmSuplier()
        {
            InitializeComponent();
        }
        IBUS_NHACC busncc = new BUS_NHACC();
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            int val = busncc.Insert(new DTO_NhaCungCap(txtSupId.Text, txtSupName.Text, txtTaxCode.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text));
            if (txtSupId.Text == "" || txtSupName.Text == "" || txtTaxCode.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" )
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
            frmSuplier_Load(sender, e);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busncc.Update(new DTO_NhaCungCap(txtSupId.Text, txtSupName.Text, txtTaxCode.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text));
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
            frmSuplier_Load(sender, e);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busncc.Delete(txtSupId.Text);
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
            frmSuplier_Load(sender, e);
        }

        private void frmSuplier_Load(object sender, EventArgs e)
        {
            dgvSuplier.DataSource = busncc.GetList();
        }

        private void dgvSuplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupId.Text= dgvSuplier[0, dgvSuplier.CurrentCell.RowIndex].Value.ToString();
            txtSupName.Text = dgvSuplier[1, dgvSuplier.CurrentCell.RowIndex].Value.ToString();
            txtTaxCode.Text = dgvSuplier[2, dgvSuplier.CurrentCell.RowIndex].Value.ToString();
            txtAddress.Text = dgvSuplier[3, dgvSuplier.CurrentCell.RowIndex].Value.ToString();
            txtPhone.Text = dgvSuplier[4, dgvSuplier.CurrentCell.RowIndex].Value.ToString();
            txtEmail.Text = dgvSuplier[5, dgvSuplier.CurrentCell.RowIndex].Value.ToString();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            txtSupId.Text = "";
            txtSupName.Text = "";
            txtTaxCode.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string Word = txtWord.Text;
            IList<DTO_NhaCungCap> list = busncc.Search(Word);
            dgvSuplier.DataSource = list;
        }
    }
}
