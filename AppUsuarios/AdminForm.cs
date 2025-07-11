using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AppUsuarios
{
    public partial class AdminForm : Form
    {
        private List<Usuario> usuarios;

        public AdminForm(List<Usuario> listaUsuarios)
        {
            InitializeComponent();
            usuarios = listaUsuarios;
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios.Select(u => new
            {
                u.NombreUsuario,
                u.Email,
                Contraseña = "••••••", // ocultamos visualmente
                Nivel = u.EsAdmin ? "Administrador" : "Usuario"
            }).ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre de usuario:", "Nuevo Usuario");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Email:", "Nuevo Usuario");
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Contraseña:", "Nuevo Usuario");
            DialogResult esAdmin = MessageBox.Show("¿Es Administrador?", "Nivel", MessageBoxButtons.YesNo);

            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pass))
            {
                usuarios.Add(new Usuario
                {
                    NombreUsuario = nombre,
                    Email = email,
                    Contraseña = pass,
                    EsAdmin = (esAdmin == DialogResult.Yes)
                });

                CargarUsuarios();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un usuario para editar.", "Aviso");
                return;
            }

            string nombreSeleccionado = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            Usuario usuarioSeleccionado = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreSeleccionado);

            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("No se pudo encontrar el usuario.", "Error");
                return;
            }

            EditarUsuarioForm formEditar = new EditarUsuarioForm(usuarioSeleccionado);
            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                CargarUsuarios(); 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
