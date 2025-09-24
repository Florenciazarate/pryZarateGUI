namespace pryZarateGUI
{
    partial class frmControles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControles));
            btnBotonera = new Button();
            SuspendLayout();
            // 
            // btnBotonera
            // 
            btnBotonera.BackColor = Color.LightSteelBlue;
            btnBotonera.FlatStyle = FlatStyle.System;
            btnBotonera.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBotonera.Location = new Point(170, 117);
            btnBotonera.Name = "btnBotonera";
            btnBotonera.Size = new Size(122, 51);
            btnBotonera.TabIndex = 1;
            btnBotonera.Text = "Botonera";
            btnBotonera.UseVisualStyleBackColor = false;
            btnBotonera.Click += btnBotonera_Click;
            // 
            // frmControles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(484, 306);
            Controls.Add(btnBotonera);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmControles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controles de Interfaz Grafica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBotonera;
    }
}