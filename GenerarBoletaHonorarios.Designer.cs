using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class GenerarBoletaHonorarios
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
            this.textRutEmisor = new System.Windows.Forms.TextBox();
            this.DatosBoletaHonorariosGroupBox = new System.Windows.Forms.GroupBox();
            this.numericRegion = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textComuna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRutReceptor = new System.Windows.Forms.TextBox();
            this.GenerarBoletaButton = new System.Windows.Forms.Button();
            this.ReceptorRetencionRadioButton = new System.Windows.Forms.RadioButton();
            this.RetencionContribuyenteRadioButton = new System.Windows.Forms.RadioButton();
            this.gridDetalles = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDomicilios = new System.Windows.Forms.DataGridView();
            this.groupDomicilios = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatosBoletaHonorariosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomicilios)).BeginInit();
            this.groupDomicilios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textRutEmisor
            // 
            this.textRutEmisor.ForeColor = System.Drawing.Color.Red;
            this.textRutEmisor.Location = new System.Drawing.Point(73, 20);
            this.textRutEmisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRutEmisor.Name = "textRutEmisor";
            this.textRutEmisor.Size = new System.Drawing.Size(68, 20);
            this.textRutEmisor.TabIndex = 0;
            // 
            // DatosBoletaHonorariosGroupBox
            // 
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.numericRegion);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.label7);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.label5);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.textComuna);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.label6);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.textDireccion);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.label4);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.textNombre);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.label2);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.textRutReceptor);
            this.DatosBoletaHonorariosGroupBox.Location = new System.Drawing.Point(8, 8);
            this.DatosBoletaHonorariosGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatosBoletaHonorariosGroupBox.Name = "DatosBoletaHonorariosGroupBox";
            this.DatosBoletaHonorariosGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatosBoletaHonorariosGroupBox.Size = new System.Drawing.Size(376, 100);
            this.DatosBoletaHonorariosGroupBox.TabIndex = 1;
            this.DatosBoletaHonorariosGroupBox.TabStop = false;
            this.DatosBoletaHonorariosGroupBox.Text = "Receptor";
            // 
            // numericRegion
            // 
            this.numericRegion.Location = new System.Drawing.Point(237, 20);
            this.numericRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericRegion.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericRegion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRegion.Name = "numericRegion";
            this.numericRegion.Size = new System.Drawing.Size(40, 20);
            this.numericRegion.TabIndex = 8;
            this.numericRegion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Región:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Comuna:";
            // 
            // textComuna
            // 
            this.textComuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textComuna.Location = new System.Drawing.Point(237, 41);
            this.textComuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textComuna.Name = "textComuna";
            this.textComuna.Size = new System.Drawing.Size(122, 20);
            this.textComuna.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dirección:";
            // 
            // textDireccion
            // 
            this.textDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDireccion.Location = new System.Drawing.Point(62, 62);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(296, 20);
            this.textDireccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNombre.Location = new System.Drawing.Point(62, 41);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(116, 20);
            this.textNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RUT:";
            // 
            // textRutReceptor
            // 
            this.textRutReceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRutReceptor.Location = new System.Drawing.Point(62, 20);
            this.textRutReceptor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRutReceptor.Name = "textRutReceptor";
            this.textRutReceptor.Size = new System.Drawing.Size(73, 20);
            this.textRutReceptor.TabIndex = 1;
            // 
            // GenerarBoletaButton
            // 
            this.GenerarBoletaButton.Location = new System.Drawing.Point(494, 247);
            this.GenerarBoletaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerarBoletaButton.Name = "GenerarBoletaButton";
            this.GenerarBoletaButton.Size = new System.Drawing.Size(114, 41);
            this.GenerarBoletaButton.TabIndex = 9;
            this.GenerarBoletaButton.Text = "Generar Boleta";
            this.GenerarBoletaButton.UseVisualStyleBackColor = true;
            this.GenerarBoletaButton.Click += new System.EventHandler(this.GenerarBoletaButton_Click);
            // 
            // ReceptorRetencionRadioButton
            // 
            this.ReceptorRetencionRadioButton.Checked = true;
            this.ReceptorRetencionRadioButton.Location = new System.Drawing.Point(99, 20);
            this.ReceptorRetencionRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReceptorRetencionRadioButton.Name = "ReceptorRetencionRadioButton";
            this.ReceptorRetencionRadioButton.Size = new System.Drawing.Size(69, 15);
            this.ReceptorRetencionRadioButton.TabIndex = 5;
            this.ReceptorRetencionRadioButton.TabStop = true;
            this.ReceptorRetencionRadioButton.Text = "Receptor";
            this.ReceptorRetencionRadioButton.UseVisualStyleBackColor = true;
            // 
            // RetencionContribuyenteRadioButton
            // 
            this.RetencionContribuyenteRadioButton.Location = new System.Drawing.Point(8, 20);
            this.RetencionContribuyenteRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RetencionContribuyenteRadioButton.Name = "RetencionContribuyenteRadioButton";
            this.RetencionContribuyenteRadioButton.Size = new System.Drawing.Size(86, 15);
            this.RetencionContribuyenteRadioButton.TabIndex = 4;
            this.RetencionContribuyenteRadioButton.Text = "Contribuyente";
            this.RetencionContribuyenteRadioButton.UseVisualStyleBackColor = true;
            // 
            // gridDetalles
            // 
            this.gridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.ValorColumn});
            this.gridDetalles.Location = new System.Drawing.Point(8, 115);
            this.gridDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.RowHeadersWidth = 62;
            this.gridDetalles.RowTemplate.Height = 28;
            this.gridDetalles.Size = new System.Drawing.Size(596, 120);
            this.gridDetalles.TabIndex = 2;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.MinimumWidth = 8;
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.Width = 400;
            // 
            // ValorColumn
            // 
            this.ValorColumn.HeaderText = "Valor";
            this.ValorColumn.MinimumWidth = 8;
            this.ValorColumn.Name = "ValorColumn";
            this.ValorColumn.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RetencionContribuyenteRadioButton);
            this.groupBox1.Controls.Add(this.ReceptorRetencionRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 240);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(176, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retención";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RUT Emisor:";
            // 
            // gridDomicilios
            // 
            this.gridDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDomicilios.Location = new System.Drawing.Point(4, 20);
            this.gridDomicilios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridDomicilios.Name = "gridDomicilios";
            this.gridDomicilios.RowHeadersWidth = 62;
            this.gridDomicilios.RowTemplate.Height = 24;
            this.gridDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDomicilios.Size = new System.Drawing.Size(206, 76);
            this.gridDomicilios.TabIndex = 11;
            // 
            // groupDomicilios
            // 
            this.groupDomicilios.Controls.Add(this.gridDomicilios);
            this.groupDomicilios.Location = new System.Drawing.Point(388, 8);
            this.groupDomicilios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDomicilios.Name = "groupDomicilios";
            this.groupDomicilios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDomicilios.Size = new System.Drawing.Size(215, 100);
            this.groupDomicilios.TabIndex = 12;
            this.groupDomicilios.TabStop = false;
            this.groupDomicilios.Text = "Domicilios Emisor";
            this.groupDomicilios.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textRutEmisor);
            this.groupBox2.Location = new System.Drawing.Point(190, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(146, 49);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emisor";
            // 
            // GenerarBoletaHonorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupDomicilios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenerarBoletaButton);
            this.Controls.Add(this.gridDetalles);
            this.Controls.Add(this.DatosBoletaHonorariosGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerarBoletaHonorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Boleta de Honorarios";
            this.Load += new System.EventHandler(this.GenerarBoletaHonorarios_Load);
            this.DatosBoletaHonorariosGroupBox.ResumeLayout(false);
            this.DatosBoletaHonorariosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDomicilios)).EndInit();
            this.groupDomicilios.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView gridDetalles;

        private System.Windows.Forms.Button GenerarBoletaButton;

        private System.Windows.Forms.RadioButton ReceptorRetencionRadioButton;

        private System.Windows.Forms.RadioButton RetencionContribuyenteRadioButton;

        private System.Windows.Forms.GroupBox DatosBoletaHonorariosGroupBox;
        private System.Windows.Forms.TextBox textRutEmisor;

        private System.Windows.Forms.TextBox textRutReceptor;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDomicilios;
        private System.Windows.Forms.GroupBox groupDomicilios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textComuna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorColumn;
    }
}