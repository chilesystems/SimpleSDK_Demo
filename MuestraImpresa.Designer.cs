
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
            this.radioCarta = new System.Windows.Forms.RadioButton();
            this.radio58m = new System.Windows.Forms.RadioButton();
            this.radio80mm = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPDF = new System.Windows.Forms.RadioButton();
            this.radioBase64 = new System.Windows.Forms.RadioButton();
            this.botonVisualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFechaRes = new System.Windows.Forms.DateTimePicker();
            this.numericNroRes = new System.Windows.Forms.NumericUpDown();
            this.textUnidadSII = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textVendedor = new System.Windows.Forms.TextBox();
            this.dateHoraEmision = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato Impresión";
            // 
            // radioCarta
            // 
            this.radioCarta.AutoSize = true;
            this.radioCarta.Checked = true;
            this.radioCarta.Location = new System.Drawing.Point(6, 31);
            this.radioCarta.Name = "radioCarta";
            this.radioCarta.Size = new System.Drawing.Size(50, 17);
            this.radioCarta.TabIndex = 0;
            this.radioCarta.TabStop = true;
            this.radioCarta.Text = "Carta";
            this.radioCarta.UseVisualStyleBackColor = true;
            // 
            // radio58m
            // 
            this.radio58m.AutoSize = true;
            this.radio58m.Location = new System.Drawing.Point(62, 31);
            this.radio58m.Name = "radio58m";
            this.radio58m.Size = new System.Drawing.Size(53, 17);
            this.radio58m.TabIndex = 1;
            this.radio58m.Text = "58mm";
            this.radio58m.UseVisualStyleBackColor = true;
            // 
            // radio80mm
            // 
            this.radio80mm.AutoSize = true;
            this.radio80mm.Enabled = false;
            this.radio80mm.Location = new System.Drawing.Point(121, 31);
            this.radio80mm.Name = "radio80mm";
            this.radio80mm.Size = new System.Drawing.Size(53, 17);
            this.radio80mm.TabIndex = 2;
            this.radio80mm.Text = "80mm";
            this.radio80mm.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPDF);
            this.groupBox2.Controls.Add(this.radioBase64);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formato de Salida";
            // 
            // radioPDF
            // 
            this.radioPDF.AutoSize = true;
            this.radioPDF.Checked = true;
            this.radioPDF.Location = new System.Drawing.Point(76, 31);
            this.radioPDF.Name = "radioPDF";
            this.radioPDF.Size = new System.Drawing.Size(85, 17);
            this.radioPDF.TabIndex = 1;
            this.radioPDF.TabStop = true;
            this.radioPDF.Text = "Archivo PDF";
            this.radioPDF.UseVisualStyleBackColor = true;
            // 
            // radioBase64
            // 
            this.radioBase64.AutoSize = true;
            this.radioBase64.Location = new System.Drawing.Point(6, 31);
            this.radioBase64.Name = "radioBase64";
            this.radioBase64.Size = new System.Drawing.Size(64, 17);
            this.radioBase64.TabIndex = 0;
            this.radioBase64.Text = "Base 64";
            this.radioBase64.UseVisualStyleBackColor = true;
            // 
            // botonVisualizar
            // 
            this.botonVisualizar.Location = new System.Drawing.Point(379, 246);
            this.botonVisualizar.Name = "botonVisualizar";
            this.botonVisualizar.Size = new System.Drawing.Size(80, 30);
            this.botonVisualizar.TabIndex = 2;
            this.botonVisualizar.Text = "Visualizar";
            this.botonVisualizar.UseVisualStyleBackColor = true;
            this.botonVisualizar.Click += new System.EventHandler(this.botonVisualizar_Click);
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(202, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personalización de campos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Resolución:";
            // 
            // dateFechaRes
            // 
            this.dateFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaRes.Location = new System.Drawing.Point(123, 29);
            this.dateFechaRes.Name = "dateFechaRes";
            this.dateFechaRes.Size = new System.Drawing.Size(123, 20);
            this.dateFechaRes.TabIndex = 1;
            // 
            // numericNroRes
            // 
            this.numericNroRes.Location = new System.Drawing.Point(123, 55);
            this.numericNroRes.Name = "numericNroRes";
            this.numericNroRes.Size = new System.Drawing.Size(49, 20);
            this.numericNroRes.TabIndex = 2;
            // 
            // textUnidadSII
            // 
            this.textUnidadSII.Location = new System.Drawing.Point(123, 81);
            this.textUnidadSII.Name = "textUnidadSII";
            this.textUnidadSII.Size = new System.Drawing.Size(123, 20);
            this.textUnidadSII.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro de Resolución:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidad SII:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vendedor:";
            // 
            // textVendedor
            // 
            this.textVendedor.Location = new System.Drawing.Point(123, 107);
            this.textVendedor.Name = "textVendedor";
            this.textVendedor.Size = new System.Drawing.Size(123, 20);
            this.textVendedor.TabIndex = 6;
            // 
            // dateHoraEmision
            // 
            this.dateHoraEmision.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateHoraEmision.Location = new System.Drawing.Point(123, 133);
            this.dateHoraEmision.Name = "dateHoraEmision";
            this.dateHoraEmision.Size = new System.Drawing.Size(83, 20);
            this.dateHoraEmision.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Image = global::SimpleSDK_Demo.Properties.Resources.View;
            this.botonBuscar.Location = new System.Drawing.Point(430, 184);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(29, 20);
            this.botonBuscar.TabIndex = 12;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Logo:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(248, 184);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(176, 20);
            this.txtFilePath.TabIndex = 10;
            // 
            // MuestraImpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 288);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.botonVisualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}