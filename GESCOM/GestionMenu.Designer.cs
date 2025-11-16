namespace WinFormsApp2
{
    partial class GestionMenu
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnVolver = new Button();
            btnEliminarComida = new Button();
            btnAgregarComida = new Button();
            btnEditarComida = new Button();
            dgvComida = new DataGridView();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            dgvBebida = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            btnVolver2 = new Button();
            btnEliminarBebida = new Button();
            btnAgregarBebida = new Button();
            btnEditarBebida = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComida).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBebida).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(36, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 125);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(176, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 81);
            label1.TabIndex = 1;
            label1.Text = "Comidas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 232, 230);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminarComida);
            panel1.Controls.Add(btnAgregarComida);
            panel1.Controls.Add(btnEditarComida);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(36, 919);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 92);
            panel1.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(485, 27);
            btnVolver.Margin = new Padding(4, 5, 6, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(89, 38);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminarComida
            // 
            btnEliminarComida.Location = new Point(327, 27);
            btnEliminarComida.Margin = new Padding(4, 5, 4, 5);
            btnEliminarComida.Name = "btnEliminarComida";
            btnEliminarComida.Size = new Size(89, 38);
            btnEliminarComida.TabIndex = 5;
            btnEliminarComida.Text = "Eliminar";
            btnEliminarComida.UseVisualStyleBackColor = true;
            btnEliminarComida.Click += btnEliminarComida_Click;
            // 
            // btnAgregarComida
            // 
            btnAgregarComida.Location = new Point(17, 27);
            btnAgregarComida.Margin = new Padding(6, 5, 4, 5);
            btnAgregarComida.Name = "btnAgregarComida";
            btnAgregarComida.Size = new Size(89, 38);
            btnAgregarComida.TabIndex = 3;
            btnAgregarComida.Text = "Agregar";
            btnAgregarComida.UseVisualStyleBackColor = true;
            btnAgregarComida.Click += btnAgregarComida_Click;
            // 
            // btnEditarComida
            // 
            btnEditarComida.Location = new Point(176, 27);
            btnEditarComida.Margin = new Padding(4, 5, 4, 5);
            btnEditarComida.Name = "btnEditarComida";
            btnEditarComida.Size = new Size(79, 38);
            btnEditarComida.TabIndex = 4;
            btnEditarComida.Text = "Editar";
            btnEditarComida.UseVisualStyleBackColor = true;
            btnEditarComida.Click += btnEditarComida_Click;
            // 
            // dgvComida
            // 
            dgvComida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComida.Location = new Point(36, 140);
            dgvComida.Margin = new Padding(4, 5, 4, 5);
            dgvComida.Name = "dgvComida";
            dgvComida.RowHeadersWidth = 62;
            dgvComida.Size = new Size(682, 769);
            dgvComida.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 135);
            label2.TabIndex = 7;
            label2.Text = "Gestion De Menú";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1091, 5);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(680, 125);
            panel4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(236, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(241, 81);
            label4.TabIndex = 1;
            label4.Text = "Bebidas";
            // 
            // dgvBebida
            // 
            dgvBebida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBebida.Dock = DockStyle.Fill;
            dgvBebida.Location = new Point(1091, 140);
            dgvBebida.Margin = new Padding(4, 5, 4, 5);
            dgvBebida.Name = "dgvBebida";
            dgvBebida.RowHeadersWidth = 62;
            dgvBebida.Size = new Size(680, 769);
            dgvBebida.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.4404974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.5595F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 365F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 688F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(panel3, 3, 2);
            tableLayoutPanel1.Controls.Add(dgvBebida, 3, 1);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvComida, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8531952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.1468048F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(1806, 1050);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 232, 230);
            panel3.Controls.Add(btnVolver2);
            panel3.Controls.Add(btnEliminarBebida);
            panel3.Controls.Add(btnAgregarBebida);
            panel3.Controls.Add(btnEditarBebida);
            panel3.Location = new Point(1091, 919);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(680, 92);
            panel3.TabIndex = 7;
            // 
            // btnVolver2
            // 
            btnVolver2.Location = new Point(485, 27);
            btnVolver2.Margin = new Padding(4, 5, 6, 5);
            btnVolver2.Name = "btnVolver2";
            btnVolver2.Size = new Size(89, 38);
            btnVolver2.TabIndex = 6;
            btnVolver2.Text = "Volver";
            btnVolver2.UseVisualStyleBackColor = true;
            btnVolver2.Click += btnVolver2_Click;
            // 
            // btnEliminarBebida
            // 
            btnEliminarBebida.Location = new Point(327, 27);
            btnEliminarBebida.Margin = new Padding(4, 5, 4, 5);
            btnEliminarBebida.Name = "btnEliminarBebida";
            btnEliminarBebida.Size = new Size(89, 38);
            btnEliminarBebida.TabIndex = 5;
            btnEliminarBebida.Text = "Eliminar";
            btnEliminarBebida.UseVisualStyleBackColor = true;
            btnEliminarBebida.Click += btnEliminarBebida_Click;
            // 
            // btnAgregarBebida
            // 
            btnAgregarBebida.Location = new Point(17, 27);
            btnAgregarBebida.Margin = new Padding(6, 5, 4, 5);
            btnAgregarBebida.Name = "btnAgregarBebida";
            btnAgregarBebida.Size = new Size(89, 38);
            btnAgregarBebida.TabIndex = 3;
            btnAgregarBebida.Text = "Agregar";
            btnAgregarBebida.UseVisualStyleBackColor = true;
            btnAgregarBebida.Click += btnAgregarBebida_Click;
            // 
            // btnEditarBebida
            // 
            btnEditarBebida.Location = new Point(176, 27);
            btnEditarBebida.Margin = new Padding(4, 5, 4, 5);
            btnEditarBebida.Name = "btnEditarBebida";
            btnEditarBebida.Size = new Size(79, 38);
            btnEditarBebida.TabIndex = 4;
            btnEditarBebida.Text = "Editar";
            btnEditarBebida.UseVisualStyleBackColor = true;
            btnEditarBebida.Click += btnEditarBebida_Click;
            // 
            // GestionMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionMenu";
            Text = "GestionMenu";
            Load += GestionMenu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComida).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBebida).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button btnVolver;
        private Button btnEliminarComida;
        private Button btnAgregarComida;
        private Button btnEditarComida;
        private DataGridView dgvComida;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private DataGridView dgvBebida;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnEliminarBebida;
        private Button btnAgregarBebida;
        private Button btnEditarBebida;
        private Button btnVolver2;
    }
}