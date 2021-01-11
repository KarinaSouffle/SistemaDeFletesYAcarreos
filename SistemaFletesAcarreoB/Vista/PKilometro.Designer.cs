namespace SistemaFletesAcarreoB
{
    partial class PKilometro
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
            this.lbl_SetPrecio = new System.Windows.Forms.Label();
            this.btn_GuardarNPK = new System.Windows.Forms.Button();
            this.btn_VolverPKPP = new System.Windows.Forms.Button();
            this.txt_NuevoPrecio = new System.Windows.Forms.TextBox();
            this.lbl_Nprecio = new System.Windows.Forms.Label();
            this.lbl_PrecioK = new System.Windows.Forms.Label();
            this.dgv_PrecioKilometro = new System.Windows.Forms.DataGridView();
            this.sISTEMAFLETESACARREOSDataSet7 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet7();
            this.kILOMETROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kILOMETROTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet7TableAdapters.KILOMETROTableAdapter();
            this.idKilometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrecioKilometro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kILOMETROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbl_SetPrecio);
            this.panel1.Controls.Add(this.btn_GuardarNPK);
            this.panel1.Controls.Add(this.btn_VolverPKPP);
            this.panel1.Controls.Add(this.txt_NuevoPrecio);
            this.panel1.Controls.Add(this.lbl_Nprecio);
            this.panel1.Controls.Add(this.lbl_PrecioK);
            this.panel1.Location = new System.Drawing.Point(119, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 458);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lbl_SetPrecio
            // 
            this.lbl_SetPrecio.AutoSize = true;
            this.lbl_SetPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetPrecio.Location = new System.Drawing.Point(422, 96);
            this.lbl_SetPrecio.Name = "lbl_SetPrecio";
            this.lbl_SetPrecio.Size = new System.Drawing.Size(75, 28);
            this.lbl_SetPrecio.TabIndex = 5;
            this.lbl_SetPrecio.Text = "-------";
            // 
            // btn_GuardarNPK
            // 
            this.btn_GuardarNPK.BackColor = System.Drawing.Color.DarkRed;
            this.btn_GuardarNPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_GuardarNPK.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarNPK.Location = new System.Drawing.Point(577, 370);
            this.btn_GuardarNPK.Name = "btn_GuardarNPK";
            this.btn_GuardarNPK.Size = new System.Drawing.Size(83, 38);
            this.btn_GuardarNPK.TabIndex = 4;
            this.btn_GuardarNPK.Text = "Guardar";
            this.btn_GuardarNPK.UseVisualStyleBackColor = false;
            this.btn_GuardarNPK.Click += new System.EventHandler(this.btn_GuardarNPK_Click);
            // 
            // btn_VolverPKPP
            // 
            this.btn_VolverPKPP.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverPKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_VolverPKPP.ForeColor = System.Drawing.Color.White;
            this.btn_VolverPKPP.Location = new System.Drawing.Point(62, 370);
            this.btn_VolverPKPP.Name = "btn_VolverPKPP";
            this.btn_VolverPKPP.Size = new System.Drawing.Size(83, 38);
            this.btn_VolverPKPP.TabIndex = 3;
            this.btn_VolverPKPP.Text = "Volver";
            this.btn_VolverPKPP.UseVisualStyleBackColor = false;
            this.btn_VolverPKPP.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // txt_NuevoPrecio
            // 
            this.txt_NuevoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NuevoPrecio.Location = new System.Drawing.Point(298, 243);
            this.txt_NuevoPrecio.Name = "txt_NuevoPrecio";
            this.txt_NuevoPrecio.Size = new System.Drawing.Size(133, 26);
            this.txt_NuevoPrecio.TabIndex = 2;
            // 
            // lbl_Nprecio
            // 
            this.lbl_Nprecio.AutoSize = true;
            this.lbl_Nprecio.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nprecio.Location = new System.Drawing.Point(284, 191);
            this.lbl_Nprecio.Name = "lbl_Nprecio";
            this.lbl_Nprecio.Size = new System.Drawing.Size(160, 28);
            this.lbl_Nprecio.TabIndex = 1;
            this.lbl_Nprecio.Text = "Nuevo Precio:";
            // 
            // lbl_PrecioK
            // 
            this.lbl_PrecioK.AutoSize = true;
            this.lbl_PrecioK.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioK.Location = new System.Drawing.Point(220, 96);
            this.lbl_PrecioK.Name = "lbl_PrecioK";
            this.lbl_PrecioK.Size = new System.Drawing.Size(196, 28);
            this.lbl_PrecioK.TabIndex = 0;
            this.lbl_PrecioK.Text = "Precio Kilometro:";
            // 
            // dgv_PrecioKilometro
            // 
            this.dgv_PrecioKilometro.AutoGenerateColumns = false;
            this.dgv_PrecioKilometro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PrecioKilometro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKilometroDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dgv_PrecioKilometro.DataSource = this.kILOMETROBindingSource;
            this.dgv_PrecioKilometro.Location = new System.Drawing.Point(122, 105);
            this.dgv_PrecioKilometro.Name = "dgv_PrecioKilometro";
            this.dgv_PrecioKilometro.Size = new System.Drawing.Size(240, 150);
            this.dgv_PrecioKilometro.TabIndex = 6;
            this.dgv_PrecioKilometro.Visible = false;
            // 
            // sISTEMAFLETESACARREOSDataSet7
            // 
            this.sISTEMAFLETESACARREOSDataSet7.DataSetName = "SISTEMAFLETESACARREOSDataSet7";
            this.sISTEMAFLETESACARREOSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kILOMETROBindingSource
            // 
            this.kILOMETROBindingSource.DataMember = "KILOMETRO";
            this.kILOMETROBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet7;
            // 
            // kILOMETROTableAdapter
            // 
            this.kILOMETROTableAdapter.ClearBeforeFill = true;
            // 
            // idKilometroDataGridViewTextBoxColumn
            // 
            this.idKilometroDataGridViewTextBoxColumn.DataPropertyName = "Id_Kilometro";
            this.idKilometroDataGridViewTextBoxColumn.HeaderText = "Id_Kilometro";
            this.idKilometroDataGridViewTextBoxColumn.Name = "idKilometroDataGridViewTextBoxColumn";
            this.idKilometroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PKilometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(947, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_PrecioKilometro);
            this.Name = "PKilometro";
            this.Text = "PKilometro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PKilometro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrecioKilometro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kILOMETROBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_PrecioK;
        private System.Windows.Forms.Button btn_GuardarNPK;
        private System.Windows.Forms.Button btn_VolverPKPP;
        private System.Windows.Forms.TextBox txt_NuevoPrecio;
        private System.Windows.Forms.Label lbl_Nprecio;
        private System.Windows.Forms.Label lbl_SetPrecio;
        private System.Windows.Forms.DataGridView dgv_PrecioKilometro;
        private SISTEMAFLETESACARREOSDataSet7 sISTEMAFLETESACARREOSDataSet7;
        private System.Windows.Forms.BindingSource kILOMETROBindingSource;
        private SISTEMAFLETESACARREOSDataSet7TableAdapters.KILOMETROTableAdapter kILOMETROTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKilometroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}