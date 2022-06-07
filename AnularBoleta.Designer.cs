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
            this.MotivoTextBox = new System.Windows.Forms.TextBox();
            this.FolioLabel = new System.Windows.Forms.Label();
            this.RutEmisorLabel = new System.Windows.Forms.Label();
            this.FolioTextBox = new System.Windows.Forms.TextBox();
            this.RutEmisorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnulaButton);
            this.groupBox1.Controls.Add(this.MotivoLabel);
            this.groupBox1.Controls.Add(this.MotivoTextBox);
            this.groupBox1.Controls.Add(this.FolioLabel);
            this.groupBox1.Controls.Add(this.RutEmisorLabel);
            this.groupBox1.Controls.Add(this.FolioTextBox);
            this.groupBox1.Controls.Add(this.RutEmisorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Boleta a Anular";
            // 
            // AnulaButton
            // 
            this.AnulaButton.Location = new System.Drawing.Point(590, 37);
            this.AnulaButton.Name = "AnulaButton";
            this.AnulaButton.Size = new System.Drawing.Size(95, 46);
            this.AnulaButton.TabIndex = 6;
            this.AnulaButton.Text = "Anular";
            this.AnulaButton.UseVisualStyleBackColor = true;
            // 
            // MotivoLabel
            // 
            this.MotivoLabel.Location = new System.Drawing.Point(22, 71);
            this.MotivoLabel.Name = "MotivoLabel";
            this.MotivoLabel.Size = new System.Drawing.Size(62, 23);
            this.MotivoLabel.TabIndex = 5;
            this.MotivoLabel.Text = "Motivo";
            // 
            // MotivoTextBox
            // 
            this.MotivoTextBox.Location = new System.Drawing.Point(118, 68);
            this.MotivoTextBox.Name = "MotivoTextBox";
            this.MotivoTextBox.Size = new System.Drawing.Size(421, 26);
            this.MotivoTextBox.TabIndex = 4;
            // 
            // FolioLabel
            // 
            this.FolioLabel.Location = new System.Drawing.Point(233, 40);
            this.FolioLabel.Name = "FolioLabel";
            this.FolioLabel.Size = new System.Drawing.Size(55, 23);
            this.FolioLabel.TabIndex = 3;
            this.FolioLabel.Text = "Folio";
            // 
            // RutEmisorLabel
            // 
            this.RutEmisorLabel.Location = new System.Drawing.Point(22, 40);
            this.RutEmisorLabel.Name = "RutEmisorLabel";
            this.RutEmisorLabel.Size = new System.Drawing.Size(90, 23);
            this.RutEmisorLabel.TabIndex = 2;
            this.RutEmisorLabel.Text = "Rut Emisor";
            // 
            // FolioTextBox
            // 
            this.FolioTextBox.Location = new System.Drawing.Point(294, 37);
            this.FolioTextBox.Name = "FolioTextBox";
            this.FolioTextBox.Size = new System.Drawing.Size(100, 26);
            this.FolioTextBox.TabIndex = 1;
            // 
            // RutEmisorTextBox
            // 
            this.RutEmisorTextBox.Location = new System.Drawing.Point(118, 37);
            this.RutEmisorTextBox.Name = "RutEmisorTextBox";
            this.RutEmisorTextBox.Size = new System.Drawing.Size(100, 26);
            this.RutEmisorTextBox.TabIndex = 0;
            // 
            // AnularBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 132);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnularBoleta";
            this.Text = "Anular Boleta de Honorarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox MotivoTextBox;

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
    }
}