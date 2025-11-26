namespace capaPresentacion
{
    partial class AgregarComida
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
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(94, 148, 255);
            label1.Location = new Point(139, 19);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
            label1.TabIndex = 1;
            label1.Text = "Agregar comida";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
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
            // txtPrecio
            // 
            txtPrecio.CustomizableEdges = customizableEdges5;
            txtPrecio.DefaultText = "";
            txtPrecio.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrecio.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrecio.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrecio.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrecio.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecio.Font = new Font("Segoe UI", 9F);
            txtPrecio.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrecio.IconLeft = Properties.Resources.price;
            txtPrecio.Location = new Point(33, 288);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.SelectedText = "";
            txtPrecio.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrecio.Size = new Size(397, 41);
            txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(33, 256);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 6;
            label3.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.CustomizableEdges = customizableEdges7;
            txtDescripcion.DefaultText = "";
            txtDescripcion.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescripcion.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescripcion.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescripcion.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescripcion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescripcion.IconLeft = Properties.Resources.description;
            txtDescripcion.Location = new Point(33, 180);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.SelectedText = "";
            txtDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtDescripcion.Size = new Size(397, 41);
            txtDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(33, 148);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 4;
            label4.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.CustomizableEdges = customizableEdges9;
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
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            // AgregarComida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(553, 614);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarComida";
            Text = "AgregarComida";
            Load += AgregarComida_Load_1;
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
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}