namespace WinFormsApp2
{
    partial class GestionUsuarios
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvUsuarios = new DataGridView();
            panel1 = new Panel();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            gescomDBContextBindingSource = new BindingSource(components);
            gescomDBContextBindingSource1 = new BindingSource(components);
            id = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Constraseña = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gescomDBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gescomDBContextBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.4404974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.5595F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Controls.Add(dgvUsuarios, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.32061F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.67939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(1806, 1050);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, Usuario, Constraseña, Rol });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(81, 172);
            dgvUsuarios.Margin = new Padding(4, 5, 4, 5);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(1650, 737);
            dgvUsuarios.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 232, 230);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnEditar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(81, 919);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1650, 92);
            panel1.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(542, 27);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 38);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(366, 27);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 38);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 27);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 38);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(204, 27);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 38);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(81, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1650, 157);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(30, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(568, 81);
            label1.TabIndex = 1;
            label1.Text = "Gestion De Usuarios";
            // 
            // gescomDBContextBindingSource
            // 
            gescomDBContextBindingSource.DataSource = typeof(GESCOM.GescomDBContext);
            // 
            // gescomDBContextBindingSource1
            // 
            gescomDBContextBindingSource1.DataSource = typeof(GESCOM.GescomDBContext);
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 8;
            Usuario.Name = "Usuario";
            Usuario.Width = 150;
            // 
            // Constraseña
            // 
            Constraseña.HeaderText = "Contraseña";
            Constraseña.MinimumWidth = 8;
            Constraseña.Name = "Constraseña";
            Constraseña.Width = 150;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 8;
            Rol.Name = "Rol";
            Rol.Width = 150;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(1806, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionUsuarios";
            Text = "Gestion De Usuarios";
            Load += GestionUsuarios_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gescomDBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gescomDBContextBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dgvUsuarios;
        private Panel panel1;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnEditar;
        private Panel panel2;
        private Button btnVolver;
        private BindingSource gescomDBContextBindingSource;
        private BindingSource gescomDBContextBindingSource1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Constraseña;
        private DataGridViewTextBoxColumn Permisos;
        private DataGridViewTextBoxColumn Rol;
    }
}