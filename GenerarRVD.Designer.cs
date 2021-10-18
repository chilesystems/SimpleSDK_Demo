
namespace SimpleSDK_Demo
{
    partial class GenerarRVD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericEmitidoHasta = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericEmitidoDesde = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericAnuladoHasta = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericAnuladoDesde = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericFoliosEmitidos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericFoliosAnulados = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.botonGenerar = new System.Windows.Forms.Button();
            this.numericTotalExento = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericTotalIVA = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericTotalNeto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericSecuencia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmitidoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmitidoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnuladoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnuladoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFoliosEmitidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFoliosAnulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalExento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalNeto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericEmitidoHasta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericEmitidoDesde);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericAnuladoHasta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericAnuladoDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericFoliosEmitidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericFoliosAnulados);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folios";
            // 
            // numericEmitidoHasta
            // 
            this.numericEmitidoHasta.Location = new System.Drawing.Point(319, 49);
            this.numericEmitidoHasta.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericEmitidoHasta.Name = "numericEmitidoHasta";
            this.numericEmitidoHasta.Size = new System.Drawing.Size(60, 20);
            this.numericEmitidoHasta.TabIndex = 13;
            this.numericEmitidoHasta.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hasta:";
            // 
            // numericEmitidoDesde
            // 
            this.numericEmitidoDesde.Location = new System.Drawing.Point(209, 49);
            this.numericEmitidoDesde.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericEmitidoDesde.Name = "numericEmitidoDesde";
            this.numericEmitidoDesde.Size = new System.Drawing.Size(60, 20);
            this.numericEmitidoDesde.TabIndex = 11;
            this.numericEmitidoDesde.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Desde:";
            // 
            // numericAnuladoHasta
            // 
            this.numericAnuladoHasta.Enabled = false;
            this.numericAnuladoHasta.Location = new System.Drawing.Point(319, 23);
            this.numericAnuladoHasta.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericAnuladoHasta.Name = "numericAnuladoHasta";
            this.numericAnuladoHasta.Size = new System.Drawing.Size(60, 20);
            this.numericAnuladoHasta.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hasta:";
            // 
            // numericAnuladoDesde
            // 
            this.numericAnuladoDesde.Enabled = false;
            this.numericAnuladoDesde.Location = new System.Drawing.Point(209, 23);
            this.numericAnuladoDesde.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericAnuladoDesde.Name = "numericAnuladoDesde";
            this.numericAnuladoDesde.Size = new System.Drawing.Size(60, 20);
            this.numericAnuladoDesde.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde:";
            // 
            // numericFoliosEmitidos
            // 
            this.numericFoliosEmitidos.Location = new System.Drawing.Point(96, 49);
            this.numericFoliosEmitidos.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericFoliosEmitidos.Name = "numericFoliosEmitidos";
            this.numericFoliosEmitidos.Size = new System.Drawing.Size(60, 20);
            this.numericFoliosEmitidos.TabIndex = 5;
            this.numericFoliosEmitidos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericFoliosEmitidos.ValueChanged += new System.EventHandler(this.numericFoliosEmitidos_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Folios Emitidos:";
            // 
            // numericFoliosAnulados
            // 
            this.numericFoliosAnulados.Location = new System.Drawing.Point(96, 23);
            this.numericFoliosAnulados.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericFoliosAnulados.Name = "numericFoliosAnulados";
            this.numericFoliosAnulados.Size = new System.Drawing.Size(60, 20);
            this.numericFoliosAnulados.TabIndex = 1;
            this.numericFoliosAnulados.ValueChanged += new System.EventHandler(this.numericFoliosAnulados_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folios Anulados:";
            // 
            // botonGenerar
            // 
            this.botonGenerar.Image = global::SimpleSDK_Demo.Properties.Resources.Guardar_32;
            this.botonGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGenerar.Location = new System.Drawing.Point(312, 177);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(91, 41);
            this.botonGenerar.TabIndex = 20;
            this.botonGenerar.Text = "Generar";
            this.botonGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGenerar.UseVisualStyleBackColor = true;
            this.botonGenerar.Click += new System.EventHandler(this.botonGenerar_ClickAsync);
            // 
            // numericTotalExento
            // 
            this.numericTotalExento.Location = new System.Drawing.Point(305, 28);
            this.numericTotalExento.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericTotalExento.Name = "numericTotalExento";
            this.numericTotalExento.Size = new System.Drawing.Size(74, 20);
            this.numericTotalExento.TabIndex = 9;
            this.numericTotalExento.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exento:";
            // 
            // numericTotalIVA
            // 
            this.numericTotalIVA.Location = new System.Drawing.Point(174, 28);
            this.numericTotalIVA.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericTotalIVA.Name = "numericTotalIVA";
            this.numericTotalIVA.Size = new System.Drawing.Size(65, 20);
            this.numericTotalIVA.TabIndex = 11;
            this.numericTotalIVA.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "IVA:";
            // 
            // numericTotalNeto
            // 
            this.numericTotalNeto.Location = new System.Drawing.Point(45, 28);
            this.numericTotalNeto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericTotalNeto.Name = "numericTotalNeto";
            this.numericTotalNeto.Size = new System.Drawing.Size(74, 20);
            this.numericTotalNeto.TabIndex = 7;
            this.numericTotalNeto.Value = new decimal(new int[] {
            840,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Neto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericTotalIVA);
            this.groupBox2.Controls.Add(this.numericTotalExento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericTotalNeto);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 67);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // numericSecuencia
            // 
            this.numericSecuencia.Location = new System.Drawing.Point(125, 189);
            this.numericSecuencia.Name = "numericSecuencia";
            this.numericSecuencia.Size = new System.Drawing.Size(62, 20);
            this.numericSecuencia.TabIndex = 22;
            this.numericSecuencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Secuencia de Envío:";
            // 
            // GenerarRVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 232);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericSecuencia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonGenerar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerarRVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generación de RVD (ex-RCOF)";
            this.Load += new System.EventHandler(this.GenerarRVD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmitidoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmitidoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnuladoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnuladoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFoliosEmitidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFoliosAnulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalExento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalNeto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.NumericUpDown numericTotalExento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericTotalIVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericTotalNeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericFoliosEmitidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericFoliosAnulados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericEmitidoHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericEmitidoDesde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericAnuladoHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericAnuladoDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSecuencia;
        private System.Windows.Forms.Label label10;
    }
}