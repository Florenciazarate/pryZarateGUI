namespace pryZarateGUI
{
    partial class frmBotonera
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
            btnSiguiente = new Button();
            btnAnterior = new Button();
            txtNombre = new TextBox();
            lblIngreseNombre = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Tan;
            btnSiguiente.FlatStyle = FlatStyle.Popup;
            btnSiguiente.Font = new Font("Nirmala UI", 9.75F);
            btnSiguiente.Location = new Point(265, 285);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(91, 34);
            btnSiguiente.TabIndex = 0;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.Tan;
            btnAnterior.FlatStyle = FlatStyle.Popup;
            btnAnterior.Font = new Font("Nirmala UI", 9.75F);
            btnAnterior.Location = new Point(124, 285);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(91, 34);
            btnAnterior.TabIndex = 1;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Coral;
            txtNombre.ForeColor = SystemColors.InactiveBorder;
            txtNombre.Location = new Point(179, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(115, 23);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Ingrese un nombre";
            // 
            // lblIngreseNombre
            // 
            lblIngreseNombre.AutoSize = true;
            lblIngreseNombre.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngreseNombre.Location = new Point(149, 84);
            lblIngreseNombre.Name = "lblIngreseNombre";
            lblIngreseNombre.Size = new Size(179, 25);
            lblIngreseNombre.TabIndex = 3;
            lblIngreseNombre.Text = "Ingrese su nombre";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(202, 231);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(484, 461);
            Controls.Add(lblNombre);
            Controls.Add(lblIngreseNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Name = "frmBotonera";
            Text = "frmBotonera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiguiente;
        private Button btnAnterior;
        private TextBox txtNombre;
        private Label lblIngreseNombre;
        private Label lblNombre;
    }
}