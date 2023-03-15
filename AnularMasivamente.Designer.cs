using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class AnularMasivamente
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
            this.AnularButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioProduccion = new System.Windows.Forms.RadioButton();
            this.radioCertificacion = new System.Windows.Forms.RadioButton();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RutEmisorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericDesde = new System.Windows.Forms.NumericUpDown();
            this.numericHasta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textMotivoAnulacion = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHasta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnularButton
            // 
            this.AnularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnularButton.Location = new System.Drawing.Point(565, 95);
            this.AnularButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnularButton.Name = "AnularButton";
            this.AnularButton.Size = new System.Drawing.Size(116, 51);
            this.AnularButton.TabIndex = 6;
            this.AnularButton.Text = "Anular";
            this.AnularButton.UseVisualStyleBackColor = true;
            this.AnularButton.Click += new System.EventHandler(this.AnularButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RutEmisorTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboTipo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radioProduccion);
            this.groupBox2.Controls.Add(this.radioCertificacion);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(669, 63);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "RUT Empresa:";
            // 
            // radioProduccion
            // 
            this.radioProduccion.AutoSize = true;
            this.radioProduccion.Location = new System.Drawing.Point(567, 27);
            this.radioProduccion.Name = "radioProduccion";
            this.radioProduccion.Size = new System.Drawing.Size(94, 20);
            this.radioProduccion.TabIndex = 20;
            this.radioProduccion.TabStop = true;
            this.radioProduccion.Text = "Producción";
            this.radioProduccion.UseVisualStyleBackColor = true;
            // 
            // radioCertificacion
            // 
            this.radioCertificacion.AutoSize = true;
            this.radioCertificacion.Location = new System.Drawing.Point(462, 27);
            this.radioCertificacion.Name = "radioCertificacion";
            this.radioCertificacion.Size = new System.Drawing.Size(99, 20);
            this.radioCertificacion.TabIndex = 19;
            this.radioCertificacion.TabStop = true;
            this.radioCertificacion.Text = "Certificación";
            this.radioCertificacion.UseVisualStyleBackColor = true;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(250, 25);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(193, 24);
            this.comboTipo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo:";
            // 
            // RutEmisorTextBox
            // 
            this.RutEmisorTextBox.Location = new System.Drawing.Point(110, 25);
            this.RutEmisorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RutEmisorTextBox.Name = "RutEmisorTextBox";
            this.RutEmisorTextBox.Size = new System.Drawing.Size(89, 22);
            this.RutEmisorTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Desde:";
            // 
            // numericDesde
            // 
            this.numericDesde.Location = new System.Drawing.Point(65, 16);
            this.numericDesde.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericDesde.Name = "numericDesde";
            this.numericDesde.Size = new System.Drawing.Size(108, 22);
            this.numericDesde.TabIndex = 26;
            // 
            // numericHasta
            // 
            this.numericHasta.Location = new System.Drawing.Point(65, 44);
            this.numericHasta.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericHasta.Name = "numericHasta";
            this.numericHasta.Size = new System.Drawing.Size(108, 22);
            this.numericHasta.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hasta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericHasta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 76);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textMotivoAnulacion);
            this.groupBox3.Location = new System.Drawing.Point(201, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 76);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motivo de la anulación:";
            // 
            // textMotivoAnulacion
            // 
            this.textMotivoAnulacion.Location = new System.Drawing.Point(6, 22);
            this.textMotivoAnulacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMotivoAnulacion.Multiline = true;
            this.textMotivoAnulacion.Name = "textMotivoAnulacion";
            this.textMotivoAnulacion.Size = new System.Drawing.Size(171, 49);
            this.textMotivoAnulacion.TabIndex = 26;
            // 
            // AnularMasivamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 165);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AnularButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnularMasivamente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anulación de Folios Masiva";
            this.Load += new System.EventHandler(this.AnularMasivamente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHasta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button AnularButton;

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RutEmisorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioProduccion;
        private System.Windows.Forms.RadioButton radioCertificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericDesde;
        private System.Windows.Forms.NumericUpDown numericHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textMotivoAnulacion;
    }
}