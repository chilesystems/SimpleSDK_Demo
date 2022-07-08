using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class ConsultarRegistroCompras
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
            this.DatosConsultaGroupBox = new System.Windows.Forms.GroupBox();
            this.RutUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.RutEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.RutEmpresaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.MensualCheckBox = new System.Windows.Forms.CheckBox();
            this.checkDetallado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.ResultadoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.DatosConsultaGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultadoGroupBox
            // 
            this.ResultadoGroupBox.Controls.Add(this.dataGrid1);
            this.ResultadoGroupBox.Location = new System.Drawing.Point(11, 87);
            this.ResultadoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultadoGroupBox.Name = "ResultadoGroupBox";
            this.ResultadoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultadoGroupBox.Size = new System.Drawing.Size(1025, 454);
            this.ResultadoGroupBox.TabIndex = 6;
            this.ResultadoGroupBox.TabStop = false;
            this.ResultadoGroupBox.Text = "Resultado";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(5, 25);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(1014, 425);
            this.dataGrid1.TabIndex = 0;
            // 
            // DatosConsultaGroupBox
            // 
            this.DatosConsultaGroupBox.Controls.Add(this.label1);
            this.DatosConsultaGroupBox.Controls.Add(this.checkDetallado);
            this.DatosConsultaGroupBox.Controls.Add(this.RutUsuarioTextBox);
            this.DatosConsultaGroupBox.Controls.Add(this.RutEmpresaTextBox);
            this.DatosConsultaGroupBox.Controls.Add(this.RutEmpresaLabel);
            this.DatosConsultaGroupBox.Controls.Add(this.FechaDateTimePicker);
            this.DatosConsultaGroupBox.Controls.Add(this.FechaLabel);
            this.DatosConsultaGroupBox.Controls.Add(this.MensualCheckBox);
            this.DatosConsultaGroupBox.Location = new System.Drawing.Point(11, 10);
            this.DatosConsultaGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatosConsultaGroupBox.Name = "DatosConsultaGroupBox";
            this.DatosConsultaGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatosConsultaGroupBox.Size = new System.Drawing.Size(795, 73);
            this.DatosConsultaGroupBox.TabIndex = 7;
            this.DatosConsultaGroupBox.TabStop = false;
            this.DatosConsultaGroupBox.Text = "Datos Consulta";
            // 
            // RutUsuarioTextBox
            // 
            this.RutUsuarioTextBox.Location = new System.Drawing.Point(306, 32);
            this.RutUsuarioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RutUsuarioTextBox.Name = "RutUsuarioTextBox";
            this.RutUsuarioTextBox.Size = new System.Drawing.Size(89, 22);
            this.RutUsuarioTextBox.TabIndex = 16;
            // 
            // RutEmpresaTextBox
            // 
            this.RutEmpresaTextBox.Location = new System.Drawing.Point(111, 32);
            this.RutEmpresaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RutEmpresaTextBox.Name = "RutEmpresaTextBox";
            this.RutEmpresaTextBox.Size = new System.Drawing.Size(89, 22);
            this.RutEmpresaTextBox.TabIndex = 14;
            // 
            // RutEmpresaLabel
            // 
            this.RutEmpresaLabel.Location = new System.Drawing.Point(6, 35);
            this.RutEmpresaLabel.Name = "RutEmpresaLabel";
            this.RutEmpresaLabel.Size = new System.Drawing.Size(114, 18);
            this.RutEmpresaLabel.TabIndex = 13;
            this.RutEmpresaLabel.Text = "RUT Empresa:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(662, 34);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.FechaDateTimePicker.TabIndex = 12;
            // 
            // FechaLabel
            // 
            this.FechaLabel.Location = new System.Drawing.Point(601, 37);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(54, 18);
            this.FechaLabel.TabIndex = 11;
            this.FechaLabel.Text = "Fecha:";
            // 
            // MensualCheckBox
            // 
            this.MensualCheckBox.Location = new System.Drawing.Point(412, 35);
            this.MensualCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MensualCheckBox.Name = "MensualCheckBox";
            this.MensualCheckBox.Size = new System.Drawing.Size(92, 19);
            this.MensualCheckBox.TabIndex = 9;
            this.MensualCheckBox.Text = "Mensual";
            this.MensualCheckBox.UseVisualStyleBackColor = true;
            this.MensualCheckBox.CheckedChanged += new System.EventHandler(this.MensualCheckBox_CheckedChanged);
            // 
            // checkDetallado
            // 
            this.checkDetallado.Location = new System.Drawing.Point(503, 35);
            this.checkDetallado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkDetallado.Name = "checkDetallado";
            this.checkDetallado.Size = new System.Drawing.Size(97, 19);
            this.checkDetallado.TabIndex = 17;
            this.checkDetallado.Text = "Detallado";
            this.checkDetallado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "RUT Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioProduccion);
            this.groupBox1.Controls.Add(this.radioCertificacion);
            this.groupBox1.Location = new System.Drawing.Point(812, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 71);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ambiente";
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Location = new System.Drawing.Point(6, 35);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(106, 21);
            this.radioCertificacion.TabIndex = 0;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(118, 35);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(100, 21);
            this.radioProduccion.TabIndex = 1;
            this.radioProduccion.TabStop = true;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(928, 548);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(108, 35);
            this.buttonConsultar.TabIndex = 10;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // ConsultarRegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.DatosConsultaGroupBox);
            this.Controls.Add(this.ResultadoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarRegistroCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Registro de Compras";
            this.Load += new System.EventHandler(this.ConsultarRegistroCompras_Load);
            this.ResultadoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.DatosConsultaGroupBox.ResumeLayout(false);
            this.DatosConsultaGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox RutUsuarioTextBox;
        private System.Windows.Forms.TextBox RutEmpresaTextBox;
        private System.Windows.Forms.Label RutEmpresaLabel;

        private System.Windows.Forms.DataGrid dataGrid1;

        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;

        private System.Windows.Forms.GroupBox ResultadoGroupBox;

        private System.Windows.Forms.GroupBox DatosConsultaGroupBox;

        private System.Windows.Forms.Label FechaLabel;

        private System.Windows.Forms.CheckBox MensualCheckBox;
        private System.Windows.Forms.Button buttonConsultar;

        #endregion

        private System.Windows.Forms.CheckBox checkDetallado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
    }
}