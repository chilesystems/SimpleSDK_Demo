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
            this.AnulaButton = new System.Windows.Forms.Button();
            this.MotivoLabel = new System.Windows.Forms.Label();
            this.FolioLabel = new System.Windows.Forms.Label();
            this.RutEmisorLabel = new System.Windows.Forms.Label();
            this.FolioTextBox = new System.Windows.Forms.TextBox();
            this.RutEmisorTextBox = new System.Windows.Forms.TextBox();
            this.CausaAnulacionServicioNoPagadoRadioButton = new System.Windows.Forms.RadioButton();
            this.CausaAnulacionServicioNoEfectuadoRadioButton = new System.Windows.Forms.RadioButton();
            this.CausaAnulacionErrorDigitacionRadioButton = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(499, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Boleta a Anular";
            // 
            // AnulaButton
            // 
            this.AnulaButton.Location = new System.Drawing.Point(409, 23);
            this.AnulaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnulaButton.Name = "AnulaButton";
            this.AnulaButton.Size = new System.Drawing.Size(84, 37);
            this.AnulaButton.TabIndex = 6;
            this.AnulaButton.Text = "Anular";
            this.AnulaButton.UseVisualStyleBackColor = true;
            this.AnulaButton.Click += new System.EventHandler(this.AnulaButton_Click);
            // 
            // MotivoLabel
            // 
            this.MotivoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotivoLabel.Location = new System.Drawing.Point(20, 57);
            this.MotivoLabel.Name = "MotivoLabel";
            this.MotivoLabel.Size = new System.Drawing.Size(79, 18);
            this.MotivoLabel.TabIndex = 5;
            this.MotivoLabel.Text = "Motivo";
            // 
            // FolioLabel
            // 
            this.FolioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolioLabel.Location = new System.Drawing.Point(226, 32);
            this.FolioLabel.Name = "FolioLabel";
            this.FolioLabel.Size = new System.Drawing.Size(57, 18);
            this.FolioLabel.TabIndex = 3;
            this.FolioLabel.Text = "Folio";
            // 
            // RutEmisorLabel
            // 
            this.RutEmisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutEmisorLabel.Location = new System.Drawing.Point(20, 32);
            this.RutEmisorLabel.Name = "RutEmisorLabel";
            this.RutEmisorLabel.Size = new System.Drawing.Size(84, 18);
            this.RutEmisorLabel.TabIndex = 2;
            this.RutEmisorLabel.Text = "Rut Emisor";
            // 
            // FolioTextBox
            // 
            this.FolioTextBox.Location = new System.Drawing.Point(289, 30);
            this.FolioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FolioTextBox.Name = "FolioTextBox";
            this.FolioTextBox.Size = new System.Drawing.Size(89, 22);
            this.FolioTextBox.TabIndex = 1;
            // 
            // RutEmisorTextBox
            // 
            this.RutEmisorTextBox.Location = new System.Drawing.Point(112, 30);
            this.RutEmisorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RutEmisorTextBox.Name = "RutEmisorTextBox";
            this.RutEmisorTextBox.Size = new System.Drawing.Size(89, 22);
            this.RutEmisorTextBox.TabIndex = 0;
            // 
            // CausaAnulacionServicioNoPagadoRadioButton
            // 
            this.CausaAnulacionServicioNoPagadoRadioButton.AutoSize = true;
            this.CausaAnulacionServicioNoPagadoRadioButton.Location = new System.Drawing.Point(112, 57);
            this.CausaAnulacionServicioNoPagadoRadioButton.Name = "CausaAnulacionServicioNoPagadoRadioButton";
            this.CausaAnulacionServicioNoPagadoRadioButton.Size = new System.Drawing.Size(222, 20);
            this.CausaAnulacionServicioNoPagadoRadioButton.TabIndex = 10;
            this.CausaAnulacionServicioNoPagadoRadioButton.TabStop = true;
            this.CausaAnulacionServicioNoPagadoRadioButton.Text = "El receptor no pagó los servicios";
            this.CausaAnulacionServicioNoPagadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CausaAnulacionServicioNoEfectuadoRadioButton
            // 
            this.CausaAnulacionServicioNoEfectuadoRadioButton.AutoSize = true;
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Location = new System.Drawing.Point(112, 83);
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Name = "CausaAnulacionServicioNoEfectuadoRadioButton";
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Size = new System.Drawing.Size(167, 20);
            this.CausaAnulacionServicioNoEfectuadoRadioButton.TabIndex = 11;
            this.CausaAnulacionServicioNoEfectuadoRadioButton.TabStop = true;
            this.CausaAnulacionServicioNoEfectuadoRadioButton.Text = "No se prestó el servicio";
            this.CausaAnulacionServicioNoEfectuadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CausaAnulacionErrorDigitacionRadioButton
            // 
            this.CausaAnulacionErrorDigitacionRadioButton.AutoSize = true;
            this.CausaAnulacionErrorDigitacionRadioButton.Location = new System.Drawing.Point(112, 109);
            this.CausaAnulacionErrorDigitacionRadioButton.Name = "CausaAnulacionErrorDigitacionRadioButton";
            this.CausaAnulacionErrorDigitacionRadioButton.Size = new System.Drawing.Size(137, 20);
            this.CausaAnulacionErrorDigitacionRadioButton.TabIndex = 12;
            this.CausaAnulacionErrorDigitacionRadioButton.TabStop = true;
            this.CausaAnulacionErrorDigitacionRadioButton.Text = "Error de Digitación";
            this.CausaAnulacionErrorDigitacionRadioButton.UseVisualStyleBackColor = true;
            // 
            // AnularBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 168);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnularBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anular Boleta de Honorarios";
            this.Load += new System.EventHandler(this.AnularBoleta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

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

        private System.Windows.Forms.RadioButton CausaAnulacionErrorDigitacionRadioButton;
        private System.Windows.Forms.RadioButton CausaAnulacionServicioNoEfectuadoRadioButton;
        private System.Windows.Forms.RadioButton CausaAnulacionServicioNoPagadoRadioButton;
    }
}