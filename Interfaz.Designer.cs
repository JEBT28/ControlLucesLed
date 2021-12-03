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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDiaActual = new System.Windows.Forms.ComboBox();
            this.chkDiasValidos = new System.Windows.Forms.CheckedListBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargarSP,
            this.cmbPuertosSeriales,
            this.btnConectar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(287, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCargarSP
            // 
            this.btnCargarSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCargarSP.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarSP.Image")));
            this.btnCargarSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargarSP.Name = "btnCargarSP";
            this.btnCargarSP.Size = new System.Drawing.Size(89, 35);
            this.btnCargarSP.Text = "Cargar Puertos";
            this.btnCargarSP.Click += new System.EventHandler(this.btnCargarSP_Click);
            // 
            // cmbPuertosSeriales
            // 
            this.cmbPuertosSeriales.Name = "cmbPuertosSeriales";
            this.cmbPuertosSeriales.Size = new System.Drawing.Size(121, 38);
            // 
            // btnConectar
            // 
            this.btnConectar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConectar.Image = ((System.Drawing.Image)(resources.GetObject("btnConectar.Image")));
            this.btnConectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(59, 35);
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen.Location = new System.Drawing.Point(0, 0);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(800, 450);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.26129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.73871F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContador, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 38);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbDiaActual, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkDiasValidos, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(290, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(223, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia Actual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dias Seleccionados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDiaActual
            // 
            this.cmbDiaActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaActual.FormattingEnabled = true;
            this.cmbDiaActual.Location = new System.Drawing.Point(308, 3);
            this.cmbDiaActual.Name = "cmbDiaActual";
            this.cmbDiaActual.Size = new System.Drawing.Size(127, 23);
            this.cmbDiaActual.TabIndex = 3;
            // 
            // chkDiasValidos
            // 
            this.chkDiasValidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDiasValidos.FormattingEnabled = true;
            this.chkDiasValidos.Location = new System.Drawing.Point(86, 3);
            this.chkDiasValidos.Name = "chkDiasValidos";
            this.chkDiasValidos.Size = new System.Drawing.Size(131, 26);
            this.chkDiasValidos.TabIndex = 4;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContador.Location = new System.Drawing.Point(734, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(63, 38);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "00";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbImagen);
            this.Name = "Interfaz";
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbPuertosSeriales;
        private System.Windows.Forms.ToolStripButton btnConectar;
        private System.Windows.Forms.ToolStripButton btnCargarSP;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiaActual;
        private System.Windows.Forms.CheckedListBox chkDiasValidos;
        private System.Windows.Forms.Label lblContador;
    }
}
