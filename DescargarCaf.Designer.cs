using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class DescargarCaf
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
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.RutEmisorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescargarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoDteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CantidadTextBox);
            this.groupBox1.Controls.Add(this.RutEmisorTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DescargarButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TipoDteTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(492, 43);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 26);
            this.CantidadTextBox.TabIndex = 9;
            // 
            // RutEmisorTextBox
            // 
            this.RutEmisorTextBox.Location = new System.Drawing.Point(113, 43);
            this.RutEmisorTextBox.Name = "RutEmisorTextBox";
            this.RutEmisorTextBox.Size = new System.Drawing.Size(100, 26);
            this.RutEmisorTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rut Emisor";
            // 
            // DescargarButton
            // 
            this.DescargarButton.Location = new System.Drawing.Point(891, 24);
            this.DescargarButton.Name = "DescargarButton";
            this.DescargarButton.Size = new System.Drawing.Size(130, 64);
            this.DescargarButton.TabIndex = 6;
            this.DescargarButton.Text = "Descargar CAF";
            this.DescargarButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // TipoDteTextBox
            // 
            this.TipoDteTextBox.Location = new System.Drawing.Point(269, 43);
            this.TipoDteTextBox.Name = "TipoDteTextBox";
            this.TipoDteTextBox.Size = new System.Drawing.Size(100, 26);
            this.TipoDteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo DTE";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(640, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ambiente";
            // 
            // DescargarCaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 130);
            this.Controls.Add(this.groupBox1);
            this.Name = "DescargarCaf";
            this.Text = "Descargar Caf";
            this.Load += new System.EventHandler(this.DescargarCaf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RutEmisorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DescargarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TipoDteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CantidadTextBox;

        #endregion
    }
}