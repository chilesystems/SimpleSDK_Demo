
namespace SimpleSDK_Demo
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.botonEnviarSii = new System.Windows.Forms.Button();
            this.botonFacturaCompra = new System.Windows.Forms.Button();
            this.botonMuestraImpresa = new System.Windows.Forms.Button();
            this.botonLibroGuias = new System.Windows.Forms.Button();
            this.botonSetExportacion2 = new System.Windows.Forms.Button();
            this.botonIntercambio = new System.Windows.Forms.Button();
            this.botonCesion = new System.Windows.Forms.Button();
            this.botonSetExportacion = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.botonConsultarEstadoEnvio = new System.Windows.Forms.Button();
            this.botonValidador = new System.Windows.Forms.Button();
            this.botonConsultarEstadoDTE = new System.Windows.Forms.Button();
            this.botonTimbre = new System.Windows.Forms.Button();
            this.botonAceptacion = new System.Windows.Forms.Button();
            this.botonGenerarNotaCredito = new System.Windows.Forms.Button();
            this.botonGenerarRCOF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonGenerarSobreEnvio = new System.Windows.Forms.Button();
            this.botonGenerarDocumento = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTipoEnvio = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(6, 19);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 14;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(98, 19);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(79, 17);
            this.radioProduccion.TabIndex = 15;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // botonEnviarSii
            // 
            this.botonEnviarSii.Location = new System.Drawing.Point(6, 51);
            this.botonEnviarSii.Name = "botonEnviarSii";
            this.botonEnviarSii.Size = new System.Drawing.Size(171, 23);
            this.botonEnviarSii.TabIndex = 3;
            this.botonEnviarSii.Text = "Enviar un archivo al SII";
            this.botonEnviarSii.UseVisualStyleBackColor = true;
            this.botonEnviarSii.Click += new System.EventHandler(this.botonEnviarSii_Click);
            // 
            // botonFacturaCompra
            // 
            this.botonFacturaCompra.Location = new System.Drawing.Point(6, 19);
            this.botonFacturaCompra.Name = "botonFacturaCompra";
            this.botonFacturaCompra.Size = new System.Drawing.Size(178, 23);
            this.botonFacturaCompra.TabIndex = 21;
            this.botonFacturaCompra.Text = "Factura de Compra";
            this.botonFacturaCompra.UseVisualStyleBackColor = true;
            this.botonFacturaCompra.Click += new System.EventHandler(this.botonFacturaCompra_Click);
            // 
            // botonMuestraImpresa
            // 
            this.botonMuestraImpresa.Location = new System.Drawing.Point(6, 48);
            this.botonMuestraImpresa.Name = "botonMuestraImpresa";
            this.botonMuestraImpresa.Size = new System.Drawing.Size(151, 23);
            this.botonMuestraImpresa.TabIndex = 19;
            this.botonMuestraImpresa.Text = "Muestra Impresa";
            this.botonMuestraImpresa.UseVisualStyleBackColor = true;
            // 
            // botonLibroGuias
            // 
            this.botonLibroGuias.Location = new System.Drawing.Point(6, 134);
            this.botonLibroGuias.Name = "botonLibroGuias";
            this.botonLibroGuias.Size = new System.Drawing.Size(178, 23);
            this.botonLibroGuias.TabIndex = 18;
            this.botonLibroGuias.Text = "Libro de Guías";
            this.botonLibroGuias.UseVisualStyleBackColor = true;
            this.botonLibroGuias.Click += new System.EventHandler(this.botonLibroGuias_ClickAsync);
            // 
            // botonSetExportacion2
            // 
            this.botonSetExportacion2.Enabled = false;
            this.botonSetExportacion2.Location = new System.Drawing.Point(6, 105);
            this.botonSetExportacion2.Name = "botonSetExportacion2";
            this.botonSetExportacion2.Size = new System.Drawing.Size(178, 23);
            this.botonSetExportacion2.TabIndex = 20;
            this.botonSetExportacion2.Text = "SET de Exportación (2)";
            this.botonSetExportacion2.UseVisualStyleBackColor = true;
            // 
            // botonIntercambio
            // 
            this.botonIntercambio.Location = new System.Drawing.Point(6, 21);
            this.botonIntercambio.Name = "botonIntercambio";
            this.botonIntercambio.Size = new System.Drawing.Size(151, 23);
            this.botonIntercambio.TabIndex = 18;
            this.botonIntercambio.Text = "Intercambio";
            this.botonIntercambio.UseVisualStyleBackColor = true;
            // 
            // botonCesion
            // 
            this.botonCesion.Location = new System.Drawing.Point(6, 48);
            this.botonCesion.Name = "botonCesion";
            this.botonCesion.Size = new System.Drawing.Size(178, 23);
            this.botonCesion.TabIndex = 19;
            this.botonCesion.Text = "Cesión de Documentos";
            this.botonCesion.UseVisualStyleBackColor = true;
            this.botonCesion.Click += new System.EventHandler(this.botonCesion_ClickAsync);
            // 
            // botonSetExportacion
            // 
            this.botonSetExportacion.Enabled = false;
            this.botonSetExportacion.Location = new System.Drawing.Point(6, 77);
            this.botonSetExportacion.Name = "botonSetExportacion";
            this.botonSetExportacion.Size = new System.Drawing.Size(178, 23);
            this.botonSetExportacion.TabIndex = 17;
            this.botonSetExportacion.Text = "SET de Exportación (1)";
            this.botonSetExportacion.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.botonConsultarEstadoEnvio);
            this.groupBox5.Controls.Add(this.botonValidador);
            this.groupBox5.Controls.Add(this.botonConsultarEstadoDTE);
            this.groupBox5.Location = new System.Drawing.Point(397, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 107);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Utilidades";
            // 
            // botonConsultarEstadoEnvio
            // 
            this.botonConsultarEstadoEnvio.Location = new System.Drawing.Point(6, 48);
            this.botonConsultarEstadoEnvio.Name = "botonConsultarEstadoEnvio";
            this.botonConsultarEstadoEnvio.Size = new System.Drawing.Size(151, 23);
            this.botonConsultarEstadoEnvio.TabIndex = 18;
            this.botonConsultarEstadoEnvio.Text = "Consultar Estado Envío";
            this.botonConsultarEstadoEnvio.UseVisualStyleBackColor = true;
            this.botonConsultarEstadoEnvio.Click += new System.EventHandler(this.botonConsultarEstadoEnvio_Click);
            // 
            // botonValidador
            // 
            this.botonValidador.Location = new System.Drawing.Point(6, 77);
            this.botonValidador.Name = "botonValidador";
            this.botonValidador.Size = new System.Drawing.Size(151, 23);
            this.botonValidador.TabIndex = 17;
            this.botonValidador.Text = "Validador";
            this.botonValidador.UseVisualStyleBackColor = true;
            this.botonValidador.Click += new System.EventHandler(this.botonValidador_Click);
            // 
            // botonConsultarEstadoDTE
            // 
            this.botonConsultarEstadoDTE.Location = new System.Drawing.Point(6, 19);
            this.botonConsultarEstadoDTE.Name = "botonConsultarEstadoDTE";
            this.botonConsultarEstadoDTE.Size = new System.Drawing.Size(151, 23);
            this.botonConsultarEstadoDTE.TabIndex = 1;
            this.botonConsultarEstadoDTE.Text = "Consultar Estado DTE";
            this.botonConsultarEstadoDTE.UseVisualStyleBackColor = true;
            this.botonConsultarEstadoDTE.Click += new System.EventHandler(this.botonConsultarEstadoDTE_Click);
            // 
            // botonTimbre
            // 
            this.botonTimbre.Location = new System.Drawing.Point(6, 21);
            this.botonTimbre.Name = "botonTimbre";
            this.botonTimbre.Size = new System.Drawing.Size(151, 23);
            this.botonTimbre.TabIndex = 12;
            this.botonTimbre.Text = "Imagen del Timbre";
            this.botonTimbre.UseVisualStyleBackColor = true;
            // 
            // botonAceptacion
            // 
            this.botonAceptacion.Location = new System.Drawing.Point(6, 49);
            this.botonAceptacion.Name = "botonAceptacion";
            this.botonAceptacion.Size = new System.Drawing.Size(151, 23);
            this.botonAceptacion.TabIndex = 3;
            this.botonAceptacion.Text = "Enviar Aceptación/Reclamo";
            this.botonAceptacion.UseVisualStyleBackColor = true;
            // 
            // botonGenerarNotaCredito
            // 
            this.botonGenerarNotaCredito.Location = new System.Drawing.Point(6, 48);
            this.botonGenerarNotaCredito.Name = "botonGenerarNotaCredito";
            this.botonGenerarNotaCredito.Size = new System.Drawing.Size(171, 23);
            this.botonGenerarNotaCredito.TabIndex = 3;
            this.botonGenerarNotaCredito.Text = "Notas de Crédito";
            this.botonGenerarNotaCredito.UseVisualStyleBackColor = true;
            this.botonGenerarNotaCredito.Click += new System.EventHandler(this.botonGenerarNotaCredito_Click);
            // 
            // botonGenerarRCOF
            // 
            this.botonGenerarRCOF.Location = new System.Drawing.Point(6, 106);
            this.botonGenerarRCOF.Name = "botonGenerarRCOF";
            this.botonGenerarRCOF.Size = new System.Drawing.Size(171, 23);
            this.botonGenerarRCOF.TabIndex = 2;
            this.botonGenerarRCOF.Text = "Generar RVD";
            this.botonGenerarRCOF.UseVisualStyleBackColor = true;
            this.botonGenerarRCOF.Click += new System.EventHandler(this.botonGenerarRCOF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonGenerarSobreEnvio);
            this.groupBox1.Controls.Add(this.botonGenerarNotaCredito);
            this.groupBox1.Controls.Add(this.botonGenerarRCOF);
            this.groupBox1.Controls.Add(this.botonGenerarDocumento);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 143);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación de Documentos";
            // 
            // botonGenerarSobreEnvio
            // 
            this.botonGenerarSobreEnvio.Location = new System.Drawing.Point(6, 77);
            this.botonGenerarSobreEnvio.Name = "botonGenerarSobreEnvio";
            this.botonGenerarSobreEnvio.Size = new System.Drawing.Size(171, 23);
            this.botonGenerarSobreEnvio.TabIndex = 4;
            this.botonGenerarSobreEnvio.Text = "Generar Sobre Envio";
            this.botonGenerarSobreEnvio.UseVisualStyleBackColor = true;
            this.botonGenerarSobreEnvio.Click += new System.EventHandler(this.botonGenerarSobreEnvio_Click);
            // 
            // botonGenerarDocumento
            // 
            this.botonGenerarDocumento.Location = new System.Drawing.Point(6, 19);
            this.botonGenerarDocumento.Name = "botonGenerarDocumento";
            this.botonGenerarDocumento.Size = new System.Drawing.Size(171, 23);
            this.botonGenerarDocumento.TabIndex = 1;
            this.botonGenerarDocumento.Text = "Generar Documento";
            this.botonGenerarDocumento.UseVisualStyleBackColor = true;
            this.botonGenerarDocumento.Click += new System.EventHandler(this.botonGenerarDocumento_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.botonFacturaCompra);
            this.groupBox6.Controls.Add(this.botonSetExportacion);
            this.groupBox6.Controls.Add(this.botonCesion);
            this.groupBox6.Controls.Add(this.botonLibroGuias);
            this.groupBox6.Controls.Add(this.botonSetExportacion2);
            this.groupBox6.Location = new System.Drawing.Point(201, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 168);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Otros DTE";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.botonIntercambio);
            this.groupBox7.Controls.Add(this.botonAceptacion);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(397, 151);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 80);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Documentos Recibidos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botonTimbre);
            this.groupBox3.Controls.Add(this.botonMuestraImpresa);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(397, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 82);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documentos Impresos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioCertificacion);
            this.groupBox4.Controls.Add(this.radioProduccion);
            this.groupBox4.Location = new System.Drawing.Point(12, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 44);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ambiente en el SII";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTipoEnvio);
            this.groupBox2.Controls.Add(this.botonEnviarSii);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 80);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enviar al SII";
            // 
            // comboTipoEnvio
            // 
            this.comboTipoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoEnvio.FormattingEnabled = true;
            this.comboTipoEnvio.Items.AddRange(new object[] {
            "EnvioDTE",
            "EnvioBoleta",
            "RVD",
            "Libro"});
            this.comboTipoEnvio.Location = new System.Drawing.Point(6, 24);
            this.comboTipoEnvio.Name = "comboTipoEnvio";
            this.comboTipoEnvio.Size = new System.Drawing.Size(171, 21);
            this.comboTipoEnvio.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Image = global::SimpleSDK_Demo.Properties.Resources.ConfiguracionEdit16;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.Button botonEnviarSii;
        private System.Windows.Forms.Button botonFacturaCompra;
        private System.Windows.Forms.Button botonMuestraImpresa;
        private System.Windows.Forms.Button botonLibroGuias;
        private System.Windows.Forms.Button botonSetExportacion2;
        private System.Windows.Forms.Button botonIntercambio;
        private System.Windows.Forms.Button botonCesion;
        private System.Windows.Forms.Button botonSetExportacion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button botonConsultarEstadoEnvio;
        private System.Windows.Forms.Button botonValidador;
        private System.Windows.Forms.Button botonTimbre;
        private System.Windows.Forms.Button botonAceptacion;
        private System.Windows.Forms.Button botonConsultarEstadoDTE;
        private System.Windows.Forms.Button botonGenerarNotaCredito;
        private System.Windows.Forms.Button botonGenerarRCOF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonGenerarDocumento;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboTipoEnvio;
        private System.Windows.Forms.Button botonGenerarSobreEnvio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
    }
}

