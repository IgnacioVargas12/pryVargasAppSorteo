namespace pryVargasAppSorteo
{
    partial class frmRegistroSorteo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblFecha = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnRegistrar = new Button();
            dtpFecha = new DateTimePicker();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(37, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(112, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del sorteo";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.Location = new Point(37, 79);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(98, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha del sorteo";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidad.Location = new Point(37, 120);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(147, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad de participantes";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(194, 117);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(54, 23);
            txtCantidad.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(287, 172);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 43);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(194, 79);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 7;
            // 
            // frmRegistroSorteo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(495, 304);
            Controls.Add(dtpFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblFecha);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmRegistroSorteo";
            Text = "Registrar Sorteo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblFecha;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
    }
}
