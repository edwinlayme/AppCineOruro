using AppCineOruro.CONTROLLER;
using AppCineOruro.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCineOruro.VIEW
{
    public partial class FrmUsers : Form
    {
        public UserController<Usuario> lista = new UserController<Usuario>();
        public FrmUsers()
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCI.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" )
            { 
            Usuario nuevo = new Usuario(txtCI.Text, txtFullName.Text, txtUserName.Text,
                                        txtPassword.Text, txtEmail.Text, cmbRole.Text);
            lista.Adicionar(nuevo, txtCI.Text);
            MessageBox.Show("Se Inserto correctamente"); 
            }
            else
            {
                MessageBox.Show("ERROR Llene todos los campos...");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Usuario filtro = lista.Buscar(txtSearchCI.Text);
            if (txtSearchCI.Text !=""&&filtro!= null)
            { 
            Usuario nuevo = new Usuario(txtCI.Text, txtFullName.Text, txtUserName.Text,
                            txtPassword.Text, txtEmail.Text, cmbRole.Text);
            lista.Actualizar(nuevo,txtSearchCI.Text);
            MessageBox.Show("Se Modifico el Registro correctamente");
            }
            else
            {
                MessageBox.Show("ERROR Ingrese CI valido Modificar...");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Usuario filtro = lista.Buscar(txtSearchCI.Text);
            if (filtro != null) { 
            txtCI.Text = filtro.ci;
            txtFullName.Text = filtro.nom_completo;
            txtEmail.Text = filtro.email;
            cmbRole.Text = filtro.rol;
            txtUserName.Text = filtro.nom_usuario;
            txtPassword.Text = filtro.password;

            //Cargar datos dataGridView
            dgvUsers.Rows.Clear();
            DataGridViewRow fila = new DataGridViewRow();
            fila.Cells.Add(new DataGridViewTextBoxCell() { Value = filtro.ci });
            fila.Cells.Add(new DataGridViewTextBoxCell() { Value = filtro.nom_completo });
            fila.Cells.Add(new DataGridViewTextBoxCell() { Value = filtro.nom_usuario });
            fila.Cells.Add(new DataGridViewTextBoxCell() { Value = filtro.email });
            fila.Cells.Add(new DataGridViewTextBoxCell() { Value = filtro.rol });
            dgvUsers.Rows.Add(fila);
            }
            else
            {
                MessageBox.Show("ERROR Ingrese un CI válido registrado...");
            }
        }

        private void btEliminarUser_Click(object sender, EventArgs e)
        {
            if (txtSearchCI.Text != "")
            {
                /*Usuario nuevo = new Usuario(txtCI.Text, txtFullName.Text, txtUserName.Text,
                                txtPassword.Text, txtEmail.Text, cmbRole.Text);*/
                lista.Eliminar(txtSearchCI.Text);
                MessageBox.Show("Se Elimino el Registro");
            }
            else
            {
                MessageBox.Show("ERROR Ingrese un CI válido a Eliminar...");
            }
        }
    }
}
