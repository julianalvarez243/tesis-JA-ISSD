namespace WinFormsApp2
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtConfirmarContrasenia = new TextBox();
            btnCancelar = new Button();
            btnActualizar = new Button();
            txtContrasenia = new TextBox();
            txtNombreUsuario = new TextBox();
            cboRol = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            label1.Text = "Modificar Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Controls.Add(cboRol);
            panel1.Controls.Add(txtConfirmarContrasenia);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(txtContrasenia);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(59, 163);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 462);
            panel1.TabIndex = 0;
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContrasenia.Font = new Font("Segoe UI", 12F);
            txtConfirmarContrasenia.Location = new Point(51, 212);
            txtConfirmarContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.PlaceholderText = "Confirmar contraseña";
            txtConfirmarContrasenia.Size = new Size(471, 39);
            txtConfirmarContrasenia.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(306, 363);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 62);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(67, 363);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(207, 62);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar Usuario";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 12F);
            txtContrasenia.Location = new Point(54, 135);
            txtContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.Size = new Size(471, 39);
            txtContrasenia.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Segoe UI", 12F);
            txtNombreUsuario.Location = new Point(54, 62);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre de Usuario";
            txtNombreUsuario.Size = new Size(471, 39);
            txtNombreUsuario.TabIndex = 0;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(51, 291);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(461, 33);
            cboRol.TabIndex = 7;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(691, 768);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "ModificarUsuario";
            Text = "EditarUsuario";
            Load += ModificarUsuario_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox txtConfirmarContrasenia;
        private Button btnCancelar;
        private Button btnActualizar;
        private TextBox txtContrasenia;
        private TextBox txtNombreUsuario;
        private ComboBox cboRol;
    }
}