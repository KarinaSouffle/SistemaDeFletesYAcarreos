namespace SistemaFletesAcarreoB
{
    partial class ListaDeAutos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AñadirPKPP = new System.Windows.Forms.Button();
            this.dgv_ListadoAutos = new System.Windows.Forms.DataGridView();
            this.numPlacasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_NumPlaca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Capacidad = new System.Windows.Forms.Label();
            this.lbl_Kilometraje = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.aUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOSTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSetTableAdapters.AUTOSTableAdapter();
            this.lbl_SetPlaca = new System.Windows.Forms.TextBox();
            this.lbl_SetMarca = new System.Windows.Forms.TextBox();
            this.lbl_SetKilometraje = new System.Windows.Forms.TextBox();
            this.lbl_SetCapacidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(846, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AñadirPKPP
            // 
            this.btn_AñadirPKPP.BackColor = System.Drawing.Color.DarkRed;
            this.btn_AñadirPKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AñadirPKPP.ForeColor = System.Drawing.Color.White;
            this.btn_AñadirPKPP.Location = new System.Drawing.Point(684, 460);
            this.btn_AñadirPKPP.Name = "btn_AñadirPKPP";
            this.btn_AñadirPKPP.Size = new System.Drawing.Size(75, 35);
            this.btn_AñadirPKPP.TabIndex = 7;
            this.btn_AñadirPKPP.Text = "Añadir";
            this.btn_AñadirPKPP.UseVisualStyleBackColor = false;
            this.btn_AñadirPKPP.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // dgv_ListadoAutos
            // 
            this.dgv_ListadoAutos.AutoGenerateColumns = false;
            this.dgv_ListadoAutos.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListadoAutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListadoAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPlacasDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.kilometrajeDataGridViewTextBoxColumn,
            this.capADataGridViewTextBoxColumn});
            this.dgv_ListadoAutos.DataSource = this.aUTOSBindingSource1;
            this.dgv_ListadoAutos.Location = new System.Drawing.Point(93, 72);
            this.dgv_ListadoAutos.Name = "dgv_ListadoAutos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListadoAutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListadoAutos.Size = new System.Drawing.Size(446, 498);
            this.dgv_ListadoAutos.TabIndex = 27;
            this.dgv_ListadoAutos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoAutos_CellMouseEnter);
            // 
            // numPlacasDataGridViewTextBoxColumn
            // 
            this.numPlacasDataGridViewTextBoxColumn.DataPropertyName = "Num_Placas";
            this.numPlacasDataGridViewTextBoxColumn.HeaderText = "Num_Placas";
            this.numPlacasDataGridViewTextBoxColumn.Name = "numPlacasDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // kilometrajeDataGridViewTextBoxColumn
            // 
            this.kilometrajeDataGridViewTextBoxColumn.DataPropertyName = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.HeaderText = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.Name = "kilometrajeDataGridViewTextBoxColumn";
            // 
            // capADataGridViewTextBoxColumn
            // 
            this.capADataGridViewTextBoxColumn.DataPropertyName = "Cap_A";
            this.capADataGridViewTextBoxColumn.HeaderText = "Cap_A";
            this.capADataGridViewTextBoxColumn.Name = "capADataGridViewTextBoxColumn";
            // 
            // aUTOSBindingSource1
            // 
            this.aUTOSBindingSource1.DataMember = "AUTOS";
            this.aUTOSBindingSource1.DataSource = this.sISTEMAFLETESACARREOSDataSetBindingSource;
            // 
            // sISTEMAFLETESACARREOSDataSetBindingSource
            // 
            this.sISTEMAFLETESACARREOSDataSetBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet;
            this.sISTEMAFLETESACARREOSDataSetBindingSource.Position = 0;
            // 
            // sISTEMAFLETESACARREOSDataSet
            // 
            this.sISTEMAFLETESACARREOSDataSet.DataSetName = "SISTEMAFLETESACARREOSDataSet";
            this.sISTEMAFLETESACARREOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(603, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_NumPlaca
            // 
            this.lbl_NumPlaca.AutoSize = true;
            this.lbl_NumPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumPlaca.ForeColor = System.Drawing.Color.Black;
            this.lbl_NumPlaca.Location = new System.Drawing.Point(89, 35);
            this.lbl_NumPlaca.Name = "lbl_NumPlaca";
            this.lbl_NumPlaca.Size = new System.Drawing.Size(129, 20);
            this.lbl_NumPlaca.TabIndex = 29;
            this.lbl_NumPlaca.Text = "Listado de Autos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lbl_SetCapacidad);
            this.panel1.Controls.Add(this.lbl_SetKilometraje);
            this.panel1.Controls.Add(this.lbl_SetMarca);
            this.panel1.Controls.Add(this.lbl_SetPlaca);
            this.panel1.Controls.Add(this.lbl_Capacidad);
            this.panel1.Controls.Add(this.lbl_Kilometraje);
            this.panel1.Controls.Add(this.lbl_Marca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(603, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 223);
            this.panel1.TabIndex = 30;
            // 
            // lbl_Capacidad
            // 
            this.lbl_Capacidad.AutoSize = true;
            this.lbl_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capacidad.ForeColor = System.Drawing.Color.White;
            this.lbl_Capacidad.Location = new System.Drawing.Point(40, 138);
            this.lbl_Capacidad.Name = "lbl_Capacidad";
            this.lbl_Capacidad.Size = new System.Drawing.Size(156, 20);
            this.lbl_Capacidad.TabIndex = 3;
            this.lbl_Capacidad.Text = "Capacidad del Auto: ";
            // 
            // lbl_Kilometraje
            // 
            this.lbl_Kilometraje.AutoSize = true;
            this.lbl_Kilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kilometraje.ForeColor = System.Drawing.Color.White;
            this.lbl_Kilometraje.Location = new System.Drawing.Point(40, 105);
            this.lbl_Kilometraje.Name = "lbl_Kilometraje";
            this.lbl_Kilometraje.Size = new System.Drawing.Size(95, 20);
            this.lbl_Kilometraje.TabIndex = 2;
            this.lbl_Kilometraje.Text = "Kilometraje: ";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.ForeColor = System.Drawing.Color.White;
            this.lbl_Marca.Location = new System.Drawing.Point(40, 72);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(61, 20);
            this.lbl_Marca.TabIndex = 1;
            this.lbl_Marca.Text = "Marca: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. de Placa: ";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(765, 460);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 35);
            this.btn_Eliminar.TabIndex = 31;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // aUTOSBindingSource
            // 
            this.aUTOSBindingSource.DataMember = "AUTOS";
            this.aUTOSBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet;
            // 
            // aUTOSTableAdapter
            // 
            this.aUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_SetPlaca
            // 
            this.lbl_SetPlaca.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_SetPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SetPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetPlaca.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_SetPlaca.Location = new System.Drawing.Point(165, 44);
            this.lbl_SetPlaca.Name = "lbl_SetPlaca";
            this.lbl_SetPlaca.Size = new System.Drawing.Size(100, 19);
            this.lbl_SetPlaca.TabIndex = 4;
            // 
            // lbl_SetMarca
            // 
            this.lbl_SetMarca.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_SetMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SetMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetMarca.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_SetMarca.Location = new System.Drawing.Point(107, 74);
            this.lbl_SetMarca.Name = "lbl_SetMarca";
            this.lbl_SetMarca.Size = new System.Drawing.Size(100, 19);
            this.lbl_SetMarca.TabIndex = 5;
            // 
            // lbl_SetKilometraje
            // 
            this.lbl_SetKilometraje.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_SetKilometraje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SetKilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetKilometraje.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_SetKilometraje.Location = new System.Drawing.Point(141, 107);
            this.lbl_SetKilometraje.Name = "lbl_SetKilometraje";
            this.lbl_SetKilometraje.Size = new System.Drawing.Size(100, 19);
            this.lbl_SetKilometraje.TabIndex = 6;
            // 
            // lbl_SetCapacidad
            // 
            this.lbl_SetCapacidad.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_SetCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SetCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetCapacidad.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_SetCapacidad.Location = new System.Drawing.Point(202, 140);
            this.lbl_SetCapacidad.Name = "lbl_SetCapacidad";
            this.lbl_SetCapacidad.Size = new System.Drawing.Size(100, 19);
            this.lbl_SetCapacidad.TabIndex = 7;
            // 
            // ListaDeAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 603);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_NumPlaca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_ListadoAutos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AñadirPKPP);
            this.Name = "ListaDeAutos";
            this.Text = "ListaDeAutos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ListaDeAutos_Activated);
            this.Load += new System.EventHandler(this.ListaDeAutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AñadirPKPP;
        private System.Windows.Forms.DataGridView dgv_ListadoAutos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_NumPlaca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Capacidad;
        private System.Windows.Forms.Label lbl_Kilometraje;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.BindingSource sISTEMAFLETESACARREOSDataSetBindingSource;
        private SISTEMAFLETESACARREOSDataSet sISTEMAFLETESACARREOSDataSet;
        private System.Windows.Forms.BindingSource aUTOSBindingSource;
        private SISTEMAFLETESACARREOSDataSetTableAdapters.AUTOSTableAdapter aUTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPlacasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aUTOSBindingSource1;
        private System.Windows.Forms.TextBox lbl_SetCapacidad;
        private System.Windows.Forms.TextBox lbl_SetKilometraje;
        private System.Windows.Forms.TextBox lbl_SetMarca;
        private System.Windows.Forms.TextBox lbl_SetPlaca;
    }
}