using System.ComponentModel;

namespace SimpleSDK_Demo
{
    partial class EnviarBoletaPorEmail
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
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnioTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FolioTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RutEmisorTextbox = new System.Windows.Forms.TextBox();
            this.EnviarEmailButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CorreoTextBox);
            this.groupBox1.Controls.Add(this.CorreoLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AnioTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FolioTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RutEmisorTextbox);
            this.groupBox1.Controls.Add(this.EnviarEmailButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(973, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Boleta de Honorarios Electrónica";
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Location = new System.Drawing.Point(568, 36);
            this.CorreoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(277, 22);
            this.CorreoTextBox.TabIndex = 8;
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoLabel.Location = new System.Drawing.Point(500, 38);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(63, 18);
            this.CorreoLabel.TabIndex = 7;
            this.CorreoLabel.Text = "Correo";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // AnioTextbox
            // 
            this.AnioTextbox.Location = new System.Drawing.Point(424, 38);
            this.AnioTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnioTextbox.Name = "AnioTextbox";
            this.AnioTextbox.Size = new System.Drawing.Size(55, 22);
            this.AnioTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folio";
            // 
            // FolioTextbox
            // 
            this.FolioTextbox.Location = new System.Drawing.Point(270, 38);
            this.FolioTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FolioTextbox.Name = "FolioTextbox";
            this.FolioTextbox.Size = new System.Drawing.Size(89, 22);
            this.FolioTextbox.TabIndex = 3;
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
            // EnviarEmailButton
            // 
            this.EnviarEmailButton.Location = new System.Drawing.Point(861, 20);
            this.EnviarEmailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnviarEmailButton.Name = "EnviarEmailButton";
            this.EnviarEmailButton.Size = new System.Drawing.Size(98, 53);
            this.EnviarEmailButton.TabIndex = 0;
            this.EnviarEmailButton.Text = "Enviar Email";
            this.EnviarEmailButton.UseVisualStyleBackColor = true;
            this.EnviarEmailButton.Click += new System.EventHandler(this.EnviarEmailButton_Click);
            // 
            // EnviarBoletaPorEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 112);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnviarBoletaPorEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Boleta de Honorarios por Email";
            this.Load += new System.EventHandler(this.EnviarBoletaPorEmail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox CorreoTextBox;

        private System.Windows.Forms.Label CorreoLabel;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnioTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FolioTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutEmisorTextbox;
        private System.Windows.Forms.Button EnviarEmailButton;

        #endregion
    }
}