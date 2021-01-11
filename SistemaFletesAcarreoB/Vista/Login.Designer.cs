namespace SistemaFletesAcarreoB
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraeña = new System.Windows.Forms.TextBox();
            this.label_NusuarioLogIn = new System.Windows.Forms.Label();
            this.label_ContraseñaLogIn = new System.Windows.Forms.Label();
            this.gB_Datos = new System.Windows.Forms.GroupBox();
            this.btn_registro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enUsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet14 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet14();
            this.sISTEMAFLETESACARREOSDataSet12 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet12();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet12TableAdapters.USUARIOSTableAdapter();
            this.uSUARIOSTableAdapter1 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet14TableAdapters.USUARIOSTableAdapter();
            this.gB_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Iniciar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.ForeColor = System.Drawing.Color.White;
            this.btn_Iniciar.Location = new System.Drawing.Point(561, 176);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar.TabIndex = 3;
            this.btn_Iniciar.Text = "INICIAR";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(340, 44);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(205, 20);
            this.txt_Usuario.TabIndex = 0;
            // 
            // txt_Contraeña
            // 
            this.txt_Contraeña.Location = new System.Drawing.Point(340, 92);
            this.txt_Contraeña.Name = "txt_Contraeña";
            this.txt_Contraeña.PasswordChar = '*';
            this.txt_Contraeña.Size = new System.Drawing.Size(205, 20);
            this.txt_Contraeña.TabIndex = 1;
            // 
            // label_NusuarioLogIn
            // 
            this.label_NusuarioLogIn.AutoSize = true;
            this.label_NusuarioLogIn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NusuarioLogIn.ForeColor = System.Drawing.Color.White;
            this.label_NusuarioLogIn.Location = new System.Drawing.Point(224, 44);
            this.label_NusuarioLogIn.Name = "label_NusuarioLogIn";
            this.label_NusuarioLogIn.Size = new System.Drawing.Size(85, 22);
            this.label_NusuarioLogIn.TabIndex = 3;
            this.label_NusuarioLogIn.Text = "USUARIO";
            // 
            // label_ContraseñaLogIn
            // 
            this.label_ContraseñaLogIn.AutoSize = true;
            this.label_ContraseñaLogIn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ContraseñaLogIn.ForeColor = System.Drawing.Color.White;
            this.label_ContraseñaLogIn.Location = new System.Drawing.Point(183, 89);
            this.label_ContraseñaLogIn.Name = "label_ContraseñaLogIn";
            this.label_ContraseñaLogIn.Size = new System.Drawing.Size(126, 22);
            this.label_ContraseñaLogIn.TabIndex = 4;
            this.label_ContraseñaLogIn.Text = "CONTRASEÑA";
            // 
            // gB_Datos
            // 
            this.gB_Datos.BackColor = System.Drawing.Color.DarkRed;
            this.gB_Datos.Controls.Add(this.btn_registro);
            this.gB_Datos.Controls.Add(this.txt_Contraeña);
            this.gB_Datos.Controls.Add(this.btn_Iniciar);
            this.gB_Datos.Controls.Add(this.label_NusuarioLogIn);
            this.gB_Datos.Controls.Add(this.label_ContraseñaLogIn);
            this.gB_Datos.Controls.Add(this.txt_Usuario);
            this.gB_Datos.ForeColor = System.Drawing.Color.White;
            this.gB_Datos.Location = new System.Drawing.Point(260, 313);
            this.gB_Datos.Name = "gB_Datos";
            this.gB_Datos.Size = new System.Drawing.Size(831, 225);
            this.gB_Datos.TabIndex = 5;
            this.gB_Datos.TabStop = false;
            this.gB_Datos.Text = "LOG-IN";
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.DarkRed;
            this.btn_registro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.ForeColor = System.Drawing.Color.White;
            this.btn_registro.Location = new System.Drawing.Point(642, 176);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(75, 23);
            this.btn_registro.TabIndex = 4;
            this.btn_registro.Text = "REGISTRO";
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaFletesAcarreoB.Properties.Resources.P1;
            this.pictureBox1.Location = new System.Drawing.Point(120, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1110, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.dgv_Usuarios.DataSource = this.uSUARIOSBindingSource1;
            this.dgv_Usuarios.Location = new System.Drawing.Point(3, 313);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(251, 99);
            this.dgv_Usuarios.TabIndex = 7;
            this.dgv_Usuarios.TabStop = false;
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
            this.uSUARIOSBindingSource1.DataSource = this.sISTEMAFLETESACARREOSDataSet14;
            // 
            // sISTEMAFLETESACARREOSDataSet14
            // 
            this.sISTEMAFLETESACARREOSDataSet14.DataSetName = "SISTEMAFLETESACARREOSDataSet14";
            this.sISTEMAFLETESACARREOSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sISTEMAFLETESACARREOSDataSet12
            // 
            this.sISTEMAFLETESACARREOSDataSet12.DataSetName = "SISTEMAFLETESACARREOSDataSet12";
            this.sISTEMAFLETESACARREOSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet12;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // uSUARIOSTableAdapter1
            // 
            this.uSUARIOSTableAdapter1.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1154, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gB_Datos);
            this.Controls.Add(this.dgv_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Sistemas de Fletes y Acarreos: Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.gB_Datos.ResumeLayout(false);
            this.gB_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contraeña;
        private System.Windows.Forms.Label label_NusuarioLogIn;
        private System.Windows.Forms.Label label_ContraseñaLogIn;
        private System.Windows.Forms.GroupBox gB_Datos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private SISTEMAFLETESACARREOSDataSet12 sISTEMAFLETESACARREOSDataSet12;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private SISTEMAFLETESACARREOSDataSet12TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private SISTEMAFLETESACARREOSDataSet14 sISTEMAFLETESACARREOSDataSet14;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource1;
        private SISTEMAFLETESACARREOSDataSet14TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enUsoDataGridViewTextBoxColumn;
    }
}

