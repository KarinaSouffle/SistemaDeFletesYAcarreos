﻿namespace SistemaFletesAcarreoB
{
    partial class AgregarAuto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Capacidad = new System.Windows.Forms.TextBox();
            this.txt_Kilometraje = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_NumPlaca = new System.Windows.Forms.TextBox();
            this.lbl_Capacidad = new System.Windows.Forms.Label();
            this.lbl_Kilometraje = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_NumPlaca = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sISTEMAFLETESACARREOSDataSet15 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet15();
            this.aUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOSTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet15TableAdapters.AUTOSTableAdapter();
            this.capADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPlacasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Autos = new System.Windows.Forms.DataGridView();
            this.aUTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet16 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet16();
            this.aUTOSTableAdapter1 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet16TableAdapters.AUTOSTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.txt_Capacidad);
            this.panel1.Controls.Add(this.txt_Kilometraje);
            this.panel1.Controls.Add(this.txt_Marca);
            this.panel1.Controls.Add(this.txt_NumPlaca);
            this.panel1.Controls.Add(this.lbl_Capacidad);
            this.panel1.Controls.Add(this.lbl_Kilometraje);
            this.panel1.Controls.Add(this.lbl_Marca);
            this.panel1.Controls.Add(this.lbl_NumPlaca);
            this.panel1.Location = new System.Drawing.Point(250, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 219);
            this.panel1.TabIndex = 12;
            // 
            // txt_Capacidad
            // 
            this.txt_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Capacidad.Location = new System.Drawing.Point(199, 170);
            this.txt_Capacidad.MaxLength = 6;
            this.txt_Capacidad.Name = "txt_Capacidad";
            this.txt_Capacidad.Size = new System.Drawing.Size(160, 26);
            this.txt_Capacidad.TabIndex = 13;
            // 
            // txt_Kilometraje
            // 
            this.txt_Kilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Kilometraje.Location = new System.Drawing.Point(138, 121);
            this.txt_Kilometraje.MaxLength = 6;
            this.txt_Kilometraje.Name = "txt_Kilometraje";
            this.txt_Kilometraje.Size = new System.Drawing.Size(173, 26);
            this.txt_Kilometraje.TabIndex = 12;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Marca.Location = new System.Drawing.Point(104, 72);
            this.txt_Marca.MaxLength = 20;
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(173, 26);
            this.txt_Marca.TabIndex = 11;
            // 
            // txt_NumPlaca
            // 
            this.txt_NumPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NumPlaca.Location = new System.Drawing.Point(162, 26);
            this.txt_NumPlaca.MaxLength = 6;
            this.txt_NumPlaca.Name = "txt_NumPlaca";
            this.txt_NumPlaca.Size = new System.Drawing.Size(200, 26);
            this.txt_NumPlaca.TabIndex = 10;
            this.txt_NumPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Capacidad
            // 
            this.lbl_Capacidad.AutoSize = true;
            this.lbl_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capacidad.ForeColor = System.Drawing.Color.White;
            this.lbl_Capacidad.Location = new System.Drawing.Point(41, 173);
            this.lbl_Capacidad.Name = "lbl_Capacidad";
            this.lbl_Capacidad.Size = new System.Drawing.Size(152, 20);
            this.lbl_Capacidad.TabIndex = 3;
            this.lbl_Capacidad.Text = "Capacidad del Auto:";
            // 
            // lbl_Kilometraje
            // 
            this.lbl_Kilometraje.AutoSize = true;
            this.lbl_Kilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kilometraje.ForeColor = System.Drawing.Color.White;
            this.lbl_Kilometraje.Location = new System.Drawing.Point(41, 124);
            this.lbl_Kilometraje.Name = "lbl_Kilometraje";
            this.lbl_Kilometraje.Size = new System.Drawing.Size(91, 20);
            this.lbl_Kilometraje.TabIndex = 2;
            this.lbl_Kilometraje.Text = "Kilometraje:";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.ForeColor = System.Drawing.Color.White;
            this.lbl_Marca.Location = new System.Drawing.Point(41, 75);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(57, 20);
            this.lbl_Marca.TabIndex = 1;
            this.lbl_Marca.Text = "Marca:";
            // 
            // lbl_NumPlaca
            // 
            this.lbl_NumPlaca.AutoSize = true;
            this.lbl_NumPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumPlaca.ForeColor = System.Drawing.Color.White;
            this.lbl_NumPlaca.Location = new System.Drawing.Point(41, 29);
            this.lbl_NumPlaca.Name = "lbl_NumPlaca";
            this.lbl_NumPlaca.Size = new System.Drawing.Size(115, 20);
            this.lbl_NumPlaca.TabIndex = 0;
            this.lbl_NumPlaca.Text = "Num. de Placa:";
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.Location = new System.Drawing.Point(144, 269);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 32);
            this.btn_Volver.TabIndex = 11;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Añadir.ForeColor = System.Drawing.Color.White;
            this.btn_Añadir.Location = new System.Drawing.Point(25, 269);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(75, 32);
            this.btn_Añadir.TabIndex = 10;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = false;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaFletesAcarreoB.Properties.Resources.autodefault;
            this.pictureBox1.Location = new System.Drawing.Point(16, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 219);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // sISTEMAFLETESACARREOSDataSet15
            // 
            this.sISTEMAFLETESACARREOSDataSet15.DataSetName = "SISTEMAFLETESACARREOSDataSet15";
            this.sISTEMAFLETESACARREOSDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTOSBindingSource
            // 
            this.aUTOSBindingSource.DataMember = "AUTOS";
            this.aUTOSBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet15;
            // 
            // aUTOSTableAdapter
            // 
            this.aUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // capADataGridViewTextBoxColumn
            // 
            this.capADataGridViewTextBoxColumn.DataPropertyName = "Cap_A";
            this.capADataGridViewTextBoxColumn.HeaderText = "Cap_A";
            this.capADataGridViewTextBoxColumn.Name = "capADataGridViewTextBoxColumn";
            // 
            // kilometrajeDataGridViewTextBoxColumn
            // 
            this.kilometrajeDataGridViewTextBoxColumn.DataPropertyName = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.HeaderText = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.Name = "kilometrajeDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // numPlacasDataGridViewTextBoxColumn
            // 
            this.numPlacasDataGridViewTextBoxColumn.DataPropertyName = "Num_Placas";
            this.numPlacasDataGridViewTextBoxColumn.HeaderText = "Num_Placas";
            this.numPlacasDataGridViewTextBoxColumn.Name = "numPlacasDataGridViewTextBoxColumn";
            // 
            // idAutosDataGridViewTextBoxColumn
            // 
            this.idAutosDataGridViewTextBoxColumn.DataPropertyName = "Id_Autos";
            this.idAutosDataGridViewTextBoxColumn.HeaderText = "Id_Autos";
            this.idAutosDataGridViewTextBoxColumn.Name = "idAutosDataGridViewTextBoxColumn";
            this.idAutosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgv_Autos
            // 
            this.dgv_Autos.AllowUserToAddRows = false;
            this.dgv_Autos.AutoGenerateColumns = false;
            this.dgv_Autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Autos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutosDataGridViewTextBoxColumn,
            this.numPlacasDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.kilometrajeDataGridViewTextBoxColumn,
            this.capADataGridViewTextBoxColumn});
            this.dgv_Autos.DataSource = this.aUTOSBindingSource1;
            this.dgv_Autos.Location = new System.Drawing.Point(412, 254);
            this.dgv_Autos.Name = "dgv_Autos";
            this.dgv_Autos.Size = new System.Drawing.Size(240, 150);
            this.dgv_Autos.TabIndex = 14;
            this.dgv_Autos.Visible = false;
            // 
            // aUTOSBindingSource1
            // 
            this.aUTOSBindingSource1.DataMember = "AUTOS";
            this.aUTOSBindingSource1.DataSource = this.sISTEMAFLETESACARREOSDataSet16;
            // 
            // sISTEMAFLETESACARREOSDataSet16
            // 
            this.sISTEMAFLETESACARREOSDataSet16.DataSetName = "SISTEMAFLETESACARREOSDataSet16";
            this.sISTEMAFLETESACARREOSDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTOSTableAdapter1
            // 
            this.aUTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // AgregarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 313);
            this.Controls.Add(this.dgv_Autos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Añadir);
            this.Name = "AgregarAuto";
            this.Text = "AgregarAuto";
            this.Load += new System.EventHandler(this.AgregarAuto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Capacidad;
        private System.Windows.Forms.TextBox txt_Kilometraje;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_NumPlaca;
        private System.Windows.Forms.Label lbl_Capacidad;
        private System.Windows.Forms.Label lbl_Kilometraje;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_NumPlaca;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Añadir;
        private SISTEMAFLETESACARREOSDataSet15 sISTEMAFLETESACARREOSDataSet15;
        private System.Windows.Forms.BindingSource aUTOSBindingSource;
        private SISTEMAFLETESACARREOSDataSet15TableAdapters.AUTOSTableAdapter aUTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn capADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPlacasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_Autos;
        private SISTEMAFLETESACARREOSDataSet16 sISTEMAFLETESACARREOSDataSet16;
        private System.Windows.Forms.BindingSource aUTOSBindingSource1;
        private SISTEMAFLETESACARREOSDataSet16TableAdapters.AUTOSTableAdapter aUTOSTableAdapter1;
    }
}