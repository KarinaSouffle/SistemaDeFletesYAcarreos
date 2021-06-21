namespace SistemaFletesAcarreoB
{
    partial class AgregarMaterial
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
            this.lbl_ValPrecio = new System.Windows.Forms.Label();
            this.lbl_ValNom = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_NombreMat = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_NombreMat = new System.Windows.Forms.Label();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.mATERIALESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet20 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20();
            this.mATERIALESTableAdapter1 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20TableAdapters.MATERIALESTableAdapter();
            this.pb_Mat = new System.Windows.Forms.PictureBox();
            this.mATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Materiales = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materiales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lbl_ValPrecio);
            this.panel1.Controls.Add(this.lbl_ValNom);
            this.panel1.Controls.Add(this.txt_Precio);
            this.panel1.Controls.Add(this.txt_NombreMat);
            this.panel1.Controls.Add(this.lbl_Precio);
            this.panel1.Controls.Add(this.lbl_NombreMat);
            this.panel1.Location = new System.Drawing.Point(242, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 165);
            this.panel1.TabIndex = 16;
            // 
            // lbl_ValPrecio
            // 
            this.lbl_ValPrecio.AutoSize = true;
            this.lbl_ValPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValPrecio.ForeColor = System.Drawing.Color.White;
            this.lbl_ValPrecio.Location = new System.Drawing.Point(288, 91);
            this.lbl_ValPrecio.Name = "lbl_ValPrecio";
            this.lbl_ValPrecio.Size = new System.Drawing.Size(16, 20);
            this.lbl_ValPrecio.TabIndex = 14;
            this.lbl_ValPrecio.Text = "*";
            // 
            // lbl_ValNom
            // 
            this.lbl_ValNom.AutoSize = true;
            this.lbl_ValNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValNom.ForeColor = System.Drawing.Color.White;
            this.lbl_ValNom.Location = new System.Drawing.Point(360, 44);
            this.lbl_ValNom.Name = "lbl_ValNom";
            this.lbl_ValNom.Size = new System.Drawing.Size(16, 20);
            this.lbl_ValNom.TabIndex = 13;
            this.lbl_ValNom.Text = "*";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Precio.Location = new System.Drawing.Point(109, 85);
            this.txt_Precio.MaxLength = 6;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(173, 26);
            this.txt_Precio.TabIndex = 12;
            this.txt_Precio.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Precio_Validating);
            // 
            // txt_NombreMat
            // 
            this.txt_NombreMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NombreMat.Location = new System.Drawing.Point(181, 44);
            this.txt_NombreMat.MaxLength = 30;
            this.txt_NombreMat.Name = "txt_NombreMat";
            this.txt_NombreMat.Size = new System.Drawing.Size(173, 26);
            this.txt_NombreMat.TabIndex = 11;
            this.txt_NombreMat.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NombreMat_Validating);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.Color.White;
            this.lbl_Precio.Location = new System.Drawing.Point(46, 88);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(57, 20);
            this.lbl_Precio.TabIndex = 2;
            this.lbl_Precio.Text = "Precio:";
            // 
            // lbl_NombreMat
            // 
            this.lbl_NombreMat.AutoSize = true;
            this.lbl_NombreMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreMat.ForeColor = System.Drawing.Color.White;
            this.lbl_NombreMat.Location = new System.Drawing.Point(46, 47);
            this.lbl_NombreMat.Name = "lbl_NombreMat";
            this.lbl_NombreMat.Size = new System.Drawing.Size(129, 20);
            this.lbl_NombreMat.TabIndex = 1;
            this.lbl_NombreMat.Text = "Nombre Material:";
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Añadir.ForeColor = System.Drawing.Color.White;
            this.btn_Añadir.Location = new System.Drawing.Point(137, 501);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(83, 40);
            this.btn_Añadir.TabIndex = 18;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = false;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_Añadir_Click);
            // 
            // mATERIALESBindingSource1
            // 
            this.mATERIALESBindingSource1.DataMember = "MATERIALES";
            this.mATERIALESBindingSource1.DataSource = this.sISTEMAFLETESACARREOSDataSet20;
            // 
            // sISTEMAFLETESACARREOSDataSet20
            // 
            this.sISTEMAFLETESACARREOSDataSet20.DataSetName = "SISTEMAFLETESACARREOSDataSet20";
            this.sISTEMAFLETESACARREOSDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIALESTableAdapter1
            // 
            this.mATERIALESTableAdapter1.ClearBeforeFill = true;
            // 
            // pb_Mat
            // 
            this.pb_Mat.Image = global::SistemaFletesAcarreoB.Properties.Resources.meterialdefault;
            this.pb_Mat.Location = new System.Drawing.Point(16, 21);
            this.pb_Mat.Name = "pb_Mat";
            this.pb_Mat.Size = new System.Drawing.Size(208, 198);
            this.pb_Mat.TabIndex = 17;
            this.pb_Mat.TabStop = false;
            // 
            // mATERIALESBindingSource
            // 
            this.mATERIALESBindingSource.DataMember = "MATERIALES";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // nombreMDataGridViewTextBoxColumn
            // 
            this.nombreMDataGridViewTextBoxColumn.DataPropertyName = "Nombre_M";
            this.nombreMDataGridViewTextBoxColumn.HeaderText = "Nombre_M";
            this.nombreMDataGridViewTextBoxColumn.Name = "nombreMDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgv_Materiales
            // 
            this.dgv_Materiales.AllowUserToAddRows = false;
            this.dgv_Materiales.AutoGenerateColumns = false;
            this.dgv_Materiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Materiales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreMDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dgv_Materiales.DataSource = this.mATERIALESBindingSource1;
            this.dgv_Materiales.Location = new System.Drawing.Point(271, 262);
            this.dgv_Materiales.Name = "dgv_Materiales";
            this.dgv_Materiales.Size = new System.Drawing.Size(240, 150);
            this.dgv_Materiales.TabIndex = 19;
            this.dgv_Materiales.Visible = false;
            // 
            // AgregarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 557);
            this.Controls.Add(this.dgv_Materiales);
            this.Controls.Add(this.btn_Añadir);
            this.Controls.Add(this.pb_Mat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarMaterial";
            this.Text = "AgregarMaterial";
            this.Load += new System.EventHandler(this.AgregarMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materiales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Mat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_NombreMat;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_NombreMat;
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.BindingSource mATERIALESBindingSource;
        private System.Windows.Forms.Label lbl_ValPrecio;
        private System.Windows.Forms.Label lbl_ValNom;
        private SISTEMAFLETESACARREOSDataSet20 sISTEMAFLETESACARREOSDataSet20;
        private System.Windows.Forms.BindingSource mATERIALESBindingSource1;
        private SISTEMAFLETESACARREOSDataSet20TableAdapters.MATERIALESTableAdapter mATERIALESTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_Materiales;
    }
}