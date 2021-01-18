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
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_NombreMat = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_NombreMat = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.pb_Mat = new System.Windows.Forms.PictureBox();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.dgv_Materiales = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet16 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet16();
            this.mATERIALESTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet16TableAdapters.MATERIALESTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materiales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.txt_Precio);
            this.panel1.Controls.Add(this.txt_NombreMat);
            this.panel1.Controls.Add(this.lbl_Precio);
            this.panel1.Controls.Add(this.lbl_NombreMat);
            this.panel1.Location = new System.Drawing.Point(242, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 165);
            this.panel1.TabIndex = 16;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Precio.Location = new System.Drawing.Point(109, 85);
            this.txt_Precio.MaxLength = 6;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(173, 26);
            this.txt_Precio.TabIndex = 12;
            // 
            // txt_NombreMat
            // 
            this.txt_NombreMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NombreMat.Location = new System.Drawing.Point(181, 44);
            this.txt_NombreMat.MaxLength = 30;
            this.txt_NombreMat.Name = "txt_NombreMat";
            this.txt_NombreMat.Size = new System.Drawing.Size(173, 26);
            this.txt_NombreMat.TabIndex = 11;
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
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(117, 245);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 31);
            this.btn_Regresar.TabIndex = 15;
            this.btn_Regresar.Text = "Volver";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.button1_Click);
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
            // btn_Añadir
            // 
            this.btn_Añadir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Añadir.ForeColor = System.Drawing.Color.White;
            this.btn_Añadir.Location = new System.Drawing.Point(36, 245);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(75, 31);
            this.btn_Añadir.TabIndex = 18;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = false;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_Añadir_Click);
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
            this.dgv_Materiales.DataSource = this.mATERIALESBindingSource;
            this.dgv_Materiales.Location = new System.Drawing.Point(271, 262);
            this.dgv_Materiales.Name = "dgv_Materiales";
            this.dgv_Materiales.Size = new System.Drawing.Size(240, 150);
            this.dgv_Materiales.TabIndex = 19;
            this.dgv_Materiales.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMDataGridViewTextBoxColumn
            // 
            this.nombreMDataGridViewTextBoxColumn.DataPropertyName = "Nombre_M";
            this.nombreMDataGridViewTextBoxColumn.HeaderText = "Nombre_M";
            this.nombreMDataGridViewTextBoxColumn.Name = "nombreMDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // mATERIALESBindingSource
            // 
            this.mATERIALESBindingSource.DataMember = "MATERIALES";
            this.mATERIALESBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet16;
            // 
            // sISTEMAFLETESACARREOSDataSet16
            // 
            this.sISTEMAFLETESACARREOSDataSet16.DataSetName = "SISTEMAFLETESACARREOSDataSet16";
            this.sISTEMAFLETESACARREOSDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIALESTableAdapter
            // 
            this.mATERIALESTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 292);
            this.Controls.Add(this.dgv_Materiales);
            this.Controls.Add(this.btn_Añadir);
            this.Controls.Add(this.pb_Mat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Regresar);
            this.Name = "AgregarMaterial";
            this.Text = "AgregarMaterial";
            this.Load += new System.EventHandler(this.AgregarMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materiales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Mat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_NombreMat;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_NombreMat;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.DataGridView dgv_Materiales;
        private SISTEMAFLETESACARREOSDataSet16 sISTEMAFLETESACARREOSDataSet16;
        private System.Windows.Forms.BindingSource mATERIALESBindingSource;
        private SISTEMAFLETESACARREOSDataSet16TableAdapters.MATERIALESTableAdapter mATERIALESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}