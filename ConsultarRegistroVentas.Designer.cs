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
            this.DatosConsultaGroupBox = new System.Windows.Forms.GroupBox();
            this.RutUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.RutUsuarioLabel = new System.Windows.Forms.Label();
            this.RutEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.RutEmpresaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.MensualCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultadoGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.DatosConsultaGroupBox.SuspendLayout();
            this.ResultadoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosConsultaGroupBox
            // 
            this.DatosConsultaGroupBox.Controls.Add(this.RutUsuarioTextBox);
            this.DatosConsultaGroupBox.Controls.Add(this.RutUsuarioLabel);
            this.DatosConsultaGroupBox.Controls.Add(this.RutEmpresaTextBox);
            this.DatosConsultaGroupBox.Controls.Add(this.RutEmpresaLabel);
            this.DatosConsultaGroupBox.Controls.Add(this.FechaDateTimePicker);
            this.DatosConsultaGroupBox.Controls.Add(this.FechaLabel);
            this.DatosConsultaGroupBox.Controls.Add(this.buttonConsultar);
            this.DatosConsultaGroupBox.Controls.Add(this.MensualCheckBox);
            this.DatosConsultaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DatosConsultaGroupBox.Name = "DatosConsultaGroupBox";
            this.DatosConsultaGroupBox.Size = new System.Drawing.Size(776, 113);
            this.DatosConsultaGroupBox.TabIndex = 9;
            this.DatosConsultaGroupBox.TabStop = false;
            this.DatosConsultaGroupBox.Text = "Datos Consulta";
            // 
            // RutUsuarioTextBox
            // 
            this.RutUsuarioTextBox.Location = new System.Drawing.Point(410, 17);
            this.RutUsuarioTextBox.Name = "RutUsuarioTextBox";
            this.RutUsuarioTextBox.Size = new System.Drawing.Size(100, 26);
            this.RutUsuarioTextBox.TabIndex = 16;
            // 
            // RutUsuarioLabel
            // 
            this.RutUsuarioLabel.Location = new System.Drawing.Point(276, 20);
            this.RutUsuarioLabel.Name = "RutUsuarioLabel";
            this.RutUsuarioLabel.Size = new System.Drawing.Size(128, 23);
            this.RutUsuarioLabel.TabIndex = 15;
            this.RutUsuarioLabel.Text = "RUT Usuario";
            // 
            // RutEmpresaTextBox
            // 
            this.RutEmpresaTextBox.Location = new System.Drawing.Point(161, 20);
            this.RutEmpresaTextBox.Name = "RutEmpresaTextBox";
            this.RutEmpresaTextBox.Size = new System.Drawing.Size(100, 26);
            this.RutEmpresaTextBox.TabIndex = 14;
            // 
            // RutEmpresaLabel
            // 
            this.RutEmpresaLabel.Location = new System.Drawing.Point(32, 23);
            this.RutEmpresaLabel.Name = "RutEmpresaLabel";
            this.RutEmpresaLabel.Size = new System.Drawing.Size(128, 23);
            this.RutEmpresaLabel.TabIndex = 13;
            this.RutEmpresaLabel.Text = "RUT Empresa";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(96, 69);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FechaDateTimePicker.TabIndex = 12;
            // 
            // FechaLabel
            // 
            this.FechaLabel.Location = new System.Drawing.Point(36, 69);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(54, 23);
            this.FechaLabel.TabIndex = 11;
            this.FechaLabel.Text = "Fecha";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(626, 51);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(122, 44);
            this.buttonConsultar.TabIndex = 10;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // MensualCheckBox
            // 
            this.MensualCheckBox.Location = new System.Drawing.Point(428, 71);
            this.MensualCheckBox.Name = "MensualCheckBox";
            this.MensualCheckBox.Size = new System.Drawing.Size(104, 24);
            this.MensualCheckBox.TabIndex = 9;
            this.MensualCheckBox.Text = "Mensual";
            this.MensualCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultadoGroupBox
            // 
            this.ResultadoGroupBox.Controls.Add(this.dataGrid1);
            this.ResultadoGroupBox.Location = new System.Drawing.Point(12, 140);
            this.ResultadoGroupBox.Name = "ResultadoGroupBox";
            this.ResultadoGroupBox.Size = new System.Drawing.Size(776, 309);
            this.ResultadoGroupBox.TabIndex = 8;
            this.ResultadoGroupBox.TabStop = false;
            this.ResultadoGroupBox.Text = "Resultado";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(6, 31);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(764, 264);
            this.dataGrid1.TabIndex = 0;
            // 
            // ConsultarRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 466);
            this.Controls.Add(this.DatosConsultaGroupBox);
            this.Controls.Add(this.ResultadoGroupBox);
            this.Name = "ConsultarRegistroVentas";
            this.Text = "Consultar Registro de Ventas";
            this.DatosConsultaGroupBox.ResumeLayout(false);
            this.DatosConsultaGroupBox.PerformLayout();
            this.ResultadoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox DatosConsultaGroupBox;
        private System.Windows.Forms.TextBox RutUsuarioTextBox;
        private System.Windows.Forms.Label RutUsuarioLabel;
        private System.Windows.Forms.TextBox RutEmpresaTextBox;
        private System.Windows.Forms.Label RutEmpresaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.CheckBox MensualCheckBox;
        private System.Windows.Forms.GroupBox ResultadoGroupBox;
        private System.Windows.Forms.DataGrid dataGrid1;

        #endregion
    }
}