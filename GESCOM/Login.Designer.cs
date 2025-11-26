namespace capaPresentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            txtNombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2ShadowPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.AutoSize = true;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(label1);
            guna2ShadowPanel1.Controls.Add(btnLogin);
            guna2ShadowPanel1.Controls.Add(txtContrasenia);
            guna2ShadowPanel1.Controls.Add(txtNombreUsuario);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(461, 263);
            guna2ShadowPanel1.Margin = new Padding(33);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(534, 374);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 35F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(94, 148, 255);
            label1.Location = new Point(118, 29);
            label1.Name = "label1";
            label1.Size = new Size(283, 78);
            label1.TabIndex = 4;
            label1.Text = "GESCOM";
            // 
            // btnLogin
            // 
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(114, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(292, 28);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Acceder";
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.CustomizableEdges = customizableEdges3;
            txtContrasenia.DefaultText = "";
            txtContrasenia.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContrasenia.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContrasenia.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContrasenia.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContrasenia.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContrasenia.Font = new Font("Segoe UI", 9F);
            txtContrasenia.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContrasenia.IconLeft = Properties.Resources.padlock;
            txtContrasenia.Location = new Point(118, 203);
            txtContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.SelectedText = "";
            txtContrasenia.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtContrasenia.Size = new Size(286, 33);
            txtContrasenia.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.CustomizableEdges = customizableEdges5;
            txtNombreUsuario.DefaultText = "";
            txtNombreUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombreUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombreUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombreUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombreUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreUsuario.Font = new Font("Segoe UI", 9F);
            txtNombreUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreUsuario.IconLeft = Properties.Resources.user;
            txtNombreUsuario.Location = new Point(118, 142);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre de usuario";
            txtNombreUsuario.SelectedText = "";
            txtNombreUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNombreUsuario.Size = new Size(286, 33);
            txtNombreUsuario.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoSize = true;
            guna2Panel1.Controls.Add(guna2ShadowPanel1);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(1428, 840);
            guna2Panel1.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(1428, 840);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Inicio Sesion";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Resize += Login2_Resize;
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUsuario;
        private Label label1;
    }
}
