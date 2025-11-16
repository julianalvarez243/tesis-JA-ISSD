namespace WinFormsApp2
{
    partial class ModificarComanda
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
            label6 = new Label();
            btnEliminarItem = new Button();
            txtCantidadBebida = new TextBox();
            txtCantidadComida = new TextBox();
            btnAgregarBebida = new Button();
            label5 = new Label();
            cboBebida = new ComboBox();
            btnAgregarComida = new Button();
            label4 = new Label();
            cboComida = new ComboBox();
            label1 = new Label();
            txtComentario = new TextBox();
            txtCantComensales = new TextBox();
            cboNroMesa = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            btnVolver = new Button();
            btnConfirmar = new Button();
            panel1 = new Panel();
            cboEstado = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            lstPedido = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(236, 232, 221);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 25F);
            label6.Location = new Point(588, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(426, 105);
            label6.TabIndex = 4;
            label6.Text = "Listado";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.Font = new Font("Segoe UI", 12F);
            btnEliminarItem.Location = new Point(588, 764);
            btnEliminarItem.Margin = new Padding(4, 5, 4, 5);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(206, 83);
            btnEliminarItem.TabIndex = 23;
            btnEliminarItem.Text = "Eliminar";
            btnEliminarItem.UseVisualStyleBackColor = true;
            btnEliminarItem.Click += btnEliminarItem_Click;
            // 
            // txtCantidadBebida
            // 
            txtCantidadBebida.Location = new Point(379, 353);
            txtCantidadBebida.Name = "txtCantidadBebida";
            txtCantidadBebida.Size = new Size(95, 31);
            txtCantidadBebida.TabIndex = 24;
            // 
            // txtCantidadComida
            // 
            txtCantidadComida.Location = new Point(379, 231);
            txtCantidadComida.Name = "txtCantidadComida";
            txtCantidadComida.Size = new Size(95, 31);
            txtCantidadComida.TabIndex = 23;
            // 
            // btnAgregarBebida
            // 
            btnAgregarBebida.Font = new Font("Segoe UI", 9F);
            btnAgregarBebida.ImageAlign = ContentAlignment.TopRight;
            btnAgregarBebida.Location = new Point(352, 406);
            btnAgregarBebida.Margin = new Padding(4, 5, 4, 5);
            btnAgregarBebida.Name = "btnAgregarBebida";
            btnAgregarBebida.Size = new Size(123, 33);
            btnAgregarBebida.TabIndex = 22;
            btnAgregarBebida.Text = "Agregar";
            btnAgregarBebida.UseVisualStyleBackColor = true;
            btnAgregarBebida.Click += btnAgregarBebida_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(54, 353);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 21;
            label5.Text = "Bebida:";
            // 
            // cboBebida
            // 
            cboBebida.FormattingEnabled = true;
            cboBebida.Items.AddRange(new object[] { "Elegir Bebida" });
            cboBebida.Location = new Point(54, 406);
            cboBebida.Margin = new Padding(4, 5, 4, 5);
            cboBebida.Name = "cboBebida";
            cboBebida.Size = new Size(288, 33);
            cboBebida.TabIndex = 20;
            // 
            // btnAgregarComida
            // 
            btnAgregarComida.Font = new Font("Segoe UI", 9F);
            btnAgregarComida.ImageAlign = ContentAlignment.TopRight;
            btnAgregarComida.Location = new Point(352, 286);
            btnAgregarComida.Margin = new Padding(4, 5, 4, 5);
            btnAgregarComida.Name = "btnAgregarComida";
            btnAgregarComida.Size = new Size(123, 33);
            btnAgregarComida.TabIndex = 19;
            btnAgregarComida.Text = "Agregar";
            btnAgregarComida.UseVisualStyleBackColor = true;
            btnAgregarComida.Click += btnAgregarComida_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(54, 228);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 18;
            label4.Text = "Comida:";
            // 
            // cboComida
            // 
            cboComida.FormattingEnabled = true;
            cboComida.Items.AddRange(new object[] { "Elegir Comida" });
            cboComida.Location = new Point(54, 286);
            cboComida.Margin = new Padding(4, 5, 4, 5);
            cboComida.Name = "cboComida";
            cboComida.Size = new Size(288, 33);
            cboComida.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(236, 232, 221);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(47, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(506, 105);
            label1.TabIndex = 0;
            label1.Text = "Editar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtComentario
            // 
            txtComentario.BorderStyle = BorderStyle.FixedSingle;
            txtComentario.Dock = DockStyle.Fill;
            txtComentario.Font = new Font("Segoe UI", 12F);
            txtComentario.Location = new Point(0, 0);
            txtComentario.Margin = new Padding(4, 5, 4, 5);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.PlaceholderText = "Comentario";
            txtComentario.Size = new Size(419, 95);
            txtComentario.TabIndex = 11;
            // 
            // txtCantComensales
            // 
            txtCantComensales.BorderStyle = BorderStyle.FixedSingle;
            txtCantComensales.Font = new Font("Segoe UI", 12F);
            txtCantComensales.Location = new Point(384, 72);
            txtCantComensales.Margin = new Padding(4, 5, 4, 5);
            txtCantComensales.Name = "txtCantComensales";
            txtCantComensales.Size = new Size(90, 39);
            txtCantComensales.TabIndex = 16;
            // 
            // cboNroMesa
            // 
            cboNroMesa.FormattingEnabled = true;
            cboNroMesa.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboNroMesa.Location = new Point(384, 20);
            cboNroMesa.Margin = new Padding(4, 5, 4, 5);
            cboNroMesa.Name = "cboNroMesa";
            cboNroMesa.Size = new Size(90, 33);
            cboNroMesa.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(54, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 13;
            label2.Text = "Numero de Mesa:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtComentario);
            panel2.Location = new Point(54, 455);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 97);
            panel2.TabIndex = 12;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(270, 563);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(206, 62);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(41, 563);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(207, 62);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 232, 221);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCantidadBebida);
            panel1.Controls.Add(txtCantidadComida);
            panel1.Controls.Add(btnAgregarBebida);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cboBebida);
            panel1.Controls.Add(btnAgregarComida);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboComida);
            panel1.Controls.Add(txtCantComensales);
            panel1.Controls.Add(cboNroMesa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnConfirmar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(47, 110);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 644);
            panel1.TabIndex = 1;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(292, 130);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(182, 33);
            cboEstado.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(54, 127);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 25;
            label7.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(54, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(283, 32);
            label3.TabIndex = 14;
            label3.Text = "Cantidad de Comensales:";
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.ItemHeight = 25;
            lstPedido.Location = new Point(587, 108);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(428, 554);
            lstPedido.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.82997751F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.17002F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 434F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(lstPedido, 3, 1);
            tableLayoutPanel1.Controls.Add(btnEliminarItem, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8398914F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.16011F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tableLayoutPanel1.Size = new Size(1049, 852);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // ModificarComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 852);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarComanda";
            Text = "ModificarComanda";
            Load += ModificarComanda_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Button btnEliminarItem;
        private TextBox txtCantidadBebida;
        private TextBox txtCantidadComida;
        private Button btnAgregarBebida;
        private Label label5;
        private ComboBox cboBebida;
        private Button btnAgregarComida;
        private Label label4;
        private ComboBox cboComida;
        private Label label1;
        private TextBox txtComentario;
        private TextBox txtCantComensales;
        private ComboBox cboNroMesa;
        private Label label2;
        private Panel panel2;
        private Button btnVolver;
        private Button btnConfirmar;
        private Panel panel1;
        private Label label3;
        private ListBox lstPedido;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cboEstado;
        private Label label7;
    }
}