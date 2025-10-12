namespace WinFormsApp2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtCapacidad = new TextBox();
            txtUbicacion = new TextBox();
            txtNroMesa = new TextBox();
            Reservada = new RadioButton();
            noDisponible = new RadioButton();
            Disponible = new RadioButton();
            btnCancelar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 580F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 472F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.Size = new Size(691, 768);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 232, 221);
            panel1.Controls.Add(txtCapacidad);
            panel1.Controls.Add(txtUbicacion);
            panel1.Controls.Add(txtNroMesa);
            panel1.Controls.Add(Reservada);
            panel1.Controls.Add(noDisponible);
            panel1.Controls.Add(Disponible);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(59, 163);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 462);
            panel1.TabIndex = 0;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(370, 147);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.PlaceholderText = "Capacidad";
            txtCapacidad.Size = new Size(178, 31);
            txtCapacidad.TabIndex = 10;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(61, 147);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Ubicacion";
            txtUbicacion.Size = new Size(178, 31);
            txtUbicacion.TabIndex = 9;
            // 
            // txtNroMesa
            // 
            txtNroMesa.Location = new Point(61, 19);
            txtNroMesa.Name = "txtNroMesa";
            txtNroMesa.PlaceholderText = "Numero de mesa";
            txtNroMesa.Size = new Size(178, 31);
            txtNroMesa.TabIndex = 8;
            // 
            // Reservada
            // 
            Reservada.AutoSize = true;
            Reservada.Location = new Point(397, 100);
            Reservada.Margin = new Padding(4, 5, 4, 5);
            Reservada.Name = "Reservada";
            Reservada.RightToLeft = RightToLeft.No;
            Reservada.Size = new Size(117, 29);
            Reservada.TabIndex = 7;
            Reservada.TabStop = true;
            Reservada.Text = "Reservada";
            Reservada.UseVisualStyleBackColor = true;
            // 
            // noDisponible
            // 
            noDisponible.AutoSize = true;
            noDisponible.Location = new Point(397, 61);
            noDisponible.Margin = new Padding(4, 5, 4, 5);
            noDisponible.Name = "noDisponible";
            noDisponible.RightToLeft = RightToLeft.No;
            noDisponible.Size = new Size(151, 29);
            noDisponible.TabIndex = 6;
            noDisponible.TabStop = true;
            noDisponible.Text = "No Disponible";
            noDisponible.UseVisualStyleBackColor = true;
            // 
            // Disponible
            // 
            Disponible.AutoSize = true;
            Disponible.Location = new Point(397, 19);
            Disponible.Margin = new Padding(4, 5, 4, 5);
            Disponible.Name = "Disponible";
            Disponible.RightToLeft = RightToLeft.No;
            Disponible.Size = new Size(122, 29);
            Disponible.TabIndex = 5;
            Disponible.TabStop = true;
            Disponible.Text = "Disponible";
            Disponible.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(300, 288);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 62);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(61, 288);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(207, 62);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Confirmar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(59, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(572, 158);
            label1.TabIndex = 1;
            label1.Text = "Agregar Mesa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgregarMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(691, 768);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AgregarMesa";
            Text = "Agregar Mesa";
            Load += AgregarMesa_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnAgregar;
        private Label label1;
        private RadioButton Disponible;
        private RadioButton noDisponible;
        private TextBox txtNroMesa;
        private RadioButton Reservada;
        private TextBox txtUbicacion;
        private TextBox txtCapacidad;
    }
}