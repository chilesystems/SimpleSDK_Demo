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
            this.AnioTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RutEmisorTextbox = new System.Windows.Forms.TextBox();
            this.ListadoButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolioInicialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolioFinalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVigentesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAnuladasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HonorarioBrutoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionTercerosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionContribuyenteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLiquidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RetencionLiquidoValorLabel = new System.Windows.Forms.Label();
            this.RetencionContribuyentesValorLabel = new System.Windows.Forms.Label();
            this.RetencionTercerosValorLabel = new System.Windows.Forms.Label();
            this.otalAnuladasValorLabel = new System.Windows.Forms.Label();
            this.TotalVigentesValorLabel = new System.Windows.Forms.Label();
            this.TotalHonorarioBrutoValorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EmitidaRadioButton);
            this.groupBox1.Controls.Add(this.RecibidaRadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AnioTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RutEmisorTextbox);
            this.groupBox1.Controls.Add(this.ListadoButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Boleta de Honorarios Electrónica";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // EmitidaRadioButton
            // 
            this.EmitidaRadioButton.Location = new System.Drawing.Point(484, 49);
            this.EmitidaRadioButton.Name = "EmitidaRadioButton";
            this.EmitidaRadioButton.Size = new System.Drawing.Size(104, 24);
            this.EmitidaRadioButton.TabIndex = 8;
            this.EmitidaRadioButton.Text = "Emitida";
            this.EmitidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // RecibidaRadioButton
            // 
            this.RecibidaRadioButton.Checked = true;
            this.RecibidaRadioButton.Location = new System.Drawing.Point(374, 49);
            this.RecibidaRadioButton.Name = "RecibidaRadioButton";
            this.RecibidaRadioButton.Size = new System.Drawing.Size(104, 24);
            this.RecibidaRadioButton.TabIndex = 7;
            this.RecibidaRadioButton.TabStop = true;
            this.RecibidaRadioButton.Text = "Recibida";
            this.RecibidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // AnioTextbox
            // 
            this.AnioTextbox.Location = new System.Drawing.Point(295, 48);
            this.AnioTextbox.Name = "AnioTextbox";
            this.AnioTextbox.Size = new System.Drawing.Size(61, 26);
            this.AnioTextbox.TabIndex = 5;
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
            // RutEmisorTextbox
            // 
            this.RutEmisorTextbox.Location = new System.Drawing.Point(123, 48);
            this.RutEmisorTextbox.Name = "RutEmisorTextbox";
            this.RutEmisorTextbox.Size = new System.Drawing.Size(100, 26);
            this.RutEmisorTextbox.TabIndex = 1;
            // 
            // ListadoButton
            // 
            this.ListadoButton.Location = new System.Drawing.Point(819, 28);
            this.ListadoButton.Name = "ListadoButton";
            this.ListadoButton.Size = new System.Drawing.Size(110, 66);
            this.ListadoButton.TabIndex = 0;
            this.ListadoButton.Text = "Traer Listado";
            this.ListadoButton.UseVisualStyleBackColor = true;
            this.ListadoButton.Click += new System.EventHandler(this.ListadoButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.MesColumn, this.FolioInicialColumn, this.FolioFinalColumn, this.CantidadVigentesColumn, this.CantidadAnuladasColumn, this.HonorarioBrutoColumn, this.RetencionTercerosColumn, this.RetencionContribuyenteColumn, this.TotalLiquidoColumn });
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(945, 370);
            this.dataGridView1.TabIndex = 2;
            // 
            // MesColumn
            // 
            this.MesColumn.HeaderText = "Mes";
            this.MesColumn.Name = "MesColumn";
            // 
            // FolioInicialColumn
            // 
            this.FolioInicialColumn.HeaderText = "Folio Inicial";
            this.FolioInicialColumn.Name = "FolioInicialColumn";
            // 
            // FolioFinalColumn
            // 
            this.FolioFinalColumn.HeaderText = "Folio Final";
            this.FolioFinalColumn.Name = "FolioFinalColumn";
            // 
            // CantidadVigentesColumn
            // 
            this.CantidadVigentesColumn.HeaderText = "Cantidad Vigentes";
            this.CantidadVigentesColumn.Name = "CantidadVigentesColumn";
            // 
            // CantidadAnuladasColumn
            // 
            this.CantidadAnuladasColumn.HeaderText = "Cantidad Anuladas";
            this.CantidadAnuladasColumn.Name = "CantidadAnuladasColumn";
            // 
            // HonorarioBrutoColumn
            // 
            this.HonorarioBrutoColumn.HeaderText = "Honorario Bruto";
            this.HonorarioBrutoColumn.Name = "HonorarioBrutoColumn";
            // 
            // RetencionTercerosColumn
            // 
            this.RetencionTercerosColumn.HeaderText = "Retencion Terceros";
            this.RetencionTercerosColumn.Name = "RetencionTercerosColumn";
            // 
            // RetencionContribuyenteColumn
            // 
            this.RetencionContribuyenteColumn.HeaderText = "Retencion Contribuyente";
            this.RetencionContribuyenteColumn.Name = "RetencionContribuyenteColumn";
            // 
            // TotalLiquidoColumn
            // 
            this.TotalLiquidoColumn.HeaderText = "Total Líquido";
            this.TotalLiquidoColumn.Name = "TotalLiquidoColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RetencionLiquidoValorLabel);
            this.groupBox2.Controls.Add(this.RetencionContribuyentesValorLabel);
            this.groupBox2.Controls.Add(this.RetencionTercerosValorLabel);
            this.groupBox2.Controls.Add(this.otalAnuladasValorLabel);
            this.groupBox2.Controls.Add(this.TotalVigentesValorLabel);
            this.groupBox2.Controls.Add(this.TotalHonorarioBrutoValorLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(544, 533);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 251);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // RetencionLiquidoValorLabel
            // 
            this.RetencionLiquidoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetencionLiquidoValorLabel.Location = new System.Drawing.Point(287, 212);
            this.RetencionLiquidoValorLabel.Name = "RetencionLiquidoValorLabel";
            this.RetencionLiquidoValorLabel.Size = new System.Drawing.Size(100, 23);
            this.RetencionLiquidoValorLabel.TabIndex = 11;
            this.RetencionLiquidoValorLabel.Text = "0";
            this.RetencionLiquidoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RetencionContribuyentesValorLabel
            // 
            this.RetencionContribuyentesValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetencionContribuyentesValorLabel.Location = new System.Drawing.Point(287, 178);
            this.RetencionContribuyentesValorLabel.Name = "RetencionContribuyentesValorLabel";
            this.RetencionContribuyentesValorLabel.Size = new System.Drawing.Size(100, 23);
            this.RetencionContribuyentesValorLabel.TabIndex = 10;
            this.RetencionContribuyentesValorLabel.Text = "0";
            this.RetencionContribuyentesValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RetencionTercerosValorLabel
            // 
            this.RetencionTercerosValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetencionTercerosValorLabel.Location = new System.Drawing.Point(287, 145);
            this.RetencionTercerosValorLabel.Name = "RetencionTercerosValorLabel";
            this.RetencionTercerosValorLabel.Size = new System.Drawing.Size(100, 23);
            this.RetencionTercerosValorLabel.TabIndex = 9;
            this.RetencionTercerosValorLabel.Text = "0";
            this.RetencionTercerosValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // otalAnuladasValorLabel
            // 
            this.otalAnuladasValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otalAnuladasValorLabel.Location = new System.Drawing.Point(287, 111);
            this.otalAnuladasValorLabel.Name = "otalAnuladasValorLabel";
            this.otalAnuladasValorLabel.Size = new System.Drawing.Size(100, 23);
            this.otalAnuladasValorLabel.TabIndex = 8;
            this.otalAnuladasValorLabel.Text = "0";
            this.otalAnuladasValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalVigentesValorLabel
            // 
            this.TotalVigentesValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVigentesValorLabel.Location = new System.Drawing.Point(287, 77);
            this.TotalVigentesValorLabel.Name = "TotalVigentesValorLabel";
            this.TotalVigentesValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalVigentesValorLabel.TabIndex = 7;
            this.TotalVigentesValorLabel.Text = "0";
            this.TotalVigentesValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalHonorarioBrutoValorLabel
            // 
            this.TotalHonorarioBrutoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHonorarioBrutoValorLabel.Location = new System.Drawing.Point(287, 44);
            this.TotalHonorarioBrutoValorLabel.Name = "TotalHonorarioBrutoValorLabel";
            this.TotalHonorarioBrutoValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalHonorarioBrutoValorLabel.TabIndex = 6;
            this.TotalHonorarioBrutoValorLabel.Text = "0";
            this.TotalHonorarioBrutoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Retención Líquido";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Retención de Contribuyentes";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Retención de Terceros";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Anuladas";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vigentes";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Honorarios Brutos";
            // 
            // ListadoAnualBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 799);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoAnualBoletas";
            this.Text = "Listado Anual de Boletas";
            this.Load += new System.EventHandler(this.ListadoAnualBoletas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label otalAnuladasValorLabel;
        private System.Windows.Forms.Label TotalVigentesValorLabel;
        private System.Windows.Forms.Label TotalHonorarioBrutoValorLabel;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionContribuyenteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLiquidoColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn MesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioInicialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioFinalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVigentesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAnuladasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HonorarioBrutoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionTercerosColumn;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton EmitidaRadioButton;
        private System.Windows.Forms.RadioButton RecibidaRadioButton;
        private System.Windows.Forms.Button ListadoButton;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnioTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutEmisorTextbox;

        #endregion
    }
}