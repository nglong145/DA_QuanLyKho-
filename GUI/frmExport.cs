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
    public partial class frmExport : Form
    {
        private string ten;
        public frmExport(string ten)
        {
            InitializeComponent();
            this.ten = ten;
        }

        IBUS_HDXUAT bushdx = new BUS_HDXUAT();
        IBUS_CTHDXuat busctx =new BUS_CTHDXuat();
        IBUS_BILL busb=new BUS_BILL();

        private void frmExport_Load(object sender, EventArgs e)
        {
            dgvExport.DataSource=bushdx.GetList();
            txtName.Text = ten;
            cboName.DataSource=bushdx.GetName();
            cboName.DisplayMember = "TenKH";
            dgvDetail.DataSource=busctx.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int val = bushdx.Insert(new DTO_HDXuat(txtExportID.Text, cboName.Text, txtName.Text, dtpDate.Value , txtNumberBill.Text));
            if (txtExportID.Text == "" || txtName.Text == "" || txtNumberBill.Text == "" )
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
            frmExport_Load(sender, e);
        }

        private void dgvExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExportID.Text = dgvExport[0, dgvExport.CurrentCell.RowIndex].Value.ToString();
            cboName.Text = dgvExport[1, dgvExport.CurrentCell.RowIndex].Value.ToString();
            txtName.Text = dgvExport[2, dgvExport.CurrentCell.RowIndex].Value.ToString();
            dtpDate.Value = DateTime.Parse(dgvExport[3, dgvExport.CurrentCell.RowIndex].Value.ToString());
            txtNumberBill.Text = dgvExport[4, dgvExport.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmExportForm ef = new frmExportForm();
            ef.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int val = bushdx.Update(new DTO_HDXuat(txtExportID.Text, cboName.Text, txtName.Text, dtpDate.Value, txtNumberBill.Text));
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
            frmExport_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = bushdx.Delete(txtExportID.Text);
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
            frmExport_Load(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtExportID.Text = "";
            cboName.Text = "";
            txtNumberBill.Text = "";
            txtTextBox.Text = "";
            frmExport_Load(sender, e);
        }

        private void btnSearchDetail_Click(object sender, EventArgs e)
        {
            string Word = txtTextBox.Text;
            IList<DTO_CTHDXuat> list = busctx.Search(Word);
            dgvDetail.DataSource = list;
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busctx.Delete(txtTextBox.Text);
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
            frmExport_Load(sender, e);
        }

        private void txtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExportBill_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin hóa đơn";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    bushdx.KetXuatWord(txtExportID.Text, @"C:\Users\Acer\Desktop\Đồ án\DA_QuanLyKho old\GUI\bin\Debug\Templates\bill_template.docx", saveFileDialog.FileName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }

            }

        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTextBox.Text= dgvDetail[1, dgvDetail.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Word = txtTextBox.Text;
            IList<DTO_HDXuat> list = bushdx.Search(Word);
            dgvExport.DataSource = list;
        }
    }
}
