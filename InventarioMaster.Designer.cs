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
            this.verElectronicosButton = new PracticaU2_Componentes.CustomButton();
            this.verPerecederosButton = new PracticaU2_Componentes.CustomButton();
            this.editarCantidad = new PracticaU2_Componentes.CustomButton();
            this.tablaDeDatos = new PracticaU2_Componentes.CustomDataGridView();
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
            this.signOutButton.Location = new System.Drawing.Point(748, 12);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(108, 40);
            this.signOutButton.TabIndex = 11;
            this.signOutButton.Text = "Cerrar sesión";
            this.signOutButton.TextColor = System.Drawing.Color.White;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // verElectronicosButton
            // 
            this.verElectronicosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verElectronicosButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verElectronicosButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verElectronicosButton.BorderRadius = 20;
            this.verElectronicosButton.BorderSize = 0;
            this.verElectronicosButton.FlatAppearance.BorderSize = 0;
            this.verElectronicosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verElectronicosButton.ForeColor = System.Drawing.Color.White;
            this.verElectronicosButton.Location = new System.Drawing.Point(520, 12);
            this.verElectronicosButton.Name = "verElectronicosButton";
            this.verElectronicosButton.Size = new System.Drawing.Size(222, 40);
            this.verElectronicosButton.TabIndex = 13;
            this.verElectronicosButton.Text = "Ver productos electronicos";
            this.verElectronicosButton.TextColor = System.Drawing.Color.White;
            this.verElectronicosButton.UseVisualStyleBackColor = false;
            this.verElectronicosButton.Click += new System.EventHandler(this.verElectronicosButton_Click);
            // 
            // verPerecederosButton
            // 
            this.verPerecederosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verPerecederosButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verPerecederosButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.verPerecederosButton.BorderRadius = 20;
            this.verPerecederosButton.BorderSize = 0;
            this.verPerecederosButton.FlatAppearance.BorderSize = 0;
            this.verPerecederosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verPerecederosButton.ForeColor = System.Drawing.Color.White;
            this.verPerecederosButton.Location = new System.Drawing.Point(292, 12);
            this.verPerecederosButton.Name = "verPerecederosButton";
            this.verPerecederosButton.Size = new System.Drawing.Size(222, 40);
            this.verPerecederosButton.TabIndex = 14;
            this.verPerecederosButton.Text = "Ver productos perecederos";
            this.verPerecederosButton.TextColor = System.Drawing.Color.White;
            this.verPerecederosButton.UseVisualStyleBackColor = false;
            this.verPerecederosButton.Click += new System.EventHandler(this.verPerecederosButton_Click);
            // 
            // editarCantidad
            // 
            this.editarCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.editarCantidad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.editarCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.editarCantidad.BorderRadius = 20;
            this.editarCantidad.BorderSize = 0;
            this.editarCantidad.FlatAppearance.BorderSize = 0;
            this.editarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarCantidad.ForeColor = System.Drawing.Color.White;
            this.editarCantidad.Location = new System.Drawing.Point(635, 340);
            this.editarCantidad.Name = "editarCantidad";
            this.editarCantidad.Size = new System.Drawing.Size(222, 40);
            this.editarCantidad.TabIndex = 15;
            this.editarCantidad.Text = "Editar cantidad de productos";
            this.editarCantidad.TextColor = System.Drawing.Color.White;
            this.editarCantidad.UseVisualStyleBackColor = false;
            this.editarCantidad.Click += new System.EventHandler(this.editarCantidad_Click);
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
            this.tablaDeDatos.Location = new System.Drawing.Point(12, 58);
            this.tablaDeDatos.Name = "tablaDeDatos";
            this.tablaDeDatos.RowHeadersWidth = 51;
            this.tablaDeDatos.RowTemplate.Height = 24;
            this.tablaDeDatos.Size = new System.Drawing.Size(845, 276);
            this.tablaDeDatos.TabIndex = 16;
            // 
            // InventarioMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 391);
            this.Controls.Add(this.tablaDeDatos);
            this.Controls.Add(this.editarCantidad);
            this.Controls.Add(this.verPerecederosButton);
            this.Controls.Add(this.verElectronicosButton);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "InventarioMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventarioMaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventarioMaster_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PracticaU2_Componentes.CustomLabel welcomeLabel;
        private PracticaU2_Componentes.CustomButton signOutButton;
        private PracticaU2_Componentes.CustomButton verElectronicosButton;
        private PracticaU2_Componentes.CustomButton verPerecederosButton;
        private PracticaU2_Componentes.CustomButton editarCantidad;
        private PracticaU2_Componentes.CustomDataGridView tablaDeDatos;
    }
}