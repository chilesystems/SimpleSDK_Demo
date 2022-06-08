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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AmbienteProducciónRadioButton = new System.Windows.Forms.RadioButton();
            this.AmbienteCertificacionRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.FolioHastaTextBox = new System.Windows.Forms.TextBox();
            this.FolioDesdeTextBox = new System.Windows.Forms.TextBox();
            this.RutEmisorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AnularButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoDteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AmbienteProducciónRadioButton);
            this.groupBox1.Controls.Add(this.AmbienteCertificacionRadioButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FolioHastaTextBox);
            this.groupBox1.Controls.Add(this.FolioDesdeTextBox);
            this.groupBox1.Controls.Add(this.RutEmisorTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AnularButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TipoDteTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // AmbienteProducciónRadioButton
            // 
            this.AmbienteProducciónRadioButton.Location = new System.Drawing.Point(838, 44);
            this.AmbienteProducciónRadioButton.Name = "AmbienteProducciónRadioButton";
            this.AmbienteProducciónRadioButton.Size = new System.Drawing.Size(116, 24);
            this.AmbienteProducciónRadioButton.TabIndex = 15;
            this.AmbienteProducciónRadioButton.Text = "Producción";
            this.AmbienteProducciónRadioButton.UseVisualStyleBackColor = true;
            // 
            // AmbienteCertificacionRadioButton
            // 
            this.AmbienteCertificacionRadioButton.Checked = true;
            this.AmbienteCertificacionRadioButton.Location = new System.Drawing.Point(711, 44);
            this.AmbienteCertificacionRadioButton.Name = "AmbienteCertificacionRadioButton";
            this.AmbienteCertificacionRadioButton.Size = new System.Drawing.Size(121, 24);
            this.AmbienteCertificacionRadioButton.TabIndex = 14;
            this.AmbienteCertificacionRadioButton.TabStop = true;
            this.AmbienteCertificacionRadioButton.Text = "Certificación";
            this.AmbienteCertificacionRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ambiente";
            // 
            // FolioHastaTextBox
            // 
            this.FolioHastaTextBox.Location = new System.Drawing.Point(529, 62);
            this.FolioHastaTextBox.Name = "FolioHastaTextBox";
            this.FolioHastaTextBox.Size = new System.Drawing.Size(68, 26);
            this.FolioHastaTextBox.TabIndex = 10;
            // 
            // FolioDesdeTextBox
            // 
            this.FolioDesdeTextBox.Location = new System.Drawing.Point(529, 17);
            this.FolioDesdeTextBox.Name = "FolioDesdeTextBox";
            this.FolioDesdeTextBox.Size = new System.Drawing.Size(68, 26);
            this.FolioDesdeTextBox.TabIndex = 9;
            // 
            // RutEmisorTextBox
            // 
            this.RutEmisorTextBox.Location = new System.Drawing.Point(123, 43);
            this.RutEmisorTextBox.Name = "RutEmisorTextBox";
            this.RutEmisorTextBox.Size = new System.Drawing.Size(100, 26);
            this.RutEmisorTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rut Emisor";
            // 
            // AnularButton
            // 
            this.AnularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnularButton.Location = new System.Drawing.Point(960, 24);
            this.AnularButton.Name = "AnularButton";
            this.AnularButton.Size = new System.Drawing.Size(130, 64);
            this.AnularButton.TabIndex = 6;
            this.AnularButton.Text = "Anular";
            this.AnularButton.UseVisualStyleBackColor = true;
            this.AnularButton.Click += new System.EventHandler(this.AnularButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // TipoDteTextBox
            // 
            this.TipoDteTextBox.Location = new System.Drawing.Point(334, 43);
            this.TipoDteTextBox.Name = "TipoDteTextBox";
            this.TipoDteTextBox.Size = new System.Drawing.Size(100, 26);
            this.TipoDteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo DTE";
            // 
            // AnularMasivamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 128);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnularMasivamente";
            this.Text = "Anulación de Folios Masiva";
            this.Load += new System.EventHandler(this.AnularMasivamente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton AmbienteProducciónRadioButton;
        private System.Windows.Forms.RadioButton AmbienteCertificacionRadioButton;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox FolioDesdeTextBox;
        private System.Windows.Forms.TextBox FolioHastaTextBox;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RutEmisorTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TipoDteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AnularButton;

        #endregion
    }
}