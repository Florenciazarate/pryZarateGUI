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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBotonera));
            btnSiguiente = new Button();
            btnAnterior = new Button();
            txtNombre = new TextBox();
            lblIngreseNombre = new Label();
            lblNombre = new Label();
            btnPrimero = new Button();
            btnUltimo = new Button();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.DarkKhaki;
            btnSiguiente.FlatStyle = FlatStyle.Popup;
            btnSiguiente.Font = new Font("Nirmala UI", 9.75F);
            btnSiguiente.Location = new Point(237, 285);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(102, 34);
            btnSiguiente.TabIndex = 0;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.DarkKhaki;
            btnAnterior.FlatStyle = FlatStyle.Popup;
            btnAnterior.Font = new Font("Nirmala UI", 9.75F);
            btnAnterior.Location = new Point(140, 285);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(91, 34);
            btnAnterior.TabIndex = 1;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.BurlyWood;
            txtNombre.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = SystemColors.InactiveBorder;
            txtNombre.Location = new Point(167, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 27);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Ingrese un nombre";
            // 
            // lblIngreseNombre
            // 
            lblIngreseNombre.AutoSize = true;
            lblIngreseNombre.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngreseNombre.Location = new Point(131, 70);
            lblIngreseNombre.Name = "lblIngreseNombre";
            lblIngreseNombre.Size = new Size(229, 32);
            lblIngreseNombre.TabIndex = 3;
            lblIngreseNombre.Text = "Ingrese su nombre";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(197, 231);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // btnPrimero
            // 
            btnPrimero.BackColor = Color.DarkKhaki;
            btnPrimero.FlatStyle = FlatStyle.Popup;
            btnPrimero.Font = new Font("Nirmala UI", 9.75F);
            btnPrimero.Location = new Point(45, 285);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(77, 34);
            btnPrimero.TabIndex = 5;
            btnPrimero.Text = "Primero";
            btnPrimero.UseVisualStyleBackColor = false;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.BackColor = Color.DarkKhaki;
            btnUltimo.FlatStyle = FlatStyle.Popup;
            btnUltimo.Font = new Font("Nirmala UI", 9.75F);
            btnUltimo.Location = new Point(354, 285);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(77, 34);
            btnUltimo.TabIndex = 6;
            btnUltimo.Text = "Ultimo ";
            btnUltimo.UseVisualStyleBackColor = false;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(484, 365);
            Controls.Add(btnUltimo);
            Controls.Add(btnPrimero);
            Controls.Add(lblNombre);
            Controls.Add(lblIngreseNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBotonera";
            Text = "Botonera";
            Load += frmBotonera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiguiente;
        private Button btnAnterior;
        private TextBox txtNombre;
        private Label lblIngreseNombre;
        private Label lblNombre;
        private Button btnPrimero;
        private Button btnUltimo;
    }
}