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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.agregarGroupBox = new System.Windows.Forms.GroupBox();
            this.agregarCantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.agregarPrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.agregarConfirmarButton = new System.Windows.Forms.Button();
            this.agregarProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.agregarAlmacenComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.agregarCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.agregarDescripcionTextBox = new System.Windows.Forms.TextBox();
            this.agregarNombreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.actualizarGroupBox = new System.Windows.Forms.GroupBox();
            this.actualizarCantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.actualizarPrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.actualizarConfirmarButton = new System.Windows.Forms.Button();
            this.actualizarIdTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.actualizarProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.actualizarAlmacenComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.actualizarCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.actualizarDescripcionTextBox = new System.Windows.Forms.TextBox();
            this.actualizarNombreTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.eliminarGroupBox = new System.Windows.Forms.GroupBox();
            this.eliminarConfirmarButton = new System.Windows.Forms.Button();
            this.eliminarTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productodDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.agregarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarCantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarPrecioNumericUpDown)).BeginInit();
            this.actualizarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualizarCantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualizarPrecioNumericUpDown)).BeginInit();
            this.eliminarGroupBox.SuspendLayout();
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
            this.productodDataGridView.AllowUserToAddRows = false;
            this.productodDataGridView.AllowUserToDeleteRows = false;
            this.productodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productodDataGridView.Location = new System.Drawing.Point(12, 36);
            this.productodDataGridView.Name = "productodDataGridView";
            this.productodDataGridView.ReadOnly = true;
            this.productodDataGridView.RowHeadersWidth = 51;
            this.productodDataGridView.RowTemplate.Height = 24;
            this.productodDataGridView.Size = new System.Drawing.Size(1179, 356);
            this.productodDataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.agregarGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.actualizarGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eliminarGroupBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 398);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.83568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.16432F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 408);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.eliminarButton);
            this.groupBox1.Controls.Add(this.actualizarButton);
            this.groupBox1.Controls.Add(this.agregarButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accion a realizar";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(285, 99);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(182, 35);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Limpiar campos";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(285, 58);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(182, 35);
            this.eliminarButton.TabIndex = 2;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(97, 99);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(182, 35);
            this.actualizarButton.TabIndex = 1;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(97, 58);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(182, 35);
            this.agregarButton.TabIndex = 0;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // agregarGroupBox
            // 
            this.agregarGroupBox.Controls.Add(this.agregarCantidadNumericUpDown);
            this.agregarGroupBox.Controls.Add(this.agregarPrecioNumericUpDown);
            this.agregarGroupBox.Controls.Add(this.agregarConfirmarButton);
            this.agregarGroupBox.Controls.Add(this.agregarProveedorComboBox);
            this.agregarGroupBox.Controls.Add(this.label7);
            this.agregarGroupBox.Controls.Add(this.agregarAlmacenComboBox);
            this.agregarGroupBox.Controls.Add(this.label6);
            this.agregarGroupBox.Controls.Add(this.agregarCategoriaComboBox);
            this.agregarGroupBox.Controls.Add(this.label5);
            this.agregarGroupBox.Controls.Add(this.agregarDescripcionTextBox);
            this.agregarGroupBox.Controls.Add(this.agregarNombreTextBox);
            this.agregarGroupBox.Controls.Add(this.label4);
            this.agregarGroupBox.Controls.Add(this.label3);
            this.agregarGroupBox.Controls.Add(this.label2);
            this.agregarGroupBox.Controls.Add(this.label1);
            this.agregarGroupBox.Location = new System.Drawing.Point(590, 3);
            this.agregarGroupBox.Name = "agregarGroupBox";
            this.agregarGroupBox.Size = new System.Drawing.Size(582, 176);
            this.agregarGroupBox.TabIndex = 1;
            this.agregarGroupBox.TabStop = false;
            this.agregarGroupBox.Text = "Agregar";
            // 
            // agregarCantidadNumericUpDown
            // 
            this.agregarCantidadNumericUpDown.Location = new System.Drawing.Point(94, 142);
            this.agregarCantidadNumericUpDown.Name = "agregarCantidadNumericUpDown";
            this.agregarCantidadNumericUpDown.Size = new System.Drawing.Size(174, 22);
            this.agregarCantidadNumericUpDown.TabIndex = 15;
            // 
            // agregarPrecioNumericUpDown
            // 
            this.agregarPrecioNumericUpDown.Location = new System.Drawing.Point(94, 95);
            this.agregarPrecioNumericUpDown.Name = "agregarPrecioNumericUpDown";
            this.agregarPrecioNumericUpDown.Size = new System.Drawing.Size(174, 22);
            this.agregarPrecioNumericUpDown.TabIndex = 14;
            // 
            // agregarConfirmarButton
            // 
            this.agregarConfirmarButton.Location = new System.Drawing.Point(299, 135);
            this.agregarConfirmarButton.Name = "agregarConfirmarButton";
            this.agregarConfirmarButton.Size = new System.Drawing.Size(182, 35);
            this.agregarConfirmarButton.TabIndex = 4;
            this.agregarConfirmarButton.Text = "Confirmar";
            this.agregarConfirmarButton.UseVisualStyleBackColor = true;
            this.agregarConfirmarButton.Click += new System.EventHandler(this.agregarConfirmarButton_Click);
            // 
            // agregarProveedorComboBox
            // 
            this.agregarProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agregarProveedorComboBox.FormattingEnabled = true;
            this.agregarProveedorComboBox.Location = new System.Drawing.Point(371, 87);
            this.agregarProveedorComboBox.Name = "agregarProveedorComboBox";
            this.agregarProveedorComboBox.Size = new System.Drawing.Size(199, 24);
            this.agregarProveedorComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Proveedor";
            // 
            // agregarAlmacenComboBox
            // 
            this.agregarAlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agregarAlmacenComboBox.FormattingEnabled = true;
            this.agregarAlmacenComboBox.Location = new System.Drawing.Point(377, 48);
            this.agregarAlmacenComboBox.Name = "agregarAlmacenComboBox";
            this.agregarAlmacenComboBox.Size = new System.Drawing.Size(193, 24);
            this.agregarAlmacenComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Almacen:";
            // 
            // agregarCategoriaComboBox
            // 
            this.agregarCategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agregarCategoriaComboBox.FormattingEnabled = true;
            this.agregarCategoriaComboBox.Location = new System.Drawing.Point(377, 10);
            this.agregarCategoriaComboBox.Name = "agregarCategoriaComboBox";
            this.agregarCategoriaComboBox.Size = new System.Drawing.Size(193, 24);
            this.agregarCategoriaComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria:";
            // 
            // agregarDescripcionTextBox
            // 
            this.agregarDescripcionTextBox.Location = new System.Drawing.Point(94, 50);
            this.agregarDescripcionTextBox.Name = "agregarDescripcionTextBox";
            this.agregarDescripcionTextBox.Size = new System.Drawing.Size(174, 22);
            this.agregarDescripcionTextBox.TabIndex = 5;
            // 
            // agregarNombreTextBox
            // 
            this.agregarNombreTextBox.Location = new System.Drawing.Point(94, 12);
            this.agregarNombreTextBox.Name = "agregarNombreTextBox";
            this.agregarNombreTextBox.Size = new System.Drawing.Size(174, 22);
            this.agregarNombreTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // actualizarGroupBox
            // 
            this.actualizarGroupBox.Controls.Add(this.actualizarCantidadNumericUpDown);
            this.actualizarGroupBox.Controls.Add(this.actualizarPrecioNumericUpDown);
            this.actualizarGroupBox.Controls.Add(this.actualizarConfirmarButton);
            this.actualizarGroupBox.Controls.Add(this.actualizarIdTextBox);
            this.actualizarGroupBox.Controls.Add(this.label15);
            this.actualizarGroupBox.Controls.Add(this.actualizarProveedorComboBox);
            this.actualizarGroupBox.Controls.Add(this.label8);
            this.actualizarGroupBox.Controls.Add(this.actualizarAlmacenComboBox);
            this.actualizarGroupBox.Controls.Add(this.label9);
            this.actualizarGroupBox.Controls.Add(this.actualizarCategoriaComboBox);
            this.actualizarGroupBox.Controls.Add(this.label10);
            this.actualizarGroupBox.Controls.Add(this.actualizarDescripcionTextBox);
            this.actualizarGroupBox.Controls.Add(this.actualizarNombreTextBox);
            this.actualizarGroupBox.Controls.Add(this.label11);
            this.actualizarGroupBox.Controls.Add(this.label12);
            this.actualizarGroupBox.Controls.Add(this.label13);
            this.actualizarGroupBox.Controls.Add(this.label14);
            this.actualizarGroupBox.Location = new System.Drawing.Point(3, 185);
            this.actualizarGroupBox.Name = "actualizarGroupBox";
            this.actualizarGroupBox.Size = new System.Drawing.Size(581, 220);
            this.actualizarGroupBox.TabIndex = 2;
            this.actualizarGroupBox.TabStop = false;
            this.actualizarGroupBox.Text = "Actualizar";
            // 
            // actualizarCantidadNumericUpDown
            // 
            this.actualizarCantidadNumericUpDown.Location = new System.Drawing.Point(370, 151);
            this.actualizarCantidadNumericUpDown.Name = "actualizarCantidadNumericUpDown";
            this.actualizarCantidadNumericUpDown.Size = new System.Drawing.Size(199, 22);
            this.actualizarCantidadNumericUpDown.TabIndex = 32;
            // 
            // actualizarPrecioNumericUpDown
            // 
            this.actualizarPrecioNumericUpDown.Location = new System.Drawing.Point(93, 155);
            this.actualizarPrecioNumericUpDown.Name = "actualizarPrecioNumericUpDown";
            this.actualizarPrecioNumericUpDown.Size = new System.Drawing.Size(174, 22);
            this.actualizarPrecioNumericUpDown.TabIndex = 31;
            // 
            // actualizarConfirmarButton
            // 
            this.actualizarConfirmarButton.Location = new System.Drawing.Point(215, 182);
            this.actualizarConfirmarButton.Name = "actualizarConfirmarButton";
            this.actualizarConfirmarButton.Size = new System.Drawing.Size(182, 35);
            this.actualizarConfirmarButton.TabIndex = 18;
            this.actualizarConfirmarButton.Text = "Confirmar";
            this.actualizarConfirmarButton.UseVisualStyleBackColor = true;
            this.actualizarConfirmarButton.Click += new System.EventHandler(this.actualizarConfirmarButton_Click);
            // 
            // actualizarIdTextBox
            // 
            this.actualizarIdTextBox.Location = new System.Drawing.Point(93, 32);
            this.actualizarIdTextBox.Name = "actualizarIdTextBox";
            this.actualizarIdTextBox.Size = new System.Drawing.Size(174, 22);
            this.actualizarIdTextBox.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "ID:";
            // 
            // actualizarProveedorComboBox
            // 
            this.actualizarProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualizarProveedorComboBox.FormattingEnabled = true;
            this.actualizarProveedorComboBox.Location = new System.Drawing.Point(370, 107);
            this.actualizarProveedorComboBox.Name = "actualizarProveedorComboBox";
            this.actualizarProveedorComboBox.Size = new System.Drawing.Size(199, 24);
            this.actualizarProveedorComboBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Proveedor";
            // 
            // actualizarAlmacenComboBox
            // 
            this.actualizarAlmacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualizarAlmacenComboBox.FormattingEnabled = true;
            this.actualizarAlmacenComboBox.Location = new System.Drawing.Point(376, 68);
            this.actualizarAlmacenComboBox.Name = "actualizarAlmacenComboBox";
            this.actualizarAlmacenComboBox.Size = new System.Drawing.Size(193, 24);
            this.actualizarAlmacenComboBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Almacen:";
            // 
            // actualizarCategoriaComboBox
            // 
            this.actualizarCategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualizarCategoriaComboBox.FormattingEnabled = true;
            this.actualizarCategoriaComboBox.Location = new System.Drawing.Point(376, 30);
            this.actualizarCategoriaComboBox.Name = "actualizarCategoriaComboBox";
            this.actualizarCategoriaComboBox.Size = new System.Drawing.Size(193, 24);
            this.actualizarCategoriaComboBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Categoria:";
            // 
            // actualizarDescripcionTextBox
            // 
            this.actualizarDescripcionTextBox.Location = new System.Drawing.Point(93, 107);
            this.actualizarDescripcionTextBox.Name = "actualizarDescripcionTextBox";
            this.actualizarDescripcionTextBox.Size = new System.Drawing.Size(174, 22);
            this.actualizarDescripcionTextBox.TabIndex = 20;
            // 
            // actualizarNombreTextBox
            // 
            this.actualizarNombreTextBox.Location = new System.Drawing.Point(93, 68);
            this.actualizarNombreTextBox.Name = "actualizarNombreTextBox";
            this.actualizarNombreTextBox.Size = new System.Drawing.Size(174, 22);
            this.actualizarNombreTextBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Precio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Descripcion:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Nombre:";
            // 
            // eliminarGroupBox
            // 
            this.eliminarGroupBox.Controls.Add(this.eliminarConfirmarButton);
            this.eliminarGroupBox.Controls.Add(this.eliminarTextBox);
            this.eliminarGroupBox.Controls.Add(this.label16);
            this.eliminarGroupBox.Location = new System.Drawing.Point(590, 185);
            this.eliminarGroupBox.Name = "eliminarGroupBox";
            this.eliminarGroupBox.Size = new System.Drawing.Size(582, 220);
            this.eliminarGroupBox.TabIndex = 3;
            this.eliminarGroupBox.TabStop = false;
            this.eliminarGroupBox.Text = "Eliminar";
            // 
            // eliminarConfirmarButton
            // 
            this.eliminarConfirmarButton.Location = new System.Drawing.Point(203, 96);
            this.eliminarConfirmarButton.Name = "eliminarConfirmarButton";
            this.eliminarConfirmarButton.Size = new System.Drawing.Size(200, 35);
            this.eliminarConfirmarButton.TabIndex = 31;
            this.eliminarConfirmarButton.Text = "Confirmar";
            this.eliminarConfirmarButton.UseVisualStyleBackColor = true;
            this.eliminarConfirmarButton.Click += new System.EventHandler(this.eliminarConfirmarButton_Click);
            // 
            // eliminarTextBox
            // 
            this.eliminarTextBox.Location = new System.Drawing.Point(229, 45);
            this.eliminarTextBox.Name = "eliminarTextBox";
            this.eliminarTextBox.Size = new System.Drawing.Size(174, 22);
            this.eliminarTextBox.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(200, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "ID:";
            // 
            // Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 818);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.productodDataGridView);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edicion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.productodDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.agregarGroupBox.ResumeLayout(false);
            this.agregarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarCantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarPrecioNumericUpDown)).EndInit();
            this.actualizarGroupBox.ResumeLayout(false);
            this.actualizarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualizarCantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualizarPrecioNumericUpDown)).EndInit();
            this.eliminarGroupBox.ResumeLayout(false);
            this.eliminarGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PracticaU2_Componentes.CustomLabel tituloLabel;
        private System.Windows.Forms.DataGridView productodDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.GroupBox agregarGroupBox;
        private System.Windows.Forms.TextBox agregarNombreTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox actualizarGroupBox;
        private System.Windows.Forms.GroupBox eliminarGroupBox;
        private System.Windows.Forms.Button agregarConfirmarButton;
        private System.Windows.Forms.ComboBox agregarProveedorComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox agregarAlmacenComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox agregarCategoriaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox agregarDescripcionTextBox;
        private System.Windows.Forms.TextBox actualizarIdTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox actualizarProveedorComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox actualizarAlmacenComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox actualizarCategoriaComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox actualizarDescripcionTextBox;
        private System.Windows.Forms.TextBox actualizarNombreTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button actualizarConfirmarButton;
        private System.Windows.Forms.Button eliminarConfirmarButton;
        private System.Windows.Forms.TextBox eliminarTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown agregarCantidadNumericUpDown;
        private System.Windows.Forms.NumericUpDown agregarPrecioNumericUpDown;
        private System.Windows.Forms.NumericUpDown actualizarCantidadNumericUpDown;
        private System.Windows.Forms.NumericUpDown actualizarPrecioNumericUpDown;
    }
}