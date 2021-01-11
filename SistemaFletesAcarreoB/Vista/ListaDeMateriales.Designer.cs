namespace SistemaFletesAcarreoB
{
    partial class ListaDeMateriales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.dgv_ListaMateriales = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet7 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet7();
            this.mATERIALESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet6 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet6();
            this.mATERIALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_VolverPKPP = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.mATERIALESTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSetTableAdapters.MATERIALESTableAdapter();
            this.mATERIALESTableAdapter1 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet6TableAdapters.MATERIALESTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SetIdMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SetPrecio = new System.Windows.Forms.TextBox();
            this.lbl_SetNombre = new System.Windows.Forms.TextBox();
            this.lbl_APaterno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mATERIALESTableAdapter2 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet7TableAdapters.MATERIALESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(48, 519);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(83, 40);
            this.btn_Editar.TabIndex = 33;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_ListaMateriales
            // 
            this.dgv_ListaMateriales.AllowUserToAddRows = false;
            this.dgv_ListaMateriales.AllowUserToDeleteRows = false;
            this.dgv_ListaMateriales.AutoGenerateColumns = false;
            this.dgv_ListaMateriales.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListaMateriales.ColumnHeadersHeight = 29;
            this.dgv_ListaMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreMDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dgv_ListaMateriales.DataSource = this.mATERIALESBindingSource2;
            this.dgv_ListaMateriales.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_ListaMateriales.Location = new System.Drawing.Point(48, 75);
            this.dgv_ListaMateriales.Name = "dgv_ListaMateriales";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ListaMateriales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ListaMateriales.Size = new System.Drawing.Size(484, 427);
            this.dgv_ListaMateriales.TabIndex = 32;
            this.dgv_ListaMateriales.MouseEnter += new System.EventHandler(this.dgv_ListaMateriales_MouseEnter);
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
            // mATERIALESBindingSource2
            // 
            this.mATERIALESBindingSource2.DataMember = "MATERIALES";
            this.mATERIALESBindingSource2.DataSource = this.sISTEMAFLETESACARREOSDataSet7;
            // 
            // sISTEMAFLETESACARREOSDataSet7
            // 
            this.sISTEMAFLETESACARREOSDataSet7.DataSetName = "SISTEMAFLETESACARREOSDataSet7";
            this.sISTEMAFLETESACARREOSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIALESBindingSource1
            // 
            this.mATERIALESBindingSource1.DataMember = "MATERIALES";
            this.mATERIALESBindingSource1.DataSource = this.sISTEMAFLETESACARREOSDataSet6;
            // 
            // sISTEMAFLETESACARREOSDataSet6
            // 
            this.sISTEMAFLETESACARREOSDataSet6.DataSetName = "SISTEMAFLETESACARREOSDataSet6";
            this.sISTEMAFLETESACARREOSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIALESBindingSource
            // 
            this.mATERIALESBindingSource.DataMember = "MATERIALES";
            this.mATERIALESBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet;
            // 
            // sISTEMAFLETESACARREOSDataSet
            // 
            this.sISTEMAFLETESACARREOSDataSet.DataSetName = "SISTEMAFLETESACARREOSDataSet";
            this.sISTEMAFLETESACARREOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_VolverPKPP
            // 
            this.btn_VolverPKPP.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverPKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_VolverPKPP.ForeColor = System.Drawing.Color.White;
            this.btn_VolverPKPP.Location = new System.Drawing.Point(137, 519);
            this.btn_VolverPKPP.Name = "btn_VolverPKPP";
            this.btn_VolverPKPP.Size = new System.Drawing.Size(83, 40);
            this.btn_VolverPKPP.TabIndex = 30;
            this.btn_VolverPKPP.Text = "Añadir";
            this.btn_VolverPKPP.UseVisualStyleBackColor = false;
            this.btn_VolverPKPP.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre.Location = new System.Drawing.Point(48, 40);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(164, 20);
            this.lbl_Nombre.TabIndex = 34;
            this.lbl_Nombre.Text = "Listado de Materiales:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(226, 519);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(83, 40);
            this.btn_Eliminar.TabIndex = 35;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // mATERIALESTableAdapter
            // 
            this.mATERIALESTableAdapter.ClearBeforeFill = true;
            // 
            // mATERIALESTableAdapter1
            // 
            this.mATERIALESTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lbl_SetIdMaterial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_SetPrecio);
            this.panel1.Controls.Add(this.lbl_SetNombre);
            this.panel1.Controls.Add(this.lbl_APaterno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(585, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 142);
            this.panel1.TabIndex = 36;
            // 
            // lbl_SetIdMaterial
            // 
            this.lbl_SetIdMaterial.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_SetIdMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SetIdMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetIdMaterial.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_SetIdMaterial.Location = new System.Drawing.Point(57, 16);
            this.lbl_SetIdMaterial.Name = "lbl_SetIdMaterial";
            this.lbl_SetIdMaterial.Size = new System.Drawing.Size(253, 19);
            this.lbl_SetIdMaterial.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id:";
            // 
            // lbl_SetPrecio
            // 
            this.lbl_SetPrecio.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_SetPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SetPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetPrecio.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_SetPrecio.Location = new System.Drawing.Point(89, 83);
            this.lbl_SetPrecio.Name = "lbl_SetPrecio";
            this.lbl_SetPrecio.Size = new System.Drawing.Size(197, 19);
            this.lbl_SetPrecio.TabIndex = 21;
            // 
            // lbl_SetNombre
            // 
            this.lbl_SetNombre.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_SetNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SetNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetNombre.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_SetNombre.Location = new System.Drawing.Point(105, 51);
            this.lbl_SetNombre.Name = "lbl_SetNombre";
            this.lbl_SetNombre.Size = new System.Drawing.Size(253, 19);
            this.lbl_SetNombre.TabIndex = 20;
            // 
            // lbl_APaterno
            // 
            this.lbl_APaterno.AutoSize = true;
            this.lbl_APaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_APaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_APaterno.Location = new System.Drawing.Point(26, 82);
            this.lbl_APaterno.Name = "lbl_APaterno";
            this.lbl_APaterno.Size = new System.Drawing.Size(57, 20);
            this.lbl_APaterno.TabIndex = 1;
            this.lbl_APaterno.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // mATERIALESTableAdapter2
            // 
            this.mATERIALESTableAdapter2.ClearBeforeFill = true;
            // 
            // ListaDeMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.dgv_ListaMateriales);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_VolverPKPP);
            this.Name = "ListaDeMateriales";
            this.Text = "ListaDeMateriales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ListaDeMateriales_Activated);
            this.Load += new System.EventHandler(this.ListaDeMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.DataGridView dgv_ListaMateriales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_VolverPKPP;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button btn_Eliminar;
        private SISTEMAFLETESACARREOSDataSet sISTEMAFLETESACARREOSDataSet;
        private System.Windows.Forms.BindingSource mATERIALESBindingSource;
        private SISTEMAFLETESACARREOSDataSetTableAdapters.MATERIALESTableAdapter mATERIALESTableAdapter;
        private SISTEMAFLETESACARREOSDataSet6 sISTEMAFLETESACARREOSDataSet6;
        private System.Windows.Forms.BindingSource mATERIALESBindingSource1;
        private SISTEMAFLETESACARREOSDataSet6TableAdapters.MATERIALESTableAdapter mATERIALESTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lbl_SetIdMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbl_SetPrecio;
        private System.Windows.Forms.TextBox lbl_SetNombre;
        private System.Windows.Forms.Label lbl_APaterno;
        private System.Windows.Forms.Label label1;
        private SISTEMAFLETESACARREOSDataSet7 sISTEMAFLETESACARREOSDataSet7;
        private System.Windows.Forms.BindingSource mATERIALESBindingSource2;
        private SISTEMAFLETESACARREOSDataSet7TableAdapters.MATERIALESTableAdapter mATERIALESTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}