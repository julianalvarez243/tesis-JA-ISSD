namespace WinFormsApp2
{
    partial class GestionInformes
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
            panel2 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            generarInformesMozo = new Button();
            label13 = new Label();
            label14 = new Label();
            generarInformeMesas = new Button();
            label11 = new Label();
            label12 = new Label();
            generarInformeCajaMes = new Button();
            label10 = new Label();
            generarInformeCajaDia = new Button();
            label8 = new Label();
            label9 = new Label();
            btnMenu = new Button();
            label6 = new Label();
            label7 = new Label();
            btnMesas = new Button();
            label4 = new Label();
            label5 = new Label();
            btnUsuarios = new Button();
            label3 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.4404974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.5595F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.32061F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.67939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1445, 908);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(64, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1321, 138);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(710, 67);
            label1.TabIndex = 1;
            label1.Text = "Gestion De Listados e Informes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(generarInformesMozo);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(generarInformeMesas);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(generarInformeCajaMes);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(generarInformeCajaDia);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnMesas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(64, 150);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1320, 645);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // generarInformesMozo
            // 
            generarInformesMozo.Location = new Point(1175, 393);
            generarInformesMozo.Margin = new Padding(3, 4, 3, 4);
            generarInformesMozo.Name = "generarInformesMozo";
            generarInformesMozo.Size = new Size(86, 31);
            generarInformesMozo.TabIndex = 21;
            generarInformesMozo.Text = "Generar";
            generarInformesMozo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(671, 393);
            label13.Name = "label13";
            label13.Size = new Size(449, 25);
            label13.TabIndex = 20;
            label13.Text = "Generar informe sobre el desempeños de los mozos";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F);
            label14.Location = new Point(671, 339);
            label14.Name = "label14";
            label14.Size = new Size(392, 35);
            label14.TabIndex = 19;
            label14.Text = "Informe de desempeño de mozos";
            // 
            // generarInformeMesas
            // 
            generarInformeMesas.Location = new Point(1175, 259);
            generarInformeMesas.Margin = new Padding(3, 4, 3, 4);
            generarInformeMesas.Name = "generarInformeMesas";
            generarInformeMesas.Size = new Size(86, 31);
            generarInformeMesas.TabIndex = 18;
            generarInformeMesas.Text = "Generar";
            generarInformeMesas.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(671, 259);
            label11.Name = "label11";
            label11.Size = new Size(468, 25);
            label11.TabIndex = 17;
            label11.Text = "Generar informe con la ocupacion de mesas en el mes";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(671, 204);
            label12.Name = "label12";
            label12.Size = new Size(373, 35);
            label12.TabIndex = 16;
            label12.Text = "Informe de ocupacion de mesas";
            // 
            // generarInformeCajaMes
            // 
            generarInformeCajaMes.Location = new Point(1175, 131);
            generarInformeCajaMes.Margin = new Padding(3, 4, 3, 4);
            generarInformeCajaMes.Name = "generarInformeCajaMes";
            generarInformeCajaMes.Size = new Size(86, 31);
            generarInformeCajaMes.TabIndex = 15;
            generarInformeCajaMes.Text = "Generar";
            generarInformeCajaMes.UseVisualStyleBackColor = true;
            generarInformeCajaMes.Click += generarInformeCajaMes_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(671, 131);
            label10.Name = "label10";
            label10.Size = new Size(489, 25);
            label10.TabIndex = 14;
            label10.Text = "Generar informe de los movimientos de la caja en el mes";
            // 
            // generarInformeCajaDia
            // 
            generarInformeCajaDia.Location = new Point(1175, 80);
            generarInformeCajaDia.Margin = new Padding(3, 4, 3, 4);
            generarInformeCajaDia.Name = "generarInformeCajaDia";
            generarInformeCajaDia.Size = new Size(86, 31);
            generarInformeCajaDia.TabIndex = 13;
            generarInformeCajaDia.Text = "Generar";
            generarInformeCajaDia.UseVisualStyleBackColor = true;
            generarInformeCajaDia.Click += generarInformeCajaDia_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(671, 80);
            label8.Name = "label8";
            label8.Size = new Size(481, 25);
            label8.TabIndex = 12;
            label8.Text = "Generar informe de los movimientos de la caja en el dia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(671, 25);
            label9.Name = "label9";
            label9.Size = new Size(375, 35);
            label9.TabIndex = 11;
            label9.Text = "Informe de movimientos de caja";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(462, 339);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(86, 31);
            btnMenu.TabIndex = 10;
            btnMenu.Text = "Ver";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(24, 339);
            label6.Name = "label6";
            label6.Size = new Size(255, 25);
            label6.TabIndex = 9;
            label6.Text = "Consultar listado de comidas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(24, 284);
            label7.Name = "label7";
            label7.Size = new Size(231, 35);
            label7.TabIndex = 8;
            label7.Text = "Listado de comidas";
            // 
            // btnMesas
            // 
            btnMesas.Location = new Point(462, 204);
            btnMesas.Margin = new Padding(3, 4, 3, 4);
            btnMesas.Name = "btnMesas";
            btnMesas.Size = new Size(86, 31);
            btnMesas.TabIndex = 7;
            btnMesas.Text = "Ver";
            btnMesas.UseVisualStyleBackColor = true;
            btnMesas.Click += btnMesas_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(24, 204);
            label4.Name = "label4";
            label4.Size = new Size(242, 25);
            label4.TabIndex = 6;
            label4.Text = "Consultar listado de mesas ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(24, 149);
            label5.Name = "label5";
            label5.Size = new Size(207, 35);
            label5.TabIndex = 5;
            label5.Text = "Listado de mesas";
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(462, 80);
            btnUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(86, 31);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Ver";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(24, 80);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 3;
            label3.Text = "Consultar listado de usuarios \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(230, 35);
            label2.TabIndex = 2;
            label2.Text = "Listado de usuarios";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1208, 606);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 39);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // GestionInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionInformes";
            Text = "GestionInformes";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnMesas;
        private Label label4;
        private Label label5;
        private Button btnUsuarios;
        private Label label3;
        private Label label2;
        private Button generarInformesMozo;
        private Label label13;
        private Label label14;
        private Button generarInformeMesas;
        private Label label11;
        private Label label12;
        private Button generarInformeCajaMes;
        private Label label10;
        private Button generarInformeCajaDia;
        private Label label8;
        private Label label9;
        private Button btnMenu;
        private Label label6;
        private Label label7;
        private Button btnVolver;
    }
}