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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI.Components
{
    public partial class frmCustommer : Form
    {
        public frmCustommer()
        {
            InitializeComponent();
        }

        IBUS_KhachHang buskh = new BUS_KhachHang();

        private void frmCustommer_Load(object sender, EventArgs e)
        {
            dgvCustommer.DataSource = buskh.GetList();
        }

        private void dgvCustommer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCusID.Text = dgvCustommer[0, dgvCustommer.CurrentCell.RowIndex].Value.ToString();
            txtCusName.Text = dgvCustommer[1, dgvCustommer.CurrentCell.RowIndex].Value.ToString();
            txtAddress.Text = dgvCustommer[2, dgvCustommer.CurrentCell.RowIndex].Value.ToString();
            txtPhone.Text = dgvCustommer[3, dgvCustommer.CurrentCell.RowIndex].Value.ToString();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            int val = buskh.Insert(new DTO_KhachHang(txtCusID.Text, txtCusName.Text, txtAddress.Text, txtPhone.Text));
            if (txtCusID.Text == "" || txtCusName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" )
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
            frmCustommer_Load(sender, e);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int val = buskh.Update(new DTO_KhachHang(txtCusID.Text, txtCusName.Text, txtAddress.Text, txtPhone.Text));
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
            frmCustommer_Load(sender, e);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = buskh.Delete(txtCusID.Text);
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
            frmCustommer_Load(sender, e);
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string Word = txtWord.Text;
            IList<DTO_KhachHang> list = buskh.Search(Word);
            dgvCustommer.DataSource = list;
        }
    }
}
