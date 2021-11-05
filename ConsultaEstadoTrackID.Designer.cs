
namespace SimpleSDK_Demo
{
    partial class ConsultaEstadoTrackID
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEnvioDTE = new System.Windows.Forms.RadioButton();
            this.radioEnvioBoleta = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.textTrackID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDVEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRUTEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkServidorBoleta = new System.Windows.Forms.CheckBox();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRespuesta);
            this.groupBox3.Location = new System.Drawing.Point(300, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 300);
            this.groupBox3.TabIndex = 26;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEnvioDTE);
            this.groupBox1.Controls.Add(this.radioEnvioBoleta);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textTrackID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textDVEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textRUTEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 105);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del DTE";
            // 
            // radioEnvioDTE
            // 
            this.radioEnvioDTE.AutoSize = true;
            this.radioEnvioDTE.Checked = true;
            this.radioEnvioDTE.Location = new System.Drawing.Point(117, 75);
            this.radioEnvioDTE.Name = "radioEnvioDTE";
            this.radioEnvioDTE.Size = new System.Drawing.Size(74, 17);
            this.radioEnvioDTE.TabIndex = 22;
            this.radioEnvioDTE.TabStop = true;
            this.radioEnvioDTE.Text = "EnvioDTE";
            this.radioEnvioDTE.UseVisualStyleBackColor = true;
            // 
            // radioEnvioBoleta
            // 
            this.radioEnvioBoleta.AutoSize = true;
            this.radioEnvioBoleta.Location = new System.Drawing.Point(194, 75);
            this.radioEnvioBoleta.Name = "radioEnvioBoleta";
            this.radioEnvioBoleta.Size = new System.Drawing.Size(82, 17);
            this.radioEnvioBoleta.TabIndex = 23;
            this.radioEnvioBoleta.Text = "EnvioBoleta";
            this.radioEnvioBoleta.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "TrackID:";
            // 
            // textTrackID
            // 
            this.textTrackID.Location = new System.Drawing.Point(117, 49);
            this.textTrackID.Name = "textTrackID";
            this.textTrackID.Size = new System.Drawing.Size(112, 20);
            this.textTrackID.TabIndex = 20;
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
            this.textDVEmpresa.ReadOnly = true;
            this.textDVEmpresa.Size = new System.Drawing.Size(23, 20);
            this.textDVEmpresa.TabIndex = 12;
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
            this.textRUTEmpresa.ReadOnly = true;
            this.textRUTEmpresa.Size = new System.Drawing.Size(112, 20);
            this.textRUTEmpresa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkServidorBoleta);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.botonConsultar);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 83);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ambiente";
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
            // ConsultaEstadoTrackID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaEstadoTrackID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Estado por TrackID";
            this.Load += new System.EventHandler(this.ConsultaEstadoTrackID_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textRespuesta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEnvioDTE;
        private System.Windows.Forms.RadioButton radioEnvioBoleta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTrackID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDVEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRUTEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkServidorBoleta;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.Button botonConsultar;
    }
}