namespace InventarioMaster
{
    partial class Edicion
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
            this.tituloLabel = new PracticaU2_Componentes.CustomLabel();
            this.productodDataGridView = new System.Windows.Forms.DataGridView();
            this.editarButton = new PracticaU2_Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.productodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.CustomText = null;
            this.tituloLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.tituloLabel.Location = new System.Drawing.Point(12, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(136, 24);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "customLabel1";
            // 
            // productodDataGridView
            // 
            this.productodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productodDataGridView.Location = new System.Drawing.Point(12, 36);
            this.productodDataGridView.Name = "productodDataGridView";
            this.productodDataGridView.RowHeadersWidth = 51;
            this.productodDataGridView.RowTemplate.Height = 24;
            this.productodDataGridView.Size = new System.Drawing.Size(776, 345);
            this.productodDataGridView.TabIndex = 1;
            // 
            // editarButton
            // 
            this.editarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.editarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.editarButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.editarButton.BorderRadius = 20;
            this.editarButton.BorderSize = 0;
            this.editarButton.FlatAppearance.BorderSize = 0;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarButton.ForeColor = System.Drawing.Color.White;
            this.editarButton.Location = new System.Drawing.Point(12, 398);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(150, 40);
            this.editarButton.TabIndex = 2;
            this.editarButton.Text = "confirmButton";
            this.editarButton.TextColor = System.Drawing.Color.White;
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.productodDataGridView);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Edicion";
            this.Text = "Edicion";
            ((System.ComponentModel.ISupportInitialize)(this.productodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PracticaU2_Componentes.CustomLabel tituloLabel;
        private System.Windows.Forms.DataGridView productodDataGridView;
        private PracticaU2_Componentes.CustomButton editarButton;
    }
}