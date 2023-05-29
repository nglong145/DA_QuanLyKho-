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


namespace GUI
{
    public partial class frmLogin : Form
    {
        IBUS_NguoiDung busnd = new BUS_NguoiDung();

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            bool val = busnd.Login(txtTaiKhoan.Text, txtMatKhau.Text);
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (val)
            {
                string quyen = busnd.GetQuyen(txtTaiKhoan.Text, txtMatKhau.Text);
                string ten = busnd.GetName(txtTaiKhoan.Text, txtMatKhau.Text);
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                frmMain frm = new frmMain(quyen,ten);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ \n Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
