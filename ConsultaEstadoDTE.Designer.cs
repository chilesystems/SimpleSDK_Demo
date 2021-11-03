
namespace SimpleSDK_Demo
{
    partial class ConsultaEstadoDTE
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textRespuesta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textDVReceptor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textRUTReceptor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDVEnvio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDVEmpresa = new System.Windows.Forms.TextBox();
            this.dateFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.comboTipoDTE = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRUTEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRUTEmpresa = new System.Windows.Forms.TextBox();
            this.checkServidorBoleta = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRespuesta);
            this.groupBox3.Location = new System.Drawing.Point(300, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 300);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // textRespuesta
            // 
            this.textRespuesta.Location = new System.Drawing.Point(6, 23);
            this.textRespuesta.Multiline = true;
            this.textRespuesta.Name = "textRespuesta";
            this.textRespuesta.Size = new System.Drawing.Size(341, 271);
            this.textRespuesta.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkServidorBoleta);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.botonConsultar);
            this.groupBox2.Location = new System.Drawing.Point(6, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 83);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ambiente";
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Checked = true;
            this.radioCertificacion.Location = new System.Drawing.Point(9, 28);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 16;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(9, 51);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(79, 17);
            this.radioProduccion.TabIndex = 17;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(201, 48);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar.TabIndex = 0;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textFolio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textDVReceptor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textRUTReceptor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textDVEnvio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textDVEmpresa);
            this.groupBox1.Controls.Add(this.dateFechaEmision);
            this.groupBox1.Controls.Add(this.comboTipoDTE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textRUTEnvio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textRUTEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 211);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del DTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Folio:";
            // 
            // textFolio
            // 
            this.textFolio.Location = new System.Drawing.Point(117, 127);
            this.textFolio.Name = "textFolio";
            this.textFolio.Size = new System.Drawing.Size(112, 20);
            this.textFolio.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "-";
            // 
            // textDVReceptor
            // 
            this.textDVReceptor.Location = new System.Drawing.Point(253, 75);
            this.textDVReceptor.Name = "textDVReceptor";
            this.textDVReceptor.Size = new System.Drawing.Size(23, 20);
            this.textDVReceptor.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RUT Receptor:";
            // 
            // textRUTReceptor
            // 
            this.textRUTReceptor.Location = new System.Drawing.Point(117, 75);
            this.textRUTReceptor.Name = "textRUTReceptor";
            this.textRUTReceptor.Size = new System.Drawing.Size(112, 20);
            this.textRUTReceptor.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "-";
            // 
            // textDVEnvio
            // 
            this.textDVEnvio.Enabled = false;
            this.textDVEnvio.Location = new System.Drawing.Point(253, 49);
            this.textDVEnvio.Name = "textDVEnvio";
            this.textDVEnvio.Size = new System.Drawing.Size(23, 20);
            this.textDVEnvio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // textDVEmpresa
            // 
            this.textDVEmpresa.Enabled = false;
            this.textDVEmpresa.Location = new System.Drawing.Point(253, 23);
            this.textDVEmpresa.Name = "textDVEmpresa";
            this.textDVEmpresa.Size = new System.Drawing.Size(23, 20);
            this.textDVEmpresa.TabIndex = 12;
            // 
            // dateFechaEmision
            // 
            this.dateFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaEmision.Location = new System.Drawing.Point(117, 153);
            this.dateFechaEmision.Name = "dateFechaEmision";
            this.dateFechaEmision.Size = new System.Drawing.Size(112, 20);
            this.dateFechaEmision.TabIndex = 30;
            // 
            // comboTipoDTE
            // 
            this.comboTipoDTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDTE.FormattingEnabled = true;
            this.comboTipoDTE.Location = new System.Drawing.Point(117, 179);
            this.comboTipoDTE.Name = "comboTipoDTE";
            this.comboTipoDTE.Size = new System.Drawing.Size(159, 21);
            this.comboTipoDTE.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Emisión:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(117, 101);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(112, 20);
            this.textTotal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo DTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RUT Certificado:";
            // 
            // textRUTEnvio
            // 
            this.textRUTEnvio.Enabled = false;
            this.textRUTEnvio.Location = new System.Drawing.Point(117, 49);
            this.textRUTEnvio.Name = "textRUTEnvio";
            this.textRUTEnvio.Size = new System.Drawing.Size(112, 20);
            this.textRUTEnvio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RUT Empresa:";
            // 
            // textRUTEmpresa
            // 
            this.textRUTEmpresa.Enabled = false;
            this.textRUTEmpresa.Location = new System.Drawing.Point(117, 23);
            this.textRUTEmpresa.Name = "textRUTEmpresa";
            this.textRUTEmpresa.Size = new System.Drawing.Size(112, 20);
            this.textRUTEmpresa.TabIndex = 0;
            // 
            // checkServidorBoleta
            // 
            this.checkServidorBoleta.AutoSize = true;
            this.checkServidorBoleta.Location = new System.Drawing.Point(158, 28);
            this.checkServidorBoleta.Name = "checkServidorBoleta";
            this.checkServidorBoleta.Size = new System.Drawing.Size(118, 17);
            this.checkServidorBoleta.TabIndex = 18;
            this.checkServidorBoleta.Text = "Servidor de Boletas";
            this.checkServidorBoleta.UseVisualStyleBackColor = true;
            // 
            // ConsultaEstadoDTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 322);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaEstadoDTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Estado de DTE";
            this.Load += new System.EventHandler(this.ConsultaEstadoDTE_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textRespuesta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textFolio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textDVReceptor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textRUTReceptor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDVEnvio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDVEmpresa;
        private System.Windows.Forms.DateTimePicker dateFechaEmision;
        private System.Windows.Forms.ComboBox comboTipoDTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRUTEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRUTEmpresa;
        private System.Windows.Forms.CheckBox checkServidorBoleta;
    }
}