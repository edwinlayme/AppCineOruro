using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCineOruro.VIEW
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers users = new FrmUsers();
            users.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente clie = new FrmCliente();
            clie.ShowDialog();
        }
    }
}
