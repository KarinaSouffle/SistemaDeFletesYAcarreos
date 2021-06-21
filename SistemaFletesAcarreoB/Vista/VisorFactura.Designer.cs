namespace SistemaFletesAcarreoB.Vista
{
    partial class VisorFactura
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
            this.dgv_Factura = new System.Windows.Forms.DataGridView();
            this.sISTEMAFLETESACARREOSDataSet = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURATableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSetTableAdapters.FACTURATableAdapter();
            this.boletanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalmetrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalviajesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKilometrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factlicenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factplacasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factKilometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Factura
            // 
            this.dgv_Factura.AllowUserToAddRows = false;
            this.dgv_Factura.AutoGenerateColumns = false;
            this.dgv_Factura.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boletanoDataGridViewTextBoxColumn,
            this.numFacturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.materialesDataGridViewTextBoxColumn,
            this.totalmetrosDataGridViewTextBoxColumn,
            this.totalviajesDataGridViewTextBoxColumn,
            this.totalKilometrosDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.factmaterialDataGridViewTextBoxColumn,
            this.factlicenciaDataGridViewTextBoxColumn,
            this.factplacasDataGridViewTextBoxColumn,
            this.factKilometroDataGridViewTextBoxColumn});
            this.dgv_Factura.DataSource = this.fACTURABindingSource;
            this.dgv_Factura.Location = new System.Drawing.Point(12, 12);
            this.dgv_Factura.Name = "dgv_Factura";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Factura.Size = new System.Drawing.Size(776, 426);
            this.dgv_Factura.TabIndex = 10;
            // 
            // sISTEMAFLETESACARREOSDataSet
            // 
            this.sISTEMAFLETESACARREOSDataSet.DataSetName = "SISTEMAFLETESACARREOSDataSet";
            this.sISTEMAFLETESACARREOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataMember = "FACTURA";
            this.fACTURABindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet;
            // 
            // fACTURATableAdapter
            // 
            this.fACTURATableAdapter.ClearBeforeFill = true;
            // 
            // boletanoDataGridViewTextBoxColumn
            // 
            this.boletanoDataGridViewTextBoxColumn.DataPropertyName = "Boleta_no";
            this.boletanoDataGridViewTextBoxColumn.HeaderText = "Boleta_no";
            this.boletanoDataGridViewTextBoxColumn.Name = "boletanoDataGridViewTextBoxColumn";
            this.boletanoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numFacturaDataGridViewTextBoxColumn
            // 
            this.numFacturaDataGridViewTextBoxColumn.DataPropertyName = "Num_Factura";
            this.numFacturaDataGridViewTextBoxColumn.HeaderText = "Num_Factura";
            this.numFacturaDataGridViewTextBoxColumn.Name = "numFacturaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // materialesDataGridViewTextBoxColumn
            // 
            this.materialesDataGridViewTextBoxColumn.DataPropertyName = "Materiales";
            this.materialesDataGridViewTextBoxColumn.HeaderText = "Materiales";
            this.materialesDataGridViewTextBoxColumn.Name = "materialesDataGridViewTextBoxColumn";
            // 
            // totalmetrosDataGridViewTextBoxColumn
            // 
            this.totalmetrosDataGridViewTextBoxColumn.DataPropertyName = "Total_metros";
            this.totalmetrosDataGridViewTextBoxColumn.HeaderText = "Total_metros";
            this.totalmetrosDataGridViewTextBoxColumn.Name = "totalmetrosDataGridViewTextBoxColumn";
            // 
            // totalviajesDataGridViewTextBoxColumn
            // 
            this.totalviajesDataGridViewTextBoxColumn.DataPropertyName = "Total_viajes";
            this.totalviajesDataGridViewTextBoxColumn.HeaderText = "Total_viajes";
            this.totalviajesDataGridViewTextBoxColumn.Name = "totalviajesDataGridViewTextBoxColumn";
            // 
            // totalKilometrosDataGridViewTextBoxColumn
            // 
            this.totalKilometrosDataGridViewTextBoxColumn.DataPropertyName = "Total_Kilometros";
            this.totalKilometrosDataGridViewTextBoxColumn.HeaderText = "Total_Kilometros";
            this.totalKilometrosDataGridViewTextBoxColumn.Name = "totalKilometrosDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // iVADataGridViewTextBoxColumn
            // 
            this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
            this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // factmaterialDataGridViewTextBoxColumn
            // 
            this.factmaterialDataGridViewTextBoxColumn.DataPropertyName = "Fact_material";
            this.factmaterialDataGridViewTextBoxColumn.HeaderText = "Fact_material";
            this.factmaterialDataGridViewTextBoxColumn.Name = "factmaterialDataGridViewTextBoxColumn";
            // 
            // factlicenciaDataGridViewTextBoxColumn
            // 
            this.factlicenciaDataGridViewTextBoxColumn.DataPropertyName = "Fact_licencia";
            this.factlicenciaDataGridViewTextBoxColumn.HeaderText = "Fact_licencia";
            this.factlicenciaDataGridViewTextBoxColumn.Name = "factlicenciaDataGridViewTextBoxColumn";
            // 
            // factplacasDataGridViewTextBoxColumn
            // 
            this.factplacasDataGridViewTextBoxColumn.DataPropertyName = "Fact_placas";
            this.factplacasDataGridViewTextBoxColumn.HeaderText = "Fact_placas";
            this.factplacasDataGridViewTextBoxColumn.Name = "factplacasDataGridViewTextBoxColumn";
            // 
            // factKilometroDataGridViewTextBoxColumn
            // 
            this.factKilometroDataGridViewTextBoxColumn.DataPropertyName = "Fact_Kilometro";
            this.factKilometroDataGridViewTextBoxColumn.HeaderText = "Fact_Kilometro";
            this.factKilometroDataGridViewTextBoxColumn.Name = "factKilometroDataGridViewTextBoxColumn";
            // 
            // VisorFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Factura);
            this.Name = "VisorFactura";
            this.Text = "VisorFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisorFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Factura;
        private SISTEMAFLETESACARREOSDataSet sISTEMAFLETESACARREOSDataSet;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private SISTEMAFLETESACARREOSDataSetTableAdapters.FACTURATableAdapter fACTURATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boletanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalmetrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalviajesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKilometrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factlicenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factplacasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factKilometroDataGridViewTextBoxColumn;
    }
}