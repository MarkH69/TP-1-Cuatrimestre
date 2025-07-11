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
    public partial class LoginForm : Form
    {
        private List<Usuario> usuarios;


        private Usuario usuarioEncontrado;

        public LoginForm()
        {
            InitializeComponent();

            usuarios = new List<Usuario>
    {
        new Usuario
        {
            NombreUsuario = "admin",
            Email = "admin@gmail.com",
            Contraseña = "admin123",
            EsAdmin = true
        },
        new Usuario
        {
            NombreUsuario = "juan",
            Email = "juan@gmail.com",
            Contraseña = "juan123",
            EsAdmin = false
        }
    };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();
            string contraseñaIngresada = txtPassword.Text;

            
            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            usuarioEncontrado = usuarios.FirstOrDefault(u =>
                (u.NombreUsuario == usuarioIngresado || u.Email == usuarioIngresado) &&
                u.Contraseña == contraseñaIngresada);

            if (usuarioEncontrado == null)
            {
                
                MessageBox.Show("Usuario, email o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                return;
            }

           
            if (usuarioEncontrado.EsAdmin)
            {
                AdminForm adminForm = new AdminForm(usuarios);
                this.Hide();
                adminForm.ShowDialog();
                this.Show();
            }
            else
            {
                UsuarioForm userForm = new UsuarioForm(usuarioEncontrado);
                this.Hide();
                userForm.ShowDialog();
                this.Show();
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseñaForm recuperarForm = new RecuperarContraseñaForm(usuarios);
            recuperarForm.ShowDialog();

        }
    }
}
