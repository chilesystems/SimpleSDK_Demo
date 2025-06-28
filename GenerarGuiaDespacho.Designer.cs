namespace SimpleSDK_Demo
{
    partial class GenerarGuiaDespacho
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textTipoGuia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericFolio = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textGiroEmisor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textComunaEmisor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textDireccionEmisor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textRazonSocialEmisor = new System.Windows.Forms.TextBox();
            this.textRUTEmisor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textGiroReceptor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textComunaReceptor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textDireccionReceptor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textRazonSocialReceptor = new System.Windows.Forms.TextBox();
            this.textRUTReceptor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBoxTransporte = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textTipoGuia);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.numericFolio);
            this.groupBox5.Location = new System.Drawing.Point(5, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(607, 53);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "General";
            // 
            // textTipoGuia
            // 
            this.textTipoGuia.Enabled = false;
            this.textTipoGuia.Location = new System.Drawing.Point(400, 20);
            this.textTipoGuia.Margin = new System.Windows.Forms.Padding(2);
            this.textTipoGuia.Name = "textTipoGuia";
            this.textTipoGuia.Size = new System.Drawing.Size(202, 20);
            this.textTipoGuia.TabIndex = 17;
            this.textTipoGuia.Text = "GUÍA DE DESPACHO ELECTRÓNICA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Folio:";
            // 
            // numericFolio
            // 
            this.numericFolio.Location = new System.Drawing.Point(301, 20);
            this.numericFolio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFolio.Name = "numericFolio";
            this.numericFolio.Size = new System.Drawing.Size(67, 20);
            this.numericFolio.TabIndex = 13;
            this.numericFolio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textGiroEmisor);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textComunaEmisor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textDireccionEmisor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textRazonSocialEmisor);
            this.groupBox3.Controls.Add(this.textRUTEmisor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(5, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 85);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emisor";
            // 
            // textGiroEmisor
            // 
            this.textGiroEmisor.Location = new System.Drawing.Point(225, 50);
            this.textGiroEmisor.Name = "textGiroEmisor";
            this.textGiroEmisor.Size = new System.Drawing.Size(376, 20);
            this.textGiroEmisor.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Giro:";
            // 
            // textComunaEmisor
            // 
            this.textComunaEmisor.Location = new System.Drawing.Point(61, 50);
            this.textComunaEmisor.Name = "textComunaEmisor";
            this.textComunaEmisor.Size = new System.Drawing.Size(119, 20);
            this.textComunaEmisor.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Comuna:";
            // 
            // textDireccionEmisor
            // 
            this.textDireccionEmisor.Location = new System.Drawing.Point(433, 24);
            this.textDireccionEmisor.Name = "textDireccionEmisor";
            this.textDireccionEmisor.Size = new System.Drawing.Size(168, 20);
            this.textDireccionEmisor.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dirección:";
            // 
            // textRazonSocialEmisor
            // 
            this.textRazonSocialEmisor.Location = new System.Drawing.Point(225, 24);
            this.textRazonSocialEmisor.Name = "textRazonSocialEmisor";
            this.textRazonSocialEmisor.Size = new System.Drawing.Size(141, 20);
            this.textRazonSocialEmisor.TabIndex = 18;
            // 
            // textRUTEmisor
            // 
            this.textRUTEmisor.Location = new System.Drawing.Point(61, 24);
            this.textRUTEmisor.Name = "textRUTEmisor";
            this.textRUTEmisor.Size = new System.Drawing.Size(81, 20);
            this.textRUTEmisor.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Razón Social:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "RUT:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textGiroReceptor);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textComunaReceptor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textDireccionReceptor);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textRazonSocialReceptor);
            this.groupBox4.Controls.Add(this.textRUTReceptor);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(5, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(607, 85);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receptor";
            // 
            // textGiroReceptor
            // 
            this.textGiroReceptor.Location = new System.Drawing.Point(225, 50);
            this.textGiroReceptor.Name = "textGiroReceptor";
            this.textGiroReceptor.Size = new System.Drawing.Size(376, 20);
            this.textGiroReceptor.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Giro:";
            // 
            // textComunaReceptor
            // 
            this.textComunaReceptor.Location = new System.Drawing.Point(61, 50);
            this.textComunaReceptor.Name = "textComunaReceptor";
            this.textComunaReceptor.Size = new System.Drawing.Size(119, 20);
            this.textComunaReceptor.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Comuna:";
            // 
            // textDireccionReceptor
            // 
            this.textDireccionReceptor.Location = new System.Drawing.Point(433, 24);
            this.textDireccionReceptor.Name = "textDireccionReceptor";
            this.textDireccionReceptor.Size = new System.Drawing.Size(168, 20);
            this.textDireccionReceptor.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Dirección:";
            // 
            // textRazonSocialReceptor
            // 
            this.textRazonSocialReceptor.Location = new System.Drawing.Point(225, 24);
            this.textRazonSocialReceptor.Name = "textRazonSocialReceptor";
            this.textRazonSocialReceptor.Size = new System.Drawing.Size(141, 20);
            this.textRazonSocialReceptor.TabIndex = 18;
            // 
            // textRUTReceptor
            // 
            this.textRUTReceptor.Location = new System.Drawing.Point(61, 24);
            this.textRUTReceptor.Name = "textRUTReceptor";
            this.textRUTReceptor.Size = new System.Drawing.Size(81, 20);
            this.textRUTReceptor.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Razón Social:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "RUT:";
            // 
            // groupBoxTransporte
            // 
            this.groupBoxTransporte.Controls.Add(this.textBox9);
            this.groupBoxTransporte.Controls.Add(this.textBox10);
            this.groupBoxTransporte.Controls.Add(this.label21);
            this.groupBoxTransporte.Controls.Add(this.label22);
            this.groupBoxTransporte.Controls.Add(this.textBox4);
            this.groupBoxTransporte.Controls.Add(this.textBox5);
            this.groupBoxTransporte.Controls.Add(this.label4);
            this.groupBoxTransporte.Controls.Add(this.label17);
            this.groupBoxTransporte.Location = new System.Drawing.Point(5, 252);
            this.groupBoxTransporte.Name = "groupBoxTransporte";
            this.groupBoxTransporte.Size = new System.Drawing.Size(607, 86);
            this.groupBoxTransporte.TabIndex = 26;
            this.groupBoxTransporte.TabStop = false;
            this.groupBoxTransporte.Text = "Transporte";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(497, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Patente:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "RutTransporte:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(254, 24);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(188, 20);
            this.textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(90, 56);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(81, 20);
            this.textBox10.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(175, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Nombre Chofer:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "RUT Chofer:";
            // 
            // GenerarGuiaDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 821);
            this.Controls.Add(this.groupBoxTransporte);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GenerarGuiaDespacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Guía de Despacho";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFolio)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxTransporte.ResumeLayout(false);
            this.groupBoxTransporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericFolio;
        private System.Windows.Forms.TextBox textTipoGuia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textGiroEmisor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textComunaEmisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDireccionEmisor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textRazonSocialEmisor;
        private System.Windows.Forms.TextBox textRUTEmisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textGiroReceptor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textComunaReceptor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textDireccionReceptor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textRazonSocialReceptor;
        private System.Windows.Forms.TextBox textRUTReceptor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBoxTransporte;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}