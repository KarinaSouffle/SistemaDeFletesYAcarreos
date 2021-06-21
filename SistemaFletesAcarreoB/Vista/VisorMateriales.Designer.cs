
namespace SistemaFletesAcarreoB.Vista
{
    partial class VisorMateriales
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
            this.pnl_Contenedor2 = new System.Windows.Forms.Panel();
            this.btn_VolverPKPP = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enUsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet20 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20();
            this.uSUARIOSTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20TableAdapters.USUARIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Contenedor2
            // 
            this.pnl_Contenedor2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Contenedor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Contenedor2.Location = new System.Drawing.Point(0, 0);
            this.pnl_Contenedor2.Name = "pnl_Contenedor2";
            this.pnl_Contenedor2.Size = new System.Drawing.Size(1101, 557);
            this.pnl_Contenedor2.TabIndex = 7;
            // 
            // btn_VolverPKPP
            // 
            this.btn_VolverPKPP.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverPKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_VolverPKPP.ForeColor = System.Drawing.Color.White;
            this.btn_VolverPKPP.Location = new System.Drawing.Point(137, 501);
            this.btn_VolverPKPP.Name = "btn_VolverPKPP";
            this.btn_VolverPKPP.Size = new System.Drawing.Size(83, 40);
            this.btn_VolverPKPP.TabIndex = 32;
            this.btn_VolverPKPP.Text = "Añadir";
            this.btn_VolverPKPP.UseVisualStyleBackColor = false;
            this.btn_VolverPKPP.Visible = false;
            this.btn_VolverPKPP.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(233, 501);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 40);
            this.btn_Regresar.TabIndex = 33;
            this.btn_Regresar.Text = "Volver";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Visible = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AutoGenerateColumns = false;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.contraDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.enUsoDataGridViewTextBoxColumn});
            this.dgv_Usuarios.DataSource = this.uSUARIOSBindingSource;
            this.dgv_Usuarios.Location = new System.Drawing.Point(521, 520);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(532, 150);
            this.dgv_Usuarios.TabIndex = 34;
            this.dgv_Usuarios.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // contraDataGridViewTextBoxColumn
            // 
            this.contraDataGridViewTextBoxColumn.DataPropertyName = "Contra";
            this.contraDataGridViewTextBoxColumn.HeaderText = "Contra";
            this.contraDataGridViewTextBoxColumn.Name = "contraDataGridViewTextBoxColumn";
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            // 
            // enUsoDataGridViewTextBoxColumn
            // 
            this.enUsoDataGridViewTextBoxColumn.DataPropertyName = "EnUso";
            this.enUsoDataGridViewTextBoxColumn.HeaderText = "EnUso";
            this.enUsoDataGridViewTextBoxColumn.Name = "enUsoDataGridViewTextBoxColumn";
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet20;
            // 
            // sISTEMAFLETESACARREOSDataSet20
            // 
            this.sISTEMAFLETESACARREOSDataSet20.DataSetName = "SISTEMAFLETESACARREOSDataSet20";
            this.sISTEMAFLETESACARREOSDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // VisorMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 557);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_VolverPKPP);
            this.Controls.Add(this.pnl_Contenedor2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisorMateriales";
            this.Text = "VisorMateriales";
            this.Load += new System.EventHandler(this.VisorMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Contenedor2;
        private System.Windows.Forms.Button btn_VolverPKPP;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private SISTEMAFLETESACARREOSDataSet20 sISTEMAFLETESACARREOSDataSet20;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private SISTEMAFLETESACARREOSDataSet20TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enUsoDataGridViewTextBoxColumn;
    }
}