
namespace SimpleSDK_Demo
{
    partial class ConfiguracionDemo
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
            this.label6 = new System.Windows.Forms.Label();
            this.textAPIKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericNResolucion = new System.Windows.Forms.NumericUpDown();
            this.dateFechaResolucion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textRutCertificado = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.botonGuardarActividad = new System.Windows.Forms.Button();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.textNumeroActividad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.textComuna = new System.Windows.Forms.TextBox();
            this.textRazonSocial = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textRutEmpresa = new System.Windows.Forms.TextBox();
            this.textGiro = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textRutaCertificado = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonBuscarCertificado = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNResolucion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "API Key:";
            // 
            // textAPIKey
            // 
            this.textAPIKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textAPIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAPIKey.Location = new System.Drawing.Point(91, 294);
            this.textAPIKey.Name = "textAPIKey";
            this.textAPIKey.Size = new System.Drawing.Size(273, 26);
            this.textAPIKey.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericNResolucion);
            this.groupBox2.Controls.Add(this.dateFechaResolucion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(370, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 78);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resolución";
            // 
            // numericNResolucion
            // 
            this.numericNResolucion.Location = new System.Drawing.Point(111, 17);
            this.numericNResolucion.Name = "numericNResolucion";
            this.numericNResolucion.Size = new System.Drawing.Size(48, 20);
            this.numericNResolucion.TabIndex = 35;
            // 
            // dateFechaResolucion
            // 
            this.dateFechaResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaResolucion.Location = new System.Drawing.Point(111, 42);
            this.dateFechaResolucion.Name = "dateFechaResolucion";
            this.dateFechaResolucion.Size = new System.Drawing.Size(94, 20);
            this.dateFechaResolucion.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "N° Resolución:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha Resolución:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonBuscarCertificado);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textRutaCertificado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textRutCertificado);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 103);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Certificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "RUT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ruta:";
            // 
            // textRutCertificado
            // 
            this.textRutCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRutCertificado.Location = new System.Drawing.Point(118, 19);
            this.textRutCertificado.Name = "textRutCertificado";
            this.textRutCertificado.Size = new System.Drawing.Size(112, 20);
            this.textRutCertificado.TabIndex = 33;
            // 
            // botonGuardar
            // 
            this.botonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonGuardar.Location = new System.Drawing.Point(506, 294);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(79, 33);
            this.botonGuardar.TabIndex = 38;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.botonGuardarActividad);
            this.groupBox12.Controls.Add(this.gridResultados);
            this.groupBox12.Controls.Add(this.textNumeroActividad);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Location = new System.Drawing.Point(370, 17);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(215, 187);
            this.groupBox12.TabIndex = 37;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Actividades Económicas";
            // 
            // botonGuardarActividad
            // 
            this.botonGuardarActividad.Location = new System.Drawing.Point(174, 22);
            this.botonGuardarActividad.Name = "botonGuardarActividad";
            this.botonGuardarActividad.Size = new System.Drawing.Size(31, 23);
            this.botonGuardarActividad.TabIndex = 6;
            this.botonGuardarActividad.UseVisualStyleBackColor = true;
            this.botonGuardarActividad.Click += new System.EventHandler(this.botonGuardarActividad_Click);
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.AllowUserToResizeColumns = false;
            this.gridResultados.AllowUserToResizeRows = false;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Eliminar});
            this.gridResultados.Location = new System.Drawing.Point(11, 52);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowHeadersWidth = 25;
            this.gridResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridResultados.Size = new System.Drawing.Size(194, 129);
            this.gridResultados.TabIndex = 5;
            this.gridResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultados_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Codigo";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 35;
            // 
            // textNumeroActividad
            // 
            this.textNumeroActividad.Location = new System.Drawing.Point(61, 23);
            this.textNumeroActividad.Name = "textNumeroActividad";
            this.textNumeroActividad.Size = new System.Drawing.Size(107, 20);
            this.textNumeroActividad.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Número:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label61);
            this.groupBox3.Controls.Add(this.label56);
            this.groupBox3.Controls.Add(this.textComuna);
            this.groupBox3.Controls.Add(this.textRazonSocial);
            this.groupBox3.Controls.Add(this.label57);
            this.groupBox3.Controls.Add(this.textRutEmpresa);
            this.groupBox3.Controls.Add(this.textGiro);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Controls.Add(this.textDireccionEmpresa);
            this.groupBox3.Controls.Add(this.label54);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 151);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Empresa";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(9, 100);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(49, 13);
            this.label61.TabIndex = 44;
            this.label61.Text = "Comuna:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(9, 22);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(33, 13);
            this.label56.TabIndex = 32;
            this.label56.Text = "RUT:";
            // 
            // textComuna
            // 
            this.textComuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textComuna.Location = new System.Drawing.Point(118, 97);
            this.textComuna.Name = "textComuna";
            this.textComuna.Size = new System.Drawing.Size(87, 20);
            this.textComuna.TabIndex = 30;
            // 
            // textRazonSocial
            // 
            this.textRazonSocial.Location = new System.Drawing.Point(118, 45);
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(226, 20);
            this.textRazonSocial.TabIndex = 10;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(9, 48);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(73, 13);
            this.label57.TabIndex = 30;
            this.label57.Text = "Razón Social:";
            // 
            // textRutEmpresa
            // 
            this.textRutEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRutEmpresa.Location = new System.Drawing.Point(118, 19);
            this.textRutEmpresa.Name = "textRutEmpresa";
            this.textRutEmpresa.Size = new System.Drawing.Size(87, 20);
            this.textRutEmpresa.TabIndex = 0;
            // 
            // textGiro
            // 
            this.textGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textGiro.Location = new System.Drawing.Point(118, 71);
            this.textGiro.Name = "textGiro";
            this.textGiro.Size = new System.Drawing.Size(226, 20);
            this.textGiro.TabIndex = 20;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(9, 74);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(78, 13);
            this.label55.TabIndex = 34;
            this.label55.Text = "Giro Comercial:";
            // 
            // textDireccionEmpresa
            // 
            this.textDireccionEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDireccionEmpresa.Location = new System.Drawing.Point(118, 123);
            this.textDireccionEmpresa.Name = "textDireccionEmpresa";
            this.textDireccionEmpresa.Size = new System.Drawing.Size(226, 20);
            this.textDireccionEmpresa.TabIndex = 40;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(9, 126);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(55, 13);
            this.label54.TabIndex = 36;
            this.label54.Text = "Dirección:";
            // 
            // textRutaCertificado
            // 
            this.textRutaCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRutaCertificado.Location = new System.Drawing.Point(118, 45);
            this.textRutaCertificado.Name = "textRutaCertificado";
            this.textRutaCertificado.Size = new System.Drawing.Size(192, 20);
            this.textRutaCertificado.TabIndex = 34;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(118, 71);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(112, 20);
            this.textPassword.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Password:";
            // 
            // botonBuscarCertificado
            // 
            this.botonBuscarCertificado.Image = global::SimpleSDK_Demo.Properties.Resources.View;
            this.botonBuscarCertificado.Location = new System.Drawing.Point(316, 43);
            this.botonBuscarCertificado.Name = "botonBuscarCertificado";
            this.botonBuscarCertificado.Size = new System.Drawing.Size(28, 23);
            this.botonBuscarCertificado.TabIndex = 37;
            this.botonBuscarCertificado.UseVisualStyleBackColor = true;
            this.botonBuscarCertificado.Click += new System.EventHandler(this.botonBuscarCertificado_Click);
            // 
            // ConfiguracionDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textAPIKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracionDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNResolucion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAPIKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericNResolucion;
        private System.Windows.Forms.DateTimePicker dateFechaResolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRutCertificado;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button botonGuardarActividad;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.TextBox textNumeroActividad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textComuna;
        private System.Windows.Forms.TextBox textRazonSocial;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textRutEmpresa;
        private System.Windows.Forms.TextBox textGiro;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textDireccionEmpresa;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textRutaCertificado;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonBuscarCertificado;
    }
}