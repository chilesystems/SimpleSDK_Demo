using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class AnularBoleta
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
            this.CausaAnulacionErrorDigitacionRadioButton = new System.Windows.Forms.RadioButton();
            this.CausaAnulacionServicioNoEfectuadoRadioButton = new System.Windows.Forms.RadioButton();
            this.CausaAnulacionServicioNoPagadoRadioButton = new System.Windows.Forms.RadioButton();
            this.AnulaButton = new System.Windows.Forms.Button();
            this.MotivoLabel = new System.Windows.Forms.Label();
            this.FolioLabel = new System.Windows.Forms.Label();
            this.RutEmisorLabel = new System.Windows.Forms.Label();
            this.FolioTextBox = new System.Windows.Forms.TextBox();
            this.RutEmisorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CausaAnulacionErrorDigitacionRadioButton);
            this.groupBox1.Controls.Add(this.CausaAnulacionServicioNoEfectuadoRadioButton);
            this.groupBox1.Controls.Add(this.CausaAnulacionServicioNoPagadoRadioButton);
            this.groupBox1.Controls.Add(this.AnulaButton);
            this.groupBox1.Controls.Add(this.MotivoLabel);
            this.groupBox1.Controls.Add(this.FolioLabel);
            this.groupBox1.Controls.Add(this.RutEmisorLabel);
            this.groupBox1.Controls.Add(this.FolioTextBox);
            this.groupBox1.Controls.Add(this.RutEmisorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Boleta a Anular";
            // 
            // CausaAnulacionErrorDigitacionRadioButton
            // 
            this.CausaAnulacionErrorDigitacionRadioButton.Location = new System.Drawing.Point(118, 131);
            this.CausaAnulacionErrorDigitacionRadioButton.Name = "CausaAnulacionErrorDigitacionRadioButton";
            this.CausaAnulacionErrorDigitacionRadioButton.Size = new System.Drawing.Size(181, 24);
            this.CausaAnulacionErrorDigitacionRadioButton.TabIndex = 9;
            this.CausaAnulacionErrorDigitacionRadioButton.TabStop = true;
            this.CausaAnulacionErrorDigitacionRadioButton.Text = "Error de Digitación";
            this.CausaAnulacionErrorDigitacionRadioButton.UseVisualStyleBackColor = true;
            // 
            // CausaAnulacionServicioNoEfectuadoRadioButton
            // 
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Location = new System.Drawing.Point(118, 101);
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Name = "CausaAnulacionServicioNoEfectuadoRadioButton";
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Size = new System.Drawing.Size(201, 24);
            this.CausaAnulacionServicioNoEfectuadoRadioButton.TabIndex = 8;
            this.CausaAnulacionServicioNoEfectuadoRadioButton.TabStop = true;
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Text = "No se prestó el servicio";
            this.CausaAnulacionServicioNoEfectuadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CausaAnulacionServicioNoPagadoRadioButton
            // 
            this.CausaAnulacionServicioNoPagadoRadioButton.Location = new System.Drawing.Point(118, 71);
            this.CausaAnulacionServicioNoPagadoRadioButton.Name = "CausaAnulacionServicioNoPagadoRadioButton";
            this.CausaAnulacionServicioNoPagadoRadioButton.Size = new System.Drawing.Size(276, 24);
            this.CausaAnulacionServicioNoPagadoRadioButton.TabIndex = 7;
            this.CausaAnulacionServicioNoPagadoRadioButton.TabStop = true;
            this.CausaAnulacionServicioNoPagadoRadioButton.Text = "El receptor no pagó los servicios";
            this.CausaAnulacionServicioNoPagadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // AnulaButton
            // 
            this.AnulaButton.Location = new System.Drawing.Point(450, 27);
            this.AnulaButton.Name = "AnulaButton";
            this.AnulaButton.Size = new System.Drawing.Size(95, 46);
            this.AnulaButton.TabIndex = 6;
            this.AnulaButton.Text = "Anular";
            this.AnulaButton.UseVisualStyleBackColor = true;
            this.AnulaButton.Click += new System.EventHandler(this.AnulaButton_Click);
            // 
            // MotivoLabel
            // 
            this.MotivoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotivoLabel.Location = new System.Drawing.Point(22, 71);
            this.MotivoLabel.Name = "MotivoLabel";
            this.MotivoLabel.Size = new System.Drawing.Size(62, 23);
            this.MotivoLabel.TabIndex = 5;
            this.MotivoLabel.Text = "Motivo";
            // 
            // FolioLabel
            // 
            this.FolioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolioLabel.Location = new System.Drawing.Point(233, 40);
            this.FolioLabel.Name = "FolioLabel";
            this.FolioLabel.Size = new System.Drawing.Size(55, 23);
            this.FolioLabel.TabIndex = 3;
            this.FolioLabel.Text = "Folio";
            // 
            // RutEmisorLabel
            // 
            this.RutEmisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutEmisorLabel.Location = new System.Drawing.Point(22, 40);
            this.RutEmisorLabel.Name = "RutEmisorLabel";
            this.RutEmisorLabel.Size = new System.Drawing.Size(90, 23);
            this.RutEmisorLabel.TabIndex = 2;
            this.RutEmisorLabel.Text = "Rut Emisor";
            // 
            // FolioTextBox
            // 
            this.FolioTextBox.Location = new System.Drawing.Point(294, 37);
            this.FolioTextBox.Name = "FolioTextBox";
            this.FolioTextBox.Size = new System.Drawing.Size(100, 26);
            this.FolioTextBox.TabIndex = 1;
            // 
            // RutEmisorTextBox
            // 
            this.RutEmisorTextBox.Location = new System.Drawing.Point(118, 37);
            this.RutEmisorTextBox.Name = "RutEmisorTextBox";
            this.RutEmisorTextBox.Size = new System.Drawing.Size(100, 26);
            this.RutEmisorTextBox.TabIndex = 0;
            // 
            // AnularBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 210);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnularBoleta";
            this.Text = "Anular Boleta de Honorarios";
            this.Load += new System.EventHandler(this.AnularBoleta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton CausaAnulacionServicioNoPagadoRadioButton;
        private System.Windows.Forms.RadioButton CausaAnulacionServicioNoEfectuadoRadioButton;
        private System.Windows.Forms.RadioButton CausaAnulacionErrorDigitacionRadioButton;

        private System.Windows.Forms.TextBox RutEmisorTextBox;

        private System.Windows.Forms.TextBox FolioTextBox;

        private System.Windows.Forms.Button AnulaButton;

        private System.Windows.Forms.Label FolioLabel;
        private System.Windows.Forms.Label MotivoLabel;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label RutEmisorLabel;

        #endregion
    }
}