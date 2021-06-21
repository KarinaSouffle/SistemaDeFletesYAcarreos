
namespace SistemaFletesAcarreoB.Vista
{
    partial class RegistroUsuarioLogin
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
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.txt_CContraseña = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_CContraseña = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enUsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet20 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter1 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20TableAdapters.USUARIOSTableAdapter();
            this.sISTEMAFLETESACARREOSDataSet = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet();
            this.uSUARIOSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSetTableAdapters.USUARIOSTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Iniciar);
            this.panel1.Controls.Add(this.txt_CContraseña);
            this.panel1.Controls.Add(this.txt_Contraseña);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.lbl_CContraseña);
            this.panel1.Controls.Add(this.lbl_Contraseña);
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 230);
            this.panel1.TabIndex = 1;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Iniciar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.ForeColor = System.Drawing.Color.White;
            this.btn_Iniciar.Location = new System.Drawing.Point(112, 175);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(90, 29);
            this.btn_Iniciar.TabIndex = 13;
            this.btn_Iniciar.Text = "Aceptar";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // txt_CContraseña
            // 
            this.txt_CContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CContraseña.Location = new System.Drawing.Point(199, 119);
            this.txt_CContraseña.MaxLength = 12;
            this.txt_CContraseña.Name = "txt_CContraseña";
            this.txt_CContraseña.Size = new System.Drawing.Size(100, 26);
            this.txt_CContraseña.TabIndex = 12;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(129, 73);
            this.txt_Contraseña.MaxLength = 12;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 26);
            this.txt_Contraseña.TabIndex = 11;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(102, 30);
            this.txt_Nombre.MaxLength = 20;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 26);
            this.txt_Nombre.TabIndex = 10;
            // 
            // lbl_CContraseña
            // 
            this.lbl_CContraseña.AutoSize = true;
            this.lbl_CContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CContraseña.Location = new System.Drawing.Point(27, 122);
            this.lbl_CContraseña.Name = "lbl_CContraseña";
            this.lbl_CContraseña.Size = new System.Drawing.Size(166, 20);
            this.lbl_CContraseña.TabIndex = 9;
            this.lbl_CContraseña.Text = "Confirmar contraseña:";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.Location = new System.Drawing.Point(27, 79);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(96, 20);
            this.lbl_Contraseña.TabIndex = 8;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(27, 36);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(69, 20);
            this.lbl_Nombre.TabIndex = 7;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AutoGenerateColumns = false;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.contraDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.enUsoDataGridViewTextBoxColumn});
            this.dgv_Usuarios.DataSource = this.uSUARIOSBindingSource2;
            this.dgv_Usuarios.Location = new System.Drawing.Point(54, 260);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(247, 150);
            this.dgv_Usuarios.TabIndex = 1;
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
            // uSUARIOSBindingSource1
            // 
            this.uSUARIOSBindingSource1.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource1.DataSource = this.sISTEMAFLETESACARREOSDataSet20;
            // 
            // sISTEMAFLETESACARREOSDataSet20
            // 
            this.sISTEMAFLETESACARREOSDataSet20.DataSetName = "SISTEMAFLETESACARREOSDataSet20";
            this.sISTEMAFLETESACARREOSDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            // 
            // uSUARIOSTableAdapter1
            // 
            this.uSUARIOSTableAdapter1.ClearBeforeFill = true;
            // 
            // sISTEMAFLETESACARREOSDataSet
            // 
            this.sISTEMAFLETESACARREOSDataSet.DataSetName = "SISTEMAFLETESACARREOSDataSet";
            this.sISTEMAFLETESACARREOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource2
            // 
            this.uSUARIOSBindingSource2.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource2.DataSource = this.sISTEMAFLETESACARREOSDataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroUsuarioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 279);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroUsuarioLogin";
            this.Text = "RegistroUsuarioLogin";
            this.Load += new System.EventHandler(this.RegistroUsuarioLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.TextBox txt_CContraseña;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_CContraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enUsoDataGridViewTextBoxColumn;
        private SISTEMAFLETESACARREOSDataSet20 sISTEMAFLETESACARREOSDataSet20;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource1;
        private SISTEMAFLETESACARREOSDataSet20TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter1;
        private SISTEMAFLETESACARREOSDataSet sISTEMAFLETESACARREOSDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource2;
        private SISTEMAFLETESACARREOSDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
    }
}