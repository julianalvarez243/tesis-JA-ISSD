namespace capaPresentacion
{
    partial class InformeCajaDia
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
            dtpFecha = new DateTimePicker();
            btnGenerar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(268, 132);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(268, 216);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(123, 48);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(397, 216);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(123, 48);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // InformeCajaDia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 232, 221);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnGenerar);
            Controls.Add(dtpFecha);
            Name = "InformeCajaDia";
            Text = "InformeCajaDia";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Button btnGenerar;
        private Button btnVolver;
    }
}