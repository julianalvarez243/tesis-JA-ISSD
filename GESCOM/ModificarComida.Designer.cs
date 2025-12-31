namespace capaPresentacion
{
    partial class ModificarComida
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
            cboDisponible = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            guna2Panel1.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(236, 232, 221);
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
            guna2Panel1.TabIndex = 5;
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
            btnVolver.Location = new Point(329, 513);
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
            btnAgregar.Location = new Point(80, 513);
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
            label1.Location = new Point(139, 19);
            label1.Name = "label1";
            label1.Size = new Size(302, 46);
            label1.TabIndex = 1;
            label1.Text = "Modificar comida";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(cboDisponible);
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Controls.Add(txtPrecio);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(txtDescripcion);
            guna2ShadowPanel1.Controls.Add(label4);
            guna2ShadowPanel1.Controls.Add(txtNombre);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(46, 80);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(464, 389);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // cboDisponible
            // 
            cboDisponible.BackColor = Color.Transparent;
            cboDisponible.CustomizableEdges = customizableEdges5;
            cboDisponible.DrawMode = DrawMode.OwnerDrawFixed;
            cboDisponible.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDisponible.FocusedColor = Color.FromArgb(94, 148, 255);
            cboDisponible.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboDisponible.Font = new Font("Segoe UI", 10F);
            cboDisponible.ForeColor = Color.FromArgb(68, 88, 112);
            cboDisponible.ItemHeight = 30;
            cboDisponible.Location = new Point(175, 321);
            cboDisponible.Name = "cboDisponible";
            cboDisponible.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboDisponible.Size = new Size(255, 36);
            cboDisponible.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(34, 321);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 8;
            label5.Text = "Disponible:";
            // 
            // txtPrecio
            // 
            txtPrecio.CustomizableEdges = customizableEdges7;
            txtPrecio.DefaultText = "";
            txtPrecio.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrecio.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrecio.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrecio.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrecio.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecio.Font = new Font("Segoe UI", 9F);
            txtPrecio.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecio.IconLeft = Properties.Resources.price;
            txtPrecio.Location = new Point(34, 259);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.SelectedText = "";
            txtPrecio.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPrecio.Size = new Size(397, 41);
            txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(34, 227);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 6;
            label3.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.CustomizableEdges = customizableEdges9;
            txtDescripcion.DefaultText = "";
            txtDescripcion.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescripcion.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescripcion.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescripcion.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescripcion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescripcion.IconLeft = Properties.Resources.description;
            txtDescripcion.Location = new Point(33, 160);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.SelectedText = "";
            txtDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtDescripcion.Size = new Size(397, 41);
            txtDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(33, 128);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 4;
            label4.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.CustomizableEdges = customizableEdges11;
            txtNombre.DefaultText = "";
            txtNombre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.IconLeft = Properties.Resources.food;
            txtNombre.Location = new Point(34, 64);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de la comida";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtNombre.Size = new Size(397, 41);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(33, 32);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ModificarComida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 614);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModificarComida";
            Text = "ModificarComida";
            Load += ModificarComida_Load;
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
        private Guna.UI2.WinForms.Guna2ComboBox cboDisponible;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}