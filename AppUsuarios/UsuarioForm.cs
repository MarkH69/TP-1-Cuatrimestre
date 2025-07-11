using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUsuarios
{
    public partial class UsuarioForm : Form
    {
        private Usuario usuario;

        public UsuarioForm(Usuario usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombre.Text = usuario.NombreUsuario;
            txtEmail.Text = usuario.Email;
            txtPassword.Text = usuario.Contraseña;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuario.NombreUsuario = txtNombre.Text.Trim();
            usuario.Email = txtEmail.Text.Trim();
            usuario.Contraseña = txtPassword.Text;

            MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }

}
