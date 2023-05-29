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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        IBUS_NguoiDung busnd = new BUS_NguoiDung();

        private void frmUser_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = busnd.GetList();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dgvUser[0, dgvUser.CurrentCell.RowIndex].Value.ToString();
            txtName.Text = dgvUser[1, dgvUser.CurrentCell.RowIndex].Value.ToString();
            txtPhone.Text = dgvUser[2, dgvUser.CurrentCell.RowIndex].Value.ToString();
            txtEmail.Text = dgvUser[3, dgvUser.CurrentCell.RowIndex].Value.ToString();
            txtUserName.Text = dgvUser[4, dgvUser.CurrentCell.RowIndex].Value.ToString();
            txtPassWord.Text = dgvUser[5, dgvUser.CurrentCell.RowIndex].Value.ToString();
            cboPermission.Text = dgvUser[6, dgvUser.CurrentCell.RowIndex].Value.ToString();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            int val = busnd.Insert(new DTO_NguoiDung(txtUserID.Text, txtName.Text, txtPhone.Text, txtEmail.Text, txtUserName.Text, txtPassWord.Text, cboPermission.Text));
            if (txtUserID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || txtUserName.Text == "" || txtPassWord.Text == "" || cboPermission.Text == "")
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
            frmUser_Load(sender, e);

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busnd.Delete(txtUserID.Text);
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
            frmUser_Load(sender, e);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int val = busnd.Update(new DTO_NguoiDung(txtUserID.Text, txtName.Text, txtPhone.Text, txtEmail.Text, txtUserName.Text, txtPassWord.Text, cboPermission.Text));
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
            frmUser_Load(sender, e);
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            string Word = txtWord.Text;
            IList<DTO_NguoiDung> list = busnd.Search(Word);
            dgvUser.DataSource = list;
        }

        private void tsbTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassWord.Text = "";
            cboPermission.Text = "";
            txtWord.Text = "";
            frmUser_Load(sender, e);
        }

        private void cboPermission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}