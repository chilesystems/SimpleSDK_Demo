namespace SimpleSDK_Demo
{
    partial class Validador
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
            this.textDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonValidar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDocumento
            // 
            this.textDocumento.BackColor = System.Drawing.SystemColors.Info;
            this.textDocumento.Location = new System.Drawing.Point(85, 108);
            this.textDocumento.Name = "textDocumento";
            this.textDocumento.ReadOnly = true;
            this.textDocumento.Size = new System.Drawing.Size(303, 20);
            this.textDocumento.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Documento:";
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.SystemColors.Info;
            this.textResultado.Location = new System.Drawing.Point(85, 134);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(303, 201);
            this.textResultado.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Resultado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonValidar);
            this.groupBox1.Controls.Add(this.comboTipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 90);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lectura";
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "DTE",
            "EnvioDTE",
            "EnvioBoleta",
            "LibroGuias",
            "RVD",
            "LCV"});
            this.comboTipo.Location = new System.Drawing.Point(73, 56);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(131, 21);
            this.comboTipo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(73, 27);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(262, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // botonBuscar
            // 
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Image = global::SimpleSDK_Demo.Properties.Resources.View;
            this.botonBuscar.Location = new System.Drawing.Point(341, 27);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(29, 20);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonValidar
            // 
            this.botonValidar.Location = new System.Drawing.Point(295, 54);
            this.botonValidar.Name = "botonValidar";
            this.botonValidar.Size = new System.Drawing.Size(75, 23);
            this.botonValidar.TabIndex = 6;
            this.botonValidar.Text = "Validar";
            this.botonValidar.UseVisualStyleBackColor = true;
            this.botonValidar.Click += new System.EventHandler(this.botonValidar_Click);
            // 
            // Validador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 350);
            this.Controls.Add(this.textDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Validador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador de DTE";
            this.Load += new System.EventHandler(this.Validador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button botonValidar;
    }
}