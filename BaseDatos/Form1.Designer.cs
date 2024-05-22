namespace BaseDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.labelfecha_creacion = new System.Windows.Forms.Label();
            this.labelhistoria = new System.Windows.Forms.Label();
            this.dateTimePickerfecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxhistoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(240, 265);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(606, 272);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(653, 55);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(97, 35);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "cargar datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Power";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(114, 12);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(121, 22);
            this.textBoxid.TabIndex = 7;
            this.textBoxid.Leave += new System.EventHandler(this.textBoxid_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(114, 55);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 22);
            this.textBoxNombre.TabIndex = 8;
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Location = new System.Drawing.Point(114, 137);
            this.numericUpDownPower.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownPower.TabIndex = 10;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(639, 107);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(120, 61);
            this.buttonCrear.TabIndex = 11;
            this.buttonCrear.Text = "crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(114, 98);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRaza.TabIndex = 12;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(663, 18);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonbuscar.TabIndex = 13;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // labelfecha_creacion
            // 
            this.labelfecha_creacion.AutoSize = true;
            this.labelfecha_creacion.Location = new System.Drawing.Point(40, 183);
            this.labelfecha_creacion.Name = "labelfecha_creacion";
            this.labelfecha_creacion.Size = new System.Drawing.Size(119, 16);
            this.labelfecha_creacion.TabIndex = 14;
            this.labelfecha_creacion.Text = "Fecha de creacion";
            // 
            // labelhistoria
            // 
            this.labelhistoria.AutoSize = true;
            this.labelhistoria.Location = new System.Drawing.Point(40, 220);
            this.labelhistoria.Name = "labelhistoria";
            this.labelhistoria.Size = new System.Drawing.Size(53, 16);
            this.labelhistoria.TabIndex = 15;
            this.labelhistoria.Text = "Historia";
            // 
            // dateTimePickerfecha
            // 
            this.dateTimePickerfecha.Location = new System.Drawing.Point(178, 183);
            this.dateTimePickerfecha.Name = "dateTimePickerfecha";
            this.dateTimePickerfecha.Size = new System.Drawing.Size(243, 22);
            this.dateTimePickerfecha.TabIndex = 16;
            this.dateTimePickerfecha.Value = new System.DateTime(2024, 5, 22, 10, 19, 17, 0);
            // 
            // textBoxhistoria
            // 
            this.textBoxhistoria.Location = new System.Drawing.Point(114, 213);
            this.textBoxhistoria.Name = "textBoxhistoria";
            this.textBoxhistoria.Size = new System.Drawing.Size(100, 22);
            this.textBoxhistoria.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 559);
            this.Controls.Add(this.textBoxhistoria);
            this.Controls.Add(this.dateTimePickerfecha);
            this.Controls.Add(this.labelhistoria);
            this.Controls.Add(this.labelfecha_creacion);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.numericUpDownPower);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Label labelfecha_creacion;
        private System.Windows.Forms.Label labelhistoria;
        private System.Windows.Forms.DateTimePicker dateTimePickerfecha;
        private System.Windows.Forms.TextBox textBoxhistoria;
    }
}

