namespace clasesvirtualesprogramacion.Dialogs
{
    partial class GastosDialog
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label subcategoriaLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label formapagoLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.formapagoComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            fechaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            subcategoriaLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            formapagoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(207, 250);
            this.btnGuardar.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 250);
            this.btnCancelar.TabIndex = 7;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(45, 19);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(30, 51);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 5;
            categoriaLabel.Text = "Categoria:";
            // 
            // subcategoriaLabel
            // 
            subcategoriaLabel.AutoSize = true;
            subcategoriaLabel.Location = new System.Drawing.Point(12, 84);
            subcategoriaLabel.Name = "subcategoriaLabel";
            subcategoriaLabel.Size = new System.Drawing.Size(73, 13);
            subcategoriaLabel.TabIndex = 7;
            subcategoriaLabel.Text = "Subcategoria:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(208, 19);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 11;
            valorLabel.Text = "Valor:";
            // 
            // formapagoLabel
            // 
            formapagoLabel.AutoSize = true;
            formapagoLabel.Location = new System.Drawing.Point(335, 22);
            formapagoLabel.Name = "formapagoLabel";
            formapagoLabel.Size = new System.Drawing.Size(81, 13);
            formapagoLabel.TabIndex = 13;
            formapagoLabel.Text = "Forma de pago:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(19, 124);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 15;
            descripcionLabel.Text = "Descripción:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(93, 15);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.fechaDateTimePicker.TabIndex = 0;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Alimentos",
            "Transporte",
            "Hogar",
            "Lavandería",
            "Diversión",
            "Personal"});
            this.categoriaComboBox.Location = new System.Drawing.Point(93, 48);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(424, 21);
            this.categoriaComboBox.TabIndex = 3;
            // 
            // subcategoriaComboBox
            // 
            this.subcategoriaComboBox.FormattingEnabled = true;
            this.subcategoriaComboBox.Items.AddRange(new object[] {
            "Supermercado",
            "Kiosko",
            "Restaurante",
            "Taxi",
            "Bus",
            "Mototaxi",
            "Electricidad",
            "Agua",
            "Teléfono",
            "Jabón",
            "Detergente",
            "Suavitel",
            "Azistin",
            "Cine"});
            this.subcategoriaComboBox.Location = new System.Drawing.Point(93, 81);
            this.subcategoriaComboBox.Name = "subcategoriaComboBox";
            this.subcategoriaComboBox.Size = new System.Drawing.Size(424, 21);
            this.subcategoriaComboBox.TabIndex = 4;
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.Location = new System.Drawing.Point(262, 17);
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.valorNumericUpDown.TabIndex = 1;
            // 
            // formapagoComboBox
            // 
            this.formapagoComboBox.FormattingEnabled = true;
            this.formapagoComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Crédito",
            "Tarjeta de crédito"});
            this.formapagoComboBox.Location = new System.Drawing.Point(423, 19);
            this.formapagoComboBox.Name = "formapagoComboBox";
            this.formapagoComboBox.Size = new System.Drawing.Size(93, 21);
            this.formapagoComboBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionTextBox.Location = new System.Drawing.Point(93, 121);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(423, 93);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // GastosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 287);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(subcategoriaLabel);
            this.Controls.Add(this.subcategoriaComboBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(formapagoLabel);
            this.Controls.Add(this.formapagoComboBox);
            this.Name = "GastosDialog";
            this.Text = "Información de gastos";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.formapagoComboBox, 0);
            this.Controls.SetChildIndex(formapagoLabel, 0);
            this.Controls.SetChildIndex(this.valorNumericUpDown, 0);
            this.Controls.SetChildIndex(valorLabel, 0);
            this.Controls.SetChildIndex(this.subcategoriaComboBox, 0);
            this.Controls.SetChildIndex(subcategoriaLabel, 0);
            this.Controls.SetChildIndex(this.categoriaComboBox, 0);
            this.Controls.SetChildIndex(categoriaLabel, 0);
            this.Controls.SetChildIndex(this.fechaDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        public System.Windows.Forms.ComboBox categoriaComboBox;
        public System.Windows.Forms.ComboBox subcategoriaComboBox;
        public System.Windows.Forms.NumericUpDown valorNumericUpDown;
        public System.Windows.Forms.ComboBox formapagoComboBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
    }
}