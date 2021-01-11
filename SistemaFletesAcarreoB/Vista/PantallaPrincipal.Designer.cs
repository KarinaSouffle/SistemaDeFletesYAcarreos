namespace SistemaFletesAcarreoB
{
    partial class Pantalla_Principal
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
            this.btn_ChoferesAutos = new System.Windows.Forms.Button();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_Materiales = new System.Windows.Forms.Button();
            this.btn_VerFacturas = new System.Windows.Forms.Button();
            this.btn_PrecioKilometro = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.sISTEMAFLETESACARREOSDataSet14 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet14();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet14TableAdapters.USUARIOSTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enUsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_ChoferesAutos);
            this.panel1.Controls.Add(this.btn_Venta);
            this.panel1.Controls.Add(this.btn_Materiales);
            this.panel1.Controls.Add(this.btn_VerFacturas);
            this.panel1.Controls.Add(this.btn_PrecioKilometro);
            this.panel1.Location = new System.Drawing.Point(212, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 439);
            this.panel1.TabIndex = 6;
            // 
            // btn_ChoferesAutos
            // 
            this.btn_ChoferesAutos.Image = global::SistemaFletesAcarreoB.Properties.Resources.P4;
            this.btn_ChoferesAutos.Location = new System.Drawing.Point(504, 25);
            this.btn_ChoferesAutos.Name = "btn_ChoferesAutos";
            this.btn_ChoferesAutos.Size = new System.Drawing.Size(217, 190);
            this.btn_ChoferesAutos.TabIndex = 5;
            this.btn_ChoferesAutos.UseVisualStyleBackColor = true;
            this.btn_ChoferesAutos.Click += new System.EventHandler(this.btn_ChoferesAutos_Click);
            // 
            // btn_Venta
            // 
            this.btn_Venta.Image = global::SistemaFletesAcarreoB.Properties.Resources.P5;
            this.btn_Venta.Location = new System.Drawing.Point(163, 218);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(164, 192);
            this.btn_Venta.TabIndex = 4;
            this.btn_Venta.UseVisualStyleBackColor = true;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // btn_Materiales
            // 
            this.btn_Materiales.Image = global::SistemaFletesAcarreoB.Properties.Resources.P6;
            this.btn_Materiales.Location = new System.Drawing.Point(401, 222);
            this.btn_Materiales.Name = "btn_Materiales";
            this.btn_Materiales.Size = new System.Drawing.Size(166, 188);
            this.btn_Materiales.TabIndex = 3;
            this.btn_Materiales.UseVisualStyleBackColor = true;
            this.btn_Materiales.Click += new System.EventHandler(this.btn_Materiales_Click);
            // 
            // btn_VerFacturas
            // 
            this.btn_VerFacturas.Image = global::SistemaFletesAcarreoB.Properties.Resources.P3;
            this.btn_VerFacturas.Location = new System.Drawing.Point(289, 29);
            this.btn_VerFacturas.Name = "btn_VerFacturas";
            this.btn_VerFacturas.Size = new System.Drawing.Size(177, 183);
            this.btn_VerFacturas.TabIndex = 1;
            this.btn_VerFacturas.UseVisualStyleBackColor = true;
            this.btn_VerFacturas.Click += new System.EventHandler(this.btn_VerFacturas_Click);
            // 
            // btn_PrecioKilometro
            // 
            this.btn_PrecioKilometro.Image = global::SistemaFletesAcarreoB.Properties.Resources.P2;
            this.btn_PrecioKilometro.Location = new System.Drawing.Point(13, 29);
            this.btn_PrecioKilometro.Name = "btn_PrecioKilometro";
            this.btn_PrecioKilometro.Size = new System.Drawing.Size(229, 172);
            this.btn_PrecioKilometro.TabIndex = 0;
            this.btn_PrecioKilometro.UseVisualStyleBackColor = true;
            this.btn_PrecioKilometro.Click += new System.EventHandler(this.btn_PrecioKilometro_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_CerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(12, 12);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(119, 41);
            this.btn_CerrarSesion.TabIndex = 7;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
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
            this.dgv_Usuarios.Location = new System.Drawing.Point(41, 154);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(148, 105);
            this.dgv_Usuarios.TabIndex = 10;
            this.dgv_Usuarios.Visible = false;
            // 
            // sISTEMAFLETESACARREOSDataSet14
            // 
            this.sISTEMAFLETESACARREOSDataSet14.DataSetName = "SISTEMAFLETESACARREOSDataSet14";
            this.sISTEMAFLETESACARREOSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet14;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
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
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1154, 519);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.panel1);
            this.Name = "Pantalla_Principal";
            this.Text = "Pantalla_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PrecioKilometro;
        private System.Windows.Forms.Button btn_VerFacturas;
        private System.Windows.Forms.Button btn_Materiales;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Button btn_ChoferesAutos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private SISTEMAFLETESACARREOSDataSet14 sISTEMAFLETESACARREOSDataSet14;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private SISTEMAFLETESACARREOSDataSet14TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enUsoDataGridViewTextBoxColumn;
    }
}