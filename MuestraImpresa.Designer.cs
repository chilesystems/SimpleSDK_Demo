
namespace SimpleSDK_Demo
{
    partial class MuestraImpresa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio80mm = new System.Windows.Forms.RadioButton();
            this.radio58m = new System.Windows.Forms.RadioButton();
            this.radioCarta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPDF = new System.Windows.Forms.RadioButton();
            this.radioBase64 = new System.Windows.Forms.RadioButton();
            this.botonVisualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateHoraEmision = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUnidadSII = new System.Windows.Forms.TextBox();
            this.numericNroRes = new System.Windows.Forms.NumericUpDown();
            this.dateFechaRes = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textFormaPago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCondVenta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNroRes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio80mm);
            this.groupBox1.Controls.Add(this.radio58m);
            this.groupBox1.Controls.Add(this.radioCarta);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(245, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato Impresión";
            // 
            // radio80mm
            // 
            this.radio80mm.AutoSize = true;
            this.radio80mm.Enabled = false;
            this.radio80mm.Location = new System.Drawing.Point(161, 38);
            this.radio80mm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio80mm.Name = "radio80mm";
            this.radio80mm.Size = new System.Drawing.Size(64, 20);
            this.radio80mm.TabIndex = 2;
            this.radio80mm.Text = "80mm";
            this.radio80mm.UseVisualStyleBackColor = true;
            // 
            // radio58m
            // 
            this.radio58m.AutoSize = true;
            this.radio58m.Location = new System.Drawing.Point(83, 38);
            this.radio58m.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio58m.Name = "radio58m";
            this.radio58m.Size = new System.Drawing.Size(64, 20);
            this.radio58m.TabIndex = 1;
            this.radio58m.Text = "58mm";
            this.radio58m.UseVisualStyleBackColor = true;
            // 
            // radioCarta
            // 
            this.radioCarta.AutoSize = true;
            this.radioCarta.Checked = true;
            this.radioCarta.Location = new System.Drawing.Point(8, 38);
            this.radioCarta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCarta.Name = "radioCarta";
            this.radioCarta.Size = new System.Drawing.Size(60, 20);
            this.radioCarta.TabIndex = 0;
            this.radioCarta.TabStop = true;
            this.radioCarta.Text = "Carta";
            this.radioCarta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPDF);
            this.groupBox2.Controls.Add(this.radioBase64);
            this.groupBox2.Location = new System.Drawing.Point(16, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(245, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formato de Salida";
            // 
            // radioPDF
            // 
            this.radioPDF.AutoSize = true;
            this.radioPDF.Checked = true;
            this.radioPDF.Location = new System.Drawing.Point(101, 38);
            this.radioPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPDF.Name = "radioPDF";
            this.radioPDF.Size = new System.Drawing.Size(103, 20);
            this.radioPDF.TabIndex = 1;
            this.radioPDF.TabStop = true;
            this.radioPDF.Text = "Archivo PDF";
            this.radioPDF.UseVisualStyleBackColor = true;
            // 
            // radioBase64
            // 
            this.radioBase64.AutoSize = true;
            this.radioBase64.Location = new System.Drawing.Point(8, 38);
            this.radioBase64.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBase64.Name = "radioBase64";
            this.radioBase64.Size = new System.Drawing.Size(77, 20);
            this.radioBase64.TabIndex = 0;
            this.radioBase64.Text = "Base 64";
            this.radioBase64.UseVisualStyleBackColor = true;
            // 
            // botonVisualizar
            // 
            this.botonVisualizar.Location = new System.Drawing.Point(505, 318);
            this.botonVisualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonVisualizar.Name = "botonVisualizar";
            this.botonVisualizar.Size = new System.Drawing.Size(107, 37);
            this.botonVisualizar.TabIndex = 2;
            this.botonVisualizar.Text = "Visualizar";
            this.botonVisualizar.UseVisualStyleBackColor = true;
            this.botonVisualizar.Click += new System.EventHandler(this.botonVisualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textCondVenta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textFormaPago);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateHoraEmision);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textVendedor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textUnidadSII);
            this.groupBox3.Controls.Add(this.numericNroRes);
            this.groupBox3.Controls.Add(this.dateFechaRes);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(269, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(343, 256);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personalización de campos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora:";
            // 
            // dateHoraEmision
            // 
            this.dateHoraEmision.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateHoraEmision.Location = new System.Drawing.Point(164, 222);
            this.dateHoraEmision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateHoraEmision.Name = "dateHoraEmision";
            this.dateHoraEmision.Size = new System.Drawing.Size(109, 22);
            this.dateHoraEmision.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vendedor:";
            // 
            // textVendedor
            // 
            this.textVendedor.Location = new System.Drawing.Point(164, 131);
            this.textVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textVendedor.Name = "textVendedor";
            this.textVendedor.Size = new System.Drawing.Size(163, 22);
            this.textVendedor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidad SII:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro de Resolución:";
            // 
            // textUnidadSII
            // 
            this.textUnidadSII.Location = new System.Drawing.Point(164, 100);
            this.textUnidadSII.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUnidadSII.Name = "textUnidadSII";
            this.textUnidadSII.Size = new System.Drawing.Size(163, 22);
            this.textUnidadSII.TabIndex = 3;
            // 
            // numericNroRes
            // 
            this.numericNroRes.Location = new System.Drawing.Point(164, 68);
            this.numericNroRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericNroRes.Name = "numericNroRes";
            this.numericNroRes.Size = new System.Drawing.Size(65, 22);
            this.numericNroRes.TabIndex = 2;
            // 
            // dateFechaRes
            // 
            this.dateFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaRes.Location = new System.Drawing.Point(164, 36);
            this.dateFechaRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFechaRes.Name = "dateFechaRes";
            this.dateFechaRes.Size = new System.Drawing.Size(163, 22);
            this.dateFechaRes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Resolución:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Image = global::SimpleSDK_Demo.Properties.Resources.View;
            this.botonBuscar.Location = new System.Drawing.Point(573, 281);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(39, 25);
            this.botonBuscar.TabIndex = 12;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Logo:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(331, 281);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(233, 22);
            this.txtFilePath.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Forma Pago";
            // 
            // textFormaPago
            // 
            this.textFormaPago.Location = new System.Drawing.Point(164, 161);
            this.textFormaPago.Margin = new System.Windows.Forms.Padding(4);
            this.textFormaPago.Name = "textFormaPago";
            this.textFormaPago.Size = new System.Drawing.Size(163, 22);
            this.textFormaPago.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Condición Venta";
            // 
            // textCondVenta
            // 
            this.textCondVenta.Location = new System.Drawing.Point(164, 191);
            this.textCondVenta.Margin = new System.Windows.Forms.Padding(4);
            this.textCondVenta.Name = "textCondVenta";
            this.textCondVenta.Size = new System.Drawing.Size(163, 22);
            this.textCondVenta.TabIndex = 12;
            // 
            // MuestraImpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 373);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.botonVisualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuestraImpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra Impresa de un DTE";
            this.Load += new System.EventHandler(this.MuestraImpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNroRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio80mm;
        private System.Windows.Forms.RadioButton radio58m;
        private System.Windows.Forms.RadioButton radioCarta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPDF;
        private System.Windows.Forms.RadioButton radioBase64;
        private System.Windows.Forms.Button botonVisualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUnidadSII;
        private System.Windows.Forms.NumericUpDown numericNroRes;
        private System.Windows.Forms.DateTimePicker dateFechaRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textVendedor;
        private System.Windows.Forms.DateTimePicker dateHoraEmision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCondVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFormaPago;
    }
}