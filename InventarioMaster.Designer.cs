namespace InventarioMaster
{
    partial class InventarioMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.welcomeLabel = new PracticaU2_Componentes.CustomLabel();
            this.signOutButton = new PracticaU2_Componentes.CustomButton();
            this.tablaDeDatos = new PracticaU2_Componentes.CustomDataGridView();
            this.verProductosButton = new PracticaU2_Componentes.CustomButton();
            this.verEmpleadosButton = new PracticaU2_Componentes.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).BeginInit();
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
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.signOutButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.signOutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.signOutButton.BorderRadius = 20;
            this.signOutButton.BorderSize = 0;
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.ForeColor = System.Drawing.Color.White;
            this.signOutButton.Location = new System.Drawing.Point(1487, 12);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(108, 40);
            this.signOutButton.TabIndex = 11;
            this.signOutButton.Text = "Cerrar sesión";
            this.signOutButton.TextColor = System.Drawing.Color.White;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // tablaDeDatos
            // 
            this.tablaDeDatos.AllowUserToAddRows = false;
            this.tablaDeDatos.AllowUserToDeleteRows = false;
            this.tablaDeDatos.AllowUserToOrderColumns = true;
            this.tablaDeDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDeDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDeDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDeDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tablaDeDatos.Location = new System.Drawing.Point(12, 70);
            this.tablaDeDatos.Name = "tablaDeDatos";
            this.tablaDeDatos.ReadOnly = true;
            this.tablaDeDatos.RowHeadersWidth = 51;
            this.tablaDeDatos.RowTemplate.Height = 24;
            this.tablaDeDatos.Size = new System.Drawing.Size(1583, 607);
            this.tablaDeDatos.TabIndex = 12;
            // 
            // verProductosButton
            // 
            this.verProductosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verProductosButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verProductosButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verProductosButton.BorderRadius = 20;
            this.verProductosButton.BorderSize = 0;
            this.verProductosButton.FlatAppearance.BorderSize = 0;
            this.verProductosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verProductosButton.ForeColor = System.Drawing.Color.White;
            this.verProductosButton.Location = new System.Drawing.Point(1218, 12);
            this.verProductosButton.Name = "verProductosButton";
            this.verProductosButton.Size = new System.Drawing.Size(108, 40);
            this.verProductosButton.TabIndex = 13;
            this.verProductosButton.Text = "Ver productos";
            this.verProductosButton.TextColor = System.Drawing.Color.White;
            this.verProductosButton.UseVisualStyleBackColor = false;
            this.verProductosButton.Click += new System.EventHandler(this.verProductosButton_Click);
            // 
            // verEmpleadosButton
            // 
            this.verEmpleadosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verEmpleadosButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verEmpleadosButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verEmpleadosButton.BorderRadius = 20;
            this.verEmpleadosButton.BorderSize = 0;
            this.verEmpleadosButton.FlatAppearance.BorderSize = 0;
            this.verEmpleadosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verEmpleadosButton.ForeColor = System.Drawing.Color.White;
            this.verEmpleadosButton.Location = new System.Drawing.Point(1089, 12);
            this.verEmpleadosButton.Name = "verEmpleadosButton";
            this.verEmpleadosButton.Size = new System.Drawing.Size(123, 40);
            this.verEmpleadosButton.TabIndex = 14;
            this.verEmpleadosButton.Text = "Ver empleados";
            this.verEmpleadosButton.TextColor = System.Drawing.Color.White;
            this.verEmpleadosButton.UseVisualStyleBackColor = false;
            this.verEmpleadosButton.Click += new System.EventHandler(this.verEmpleadosButton_Click);
            // 
            // InventarioMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 690);
            this.Controls.Add(this.verEmpleadosButton);
            this.Controls.Add(this.verProductosButton);
            this.Controls.Add(this.tablaDeDatos);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "InventarioMaster";
            this.Text = "InventarioMaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventarioMaster_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PracticaU2_Componentes.CustomLabel welcomeLabel;
        private PracticaU2_Componentes.CustomButton signOutButton;
        private PracticaU2_Componentes.CustomDataGridView tablaDeDatos;
        private PracticaU2_Componentes.CustomButton verProductosButton;
        private PracticaU2_Componentes.CustomButton verEmpleadosButton;
    }
}