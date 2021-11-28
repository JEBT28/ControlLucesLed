namespace Proyecto_Arduino
{
    partial class Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargarSP = new System.Windows.Forms.ToolStripButton();
            this.cmbPuertosSeriales = new System.Windows.Forms.ToolStripComboBox();
            this.btnConectar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargarSP,
            this.cmbPuertosSeriales,
            this.btnConectar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCargarSP
            // 
            this.btnCargarSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCargarSP.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarSP.Image")));
            this.btnCargarSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargarSP.Name = "btnCargarSP";
            this.btnCargarSP.Size = new System.Drawing.Size(89, 22);
            this.btnCargarSP.Text = "Cargar Puertos";
            this.btnCargarSP.Click += new System.EventHandler(this.btnCargarSP_Click);
            // 
            // cmbPuertosSeriales
            // 
            this.cmbPuertosSeriales.Name = "cmbPuertosSeriales";
            this.cmbPuertosSeriales.Size = new System.Drawing.Size(121, 25);
            // 
            // btnConectar
            // 
            this.btnConectar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConectar.Image = ((System.Drawing.Image)(resources.GetObject("btnConectar.Image")));
            this.btnConectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(59, 22);
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Interfaz";
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbPuertosSeriales;
        private System.Windows.Forms.ToolStripButton btnConectar;
        private System.Windows.Forms.ToolStripButton btnCargarSP;
    }
}
