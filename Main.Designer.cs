
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTipoEnvio = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RegistroComprasVentasGroupBox = new System.Windows.Forms.GroupBox();
            this.RegistroVentasButton = new System.Windows.Forms.Button();
            this.RegistroComprasButton = new System.Windows.Forms.Button();
            this.FoliosGroupBox = new System.Windows.Forms.GroupBox();
            this.AnularCafMasivamenteButton = new System.Windows.Forms.Button();
            this.ConsultarUltimosCincoCafButton = new System.Windows.Forms.Button();
            this.ConsultarMaximoFoliosButton = new System.Windows.Forms.Button();
            this.DescargarCafButton = new System.Windows.Forms.Button();
            this.BoletaHonorarioGroupBox = new System.Windows.Forms.GroupBox();
            this.EnviarEmailButton = new System.Windows.Forms.Button();
            this.ListadoAnualBoletaButton = new System.Windows.Forms.Button();
            this.ListadoMensualBoletasButton = new System.Windows.Forms.Button();
            this.DownloadPdfButton = new System.Windows.Forms.Button();
            this.AnulaBoletaHonorarioButton = new System.Windows.Forms.Button();
            this.CrearBoletaHonorariosButton = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.RegistroComprasVentasGroupBox.SuspendLayout();
            this.FoliosGroupBox.SuspendLayout();
            this.BoletaHonorarioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(12, 62);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(101, 20);
            this.radioCertificacion.TabIndex = 14;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(135, 62);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(96, 20);
            this.radioProduccion.TabIndex = 15;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // botonEnviarSii
            // 
            this.botonEnviarSii.Location = new System.Drawing.Point(7, 91);
            this.botonEnviarSii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonEnviarSii.Name = "botonEnviarSii";
            this.botonEnviarSii.Size = new System.Drawing.Size(228, 28);
            this.botonEnviarSii.TabIndex = 3;
            this.botonEnviarSii.Text = "Enviar un archivo al SII";
            this.botonEnviarSii.UseVisualStyleBackColor = true;
            this.botonEnviarSii.Click += new System.EventHandler(this.botonEnviarSii_Click);
            // 
            // botonFacturaCompra
            // 
            this.botonFacturaCompra.Location = new System.Drawing.Point(8, 23);
            this.botonFacturaCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonFacturaCompra.Name = "botonFacturaCompra";
            this.botonFacturaCompra.Size = new System.Drawing.Size(237, 28);
            this.botonFacturaCompra.TabIndex = 21;
            this.botonFacturaCompra.Text = "Factura de Compra";
            this.botonFacturaCompra.UseVisualStyleBackColor = true;
            this.botonFacturaCompra.Click += new System.EventHandler(this.botonFacturaCompra_Click);
            // 
            // botonMuestraImpresa
            // 
            this.botonMuestraImpresa.Location = new System.Drawing.Point(8, 62);
            this.botonMuestraImpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonMuestraImpresa.Name = "botonMuestraImpresa";
            this.botonMuestraImpresa.Size = new System.Drawing.Size(237, 28);
            this.botonMuestraImpresa.TabIndex = 19;
            this.botonMuestraImpresa.Text = "Muestra Impresa";
            this.botonMuestraImpresa.UseVisualStyleBackColor = true;
            this.botonMuestraImpresa.Click += new System.EventHandler(this.botonMuestraImpresa_Click);
            // 
            // botonLibroGuias
            // 
            this.botonLibroGuias.Location = new System.Drawing.Point(8, 130);
            this.botonLibroGuias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonLibroGuias.Name = "botonLibroGuias";
            this.botonLibroGuias.Size = new System.Drawing.Size(237, 28);
            this.botonLibroGuias.TabIndex = 18;
            this.botonLibroGuias.Text = "Libro de Guías";
            this.botonLibroGuias.UseVisualStyleBackColor = true;
            this.botonLibroGuias.Click += new System.EventHandler(this.botonLibroGuias_ClickAsync);
            // 
            // botonCesion
            // 
            this.botonCesion.Location = new System.Drawing.Point(8, 59);
            this.botonCesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonCesion.Name = "botonCesion";
            this.botonCesion.Size = new System.Drawing.Size(237, 28);
            this.botonCesion.TabIndex = 19;
            this.botonCesion.Text = "Cesión de Documentos";
            this.botonCesion.UseVisualStyleBackColor = true;
            this.botonCesion.Click += new System.EventHandler(this.botonCesion_ClickAsync);
            // 
            // botonSetExportacion
            // 
            this.botonSetExportacion.Location = new System.Drawing.Point(8, 95);
            this.botonSetExportacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonSetExportacion.Name = "botonSetExportacion";
            this.botonSetExportacion.Size = new System.Drawing.Size(237, 28);
            this.botonSetExportacion.TabIndex = 17;
            this.botonSetExportacion.Text = "Generar Doc. de Exportación";
            this.botonSetExportacion.UseVisualStyleBackColor = true;
            this.botonSetExportacion.Click += new System.EventHandler(this.botonSetExportacion_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.botonConsultarEstadoEnvio);
            this.groupBox5.Controls.Add(this.botonValidador);
            this.groupBox5.Controls.Add(this.botonConsultarEstadoDTE);
            this.groupBox5.Location = new System.Drawing.Point(520, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(217, 132);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Utilidades";
            // 
            // botonConsultarEstadoEnvio
            // 
            this.botonConsultarEstadoEnvio.Location = new System.Drawing.Point(8, 59);
            this.botonConsultarEstadoEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonConsultarEstadoEnvio.Name = "botonConsultarEstadoEnvio";
            this.botonConsultarEstadoEnvio.Size = new System.Drawing.Size(201, 28);
            this.botonConsultarEstadoEnvio.TabIndex = 18;
            this.botonConsultarEstadoEnvio.Text = "Consultar Estado Envío";
            this.botonConsultarEstadoEnvio.UseVisualStyleBackColor = true;
            this.botonConsultarEstadoEnvio.Click += new System.EventHandler(this.botonConsultarEstadoEnvio_Click);
            // 
            // botonValidador
            // 
            this.botonValidador.Location = new System.Drawing.Point(8, 95);
            this.botonValidador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonValidador.Name = "botonValidador";
            this.botonValidador.Size = new System.Drawing.Size(201, 28);
            this.botonValidador.TabIndex = 17;
            this.botonValidador.Text = "Validador";
            this.botonValidador.UseVisualStyleBackColor = true;
            this.botonValidador.Click += new System.EventHandler(this.botonValidador_Click);
            // 
            // botonConsultarEstadoDTE
            // 
            this.botonConsultarEstadoDTE.Location = new System.Drawing.Point(8, 23);
            this.botonConsultarEstadoDTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonConsultarEstadoDTE.Name = "botonConsultarEstadoDTE";
            this.botonConsultarEstadoDTE.Size = new System.Drawing.Size(201, 28);
            this.botonConsultarEstadoDTE.TabIndex = 1;
            this.botonConsultarEstadoDTE.Text = "Consultar Estado DTE";
            this.botonConsultarEstadoDTE.UseVisualStyleBackColor = true;
            this.botonConsultarEstadoDTE.Click += new System.EventHandler(this.botonConsultarEstadoDTE_Click);
            // 
            // botonTimbre
            // 
            this.botonTimbre.Location = new System.Drawing.Point(8, 30);
            this.botonTimbre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonTimbre.Name = "botonTimbre";
            this.botonTimbre.Size = new System.Drawing.Size(237, 28);
            this.botonTimbre.TabIndex = 12;
            this.botonTimbre.Text = "Imagen del Timbre";
            this.botonTimbre.UseVisualStyleBackColor = true;
            this.botonTimbre.Click += new System.EventHandler(this.botonTimbre_Click);
            // 
            // botonGenerarNotaCredito
            // 
            this.botonGenerarNotaCredito.Location = new System.Drawing.Point(8, 59);
            this.botonGenerarNotaCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonGenerarNotaCredito.Name = "botonGenerarNotaCredito";
            this.botonGenerarNotaCredito.Size = new System.Drawing.Size(228, 28);
            this.botonGenerarNotaCredito.TabIndex = 3;
            this.botonGenerarNotaCredito.Text = "Notas de Crédito";
            this.botonGenerarNotaCredito.UseVisualStyleBackColor = true;
            this.botonGenerarNotaCredito.Click += new System.EventHandler(this.botonGenerarNotaCredito_Click);
            // 
            // botonGenerarRCOF
            // 
            this.botonGenerarRCOF.Location = new System.Drawing.Point(8, 130);
            this.botonGenerarRCOF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonGenerarRCOF.Name = "botonGenerarRCOF";
            this.botonGenerarRCOF.Size = new System.Drawing.Size(228, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(244, 176);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación de Documentos";
            // 
            // botonGenerarSobreEnvio
            // 
            this.botonGenerarSobreEnvio.Location = new System.Drawing.Point(8, 95);
            this.botonGenerarSobreEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonGenerarSobreEnvio.Name = "botonGenerarSobreEnvio";
            this.botonGenerarSobreEnvio.Size = new System.Drawing.Size(228, 28);
            this.botonGenerarSobreEnvio.TabIndex = 4;
            this.botonGenerarSobreEnvio.Text = "Generar Sobre Envio";
            this.botonGenerarSobreEnvio.UseVisualStyleBackColor = true;
            this.botonGenerarSobreEnvio.Click += new System.EventHandler(this.botonGenerarSobreEnvio_Click);
            // 
            // botonGenerarDocumento
            // 
            this.botonGenerarDocumento.Location = new System.Drawing.Point(8, 23);
            this.botonGenerarDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonGenerarDocumento.Name = "botonGenerarDocumento";
            this.botonGenerarDocumento.Size = new System.Drawing.Size(228, 28);
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
            this.groupBox6.Location = new System.Drawing.Point(259, 7);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(253, 176);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Otros DTE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botonTimbre);
            this.groupBox3.Controls.Add(this.botonMuestraImpresa);
            this.groupBox3.Location = new System.Drawing.Point(259, 191);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(253, 101);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documentos Impresos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.comboTipoEnvio);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.botonEnviarSii);
            this.groupBox2.Location = new System.Drawing.Point(7, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(244, 127);
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
            "LibroGuia"});
            this.comboTipoEnvio.Location = new System.Drawing.Point(8, 30);
            this.comboTipoEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTipoEnvio.Name = "comboTipoEnvio";
            this.comboTipoEnvio.Size = new System.Drawing.Size(227, 24);
            this.comboTipoEnvio.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(779, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Image = global::SimpleSDK_Demo.Properties.Resources.ConfiguracionEdit16;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 357);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(749, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SimpleAPI - Facturación Electrónica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RegistroComprasVentasGroupBox);
            this.tabPage2.Controls.Add(this.FoliosGroupBox);
            this.tabPage2.Controls.Add(this.BoletaHonorarioGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(749, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SimpleAPI - Servicios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RegistroComprasVentasGroupBox
            // 
            this.RegistroComprasVentasGroupBox.Controls.Add(this.RegistroVentasButton);
            this.RegistroComprasVentasGroupBox.Controls.Add(this.RegistroComprasButton);
            this.RegistroComprasVentasGroupBox.Location = new System.Drawing.Point(5, 5);
            this.RegistroComprasVentasGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistroComprasVentasGroupBox.Name = "RegistroComprasVentasGroupBox";
            this.RegistroComprasVentasGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistroComprasVentasGroupBox.Size = new System.Drawing.Size(253, 92);
            this.RegistroComprasVentasGroupBox.TabIndex = 38;
            this.RegistroComprasVentasGroupBox.TabStop = false;
            this.RegistroComprasVentasGroupBox.Text = "Registro de Compras y Ventas";
            // 
            // RegistroVentasButton
            // 
            this.RegistroVentasButton.Location = new System.Drawing.Point(8, 59);
            this.RegistroVentasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistroVentasButton.Name = "RegistroVentasButton";
            this.RegistroVentasButton.Size = new System.Drawing.Size(216, 28);
            this.RegistroVentasButton.TabIndex = 1;
            this.RegistroVentasButton.Text = "Registro de Ventas";
            this.RegistroVentasButton.UseVisualStyleBackColor = true;
            this.RegistroVentasButton.Click += new System.EventHandler(this.RegistroVentasButton_Click);
            // 
            // RegistroComprasButton
            // 
            this.RegistroComprasButton.Location = new System.Drawing.Point(8, 27);
            this.RegistroComprasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistroComprasButton.Name = "RegistroComprasButton";
            this.RegistroComprasButton.Size = new System.Drawing.Size(216, 28);
            this.RegistroComprasButton.TabIndex = 0;
            this.RegistroComprasButton.Text = "Registro de Compras";
            this.RegistroComprasButton.UseVisualStyleBackColor = true;
            this.RegistroComprasButton.Click += new System.EventHandler(this.RegistroComprasButton_Click);
            // 
            // FoliosGroupBox
            // 
            this.FoliosGroupBox.Controls.Add(this.AnularCafMasivamenteButton);
            this.FoliosGroupBox.Controls.Add(this.ConsultarUltimosCincoCafButton);
            this.FoliosGroupBox.Controls.Add(this.ConsultarMaximoFoliosButton);
            this.FoliosGroupBox.Controls.Add(this.DescargarCafButton);
            this.FoliosGroupBox.Location = new System.Drawing.Point(5, 101);
            this.FoliosGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoliosGroupBox.Name = "FoliosGroupBox";
            this.FoliosGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoliosGroupBox.Size = new System.Drawing.Size(253, 155);
            this.FoliosGroupBox.TabIndex = 40;
            this.FoliosGroupBox.TabStop = false;
            this.FoliosGroupBox.Text = "Folios";
            // 
            // AnularCafMasivamenteButton
            // 
            this.AnularCafMasivamenteButton.Location = new System.Drawing.Point(8, 118);
            this.AnularCafMasivamenteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnularCafMasivamenteButton.Name = "AnularCafMasivamenteButton";
            this.AnularCafMasivamenteButton.Size = new System.Drawing.Size(216, 28);
            this.AnularCafMasivamenteButton.TabIndex = 5;
            this.AnularCafMasivamenteButton.Text = "Anular Masivamente";
            this.AnularCafMasivamenteButton.UseVisualStyleBackColor = true;
            this.AnularCafMasivamenteButton.Click += new System.EventHandler(this.AnularCafMasivamenteButton_Click);
            // 
            // ConsultarUltimosCincoCafButton
            // 
            this.ConsultarUltimosCincoCafButton.Location = new System.Drawing.Point(8, 86);
            this.ConsultarUltimosCincoCafButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsultarUltimosCincoCafButton.Name = "ConsultarUltimosCincoCafButton";
            this.ConsultarUltimosCincoCafButton.Size = new System.Drawing.Size(216, 28);
            this.ConsultarUltimosCincoCafButton.TabIndex = 2;
            this.ConsultarUltimosCincoCafButton.Text = "Consultar Folios Descargados";
            this.ConsultarUltimosCincoCafButton.UseVisualStyleBackColor = true;
            this.ConsultarUltimosCincoCafButton.Click += new System.EventHandler(this.ConsultarUltimosCincoCafButton_Click);
            // 
            // ConsultarMaximoFoliosButton
            // 
            this.ConsultarMaximoFoliosButton.Location = new System.Drawing.Point(8, 54);
            this.ConsultarMaximoFoliosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsultarMaximoFoliosButton.Name = "ConsultarMaximoFoliosButton";
            this.ConsultarMaximoFoliosButton.Size = new System.Drawing.Size(216, 28);
            this.ConsultarMaximoFoliosButton.TabIndex = 1;
            this.ConsultarMaximoFoliosButton.Text = "Consultar Máximo de Folios";
            this.ConsultarMaximoFoliosButton.UseVisualStyleBackColor = true;
            this.ConsultarMaximoFoliosButton.Click += new System.EventHandler(this.ConsultarMaximoFoliosButton_Click);
            // 
            // DescargarCafButton
            // 
            this.DescargarCafButton.Location = new System.Drawing.Point(8, 22);
            this.DescargarCafButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescargarCafButton.Name = "DescargarCafButton";
            this.DescargarCafButton.Size = new System.Drawing.Size(216, 28);
            this.DescargarCafButton.TabIndex = 0;
            this.DescargarCafButton.Text = "Descargar CAF";
            this.DescargarCafButton.UseVisualStyleBackColor = true;
            this.DescargarCafButton.Click += new System.EventHandler(this.DescargarCafButton_Click);
            // 
            // BoletaHonorarioGroupBox
            // 
            this.BoletaHonorarioGroupBox.Controls.Add(this.EnviarEmailButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.ListadoAnualBoletaButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.ListadoMensualBoletasButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.DownloadPdfButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.AnulaBoletaHonorarioButton);
            this.BoletaHonorarioGroupBox.Controls.Add(this.CrearBoletaHonorariosButton);
            this.BoletaHonorarioGroupBox.Location = new System.Drawing.Point(265, 5);
            this.BoletaHonorarioGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoletaHonorarioGroupBox.Name = "BoletaHonorarioGroupBox";
            this.BoletaHonorarioGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoletaHonorarioGroupBox.Size = new System.Drawing.Size(259, 251);
            this.BoletaHonorarioGroupBox.TabIndex = 39;
            this.BoletaHonorarioGroupBox.TabStop = false;
            this.BoletaHonorarioGroupBox.Text = "Boletas de Honorarios";
            // 
            // EnviarEmailButton
            // 
            this.EnviarEmailButton.Location = new System.Drawing.Point(8, 118);
            this.EnviarEmailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnviarEmailButton.Name = "EnviarEmailButton";
            this.EnviarEmailButton.Size = new System.Drawing.Size(237, 28);
            this.EnviarEmailButton.TabIndex = 5;
            this.EnviarEmailButton.Text = "Enviar por email";
            this.EnviarEmailButton.UseVisualStyleBackColor = true;
            this.EnviarEmailButton.Click += new System.EventHandler(this.EnviarEmailButton_Click);
            // 
            // ListadoAnualBoletaButton
            // 
            this.ListadoAnualBoletaButton.Location = new System.Drawing.Point(8, 182);
            this.ListadoAnualBoletaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListadoAnualBoletaButton.Name = "ListadoAnualBoletaButton";
            this.ListadoAnualBoletaButton.Size = new System.Drawing.Size(237, 28);
            this.ListadoAnualBoletaButton.TabIndex = 4;
            this.ListadoAnualBoletaButton.Text = "Listado Anual de Boletas";
            this.ListadoAnualBoletaButton.UseVisualStyleBackColor = true;
            this.ListadoAnualBoletaButton.Click += new System.EventHandler(this.ListadoAnualBoletaButton_Click);
            // 
            // ListadoMensualBoletasButton
            // 
            this.ListadoMensualBoletasButton.Location = new System.Drawing.Point(8, 150);
            this.ListadoMensualBoletasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListadoMensualBoletasButton.Name = "ListadoMensualBoletasButton";
            this.ListadoMensualBoletasButton.Size = new System.Drawing.Size(237, 28);
            this.ListadoMensualBoletasButton.TabIndex = 3;
            this.ListadoMensualBoletasButton.Text = "Listado Mensual de Boletas";
            this.ListadoMensualBoletasButton.UseVisualStyleBackColor = true;
            this.ListadoMensualBoletasButton.Click += new System.EventHandler(this.ListadoMensualBoletasButton_Click);
            // 
            // DownloadPdfButton
            // 
            this.DownloadPdfButton.Location = new System.Drawing.Point(8, 86);
            this.DownloadPdfButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownloadPdfButton.Name = "DownloadPdfButton";
            this.DownloadPdfButton.Size = new System.Drawing.Size(237, 28);
            this.DownloadPdfButton.TabIndex = 2;
            this.DownloadPdfButton.Text = "Descargar PDF";
            this.DownloadPdfButton.UseVisualStyleBackColor = true;
            this.DownloadPdfButton.Click += new System.EventHandler(this.DownloadPdfButton_Click);
            // 
            // AnulaBoletaHonorarioButton
            // 
            this.AnulaBoletaHonorarioButton.Location = new System.Drawing.Point(8, 54);
            this.AnulaBoletaHonorarioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnulaBoletaHonorarioButton.Name = "AnulaBoletaHonorarioButton";
            this.AnulaBoletaHonorarioButton.Size = new System.Drawing.Size(237, 28);
            this.AnulaBoletaHonorarioButton.TabIndex = 1;
            this.AnulaBoletaHonorarioButton.Text = "Anular Boleta de Honorarios";
            this.AnulaBoletaHonorarioButton.UseVisualStyleBackColor = true;
            this.AnulaBoletaHonorarioButton.Click += new System.EventHandler(this.AnulaBoletaHonorarioButton_Click);
            // 
            // CrearBoletaHonorariosButton
            // 
            this.CrearBoletaHonorariosButton.Location = new System.Drawing.Point(8, 22);
            this.CrearBoletaHonorariosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrearBoletaHonorariosButton.Name = "CrearBoletaHonorariosButton";
            this.CrearBoletaHonorariosButton.Size = new System.Drawing.Size(237, 28);
            this.CrearBoletaHonorariosButton.TabIndex = 0;
            this.CrearBoletaHonorariosButton.Text = "Generar Boleta de Honorarios";
            this.CrearBoletaHonorariosButton.UseVisualStyleBackColor = true;
            this.CrearBoletaHonorariosButton.Click += new System.EventHandler(this.CrearBoletaHonorariosButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 407);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.RegistroComprasVentasGroupBox.ResumeLayout(false);
            this.FoliosGroupBox.ResumeLayout(false);
            this.BoletaHonorarioGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboTipoEnvio;
        private System.Windows.Forms.Button botonGenerarSobreEnvio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox RegistroComprasVentasGroupBox;
        private System.Windows.Forms.Button RegistroVentasButton;
        private System.Windows.Forms.Button RegistroComprasButton;
        private System.Windows.Forms.GroupBox FoliosGroupBox;
        private System.Windows.Forms.Button AnularCafMasivamenteButton;
        private System.Windows.Forms.Button ConsultarUltimosCincoCafButton;
        private System.Windows.Forms.Button ConsultarMaximoFoliosButton;
        private System.Windows.Forms.Button DescargarCafButton;
        private System.Windows.Forms.GroupBox BoletaHonorarioGroupBox;
        private System.Windows.Forms.Button EnviarEmailButton;
        private System.Windows.Forms.Button ListadoAnualBoletaButton;
        private System.Windows.Forms.Button ListadoMensualBoletasButton;
        private System.Windows.Forms.Button DownloadPdfButton;
        private System.Windows.Forms.Button AnulaBoletaHonorarioButton;
        private System.Windows.Forms.Button CrearBoletaHonorariosButton;
    }
}

