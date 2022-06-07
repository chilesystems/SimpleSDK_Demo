
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.botonCesion = new System.Windows.Forms.Button();
            this.botonSetExportacion = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.botonConsultarEstadoEnvio = new System.Windows.Forms.Button();
            this.botonValidador = new System.Windows.Forms.Button();
            this.botonConsultarEstadoDTE = new System.Windows.Forms.Button();
            this.botonTimbre = new System.Windows.Forms.Button();
            this.botonGenerarNotaCredito = new System.Windows.Forms.Button();
            this.botonGenerarRCOF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonGenerarSobreEnvio = new System.Windows.Forms.Button();
            this.botonGenerarDocumento = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTipoEnvio = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroComprasVentasGroupBox = new System.Windows.Forms.GroupBox();
            this.RegistroVentasButton = new System.Windows.Forms.Button();
            this.RegistroComprasButton = new System.Windows.Forms.Button();
            this.BoletaHonorarioGroupBox = new System.Windows.Forms.GroupBox();
            this.EnviarEmailButton = new System.Windows.Forms.Button();
            this.ListadoAnualBoletaButton = new System.Windows.Forms.Button();
            this.ListadoMensualBoletasButton = new System.Windows.Forms.Button();
            this.DownloadPdfButton = new System.Windows.Forms.Button();
            this.AnulaBoletaHonorarioButton = new System.Windows.Forms.Button();
            this.CrearBoletaHonorariosButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.AnularCafMasivamenteButton = new System.Windows.Forms.Button();
            this.ConsultarUltimosCincoCafButton = new System.Windows.Forms.Button();
            this.ConsultarMaximoFoliosButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.RegistroComprasVentasGroupBox.SuspendLayout();
            this.BoletaHonorarioGroupBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(9, 29);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(121, 24);
            this.radioCertificacion.TabIndex = 14;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(147, 29);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(113, 24);
            this.radioProduccion.TabIndex = 15;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // botonEnviarSii
            // 
            this.botonEnviarSii.Location = new System.Drawing.Point(9, 79);
            this.botonEnviarSii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonEnviarSii.Name = "botonEnviarSii";
            this.botonEnviarSii.Size = new System.Drawing.Size(256, 35);
            this.botonEnviarSii.TabIndex = 3;
            this.botonEnviarSii.Text = "Enviar un archivo al SII";
            this.botonEnviarSii.UseVisualStyleBackColor = true;
            this.botonEnviarSii.Click += new System.EventHandler(this.botonEnviarSii_Click);
            // 
            // botonFacturaCompra
            // 
            this.botonFacturaCompra.Location = new System.Drawing.Point(9, 29);
            this.botonFacturaCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonFacturaCompra.Name = "botonFacturaCompra";
            this.botonFacturaCompra.Size = new System.Drawing.Size(267, 35);
            this.botonFacturaCompra.TabIndex = 21;
            this.botonFacturaCompra.Text = "Factura de Compra";
            this.botonFacturaCompra.UseVisualStyleBackColor = true;
            this.botonFacturaCompra.Click += new System.EventHandler(this.botonFacturaCompra_Click);
            // 
            // botonMuestraImpresa
            // 
            this.botonMuestraImpresa.Location = new System.Drawing.Point(9, 74);
            this.botonMuestraImpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonMuestraImpresa.Name = "botonMuestraImpresa";
            this.botonMuestraImpresa.Size = new System.Drawing.Size(226, 35);
            this.botonMuestraImpresa.TabIndex = 19;
            this.botonMuestraImpresa.Text = "Muestra Impresa";
            this.botonMuestraImpresa.UseVisualStyleBackColor = true;
            this.botonMuestraImpresa.Click += new System.EventHandler(this.botonMuestraImpresa_Click);
            // 
            // botonLibroGuias
            // 
            this.botonLibroGuias.Location = new System.Drawing.Point(9, 206);
            this.botonLibroGuias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonLibroGuias.Name = "botonLibroGuias";
            this.botonLibroGuias.Size = new System.Drawing.Size(267, 35);
            this.botonLibroGuias.TabIndex = 18;
            this.botonLibroGuias.Text = "Libro de Guías";
            this.botonLibroGuias.UseVisualStyleBackColor = true;
            this.botonLibroGuias.Click += new System.EventHandler(this.botonLibroGuias_ClickAsync);
            // 
            // botonSetExportacion2
            // 
            this.botonSetExportacion2.Enabled = false;
            this.botonSetExportacion2.Location = new System.Drawing.Point(9, 161);
            this.botonSetExportacion2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonSetExportacion2.Name = "botonSetExportacion2";
            this.botonSetExportacion2.Size = new System.Drawing.Size(267, 35);
            this.botonSetExportacion2.TabIndex = 20;
            this.botonSetExportacion2.Text = "SET de Exportación (2)";
            this.botonSetExportacion2.UseVisualStyleBackColor = true;
            // 
            // botonCesion
            // 
            this.botonCesion.Location = new System.Drawing.Point(9, 74);
            this.botonCesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonCesion.Name = "botonCesion";
            this.botonCesion.Size = new System.Drawing.Size(267, 35);
            this.botonCesion.TabIndex = 19;
            this.botonCesion.Text = "Cesión de Documentos";
            this.botonCesion.UseVisualStyleBackColor = true;
            this.botonCesion.Click += new System.EventHandler(this.botonCesion_ClickAsync);
            // 
            // botonSetExportacion
            // 
            this.botonSetExportacion.Enabled = false;
            this.botonSetExportacion.Location = new System.Drawing.Point(9, 119);
            this.botonSetExportacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonSetExportacion.Name = "botonSetExportacion";
            this.botonSetExportacion.Size = new System.Drawing.Size(267, 35);
            this.botonSetExportacion.TabIndex = 17;
            this.botonSetExportacion.Text = "SET de Exportación (1)";
            this.botonSetExportacion.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.botonConsultarEstadoEnvio);
            this.groupBox5.Controls.Add(this.botonValidador);
            this.groupBox5.Controls.Add(this.botonConsultarEstadoDTE);
            this.groupBox5.Location = new System.Drawing.Point(595, 59);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(244, 165);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Utilidades";
            // 
            // botonConsultarEstadoEnvio
            // 
            this.botonConsultarEstadoEnvio.Location = new System.Drawing.Point(9, 74);
            this.botonConsultarEstadoEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonConsultarEstadoEnvio.Name = "botonConsultarEstadoEnvio";
            this.botonConsultarEstadoEnvio.Size = new System.Drawing.Size(226, 35);
            this.botonConsultarEstadoEnvio.TabIndex = 18;
            this.botonConsultarEstadoEnvio.Text = "Consultar Estado Envío";
            this.botonConsultarEstadoEnvio.UseVisualStyleBackColor = true;
            this.botonConsultarEstadoEnvio.Click += new System.EventHandler(this.botonConsultarEstadoEnvio_Click);
            // 
            // botonValidador
            // 
            this.botonValidador.Location = new System.Drawing.Point(9, 119);
            this.botonValidador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonValidador.Name = "botonValidador";
            this.botonValidador.Size = new System.Drawing.Size(226, 35);
            this.botonValidador.TabIndex = 17;
            this.botonValidador.Text = "Validador";
            this.botonValidador.UseVisualStyleBackColor = true;
            this.botonValidador.Click += new System.EventHandler(this.botonValidador_Click);
            // 
            // botonConsultarEstadoDTE
            // 
            this.botonConsultarEstadoDTE.Location = new System.Drawing.Point(9, 29);
            this.botonConsultarEstadoDTE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonConsultarEstadoDTE.Name = "botonConsultarEstadoDTE";
            this.botonConsultarEstadoDTE.Size = new System.Drawing.Size(226, 35);
            this.botonConsultarEstadoDTE.TabIndex = 1;
            this.botonConsultarEstadoDTE.Text = "Consultar Estado DTE";
            this.botonConsultarEstadoDTE.UseVisualStyleBackColor = true;
            this.botonConsultarEstadoDTE.Click += new System.EventHandler(this.botonConsultarEstadoDTE_Click);
            // 
            // botonTimbre
            // 
            this.botonTimbre.Location = new System.Drawing.Point(9, 32);
            this.botonTimbre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonTimbre.Name = "botonTimbre";
            this.botonTimbre.Size = new System.Drawing.Size(226, 35);
            this.botonTimbre.TabIndex = 12;
            this.botonTimbre.Text = "Imagen del Timbre";
            this.botonTimbre.UseVisualStyleBackColor = true;
            this.botonTimbre.Click += new System.EventHandler(this.botonTimbre_Click);
            // 
            // botonGenerarNotaCredito
            // 
            this.botonGenerarNotaCredito.Location = new System.Drawing.Point(9, 74);
            this.botonGenerarNotaCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonGenerarNotaCredito.Name = "botonGenerarNotaCredito";
            this.botonGenerarNotaCredito.Size = new System.Drawing.Size(256, 35);
            this.botonGenerarNotaCredito.TabIndex = 3;
            this.botonGenerarNotaCredito.Text = "Notas de Crédito";
            this.botonGenerarNotaCredito.UseVisualStyleBackColor = true;
            this.botonGenerarNotaCredito.Click += new System.EventHandler(this.botonGenerarNotaCredito_Click);
            // 
            // botonGenerarRCOF
            // 
            this.botonGenerarRCOF.Location = new System.Drawing.Point(9, 162);
            this.botonGenerarRCOF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonGenerarRCOF.Name = "botonGenerarRCOF";
            this.botonGenerarRCOF.Size = new System.Drawing.Size(256, 35);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(274, 220);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación de Documentos";
            // 
            // botonGenerarSobreEnvio
            // 
            this.botonGenerarSobreEnvio.Location = new System.Drawing.Point(9, 119);
            this.botonGenerarSobreEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonGenerarSobreEnvio.Name = "botonGenerarSobreEnvio";
            this.botonGenerarSobreEnvio.Size = new System.Drawing.Size(256, 35);
            this.botonGenerarSobreEnvio.TabIndex = 4;
            this.botonGenerarSobreEnvio.Text = "Generar Sobre Envio";
            this.botonGenerarSobreEnvio.UseVisualStyleBackColor = true;
            this.botonGenerarSobreEnvio.Click += new System.EventHandler(this.botonGenerarSobreEnvio_Click);
            // 
            // botonGenerarDocumento
            // 
            this.botonGenerarDocumento.Location = new System.Drawing.Point(9, 29);
            this.botonGenerarDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonGenerarDocumento.Name = "botonGenerarDocumento";
            this.botonGenerarDocumento.Size = new System.Drawing.Size(256, 35);
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
            this.groupBox6.Location = new System.Drawing.Point(302, 59);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(285, 259);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Otros DTE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botonTimbre);
            this.groupBox3.Controls.Add(this.botonMuestraImpresa);
            this.groupBox3.Location = new System.Drawing.Point(595, 232);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(244, 126);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documentos Impresos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioCertificacion);
            this.groupBox4.Controls.Add(this.radioProduccion);
            this.groupBox4.Location = new System.Drawing.Point(18, 288);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(274, 68);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ambiente en el SII";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTipoEnvio);
            this.groupBox2.Controls.Add(this.botonEnviarSii);
            this.groupBox2.Location = new System.Drawing.Point(18, 365);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(274, 122);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enviar al SII";
            // 
            // comboTipoEnvio
            // 
            this.comboTipoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoEnvio.FormattingEnabled = true;
            this.comboTipoEnvio.Items.AddRange(new object[] { "EnvioDTE", "EnvioBoleta", "RVD", "LibroGuia" });
            this.comboTipoEnvio.Location = new System.Drawing.Point(9, 38);
            this.comboTipoEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTipoEnvio.Name = "comboTipoEnvio";
            this.comboTipoEnvio.Size = new System.Drawing.Size(255, 28);
            this.comboTipoEnvio.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.configuraciónToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(861, 33);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Image = global::SimpleSDK_Demo.Properties.Resources.ConfiguracionEdit16;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(155, 29);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // RegistroComprasVentasGroupBox
            // 
            this.RegistroComprasVentasGroupBox.Controls.Add(this.RegistroVentasButton);
            this.RegistroComprasVentasGroupBox.Controls.Add(this.RegistroComprasButton);
            this.RegistroComprasVentasGroupBox.Location = new System.Drawing.Point(302, 331);
            this.RegistroComprasVentasGroupBox.Name = "RegistroComprasVentasGroupBox";
            this.RegistroComprasVentasGroupBox.Size = new System.Drawing.Size(285, 115);
            this.RegistroComprasVentasGroupBox.TabIndex = 35;
            this.RegistroComprasVentasGroupBox.TabStop = false;
            this.RegistroComprasVentasGroupBox.Text = "Registro de Compras y Ventas";
            // 
            // RegistroVentasButton
            // 
            this.RegistroVentasButton.Location = new System.Drawing.Point(9, 72);
            this.RegistroVentasButton.Name = "RegistroVentasButton";
            this.RegistroVentasButton.Size = new System.Drawing.Size(267, 32);
            this.RegistroVentasButton.TabIndex = 1;
            this.RegistroVentasButton.Text = "Registro de Ventas";
            this.RegistroVentasButton.UseVisualStyleBackColor = true;
            // 
            // RegistroComprasButton
            // 
            this.RegistroComprasButton.Location = new System.Drawing.Point(9, 34);
            this.RegistroComprasButton.Name = "RegistroComprasButton";
            this.RegistroComprasButton.Size = new System.Drawing.Size(267, 32);
            this.RegistroComprasButton.TabIndex = 0;
            this.RegistroComprasButton.Text = "Registro de Compras";
            this.RegistroComprasButton.UseVisualStyleBackColor = true;
            this.RegistroComprasButton.Click += new System.EventHandler(this.RegistroComprasButton_Click);
            // 
            // BoletaHonorarioGroupBox
            // 
            this.BoletaHonorarioGroupBox.Controls.Add(this.EnviarEmailButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.ListadoAnualBoletaButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.ListadoMensualBoletasButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.DownloadPdfButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.AnulaBoletaHonorarioButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.CrearBoletaHonorariosButton);
            this.BoletaHonorarioGroupBox.Location = new System.Drawing.Point(595, 365);
            this.BoletaHonorarioGroupBox.Name = "BoletaHonorarioGroupBox";
            this.BoletaHonorarioGroupBox.Size = new System.Drawing.Size(244, 294);
            this.BoletaHonorarioGroupBox.TabIndex = 36;
            this.BoletaHonorarioGroupBox.TabStop = false;
            this.BoletaHonorarioGroupBox.Text = "Boletas de Honorarios";
            // 
            // EnviarEmailButton
            // 
            this.EnviarEmailButton.Location = new System.Drawing.Point(9, 168);
            this.EnviarEmailButton.Name = "EnviarEmailButton";
            this.EnviarEmailButton.Size = new System.Drawing.Size(226, 36);
            this.EnviarEmailButton.TabIndex = 5;
            this.EnviarEmailButton.Text = "Enviar por email";
            this.EnviarEmailButton.UseVisualStyleBackColor = true;
            this.EnviarEmailButton.Click += new System.EventHandler(this.EnviarEmailButton_Click);
            // 
            // ListadoAnualBoletaButton
            // 
            this.ListadoAnualBoletaButton.Location = new System.Drawing.Point(9, 250);
            this.ListadoAnualBoletaButton.Name = "ListadoAnualBoletaButton";
            this.ListadoAnualBoletaButton.Size = new System.Drawing.Size(226, 29);
            this.ListadoAnualBoletaButton.TabIndex = 4;
            this.ListadoAnualBoletaButton.Text = "Listado Anual de Boletas";
            this.ListadoAnualBoletaButton.UseVisualStyleBackColor = true;
            this.ListadoAnualBoletaButton.Click += new System.EventHandler(this.ListadoAnualBoletaButton_Click);
            // 
            // ListadoMensualBoletasButton
            // 
            this.ListadoMensualBoletasButton.Location = new System.Drawing.Point(9, 210);
            this.ListadoMensualBoletasButton.Name = "ListadoMensualBoletasButton";
            this.ListadoMensualBoletasButton.Size = new System.Drawing.Size(226, 34);
            this.ListadoMensualBoletasButton.TabIndex = 3;
            this.ListadoMensualBoletasButton.Text = "Listado Mensual de Boletas";
            this.ListadoMensualBoletasButton.UseVisualStyleBackColor = true;
            this.ListadoMensualBoletasButton.Click += new System.EventHandler(this.ListadoMensualBoletasButton_Click);
            // 
            // DownloadPdfButton
            // 
            this.DownloadPdfButton.Location = new System.Drawing.Point(9, 129);
            this.DownloadPdfButton.Name = "DownloadPdfButton";
            this.DownloadPdfButton.Size = new System.Drawing.Size(226, 33);
            this.DownloadPdfButton.TabIndex = 2;
            this.DownloadPdfButton.Text = "Descargar PDF";
            this.DownloadPdfButton.UseVisualStyleBackColor = true;
            this.DownloadPdfButton.Click += new System.EventHandler(this.DownloadPdfButton_Click);
            // 
            // AnulaBoletaHonorarioButton
            // 
            this.AnulaBoletaHonorarioButton.Location = new System.Drawing.Point(9, 88);
            this.AnulaBoletaHonorarioButton.Name = "AnulaBoletaHonorarioButton";
            this.AnulaBoletaHonorarioButton.Size = new System.Drawing.Size(226, 35);
            this.AnulaBoletaHonorarioButton.TabIndex = 1;
            this.AnulaBoletaHonorarioButton.Text = "Anular Boleta de Honorarios";
            this.AnulaBoletaHonorarioButton.UseVisualStyleBackColor = true;
            this.AnulaBoletaHonorarioButton.Click += new System.EventHandler(this.AnulaBoletaHonorarioButton_Click);
            // 
            // CrearBoletaHonorariosButton
            // 
            this.CrearBoletaHonorariosButton.Location = new System.Drawing.Point(9, 27);
            this.CrearBoletaHonorariosButton.Name = "CrearBoletaHonorariosButton";
            this.CrearBoletaHonorariosButton.Size = new System.Drawing.Size(226, 55);
            this.CrearBoletaHonorariosButton.TabIndex = 0;
            this.CrearBoletaHonorariosButton.Text = "Generar Boleta de Honorarios";
            this.CrearBoletaHonorariosButton.UseVisualStyleBackColor = true;
            this.CrearBoletaHonorariosButton.Click += new System.EventHandler(this.CrearBoletaHonorariosButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.AnularCafMasivamenteButton);
            this.groupBox7.Controls.Add(this.ConsultarUltimosCincoCafButton);
            this.groupBox7.Controls.Add(this.ConsultarMaximoFoliosButton);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Location = new System.Drawing.Point(302, 453);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(285, 217);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Folios";
            // 
            // AnularCafMasivamenteButton
            // 
            this.AnularCafMasivamenteButton.Location = new System.Drawing.Point(9, 168);
            this.AnularCafMasivamenteButton.Name = "AnularCafMasivamenteButton";
            this.AnularCafMasivamenteButton.Size = new System.Drawing.Size(267, 36);
            this.AnularCafMasivamenteButton.TabIndex = 5;
            this.AnularCafMasivamenteButton.Text = "Anular Masivamente";
            this.AnularCafMasivamenteButton.UseVisualStyleBackColor = true;
            // 
            // ConsultarUltimosCincoCafButton
            // 
            this.ConsultarUltimosCincoCafButton.Location = new System.Drawing.Point(9, 129);
            this.ConsultarUltimosCincoCafButton.Name = "ConsultarUltimosCincoCafButton";
            this.ConsultarUltimosCincoCafButton.Size = new System.Drawing.Size(267, 33);
            this.ConsultarUltimosCincoCafButton.TabIndex = 2;
            this.ConsultarUltimosCincoCafButton.Text = "Consultar Folios Descargados";
            this.ConsultarUltimosCincoCafButton.UseVisualStyleBackColor = true;
            // 
            // ConsultarMaximoFoliosButton
            // 
            this.ConsultarMaximoFoliosButton.Location = new System.Drawing.Point(9, 88);
            this.ConsultarMaximoFoliosButton.Name = "ConsultarMaximoFoliosButton";
            this.ConsultarMaximoFoliosButton.Size = new System.Drawing.Size(267, 35);
            this.ConsultarMaximoFoliosButton.TabIndex = 1;
            this.ConsultarMaximoFoliosButton.Text = "Consultar Máximo de Folios";
            this.ConsultarMaximoFoliosButton.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(267, 55);
            this.button6.TabIndex = 0;
            this.button6.Text = "Generar Boleta de Honorarios";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 681);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.BoletaHonorarioGroupBox);
            this.Controls.Add(this.RegistroComprasVentasGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RegistroComprasVentasGroupBox.ResumeLayout(false);
            this.BoletaHonorarioGroupBox.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button AnularCafMasivamenteButton;
        private System.Windows.Forms.Button ConsultarUltimosCincoCafButton;
        private System.Windows.Forms.Button ConsultarMaximoFoliosButton;
        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.GroupBox BoletaHonorarioGroupBox;
        private System.Windows.Forms.Button CrearBoletaHonorariosButton;
        private System.Windows.Forms.Button AnulaBoletaHonorarioButton;
        private System.Windows.Forms.Button DownloadPdfButton;
        private System.Windows.Forms.Button ListadoMensualBoletasButton;
        private System.Windows.Forms.Button ListadoAnualBoletaButton;
        private System.Windows.Forms.Button EnviarEmailButton;

        private System.Windows.Forms.GroupBox RegistroComprasVentasGroupBox;
        private System.Windows.Forms.Button RegistroComprasButton;
        private System.Windows.Forms.Button RegistroVentasButton;

        #endregion
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.Button botonEnviarSii;
        private System.Windows.Forms.Button botonFacturaCompra;
        private System.Windows.Forms.Button botonMuestraImpresa;
        private System.Windows.Forms.Button botonLibroGuias;
        private System.Windows.Forms.Button botonSetExportacion2;
        private System.Windows.Forms.Button botonCesion;
        private System.Windows.Forms.Button botonSetExportacion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button botonConsultarEstadoEnvio;
        private System.Windows.Forms.Button botonValidador;
        private System.Windows.Forms.Button botonTimbre;
        private System.Windows.Forms.Button botonConsultarEstadoDTE;
        private System.Windows.Forms.Button botonGenerarNotaCredito;
        private System.Windows.Forms.Button botonGenerarRCOF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonGenerarDocumento;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboTipoEnvio;
        private System.Windows.Forms.Button botonGenerarSobreEnvio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
    }
}

