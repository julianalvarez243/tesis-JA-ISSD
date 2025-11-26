using capaEF;
using capaEntidad;
using capaPresentacion.Properties;
using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Login2_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            guna2ShadowPanel1.Left = (this.ClientSize.Width - guna2ShadowPanel1.Width) / 2;
            guna2ShadowPanel1.Top = (this.ClientSize.Height - guna2ShadowPanel1.Height) / 2;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
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
