namespace capaPresentacion
{
    partial class AgregarMesa
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnVolver = new Guna.UI2.WinForms.Guna2Button();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            txtCapacidad = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtUbicacion = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            txtNroMesa = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            Disponible = new Guna.UI2.WinForms.Guna2RadioButton();
            noDisponible = new Guna.UI2.WinForms.Guna2RadioButton();
            Reservada = new Guna.UI2.WinForms.Guna2RadioButton();
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
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            btnAgregar.Image = Properties.Resources.add;
            btnAgregar.ImageAlign = HorizontalAlignment.Left;
            btnAgregar.Location = new Point(68, 551);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregar.Size = new Size(148, 40);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(94, 148, 255);
            label1.Location = new Point(169, 22);
            label1.Name = "label1";
            label1.Size = new Size(241, 46);
            label1.TabIndex = 1;
            label1.Text = "Agregar mesa";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(Reservada);
            guna2ShadowPanel1.Controls.Add(noDisponible);
            guna2ShadowPanel1.Controls.Add(Disponible);
            guna2ShadowPanel1.Controls.Add(txtCapacidad);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(txtUbicacion);
            guna2ShadowPanel1.Controls.Add(label4);
            guna2ShadowPanel1.Controls.Add(txtNroMesa);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(46, 80);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(464, 456);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // txtCapacidad
            // 
            txtCapacidad.BorderColor = Color.FromArgb(94, 148, 255);
            txtCapacidad.CustomizableEdges = customizableEdges5;
            txtCapacidad.DefaultText = "";
            txtCapacidad.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCapacidad.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCapacidad.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCapacidad.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCapacidad.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCapacidad.Font = new Font("Segoe UI", 9F);
            txtCapacidad.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCapacidad.IconLeft = Properties.Resources.people;
            txtCapacidad.Location = new Point(35, 296);
            txtCapacidad.Margin = new Padding(3, 4, 3, 4);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.PlaceholderText = "Capacidad";
            txtCapacidad.SelectedText = "";
            txtCapacidad.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCapacidad.Size = new Size(174, 41);
            txtCapacidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 264);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 6;
            label3.Text = "Capacidad:";
            // 
            // txtUbicacion
            // 
            txtUbicacion.BorderColor = Color.FromArgb(94, 148, 255);
            txtUbicacion.CustomizableEdges = customizableEdges7;
            txtUbicacion.DefaultText = "";
            txtUbicacion.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUbicacion.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUbicacion.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUbicacion.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUbicacion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUbicacion.Font = new Font("Segoe UI", 9F);
            txtUbicacion.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUbicacion.IconLeft = Properties.Resources.location;
            txtUbicacion.Location = new Point(35, 205);
            txtUbicacion.Margin = new Padding(3, 4, 3, 4);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Ubicación";
            txtUbicacion.SelectedText = "";
            txtUbicacion.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtUbicacion.Size = new Size(174, 41);
            txtUbicacion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(35, 173);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 4;
            label4.Text = "Ubicación:";
            // 
            // txtNroMesa
            // 
            txtNroMesa.BorderColor = Color.FromArgb(94, 148, 255);
            txtNroMesa.CustomizableEdges = customizableEdges9;
            txtNroMesa.DefaultText = "";
            txtNroMesa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNroMesa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNroMesa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNroMesa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNroMesa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNroMesa.Font = new Font("Segoe UI", 9F);
            txtNroMesa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNroMesa.IconLeft = Properties.Resources.table;
            txtNroMesa.Location = new Point(35, 116);
            txtNroMesa.Margin = new Padding(3, 4, 3, 4);
            txtNroMesa.Name = "txtNroMesa";
            txtNroMesa.PlaceholderText = "Nro. mesa";
            txtNroMesa.SelectedText = "";
            txtNroMesa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtNroMesa.Size = new Size(174, 41);
            txtNroMesa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(34, 84);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 0;
            label2.Text = "Nro. mesa:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Disponible
            // 
            Disponible.AutoSize = true;
            Disponible.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Disponible.CheckedState.BorderThickness = 0;
            Disponible.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Disponible.CheckedState.InnerColor = Color.White;
            Disponible.CheckedState.InnerOffset = -4;
            Disponible.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Disponible.Location = new Point(266, 155);
            Disponible.Name = "Disponible";
            Disponible.Size = new Size(134, 32);
            Disponible.TabIndex = 8;
            Disponible.Text = "Disponible";
            Disponible.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Disponible.UncheckedState.BorderThickness = 2;
            Disponible.UncheckedState.FillColor = Color.Transparent;
            Disponible.UncheckedState.InnerColor = Color.Transparent;
            // 
            // noDisponible
            // 
            noDisponible.AutoSize = true;
            noDisponible.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            noDisponible.CheckedState.BorderThickness = 0;
            noDisponible.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            noDisponible.CheckedState.InnerColor = Color.White;
            noDisponible.CheckedState.InnerOffset = -4;
            noDisponible.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            noDisponible.Location = new Point(266, 205);
            noDisponible.Name = "noDisponible";
            noDisponible.Size = new Size(165, 32);
            noDisponible.TabIndex = 9;
            noDisponible.Text = "No disponible";
            noDisponible.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            noDisponible.UncheckedState.BorderThickness = 2;
            noDisponible.UncheckedState.FillColor = Color.Transparent;
            noDisponible.UncheckedState.InnerColor = Color.Transparent;
            // 
            // Reservada
            // 
            Reservada.AutoSize = true;
            Reservada.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Reservada.CheckedState.BorderThickness = 0;
            Reservada.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Reservada.CheckedState.InnerColor = Color.FromArgb(94, 148, 255);
            Reservada.CheckedState.InnerOffset = -4;
            Reservada.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Reservada.Location = new Point(266, 260);
            Reservada.Name = "Reservada";
            Reservada.Size = new Size(131, 32);
            Reservada.TabIndex = 10;
            Reservada.Text = "Reservada";
            Reservada.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Reservada.UncheckedState.BorderThickness = 2;
            Reservada.UncheckedState.FillColor = Color.Transparent;
            Reservada.UncheckedState.InnerColor = Color.Transparent;
            // 
            // AgregarMesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(553, 614);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarMesa";
            Text = "Agregar Mesa";
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
        private Guna.UI2.WinForms.Guna2TextBox txtCapacidad;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtUbicacion;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNroMesa;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2RadioButton Disponible;
        private Guna.UI2.WinForms.Guna2RadioButton Reservada;
        private Guna.UI2.WinForms.Guna2RadioButton noDisponible;
    }
}