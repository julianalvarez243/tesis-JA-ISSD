namespace WinFormsApp2
{
    partial class Gestion
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
            label2 = new Label();
            label3 = new Label();
            btnUsuarios = new Button();
            label5 = new Label();
            label4 = new Label();
            btnMesas = new Button();
            label7 = new Label();
            label6 = new Label();
            btnComida = new Button();
            label9 = new Label();
            label8 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnNuevaComanda = new Button();
            btnInformes = new Button();
            btnComandas = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label16 = new Label();
            labelNombreUsuario = new Label();
            btnSalir = new Button();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.4404974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.5595F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.32061F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.67939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Size = new Size(1445, 840);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(24, 26);
            label2.Name = "label2";
            label2.Size = new Size(230, 35);
            label2.TabIndex = 2;
            label2.Text = "Listado de usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(24, 80);
            label3.Name = "label3";
            label3.Size = new Size(469, 25);
            label3.TabIndex = 3;
            label3.Text = "Consultar listado de usuarios registrados en el sistema";
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(462, 80);
            btnUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(86, 30);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Ver";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(24, 150);
            label5.Name = "label5";
            label5.Size = new Size(207, 35);
            label5.TabIndex = 5;
            label5.Text = "Listado de mesas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(24, 204);
            label4.Name = "label4";
            label4.Size = new Size(449, 25);
            label4.TabIndex = 6;
            label4.Text = "Consultar listado de mesas registradas en el sistema";
            // 
            // btnMesas
            // 
            btnMesas.Location = new Point(462, 204);
            btnMesas.Margin = new Padding(3, 4, 3, 4);
            btnMesas.Name = "btnMesas";
            btnMesas.Size = new Size(86, 30);
            btnMesas.TabIndex = 7;
            btnMesas.Text = "Ver";
            btnMesas.UseVisualStyleBackColor = true;
            btnMesas.Click += btnMesas_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(24, 284);
            label7.Name = "label7";
            label7.Size = new Size(191, 35);
            label7.TabIndex = 8;
            label7.Text = "Gestionar menu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(24, 338);
            label6.Name = "label6";
            label6.Size = new Size(467, 25);
            label6.TabIndex = 9;
            label6.Text = "Consultar listado de comidas registradas en el sistema";
            // 
            // btnComida
            // 
            btnComida.Location = new Point(462, 338);
            btnComida.Margin = new Padding(3, 4, 3, 4);
            btnComida.Name = "btnComida";
            btnComida.Size = new Size(86, 30);
            btnComida.TabIndex = 10;
            btnComida.Text = "Ver";
            btnComida.UseVisualStyleBackColor = true;
            btnComida.Click += btnComida_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(694, 155);
            label9.Name = "label9";
            label9.Size = new Size(114, 35);
            label9.TabIndex = 11;
            label9.Text = "Informes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(694, 209);
            label8.Name = "label8";
            label8.Size = new Size(280, 25);
            label8.TabIndex = 12;
            label8.Text = "Accede al menu de los informes";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(694, 26);
            label12.Name = "label12";
            label12.Size = new Size(243, 35);
            label12.TabIndex = 16;
            label12.Text = "Gestionar comandas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(694, 80);
            label11.Name = "label11";
            label11.Size = new Size(289, 25);
            label11.TabIndex = 17;
            label11.Text = "Ver todas las comandas enviadas";
            // 
            // btnNuevaComanda
            // 
            btnNuevaComanda.Location = new Point(1077, 70);
            btnNuevaComanda.Margin = new Padding(3, 4, 3, 4);
            btnNuevaComanda.Name = "btnNuevaComanda";
            btnNuevaComanda.Size = new Size(141, 51);
            btnNuevaComanda.TabIndex = 18;
            btnNuevaComanda.Text = "Nueva comanda";
            btnNuevaComanda.UseVisualStyleBackColor = true;
            btnNuevaComanda.Click += btnNuevaComanda_Click;
            // 
            // btnInformes
            // 
            btnInformes.Location = new Point(1224, 209);
            btnInformes.Margin = new Padding(3, 4, 3, 4);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(86, 30);
            btnInformes.TabIndex = 22;
            btnInformes.Text = "Ver";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnComandas
            // 
            btnComandas.Location = new Point(1224, 80);
            btnComandas.Margin = new Padding(3, 4, 3, 4);
            btnComandas.Name = "btnComandas";
            btnComandas.Size = new Size(86, 30);
            btnComandas.TabIndex = 24;
            btnComandas.Text = "Listar";
            btnComandas.UseVisualStyleBackColor = true;
            btnComandas.Click += btnComandas_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnComandas);
            groupBox1.Controls.Add(btnInformes);
            groupBox1.Controls.Add(btnNuevaComanda);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnComida);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnMesas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(67, 142);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1320, 589);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(210, 67);
            label1.TabIndex = 1;
            label1.Text = "Gestion ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F);
            label16.Location = new Point(886, 3);
            label16.Name = "label16";
            label16.Size = new Size(112, 35);
            label16.TabIndex = 27;
            label16.Text = "Usuario: ";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Segoe UI", 15F);
            labelNombreUsuario.Location = new Point(1026, 3);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(125, 35);
            labelNombreUsuario.TabIndex = 28;
            labelNombreUsuario.Text = "***********";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Location = new Point(1229, 91);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 32);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(labelNombreUsuario);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(67, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1375, 130);
            panel2.TabIndex = 6;
            // 
            // Gestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 840);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Gestion";
            Text = "GestionInformes";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label15;
        private Button btnVerDesempenio;
        private Button btnVerInformeMensual;
        private Button btnGenerarDesempenio;
        private Label label13;
        private Label label14;
        private Button btnGenerarInformeMensual;
        private Label label10;
        private Button btnGenerarInformeDiario;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnSalir;
        private Label labelNombreUsuario;
        private Label label16;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnComandas;
        private Button btnInformes;
        private Button btnNuevaComanda;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label9;
        private Button btnComida;
        private Label label6;
        private Label label7;
        private Button btnMesas;
        private Label label4;
        private Label label5;
        private Button btnUsuarios;
        private Label label3;
        private Label label2;
    }
}