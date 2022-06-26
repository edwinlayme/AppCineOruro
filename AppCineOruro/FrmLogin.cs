using AppCineOruro.CONTROLLER;
using AppCineOruro.MODEL;
using AppCineOruro.VIEW;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCineOruro
{
    public partial class FrmLogin : Form

    {
        public UserController<Usuario> lista = new UserController<Usuario>();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
             if (txtUser.Text == "user" && txtPass.Text=="user")
             {
                 this.Hide();
                 FrmMain fr = new FrmMain();
                 fr.Show();
             }
             else
             {     
                 MessageBox.Show("Ingresar Usuario y Contraseña correctos...","Cuadro de ERROR",MessageBoxButtons.OK);
                 txtUser.Text = ""; txtPass.Text = "";
             }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
