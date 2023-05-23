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

namespace GUI.Components
{
    public partial class frmUnit : Form
    {
        public frmUnit()
        {
            InitializeComponent();
        }
        IBUS_DonViTinh busdv = new BUS_DonViTinh();

        private void frmUnit_Load(object sender, EventArgs e)
        {
            dgvUnit.DataSource=busdv.GetList();
        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUnitID.Text = dgvUnit[0, dgvUnit.CurrentCell.RowIndex].Value.ToString();
            txtUnitName.Text = dgvUnit[1, dgvUnit.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int val = busdv.Insert(new DTO_DonViTinh(int.Parse(txtUnitID.Text), txtUnitName.Text));
            if (txtUnitID.Text == "" || txtUnitName.Text == "" )
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
            frmUnit_Load(sender, e);
        }
    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busdv.Update(new DTO_DonViTinh(int.Parse(txtUnitID.Text), txtUnitName.Text));
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
            frmUnit_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busdv.Delete(int.Parse(txtUnitID.Text));
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
            frmUnit_Load(sender, e);
        }

        private void txtTextSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUnitID.Text = "";
            txtUnitName.Text = "";
        }
    }
}
