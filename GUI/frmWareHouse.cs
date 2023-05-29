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
    public partial class frmWareHouse : Form
    {
        public frmWareHouse()
        {
            InitializeComponent();
        }
        IBUS_KHOHANG buskho= new BUS_KHOHANG();
        IBUS_CTKHO busct = new BUS_CTKHO();

        private void frmWareHouse_Load(object sender, EventArgs e)
        {
            dgvWareHouse.DataSource = buskho.GetList();
            dgvWHInfo.DataSource = busct.GetList();
            cboProductName.DataSource = busct.GetProductName();
            cboProductName.DisplayMember = "TenSP";
        }

        private void dgvWareHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWareHouseID.Text = dgvWareHouse[0, dgvWareHouse.CurrentCell.RowIndex].Value.ToString();
            txtWareHouseName.Text = dgvWareHouse[1, dgvWareHouse.CurrentCell.RowIndex].Value.ToString();
            txtAddress.Text = dgvWareHouse[2, dgvWareHouse.CurrentCell.RowIndex].Value.ToString();
        }

        private void dgvWHInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWHInfoID.Text = dgvWHInfo[0, dgvWHInfo.CurrentCell.RowIndex].Value.ToString();
            txtWareHouseID.Text = dgvWHInfo[1, dgvWHInfo.CurrentCell.RowIndex].Value.ToString();
            txtProductID.Text = dgvWHInfo[2, dgvWHInfo.CurrentCell.RowIndex].Value.ToString();
            txtAmount.Text = dgvWHInfo[3, dgvWHInfo.CurrentCell.RowIndex].Value.ToString();
            txtWareHouseName.Text= dgvWHInfo[4, dgvWHInfo.CurrentCell.RowIndex].Value.ToString();
            txtAddress.Text= dgvWHInfo[5, dgvWHInfo.CurrentCell.RowIndex].Value.ToString();
            cboProductName.Text=dgvWHInfo[6, dgvWHInfo.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnUpdateWareHouse_Click(object sender, EventArgs e)
        {
            try
            {
                int val = buskho.Update(new DTO_Kho(txtWareHouseID.Text, txtWareHouseName.Text, txtAddress.Text));
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
            frmWareHouse_Load(sender, e);
        }

        private void btnDelelteWareHouse_Click(object sender, EventArgs e)
        {
            try
            {
                int val = buskho.Delete(txtWareHouseID.Text);
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
            frmWareHouse_Load(sender, e);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtWareHouseID.Text = "";
            txtWareHouseName.Text = "";
            txtAddress.Text = "";
            txtWHInfoID.Text = "";
            txtAmount.Text = "0";
            cboProductName.Text = "";
            txtWord.Text = "";
            frmWareHouse_Load(sender, e);
        }

        private void btnAddWareHouse_Click_1(object sender, EventArgs e)
        {
            int val_kho = buskho.Insert(new DTO_Kho(txtWareHouseID.Text, txtWareHouseName.Text, txtAddress.Text));
            if (txtWareHouseID.Text == "" || txtWareHouseName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (val_kho == -1)
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
            frmWareHouse_Load(sender, e);
        
        }

        private void btnAddWHInfo_Click_1(object sender, EventArgs e)
        {
            int val_ctkho = busct.Insert(new DTO_CTKho(txtWHInfoID.Text, txtWareHouseID.Text, txtProductID.Text, int.Parse(txtAmount.Text), txtWareHouseName.Text, txtAddress.Text, cboProductName.Text));
            if (txtWareHouseID.Text == "" || txtWHInfoID.Text == "" || cboProductName.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa đủ, xin hãy nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (val_ctkho == -1)
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
            frmWareHouse_Load(sender, e);
        }

        private void btnUpdateWHInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busct.Update(new DTO_CTKho(txtWHInfoID.Text, txtWareHouseID.Text, txtProductID.Text, int.Parse(txtAmount.Text), txtWareHouseName.Text, txtAddress.Text, cboProductName.Text));
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
            frmWareHouse_Load(sender, e);
        }

        private void btnDeleteWHInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busct.Delete(txtWHInfoID.Text);
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
            frmWareHouse_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Word = txtWord.Text;
            IList<DTO_Kho> list = buskho.Search(Word);
            dgvWareHouse.DataSource = list;
        }

        private void btnSearchWD_Click(object sender, EventArgs e)
        {
            string Word = txtWord.Text;
            IList<DTO_CTKho> list = busct.Search(Word);
            dgvWHInfo.DataSource = list;
        }

        private void btnExWord_Click(object sender, EventArgs e)
        {

        }

        private void btnExWord_Click_1(object sender, EventArgs e)
        {

        }
    }
}
