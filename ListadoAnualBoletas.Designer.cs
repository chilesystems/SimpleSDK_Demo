using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class ListadoAnualBoletas
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
            this.label4 = new System.Windows.Forms.Label();
            this.EmitidaRadioButton = new System.Windows.Forms.RadioButton();
            this.RecibidaRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RutEmisorTextbox = new System.Windows.Forms.TextBox();
            this.ListadoButton = new System.Windows.Forms.Button();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RetencionLiquidoValorLabel = new System.Windows.Forms.Label();
            this.RetencionContribuyentesValorLabel = new System.Windows.Forms.Label();
            this.RetencionTercerosValorLabel = new System.Windows.Forms.Label();
            this.TotalAnuladasValorLabel = new System.Windows.Forms.Label();
            this.TotalVigentesValorLabel = new System.Windows.Forms.Label();
            this.TotalHonorarioBrutoValorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericAnio = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericAnio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EmitidaRadioButton);
            this.groupBox1.Controls.Add(this.RecibidaRadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RutEmisorTextbox);
            this.groupBox1.Controls.Add(this.ListadoButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(840, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Boleta de Honorarios Electrónica";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // EmitidaRadioButton
            // 
            this.EmitidaRadioButton.Location = new System.Drawing.Point(489, 38);
            this.EmitidaRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmitidaRadioButton.Name = "EmitidaRadioButton";
            this.EmitidaRadioButton.Size = new System.Drawing.Size(92, 19);
            this.EmitidaRadioButton.TabIndex = 8;
            this.EmitidaRadioButton.Text = "Emitida";
            this.EmitidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // RecibidaRadioButton
            // 
            this.RecibidaRadioButton.Checked = true;
            this.RecibidaRadioButton.Location = new System.Drawing.Point(391, 38);
            this.RecibidaRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecibidaRadioButton.Name = "RecibidaRadioButton";
            this.RecibidaRadioButton.Size = new System.Drawing.Size(92, 19);
            this.RecibidaRadioButton.TabIndex = 7;
            this.RecibidaRadioButton.TabStop = true;
            this.RecibidaRadioButton.Text = "Recibida";
            this.RecibidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "RUT Emisor";
            // 
            // RutEmisorTextbox
            // 
            this.RutEmisorTextbox.Location = new System.Drawing.Point(109, 38);
            this.RutEmisorTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RutEmisorTextbox.Name = "RutEmisorTextbox";
            this.RutEmisorTextbox.Size = new System.Drawing.Size(89, 22);
            this.RutEmisorTextbox.TabIndex = 1;
            // 
            // ListadoButton
            // 
            this.ListadoButton.Location = new System.Drawing.Point(728, 22);
            this.ListadoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListadoButton.Name = "ListadoButton";
            this.ListadoButton.Size = new System.Drawing.Size(98, 53);
            this.ListadoButton.TabIndex = 0;
            this.ListadoButton.Text = "Traer Listado";
            this.ListadoButton.UseVisualStyleBackColor = true;
            this.ListadoButton.Click += new System.EventHandler(this.ListadoButton_Click);
            // 
            // gridResultados
            // 
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Location = new System.Drawing.Point(11, 114);
            this.gridResultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.RowTemplate.Height = 28;
            this.gridResultados.Size = new System.Drawing.Size(840, 296);
            this.gridResultados.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RetencionLiquidoValorLabel);
            this.groupBox2.Controls.Add(this.RetencionContribuyentesValorLabel);
            this.groupBox2.Controls.Add(this.RetencionTercerosValorLabel);
            this.groupBox2.Controls.Add(this.TotalAnuladasValorLabel);
            this.groupBox2.Controls.Add(this.TotalVigentesValorLabel);
            this.groupBox2.Controls.Add(this.TotalHonorarioBrutoValorLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(484, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(366, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // RetencionLiquidoValorLabel
            // 
            this.RetencionLiquidoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetencionLiquidoValorLabel.Location = new System.Drawing.Point(255, 170);
            this.RetencionLiquidoValorLabel.Name = "RetencionLiquidoValorLabel";
            this.RetencionLiquidoValorLabel.Size = new System.Drawing.Size(89, 18);
            this.RetencionLiquidoValorLabel.TabIndex = 11;
            this.RetencionLiquidoValorLabel.Text = "0";
            this.RetencionLiquidoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RetencionContribuyentesValorLabel
            // 
            this.RetencionContribuyentesValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetencionContribuyentesValorLabel.Location = new System.Drawing.Point(255, 142);
            this.RetencionContribuyentesValorLabel.Name = "RetencionContribuyentesValorLabel";
            this.RetencionContribuyentesValorLabel.Size = new System.Drawing.Size(89, 18);
            this.RetencionContribuyentesValorLabel.TabIndex = 10;
            this.RetencionContribuyentesValorLabel.Text = "0";
            this.RetencionContribuyentesValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RetencionTercerosValorLabel
            // 
            this.RetencionTercerosValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetencionTercerosValorLabel.Location = new System.Drawing.Point(255, 116);
            this.RetencionTercerosValorLabel.Name = "RetencionTercerosValorLabel";
            this.RetencionTercerosValorLabel.Size = new System.Drawing.Size(89, 18);
            this.RetencionTercerosValorLabel.TabIndex = 9;
            this.RetencionTercerosValorLabel.Text = "0";
            this.RetencionTercerosValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalAnuladasValorLabel
            // 
            this.TotalAnuladasValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAnuladasValorLabel.Location = new System.Drawing.Point(255, 89);
            this.TotalAnuladasValorLabel.Name = "TotalAnuladasValorLabel";
            this.TotalAnuladasValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalAnuladasValorLabel.TabIndex = 8;
            this.TotalAnuladasValorLabel.Text = "0";
            this.TotalAnuladasValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalVigentesValorLabel
            // 
            this.TotalVigentesValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVigentesValorLabel.Location = new System.Drawing.Point(255, 62);
            this.TotalVigentesValorLabel.Name = "TotalVigentesValorLabel";
            this.TotalVigentesValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalVigentesValorLabel.TabIndex = 7;
            this.TotalVigentesValorLabel.Text = "0";
            this.TotalVigentesValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalHonorarioBrutoValorLabel
            // 
            this.TotalHonorarioBrutoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHonorarioBrutoValorLabel.Location = new System.Drawing.Point(255, 35);
            this.TotalHonorarioBrutoValorLabel.Name = "TotalHonorarioBrutoValorLabel";
            this.TotalHonorarioBrutoValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalHonorarioBrutoValorLabel.TabIndex = 6;
            this.TotalHonorarioBrutoValorLabel.Text = "0";
            this.TotalHonorarioBrutoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Retención Líquido";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Retención de Contribuyentes";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Retención de Terceros";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Anuladas";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vigentes";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Honorarios Brutos";
            // 
            // numericAnio
            // 
            this.numericAnio.Location = new System.Drawing.Point(263, 39);
            this.numericAnio.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericAnio.Minimum = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            this.numericAnio.Name = "numericAnio";
            this.numericAnio.Size = new System.Drawing.Size(60, 22);
            this.numericAnio.TabIndex = 13;
            this.numericAnio.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            // 
            // ListadoAnualBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoAnualBoletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Anual de Boletas";
            this.Load += new System.EventHandler(this.ListadoAnualBoletas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RetencionLiquidoValorLabel;
        private System.Windows.Forms.Label RetencionContribuyentesValorLabel;
        private System.Windows.Forms.Label RetencionTercerosValorLabel;
        private System.Windows.Forms.Label TotalAnuladasValorLabel;
        private System.Windows.Forms.Label TotalVigentesValorLabel;
        private System.Windows.Forms.Label TotalHonorarioBrutoValorLabel;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.DataGridView gridResultados;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton EmitidaRadioButton;
        private System.Windows.Forms.RadioButton RecibidaRadioButton;
        private System.Windows.Forms.Button ListadoButton;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutEmisorTextbox;

        #endregion

        private System.Windows.Forms.NumericUpDown numericAnio;
    }
}