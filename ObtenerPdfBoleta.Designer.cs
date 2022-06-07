﻿using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class ObtenerPdfBoleta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescargarPdfButton = new System.Windows.Forms.Button();
            this.RutEmisorTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FolioTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnioTextbox = new System.Windows.Forms.TextBox();
            this.RecibidaRadioButton = new System.Windows.Forms.RadioButton();
            this.EmitidaRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EmitidaRadioButton);
            this.groupBox1.Controls.Add(this.RecibidaRadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AnioTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FolioTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RutEmisorTextbox);
            this.groupBox1.Controls.Add(this.DescargarPdfButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Boleta de Honorarios Electrónica";
            // 
            // DescargarPdfButton
            // 
            this.DescargarPdfButton.Location = new System.Drawing.Point(885, 28);
            this.DescargarPdfButton.Name = "DescargarPdfButton";
            this.DescargarPdfButton.Size = new System.Drawing.Size(110, 66);
            this.DescargarPdfButton.TabIndex = 0;
            this.DescargarPdfButton.Text = "Descargar PDF";
            this.DescargarPdfButton.UseVisualStyleBackColor = true;
            // 
            // RutEmisorTextbox
            // 
            this.RutEmisorTextbox.Location = new System.Drawing.Point(123, 48);
            this.RutEmisorTextbox.Name = "RutEmisorTextbox";
            this.RutEmisorTextbox.Size = new System.Drawing.Size(100, 26);
            this.RutEmisorTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "RUT Emisor";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folio";
            // 
            // FolioTextbox
            // 
            this.FolioTextbox.Location = new System.Drawing.Point(304, 48);
            this.FolioTextbox.Name = "FolioTextbox";
            this.FolioTextbox.Size = new System.Drawing.Size(100, 26);
            this.FolioTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // AnioTextbox
            // 
            this.AnioTextbox.Location = new System.Drawing.Point(477, 48);
            this.AnioTextbox.Name = "AnioTextbox";
            this.AnioTextbox.Size = new System.Drawing.Size(61, 26);
            this.AnioTextbox.TabIndex = 5;
            // 
            // RecibidaRadioButton
            // 
            this.RecibidaRadioButton.Location = new System.Drawing.Point(643, 49);
            this.RecibidaRadioButton.Name = "RecibidaRadioButton";
            this.RecibidaRadioButton.Size = new System.Drawing.Size(104, 24);
            this.RecibidaRadioButton.TabIndex = 7;
            this.RecibidaRadioButton.TabStop = true;
            this.RecibidaRadioButton.Text = "Recibida";
            this.RecibidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmitidaRadioButton
            // 
            this.EmitidaRadioButton.Location = new System.Drawing.Point(753, 49);
            this.EmitidaRadioButton.Name = "EmitidaRadioButton";
            this.EmitidaRadioButton.Size = new System.Drawing.Size(104, 24);
            this.EmitidaRadioButton.TabIndex = 8;
            this.EmitidaRadioButton.TabStop = true;
            this.EmitidaRadioButton.Text = "Emitida";
            this.EmitidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // ObtenerPdfBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 134);
            this.Controls.Add(this.groupBox1);
            this.Name = "ObtenerPdfBoleta";
            this.Text = "Obtener PDF Boleta de Honorarios Electrónica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.RadioButton RecibidaRadioButton;
        private System.Windows.Forms.RadioButton EmitidaRadioButton;

        private System.Windows.Forms.TextBox RutEmisorTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FolioTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnioTextbox;

        private System.Windows.Forms.Button DescargarPdfButton;

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}