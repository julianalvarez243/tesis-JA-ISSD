using capaEF;
using capaEntidad;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text.Trim();
            string password = txtContrasenia.Text;

            using (var db = new GescomDBContext())
            {
                var user = db.Usuario
                             .FirstOrDefault(u => u.NombreUsuario == usuario
                                               && u.Contrasenia == password);

                if (user != null)
                {
                    this.Hide();
                    // Abrir formulario principal
                    Gestion main = new Gestion(user);
                    main.WindowState = FormWindowState.Maximized;
                    main.Show();

                }
                else
                {
                    MessageBox.Show("❌ Usuario o contraseña incorrectos");
                }
            }
        }
    }
}
