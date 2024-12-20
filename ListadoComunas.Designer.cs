namespace SimpleSDK_Demo
{
    partial class ListadoComunas
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
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.ListadoButton = new System.Windows.Forms.Button();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridResultados
            // 
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Region,
            this.Comuna});
            this.gridResultados.Location = new System.Drawing.Point(11, 11);
            this.gridResultados.Margin = new System.Windows.Forms.Padding(2);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.RowHeadersWidth = 20;
            this.gridResultados.RowTemplate.Height = 28;
            this.gridResultados.Size = new System.Drawing.Size(616, 240);
            this.gridResultados.TabIndex = 3;
            this.gridResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultados_CellContentClick);
            // 
            // ListadoButton
            // 
            this.ListadoButton.Location = new System.Drawing.Point(553, 255);
            this.ListadoButton.Margin = new System.Windows.Forms.Padding(2);
            this.ListadoButton.Name = "ListadoButton";
            this.ListadoButton.Size = new System.Drawing.Size(74, 43);
            this.ListadoButton.TabIndex = 4;
            this.ListadoButton.Text = "Traer Listado";
            this.ListadoButton.UseVisualStyleBackColor = true;
            this.ListadoButton.Click += new System.EventHandler(this.ListadoButton_Click);
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Región";
            this.Region.Name = "Region";
            this.Region.Width = 375;
            // 
            // Comuna
            // 
            this.Comuna.DataPropertyName = "Comuna";
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.Name = "Comuna";
            this.Comuna.Width = 200;
            // 
            // ListadoComunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 302);
            this.Controls.Add(this.ListadoButton);
            this.Controls.Add(this.gridResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListadoComunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Comunas";
            this.Load += new System.EventHandler(this.ListadoComunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.Button ListadoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
    }
}