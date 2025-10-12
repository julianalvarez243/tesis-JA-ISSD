namespace WinFormsApp2
{
    partial class GestionDeComandas
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Constraseña = new DataGridViewTextBoxColumn();
            Permisos = new DataGridViewTextBoxColumn();
            Bebidas = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnVolver = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 232, 221);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.4404974F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.5595F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
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
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Usuario, Constraseña, Permisos, Bebidas, Comentarios, Estado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(81, 172);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1650, 737);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Mesa";
            Usuario.MinimumWidth = 8;
            Usuario.Name = "Usuario";
            Usuario.Width = 150;
            // 
            // Constraseña
            // 
            Constraseña.HeaderText = "Comensales";
            Constraseña.MinimumWidth = 8;
            Constraseña.Name = "Constraseña";
            Constraseña.Width = 150;
            // 
            // Permisos
            // 
            Permisos.HeaderText = "Comidas";
            Permisos.MinimumWidth = 8;
            Permisos.Name = "Permisos";
            Permisos.Width = 150;
            // 
            // Bebidas
            // 
            Bebidas.HeaderText = "Bebidas";
            Bebidas.MinimumWidth = 8;
            Bebidas.Name = "Bebidas";
            Bebidas.Width = 150;
            // 
            // Comentarios
            // 
            Comentarios.HeaderText = "Comentarios";
            Comentarios.MinimumWidth = 8;
            Comentarios.Name = "Comentarios";
            Comentarios.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.Width = 150;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 232, 230);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(81, 919);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1650, 92);
            panel1.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(544, 27);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 38);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // button3
            // 
            button3.Location = new Point(366, 27);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(30, 27);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(204, 27);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(97, 38);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
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
            label1.Size = new Size(621, 81);
            label1.TabIndex = 1;
            label1.Text = "Gestion De Comandas";
            // 
            // GestionDeComandas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionDeComandas";
            Text = "GestionDeComandas";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Constraseña;
        private DataGridViewTextBoxColumn Permisos;
        private DataGridViewTextBoxColumn Bebidas;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn Estado;
        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Label label1;
        private Button btnVolver;
    }
}