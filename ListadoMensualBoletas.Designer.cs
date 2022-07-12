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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmitidaRadioButton = new System.Windows.Forms.RadioButton();
            this.RecibidaRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RutEmisorTextbox = new System.Windows.Forms.TextBox();
            this.ListadoButton = new System.Windows.Forms.Button();
            this.NumeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBoletaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutEmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialEmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrutoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionEmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiquidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetenidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericAnio = new System.Windows.Forms.NumericUpDown();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(484, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(366, 214);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // CantidadDocumentosValorLabel
            // 
            this.CantidadDocumentosValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadDocumentosValorLabel.Location = new System.Drawing.Point(253, 25);
            this.CantidadDocumentosValorLabel.Name = "CantidadDocumentosValorLabel";
            this.CantidadDocumentosValorLabel.Size = new System.Drawing.Size(89, 18);
            this.CantidadDocumentosValorLabel.TabIndex = 13;
            this.CantidadDocumentosValorLabel.Text = "0";
            this.CantidadDocumentosValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cantidad de Documentos";
            // 
            // TotalLiquidoValorLabel
            // 
            this.TotalLiquidoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLiquidoValorLabel.Location = new System.Drawing.Point(253, 186);
            this.TotalLiquidoValorLabel.Name = "TotalLiquidoValorLabel";
            this.TotalLiquidoValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalLiquidoValorLabel.TabIndex = 11;
            this.TotalLiquidoValorLabel.Text = "0";
            this.TotalLiquidoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalRetencionReceptorValorLabel
            // 
            this.TotalRetencionReceptorValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRetencionReceptorValorLabel.Location = new System.Drawing.Point(253, 158);
            this.TotalRetencionReceptorValorLabel.Name = "TotalRetencionReceptorValorLabel";
            this.TotalRetencionReceptorValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalRetencionReceptorValorLabel.TabIndex = 10;
            this.TotalRetencionReceptorValorLabel.Text = "0";
            this.TotalRetencionReceptorValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalRetencionEmisorValorLabel
            // 
            this.TotalRetencionEmisorValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRetencionEmisorValorLabel.Location = new System.Drawing.Point(253, 132);
            this.TotalRetencionEmisorValorLabel.Name = "TotalRetencionEmisorValorLabel";
            this.TotalRetencionEmisorValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalRetencionEmisorValorLabel.TabIndex = 9;
            this.TotalRetencionEmisorValorLabel.Text = "0";
            this.TotalRetencionEmisorValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalPagadoValorLabel
            // 
            this.TotalPagadoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagadoValorLabel.Location = new System.Drawing.Point(253, 105);
            this.TotalPagadoValorLabel.Name = "TotalPagadoValorLabel";
            this.TotalPagadoValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalPagadoValorLabel.TabIndex = 8;
            this.TotalPagadoValorLabel.Text = "0";
            this.TotalPagadoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalRetenidoValorLabel
            // 
            this.TotalRetenidoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRetenidoValorLabel.Location = new System.Drawing.Point(253, 78);
            this.TotalRetenidoValorLabel.Name = "TotalRetenidoValorLabel";
            this.TotalRetenidoValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalRetenidoValorLabel.TabIndex = 7;
            this.TotalRetenidoValorLabel.Text = "0";
            this.TotalRetenidoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalBrutoValorLabel
            // 
            this.TotalBrutoValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBrutoValorLabel.Location = new System.Drawing.Point(253, 51);
            this.TotalBrutoValorLabel.Name = "TotalBrutoValorLabel";
            this.TotalBrutoValorLabel.Size = new System.Drawing.Size(89, 18);
            this.TotalBrutoValorLabel.TabIndex = 6;
            this.TotalBrutoValorLabel.Text = "0";
            this.TotalBrutoValorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Líquido";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Retención Receptor";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Retención Emisor";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Pagado";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Retenido";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Bruto";
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroColumn,
            this.EstadoColumn,
            this.FechaBoletaColumn,
            this.RutEmisorColumn,
            this.RazonSocialEmisorColumn,
            this.RutReceptorColumn,
            this.RazonSocialReceptorColumn,
            this.BrutoColumn,
            this.RetencionEmisorColumn,
            this.RetencionReceptorColumn,
            this.LiquidoColumn,
            this.PagadoColumn,
            this.RetenidoColumn});
            this.gridResultados.Location = new System.Drawing.Point(11, 114);
            this.gridResultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.RowTemplate.Height = 28;
            this.gridResultados.Size = new System.Drawing.Size(840, 296);
            this.gridResultados.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericMes);
            this.groupBox1.Controls.Add(this.numericAnio);
            this.groupBox1.Controls.Add(this.MesLabel);
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
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Boleta de Honorarios Electrónica";
            // 
            // MesLabel
            // 
            this.MesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesLabel.Location = new System.Drawing.Point(332, 39);
            this.MesLabel.Name = "MesLabel";
            this.MesLabel.Size = new System.Drawing.Size(41, 18);
            this.MesLabel.TabIndex = 11;
            this.MesLabel.Text = "Mes";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // EmitidaRadioButton
            // 
            this.EmitidaRadioButton.Location = new System.Drawing.Point(571, 39);
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
            this.RecibidaRadioButton.Location = new System.Drawing.Point(473, 39);
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
            // NumeroColumn
            // 
            this.NumeroColumn.DataPropertyName = "Numero";
            this.NumeroColumn.HeaderText = "Número";
            this.NumeroColumn.Name = "NumeroColumn";
            this.NumeroColumn.ReadOnly = true;
            // 
            // EstadoColumn
            // 
            this.EstadoColumn.DataPropertyName = "Estado";
            this.EstadoColumn.HeaderText = "Estado";
            this.EstadoColumn.Name = "EstadoColumn";
            this.EstadoColumn.ReadOnly = true;
            this.EstadoColumn.Width = 60;
            // 
            // FechaBoletaColumn
            // 
            this.FechaBoletaColumn.DataPropertyName = "FechaBoleta";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.FechaBoletaColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.FechaBoletaColumn.HeaderText = "Fecha Boleta";
            this.FechaBoletaColumn.Name = "FechaBoletaColumn";
            this.FechaBoletaColumn.ReadOnly = true;
            this.FechaBoletaColumn.Width = 80;
            // 
            // RutEmisorColumn
            // 
            this.RutEmisorColumn.DataPropertyName = "RutEmisor";
            this.RutEmisorColumn.HeaderText = "Rut Emisor";
            this.RutEmisorColumn.Name = "RutEmisorColumn";
            this.RutEmisorColumn.ReadOnly = true;
            // 
            // RazonSocialEmisorColumn
            // 
            this.RazonSocialEmisorColumn.DataPropertyName = "RazonSocialEmisor";
            this.RazonSocialEmisorColumn.HeaderText = "Razón Social Emisor";
            this.RazonSocialEmisorColumn.Name = "RazonSocialEmisorColumn";
            this.RazonSocialEmisorColumn.ReadOnly = true;
            this.RazonSocialEmisorColumn.Width = 200;
            // 
            // RutReceptorColumn
            // 
            this.RutReceptorColumn.DataPropertyName = "RutReceptor";
            this.RutReceptorColumn.HeaderText = "Rut Receptor";
            this.RutReceptorColumn.Name = "RutReceptorColumn";
            this.RutReceptorColumn.ReadOnly = true;
            // 
            // RazonSocialReceptorColumn
            // 
            this.RazonSocialReceptorColumn.DataPropertyName = "RazonSocialReceptor";
            this.RazonSocialReceptorColumn.HeaderText = "Razón Social Receptor";
            this.RazonSocialReceptorColumn.Name = "RazonSocialReceptorColumn";
            this.RazonSocialReceptorColumn.ReadOnly = true;
            this.RazonSocialReceptorColumn.Width = 200;
            // 
            // BrutoColumn
            // 
            this.BrutoColumn.DataPropertyName = "Bruto";
            dataGridViewCellStyle9.Format = "N0";
            this.BrutoColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.BrutoColumn.HeaderText = "Bruto";
            this.BrutoColumn.Name = "BrutoColumn";
            this.BrutoColumn.ReadOnly = true;
            // 
            // RetencionEmisorColumn
            // 
            this.RetencionEmisorColumn.DataPropertyName = "RetencionEmisor";
            dataGridViewCellStyle10.Format = "N0";
            this.RetencionEmisorColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.RetencionEmisorColumn.HeaderText = "Retención Emisor";
            this.RetencionEmisorColumn.Name = "RetencionEmisorColumn";
            this.RetencionEmisorColumn.ReadOnly = true;
            // 
            // RetencionReceptorColumn
            // 
            this.RetencionReceptorColumn.DataPropertyName = "RetencionReceptor";
            dataGridViewCellStyle11.Format = "N0";
            this.RetencionReceptorColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.RetencionReceptorColumn.HeaderText = "Retención Receptor";
            this.RetencionReceptorColumn.Name = "RetencionReceptorColumn";
            this.RetencionReceptorColumn.ReadOnly = true;
            // 
            // LiquidoColumn
            // 
            this.LiquidoColumn.DataPropertyName = "Liquido";
            dataGridViewCellStyle12.Format = "N0";
            this.LiquidoColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.LiquidoColumn.HeaderText = "Líquido";
            this.LiquidoColumn.Name = "LiquidoColumn";
            this.LiquidoColumn.ReadOnly = true;
            // 
            // PagadoColumn
            // 
            this.PagadoColumn.DataPropertyName = "Pagado";
            dataGridViewCellStyle13.Format = "N0";
            this.PagadoColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.PagadoColumn.HeaderText = "Pagado";
            this.PagadoColumn.Name = "PagadoColumn";
            this.PagadoColumn.ReadOnly = true;
            // 
            // RetenidoColumn
            // 
            this.RetenidoColumn.DataPropertyName = "Retenido";
            dataGridViewCellStyle14.Format = "N0";
            this.RetenidoColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.RetenidoColumn.HeaderText = "Retenido";
            this.RetenidoColumn.Name = "RetenidoColumn";
            this.RetenidoColumn.ReadOnly = true;
            // 
            // numericAnio
            // 
            this.numericAnio.Location = new System.Drawing.Point(252, 39);
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
            this.numericAnio.TabIndex = 12;
            this.numericAnio.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            // 
            // numericMes
            // 
            this.numericMes.Location = new System.Drawing.Point(379, 39);
            this.numericMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(48, 22);
            this.numericMes.TabIndex = 13;
            this.numericMes.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // ListadoMensualBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoMensualBoletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Mensual de Boletas";
            this.Load += new System.EventHandler(this.ListadoMensualBoletas_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            this.ResumeLayout(false);

        }

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
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton EmitidaRadioButton;
        private System.Windows.Forms.RadioButton RecibidaRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutEmisorTextbox;
        private System.Windows.Forms.Button ListadoButton;
        private System.Windows.Forms.Label MesLabel;

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBoletaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutEmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialEmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrutoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionEmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiquidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagadoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetenidoColumn;
        private System.Windows.Forms.NumericUpDown numericAnio;
        private System.Windows.Forms.NumericUpDown numericMes;
    }
}