using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class ListadoMensualBoletas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CantidadDocumentosValorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalLiquidoValorLabel = new System.Windows.Forms.Label();
            this.TotalRetencionReceptorValorLabel = new System.Windows.Forms.Label();
            this.TotalRetencionEmisorValorLabel = new System.Windows.Forms.Label();
            this.TotalPagadoValorLabel = new System.Windows.Forms.Label();
            this.TotalRetenidoValorLabel = new System.Windows.Forms.Label();
            this.TotalBrutoValorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBoletaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutEmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazónSocialEmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrutoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionEmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiquidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetenidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MesLabel = new System.Windows.Forms.Label();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmitidaRadioButton = new System.Windows.Forms.RadioButton();
            this.RecibidaRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.AnioTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RutEmisorTextbox = new System.Windows.Forms.TextBox();
            this.ListadoButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CantidadDocumentosValorLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TotalLiquidoValorLabel);
            this.groupBox2.Controls.Add(this.TotalRetencionReceptorValorLabel);
            this.groupBox2.Controls.Add(this.TotalRetencionEmisorValorLabel);
            this.groupBox2.Controls.Add(this.TotalPagadoValorLabel);
            this.groupBox2.Controls.Add(this.TotalRetenidoValorLabel);
            this.groupBox2.Controls.Add(this.TotalBrutoValorLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(544, 533);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 268);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // CantidadDocumentosValorLabel
            // 
            this.CantidadDocumentosValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadDocumentosValorLabel.Location = new System.Drawing.Point(285, 31);
            this.CantidadDocumentosValorLabel.Name = "CantidadDocumentosValorLabel";
            this.CantidadDocumentosValorLabel.Size = new System.Drawing.Size(100, 23);
            this.CantidadDocumentosValorLabel.TabIndex = 13;
            this.CantidadDocumentosValorLabel.Text = "0";
            this.CantidadDocumentosValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cantidad de Documentos";
            // 
            // TotalLiquidoValorLabel
            // 
            this.TotalLiquidoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLiquidoValorLabel.Location = new System.Drawing.Point(285, 232);
            this.TotalLiquidoValorLabel.Name = "TotalLiquidoValorLabel";
            this.TotalLiquidoValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalLiquidoValorLabel.TabIndex = 11;
            this.TotalLiquidoValorLabel.Text = "0";
            this.TotalLiquidoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalRetencionReceptorValorLabel
            // 
            this.TotalRetencionReceptorValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRetencionReceptorValorLabel.Location = new System.Drawing.Point(285, 198);
            this.TotalRetencionReceptorValorLabel.Name = "TotalRetencionReceptorValorLabel";
            this.TotalRetencionReceptorValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalRetencionReceptorValorLabel.TabIndex = 10;
            this.TotalRetencionReceptorValorLabel.Text = "0";
            this.TotalRetencionReceptorValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalRetencionEmisorValorLabel
            // 
            this.TotalRetencionEmisorValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRetencionEmisorValorLabel.Location = new System.Drawing.Point(285, 165);
            this.TotalRetencionEmisorValorLabel.Name = "TotalRetencionEmisorValorLabel";
            this.TotalRetencionEmisorValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalRetencionEmisorValorLabel.TabIndex = 9;
            this.TotalRetencionEmisorValorLabel.Text = "0";
            this.TotalRetencionEmisorValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalPagadoValorLabel
            // 
            this.TotalPagadoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagadoValorLabel.Location = new System.Drawing.Point(285, 131);
            this.TotalPagadoValorLabel.Name = "TotalPagadoValorLabel";
            this.TotalPagadoValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalPagadoValorLabel.TabIndex = 8;
            this.TotalPagadoValorLabel.Text = "0";
            this.TotalPagadoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalRetenidoValorLabel
            // 
            this.TotalRetenidoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRetenidoValorLabel.Location = new System.Drawing.Point(285, 97);
            this.TotalRetenidoValorLabel.Name = "TotalRetenidoValorLabel";
            this.TotalRetenidoValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalRetenidoValorLabel.TabIndex = 7;
            this.TotalRetenidoValorLabel.Text = "0";
            this.TotalRetenidoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalBrutoValorLabel
            // 
            this.TotalBrutoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBrutoValorLabel.Location = new System.Drawing.Point(285, 64);
            this.TotalBrutoValorLabel.Name = "TotalBrutoValorLabel";
            this.TotalBrutoValorLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalBrutoValorLabel.TabIndex = 6;
            this.TotalBrutoValorLabel.Text = "0";
            this.TotalBrutoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Líquido";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Retención Receptor";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Retención Emisor";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Pagado";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Retenido";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Bruto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.NumeroColumn, this.EstadoColumn, this.FechaBoletaColumn, this.RutEmisorColumn, this.RazónSocialEmisorColumn, this.RutReceptorColumn, this.RazonSocialReceptor, this.BrutoColumn, this.RetencionEmisorColumn, this.RetencionReceptorColumn, this.LiquidoColumn, this.PagadoColumn, this.RetenidoColumn });
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(945, 370);
            this.dataGridView1.TabIndex = 5;
            // 
            // NumeroColumn
            // 
            this.NumeroColumn.HeaderText = "Número";
            this.NumeroColumn.Name = "NumeroColumn";
            // 
            // EstadoColumn
            // 
            this.EstadoColumn.HeaderText = "Estado";
            this.EstadoColumn.Name = "EstadoColumn";
            // 
            // FechaBoletaColumn
            // 
            this.FechaBoletaColumn.HeaderText = "Fecha Boleta";
            this.FechaBoletaColumn.Name = "FechaBoletaColumn";
            // 
            // RutEmisorColumn
            // 
            this.RutEmisorColumn.HeaderText = "Rut Emisor";
            this.RutEmisorColumn.Name = "RutEmisorColumn";
            // 
            // RazónSocialEmisorColumn
            // 
            this.RazónSocialEmisorColumn.HeaderText = "Razón Social Emisor";
            this.RazónSocialEmisorColumn.Name = "RazónSocialEmisorColumn";
            // 
            // RutReceptorColumn
            // 
            this.RutReceptorColumn.HeaderText = "Rut Receptor";
            this.RutReceptorColumn.Name = "RutReceptorColumn";
            // 
            // RazonSocialReceptor
            // 
            this.RazonSocialReceptor.HeaderText = "Razón Social Receptor";
            this.RazonSocialReceptor.Name = "RazonSocialReceptor";
            // 
            // BrutoColumn
            // 
            this.BrutoColumn.HeaderText = "Bruto";
            this.BrutoColumn.Name = "BrutoColumn";
            // 
            // RetencionEmisorColumn
            // 
            this.RetencionEmisorColumn.HeaderText = "Retención Emisor";
            this.RetencionEmisorColumn.Name = "RetencionEmisorColumn";
            // 
            // RetencionReceptorColumn
            // 
            this.RetencionReceptorColumn.HeaderText = "Retención Receptor";
            this.RetencionReceptorColumn.Name = "RetencionReceptorColumn";
            // 
            // LiquidoColumn
            // 
            this.LiquidoColumn.HeaderText = "Líquido";
            this.LiquidoColumn.Name = "LiquidoColumn";
            // 
            // PagadoColumn
            // 
            this.PagadoColumn.HeaderText = "Pagado";
            this.PagadoColumn.Name = "PagadoColumn";
            // 
            // RetenidoColumn
            // 
            this.RetenidoColumn.HeaderText = "Retenido";
            this.RetenidoColumn.Name = "RetenidoColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MesLabel);
            this.groupBox1.Controls.Add(this.MesTextBox);
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
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Boleta de Honorarios Electrónica";
            // 
            // MesLabel
            // 
            this.MesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesLabel.Location = new System.Drawing.Point(373, 49);
            this.MesLabel.Name = "MesLabel";
            this.MesLabel.Size = new System.Drawing.Size(46, 23);
            this.MesLabel.TabIndex = 11;
            this.MesLabel.Text = "Mes";
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(425, 49);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.Size = new System.Drawing.Size(61, 26);
            this.MesTextBox.TabIndex = 10;
            this.MesTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // EmitidaRadioButton
            // 
            this.EmitidaRadioButton.Location = new System.Drawing.Point(642, 49);
            this.EmitidaRadioButton.Name = "EmitidaRadioButton";
            this.EmitidaRadioButton.Size = new System.Drawing.Size(104, 24);
            this.EmitidaRadioButton.TabIndex = 8;
            this.EmitidaRadioButton.TabStop = true;
            this.EmitidaRadioButton.Text = "Emitida";
            this.EmitidaRadioButton.UseVisualStyleBackColor = true;
            // 
            // RecibidaRadioButton
            // 
            this.RecibidaRadioButton.Location = new System.Drawing.Point(532, 49);
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
            this.AnioTextbox.Text = "0";
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
            // 
            // ListadoMensualBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 818);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoMensualBoletas";
            this.Text = "Listado Mensual de Boletas";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBoletaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutEmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazónSocialEmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrutoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionEmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiquidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagadoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetenidoColumn;

        private System.Windows.Forms.Label CantidadDocumentosValorLabel;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TotalLiquidoValorLabel;
        private System.Windows.Forms.Label TotalRetencionReceptorValorLabel;
        private System.Windows.Forms.Label TotalRetencionEmisorValorLabel;
        private System.Windows.Forms.Label TotalPagadoValorLabel;
        private System.Windows.Forms.Label TotalRetenidoValorLabel;
        private System.Windows.Forms.Label TotalBrutoValorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton EmitidaRadioButton;
        private System.Windows.Forms.RadioButton RecibidaRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnioTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutEmisorTextbox;
        private System.Windows.Forms.Button ListadoButton;
        private System.Windows.Forms.Label MesLabel;
        private System.Windows.Forms.TextBox MesTextBox;

        #endregion
    }
}