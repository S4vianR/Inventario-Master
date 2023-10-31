namespace InventarioMaster
{
    partial class EditarTabla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.welcomeLabel = new PracticaU2_Componentes.CustomLabel();
            this.productosDataGridView = new PracticaU2_Componentes.CustomDataGridView();
            this.confirmarButton = new PracticaU2_Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.CustomText = null;
            this.welcomeLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(136, 24);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "customLabel1";
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productosDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.productosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.productosDataGridView.Location = new System.Drawing.Point(12, 48);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.RowHeadersWidth = 51;
            this.productosDataGridView.RowTemplate.Height = 24;
            this.productosDataGridView.Size = new System.Drawing.Size(776, 344);
            this.productosDataGridView.TabIndex = 1;
            // 
            // confirmarButton
            // 
            this.confirmarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.confirmarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.confirmarButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.confirmarButton.BorderRadius = 20;
            this.confirmarButton.BorderSize = 0;
            this.confirmarButton.FlatAppearance.BorderSize = 0;
            this.confirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmarButton.ForeColor = System.Drawing.Color.White;
            this.confirmarButton.Location = new System.Drawing.Point(12, 398);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(150, 40);
            this.confirmarButton.TabIndex = 2;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.TextColor = System.Drawing.Color.White;
            this.confirmarButton.UseVisualStyleBackColor = false;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click_1);
            // 
            // EditarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.productosDataGridView);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "EditarTabla";
            this.Text = "EditarTabla";
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PracticaU2_Componentes.CustomLabel welcomeLabel;
        private PracticaU2_Componentes.CustomDataGridView productosDataGridView;
        private PracticaU2_Componentes.CustomButton confirmarButton;
    }
}