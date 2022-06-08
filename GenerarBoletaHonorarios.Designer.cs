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
            this.RutEmisorTextBox = new System.Windows.Forms.TextBox();
            this.DatosBoletaHonorariosGroupBox = new System.Windows.Forms.GroupBox();
            this.GenerarBoletaButton = new System.Windows.Forms.Button();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.RetencionLabel = new System.Windows.Forms.Label();
            this.ReceptorRetencionRadioButton = new System.Windows.Forms.RadioButton();
            this.RetencionContribuyenteRadioButton = new System.Windows.Forms.RadioButton();
            this.RutReceptorLabel = new System.Windows.Forms.Label();
            this.RutEmisorLabel = new System.Windows.Forms.Label();
            this.RutReceptorTextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosBoletaHonorariosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RutEmisorTextBox
            // 
            this.RutEmisorTextBox.Location = new System.Drawing.Point(6, 58);
            this.RutEmisorTextBox.Name = "RutEmisorTextBox";
            this.RutEmisorTextBox.Size = new System.Drawing.Size(100, 26);
            this.RutEmisorTextBox.TabIndex = 0;
            // 
            // DatosBoletaHonorariosGroupBox
            // 
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.GenerarBoletaButton);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.CorreoTextBox);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.CorreoLabel);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.RetencionLabel);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.ReceptorRetencionRadioButton);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.RetencionContribuyenteRadioButton);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.RutReceptorLabel);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.RutEmisorLabel);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.RutReceptorTextbox);
            this.DatosBoletaHonorariosGroupBox.Controls.Add(this.RutEmisorTextBox);
            this.DatosBoletaHonorariosGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DatosBoletaHonorariosGroupBox.Name = "DatosBoletaHonorariosGroupBox";
            this.DatosBoletaHonorariosGroupBox.Size = new System.Drawing.Size(776, 128);
            this.DatosBoletaHonorariosGroupBox.TabIndex = 1;
            this.DatosBoletaHonorariosGroupBox.TabStop = false;
            this.DatosBoletaHonorariosGroupBox.Text = "Datos Boleta de Honorarios";
            // 
            // GenerarBoletaButton
            // 
            this.GenerarBoletaButton.Location = new System.Drawing.Point(649, 39);
            this.GenerarBoletaButton.Name = "GenerarBoletaButton";
            this.GenerarBoletaButton.Size = new System.Drawing.Size(106, 64);
            this.GenerarBoletaButton.TabIndex = 9;
            this.GenerarBoletaButton.Text = "Generar Boleta";
            this.GenerarBoletaButton.UseVisualStyleBackColor = true;
            this.GenerarBoletaButton.Click += new System.EventHandler(this.GenerarBoletaButton_Click);
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Location = new System.Drawing.Point(241, 58);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(239, 26);
            this.CorreoTextBox.TabIndex = 8;
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoLabel.Location = new System.Drawing.Point(241, 32);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(100, 23);
            this.CorreoLabel.TabIndex = 7;
            this.CorreoLabel.Text = "Correo";
            // 
            // RetencionLabel
            // 
            this.RetencionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetencionLabel.Location = new System.Drawing.Point(492, 32);
            this.RetencionLabel.Name = "RetencionLabel";
            this.RetencionLabel.Size = new System.Drawing.Size(100, 23);
            this.RetencionLabel.TabIndex = 6;
            this.RetencionLabel.Text = "Retención";
            // 
            // ReceptorRetencionRadioButton
            // 
            this.ReceptorRetencionRadioButton.Location = new System.Drawing.Point(492, 88);
            this.ReceptorRetencionRadioButton.Name = "ReceptorRetencionRadioButton";
            this.ReceptorRetencionRadioButton.Size = new System.Drawing.Size(104, 24);
            this.ReceptorRetencionRadioButton.TabIndex = 5;
            this.ReceptorRetencionRadioButton.TabStop = true;
            this.ReceptorRetencionRadioButton.Text = "Receptor";
            this.ReceptorRetencionRadioButton.UseVisualStyleBackColor = true;
            // 
            // RetencionContribuyenteRadioButton
            // 
            this.RetencionContribuyenteRadioButton.Location = new System.Drawing.Point(492, 58);
            this.RetencionContribuyenteRadioButton.Name = "RetencionContribuyenteRadioButton";
            this.RetencionContribuyenteRadioButton.Size = new System.Drawing.Size(136, 24);
            this.RetencionContribuyenteRadioButton.TabIndex = 4;
            this.RetencionContribuyenteRadioButton.TabStop = true;
            this.RetencionContribuyenteRadioButton.Text = "Contribuyente";
            this.RetencionContribuyenteRadioButton.UseVisualStyleBackColor = true;
            // 
            // RutReceptorLabel
            // 
            this.RutReceptorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutReceptorLabel.Location = new System.Drawing.Point(123, 32);
            this.RutReceptorLabel.Name = "RutReceptorLabel";
            this.RutReceptorLabel.Size = new System.Drawing.Size(121, 23);
            this.RutReceptorLabel.TabIndex = 3;
            this.RutReceptorLabel.Text = "Rut Receptor";
            // 
            // RutEmisorLabel
            // 
            this.RutEmisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutEmisorLabel.Location = new System.Drawing.Point(6, 32);
            this.RutEmisorLabel.Name = "RutEmisorLabel";
            this.RutEmisorLabel.Size = new System.Drawing.Size(100, 23);
            this.RutEmisorLabel.TabIndex = 2;
            this.RutEmisorLabel.Text = "Rut Emisor";
            // 
            // RutReceptorTextbox
            // 
            this.RutReceptorTextbox.Location = new System.Drawing.Point(123, 58);
            this.RutReceptorTextbox.Name = "RutReceptorTextbox";
            this.RutReceptorTextbox.Size = new System.Drawing.Size(100, 26);
            this.RutReceptorTextbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.NombreColumn, this.ValorColumn });
            this.dataGridView1.Location = new System.Drawing.Point(18, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(770, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // NombreColumn
            // 
            this.NombreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.Width = 525;
            // 
            // ValorColumn
            // 
            this.ValorColumn.HeaderText = "Valor";
            this.ValorColumn.Name = "ValorColumn";
            this.ValorColumn.Width = 200;
            // 
            // GenerarBoletaHonorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DatosBoletaHonorariosGroupBox);
            this.Name = "GenerarBoletaHonorarios";
            this.Text = "Generar Boleta de Honorarios";
            this.Load += new System.EventHandler(this.GenerarBoletaHonorarios_Load);
            this.DatosBoletaHonorariosGroupBox.ResumeLayout(false);
            this.DatosBoletaHonorariosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorColumn;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button GenerarBoletaButton;

        private System.Windows.Forms.Label RetencionLabel;
        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.TextBox CorreoTextBox;

        private System.Windows.Forms.RadioButton ReceptorRetencionRadioButton;

        private System.Windows.Forms.RadioButton RetencionContribuyenteRadioButton;

        private System.Windows.Forms.Label RutEmisorLabel;
        private System.Windows.Forms.Label RutReceptorLabel;

        private System.Windows.Forms.GroupBox DatosBoletaHonorariosGroupBox;
        private System.Windows.Forms.TextBox RutEmisorTextBox;

        private System.Windows.Forms.TextBox RutReceptorTextbox;

        #endregion
    }
}