namespace capaPresentacion
{
    partial class ModificarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnVolver = new Guna.UI2.WinForms.Guna2Button();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            cboRol = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            txtConfirmarContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            txtNombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            guna2Panel1.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnVolver);
            guna2Panel1.Controls.Add(btnAgregar);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(guna2ShadowPanel1);
            guna2Panel1.CustomizableEdges = customizableEdges13;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel1.Size = new Size(553, 614);
            guna2Panel1.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.BorderRadius = 10;
            btnVolver.CustomizableEdges = customizableEdges1;
            btnVolver.DisabledState.BorderColor = Color.DarkGray;
            btnVolver.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVolver.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVolver.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVolver.Font = new Font("Segoe UI", 9F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Image = Properties.Resources.back;
            btnVolver.ImageAlign = HorizontalAlignment.Left;
            btnVolver.Location = new Point(329, 551);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnVolver.Size = new Size(148, 40);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BorderRadius = 10;
            btnAgregar.CustomizableEdges = customizableEdges3;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = Properties.Resources.check;
            btnAgregar.ImageAlign = HorizontalAlignment.Left;
            btnAgregar.Location = new Point(68, 551);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregar.Size = new Size(148, 40);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Actualizar";
            btnAgregar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(94, 148, 255);
            label1.Location = new Point(130, 18);
            label1.Name = "label1";
            label1.Size = new Size(305, 46);
            label1.TabIndex = 1;
            label1.Text = "Modificar usuario";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(cboRol);
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Controls.Add(txtConfirmarContrasenia);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(txtContrasenia);
            guna2ShadowPanel1.Controls.Add(label4);
            guna2ShadowPanel1.Controls.Add(txtNombreUsuario);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(46, 80);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(464, 456);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // cboRol
            // 
            cboRol.BackColor = Color.Transparent;
            cboRol.CustomizableEdges = customizableEdges5;
            cboRol.DrawMode = DrawMode.OwnerDrawFixed;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FocusedColor = Color.FromArgb(94, 148, 255);
            cboRol.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboRol.Font = new Font("Segoe UI", 10F);
            cboRol.ForeColor = Color.FromArgb(68, 88, 112);
            cboRol.ItemHeight = 30;
            cboRol.Location = new Point(39, 358);
            cboRol.Name = "cboRol";
            cboRol.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboRol.Size = new Size(392, 36);
            cboRol.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(33, 324);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 8;
            label5.Text = "Rol:";
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.CustomizableEdges = customizableEdges7;
            txtConfirmarContrasenia.DefaultText = "";
            txtConfirmarContrasenia.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmarContrasenia.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmarContrasenia.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmarContrasenia.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmarContrasenia.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmarContrasenia.Font = new Font("Segoe UI", 9F);
            txtConfirmarContrasenia.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmarContrasenia.IconLeft = Properties.Resources.padlock;
            txtConfirmarContrasenia.Location = new Point(34, 244);
            txtConfirmarContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.PlaceholderText = "Confirmar contraseña";
            txtConfirmarContrasenia.SelectedText = "";
            txtConfirmarContrasenia.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtConfirmarContrasenia.Size = new Size(397, 41);
            txtConfirmarContrasenia.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(34, 212);
            label3.Name = "label3";
            label3.Size = new Size(222, 28);
            label3.TabIndex = 6;
            label3.Text = "Confirmar contraseña:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.CustomizableEdges = customizableEdges9;
            txtContrasenia.DefaultText = "";
            txtContrasenia.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContrasenia.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContrasenia.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContrasenia.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContrasenia.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContrasenia.Font = new Font("Segoe UI", 9F);
            txtContrasenia.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContrasenia.IconLeft = Properties.Resources.padlock;
            txtContrasenia.Location = new Point(34, 153);
            txtContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.SelectedText = "";
            txtContrasenia.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtContrasenia.Size = new Size(397, 41);
            txtContrasenia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(34, 121);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.CustomizableEdges = customizableEdges11;
            txtNombreUsuario.DefaultText = "";
            txtNombreUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombreUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombreUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombreUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombreUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreUsuario.Font = new Font("Segoe UI", 9F);
            txtNombreUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreUsuario.IconLeft = Properties.Resources.user;
            txtNombreUsuario.Location = new Point(34, 64);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre de usuario";
            txtNombreUsuario.SelectedText = "";
            txtNombreUsuario.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtNombreUsuario.Size = new Size(397, 41);
            txtNombreUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(33, 32);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 0;
            label2.Text = "Nombre de usuario:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(553, 614);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "ModificarUsuario";
            Text = "EditarUsuario";
            Load += ModificarUsuario_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboRol;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmarContrasenia;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUsuario;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}