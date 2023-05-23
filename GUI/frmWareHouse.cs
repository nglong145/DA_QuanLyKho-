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

        private void frmWareHouse_Load(object sender, EventArgs e)
        {
            dgvWareHouse.DataSource = buskho.GetList();
        }
    }
}
