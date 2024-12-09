using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class ConsultarRegistroVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ResultadoGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.DatosConsultaGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RutUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.RutEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.RutEmpresaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.MensualCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.ResultadoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.DatosConsultaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultadoGroupBox
            // 
            this.ResultadoGroupBox.Controls.Add(this.dataGrid1);
            this.ResultadoGroupBox.Location = new System.Drawing.Point(9, 72);
            this.ResultadoGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultadoGroupBox.Name = "ResultadoGroupBox";
            this.ResultadoGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultadoGroupBox.Size = new System.Drawing.Size(769, 391);
            this.ResultadoGroupBox.TabIndex = 8;
            this.ResultadoGroupBox.TabStop = false;
            this.ResultadoGroupBox.Text = "Resultado";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(4, 20);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(760, 362);
            this.dataGrid1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioProduccion);
            this.groupBox1.Controls.Add(this.radioCertificacion);
            this.groupBox1.Location = new System.Drawing.Point(610, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(168, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ambiente";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(88, 28);
            this.radioProduccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(79, 17);
            this.radioProduccion.TabIndex = 1;
            this.radioProduccion.TabStop = true;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Location = new System.Drawing.Point(4, 28);
            this.radioCertificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(83, 17);
            this.radioCertificacion.TabIndex = 0;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // DatosConsultaGroupBox
            // 
            this.DatosConsultaGroupBox.Controls.Add(this.label1);
            this.DatosConsultaGroupBox.Controls.Add(this.RutUsuarioTextBox);
            this.DatosConsultaGroupBox.Controls.Add(this.RutEmpresaTextBox);
            this.DatosConsultaGroupBox.Controls.Add(this.RutEmpresaLabel);
            this.DatosConsultaGroupBox.Controls.Add(this.FechaDateTimePicker);
            this.DatosConsultaGroupBox.Controls.Add(this.FechaLabel);
            this.DatosConsultaGroupBox.Controls.Add(this.MensualCheckBox);
            this.DatosConsultaGroupBox.Location = new System.Drawing.Point(9, 9);
            this.DatosConsultaGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatosConsultaGroupBox.Name = "DatosConsultaGroupBox";
            this.DatosConsultaGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatosConsultaGroupBox.Size = new System.Drawing.Size(596, 59);
            this.DatosConsultaGroupBox.TabIndex = 12;
            this.DatosConsultaGroupBox.TabStop = false;
            this.DatosConsultaGroupBox.Text = "Datos Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "RUT Usuario:";
            // 
            // RutUsuarioTextBox
            // 
            this.RutUsuarioTextBox.Location = new System.Drawing.Point(230, 26);
            this.RutUsuarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RutUsuarioTextBox.Name = "RutUsuarioTextBox";
            this.RutUsuarioTextBox.Size = new System.Drawing.Size(68, 20);
            this.RutUsuarioTextBox.TabIndex = 16;
            // 
            // RutEmpresaTextBox
            // 
            this.RutEmpresaTextBox.Location = new System.Drawing.Point(83, 26);
            this.RutEmpresaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RutEmpresaTextBox.Name = "RutEmpresaTextBox";
            this.RutEmpresaTextBox.Size = new System.Drawing.Size(68, 20);
            this.RutEmpresaTextBox.TabIndex = 14;
            // 
            // RutEmpresaLabel
            // 
            this.RutEmpresaLabel.Location = new System.Drawing.Point(4, 28);
            this.RutEmpresaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RutEmpresaLabel.Name = "RutEmpresaLabel";
            this.RutEmpresaLabel.Size = new System.Drawing.Size(86, 15);
            this.RutEmpresaLabel.TabIndex = 13;
            this.RutEmpresaLabel.Text = "RUT Empresa:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(496, 28);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.FechaDateTimePicker.TabIndex = 12;
            // 
            // FechaLabel
            // 
            this.FechaLabel.Location = new System.Drawing.Point(451, 30);
            this.FechaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(40, 15);
            this.FechaLabel.TabIndex = 11;
            this.FechaLabel.Text = "Fecha:";
            // 
            // MensualCheckBox
            // 
            this.MensualCheckBox.Location = new System.Drawing.Point(309, 28);
            this.MensualCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MensualCheckBox.Name = "MensualCheckBox";
            this.MensualCheckBox.Size = new System.Drawing.Size(69, 15);
            this.MensualCheckBox.TabIndex = 9;
            this.MensualCheckBox.Text = "Mensual";
            this.MensualCheckBox.UseVisualStyleBackColor = true;
            this.MensualCheckBox.CheckedChanged += new System.EventHandler(this.MensualCheckBox_CheckedChanged);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(697, 467);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(81, 28);
            this.buttonConsultar.TabIndex = 14;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // ConsultarRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 505);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DatosConsultaGroupBox);
            this.Controls.Add(this.ResultadoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Registro de Ventas";
            this.Load += new System.EventHandler(this.ConsultarRegistroVentas_Load);
            this.ResultadoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DatosConsultaGroupBox.ResumeLayout(false);
            this.DatosConsultaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox ResultadoGroupBox;
        private System.Windows.Forms.DataGrid dataGrid1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.GroupBox DatosConsultaGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutUsuarioTextBox;
        private System.Windows.Forms.TextBox RutEmpresaTextBox;
        private System.Windows.Forms.Label RutEmpresaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.CheckBox MensualCheckBox;
        private System.Windows.Forms.Button buttonConsultar;
    }
}