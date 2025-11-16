namespace capaPresentacion
{
    partial class InformeCajaMes
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
            btnVolver = new Button();
            btnGenerar = new Button();
            dtpFecha = new DateTimePicker();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(403, 292);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(123, 48);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(274, 292);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(123, 48);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(276, 116);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 6;
            // 
            // InformeCajaMes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFecha);
            Controls.Add(btnVolver);
            Controls.Add(btnGenerar);
            Name = "InformeCajaMes";
            Text = "InformeCajaMes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Button btnGenerar;
        private DateTimePicker dtpFecha;
    }
}