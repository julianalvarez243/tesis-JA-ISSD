namespace WinFormsApp2
{
    partial class ConsultarMesa
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
            txtEstado = new Label();
            txtUbicacion = new Label();
            txtCapacidad = new Label();
            txtNroMesa = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCerrar = new Button();
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtEstado);
            panel1.Controls.Add(txtUbicacion);
            panel1.Controls.Add(txtCapacidad);
            panel1.Controls.Add(txtNroMesa);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(59, 163);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 462);
            panel1.TabIndex = 0;
            // 
            // txtEstado
            // 
            txtEstado.AutoSize = true;
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.Location = new Point(193, 262);
            txtEstado.Margin = new Padding(4, 0, 4, 0);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(104, 32);
            txtEstado.TabIndex = 10;
            txtEstado.Text = "*********";
            // 
            // txtUbicacion
            // 
            txtUbicacion.AutoSize = true;
            txtUbicacion.Font = new Font("Segoe UI", 12F);
            txtUbicacion.Location = new Point(187, 197);
            txtUbicacion.Margin = new Padding(4, 0, 4, 0);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(104, 32);
            txtUbicacion.TabIndex = 9;
            txtUbicacion.Text = "*********";
            // 
            // txtCapacidad
            // 
            txtCapacidad.AutoSize = true;
            txtCapacidad.Font = new Font("Segoe UI", 12F);
            txtCapacidad.Location = new Point(193, 130);
            txtCapacidad.Margin = new Padding(4, 0, 4, 0);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(27, 32);
            txtCapacidad.TabIndex = 8;
            txtCapacidad.Text = "0";
            // 
            // txtNroMesa
            // 
            txtNroMesa.AutoSize = true;
            txtNroMesa.Font = new Font("Segoe UI", 12F);
            txtNroMesa.Location = new Point(261, 60);
            txtNroMesa.Margin = new Padding(4, 0, 4, 0);
            txtNroMesa.Name = "txtNroMesa";
            txtNroMesa.Size = new Size(27, 32);
            txtNroMesa.TabIndex = 7;
            txtNroMesa.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(63, 262);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 6;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(63, 197);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 5;
            label4.Text = "Ubicacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(63, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 4;
            label3.Text = "Capacidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 3;
            label2.Text = "Numero de Mesa:";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F);
            btnCerrar.Location = new Point(180, 363);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(207, 62);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(236, 232, 221);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(59, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(572, 158);
            label1.TabIndex = 1;
            label1.Text = "Datos de la Mesa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConsultarMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(691, 768);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConsultarMesa";
            Text = "Datos de la mesa";
            Load += ConsultarMesa_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnCerrar;
        private Label label1;
        private Label txtEstado;
        private Label txtUbicacion;
        private Label txtCapacidad;
        private Label txtNroMesa;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}