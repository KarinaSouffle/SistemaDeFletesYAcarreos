namespace SistemaFletesAcarreoB
{
    partial class AgregarChofer
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Sexo = new System.Windows.Forms.ComboBox();
            this.dt_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.txt_Licencia = new System.Windows.Forms.TextBox();
            this.txt_Domicilio = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_AMaterno = new System.Windows.Forms.TextBox();
            this.txt_APaterno = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Licencia = new System.Windows.Forms.Label();
            this.lbl_FechaNac = new System.Windows.Forms.Label();
            this.lbl_Domicilio = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_AMaterno = new System.Windows.Forms.Label();
            this.lbl_APaterno = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.pb_Usuario = new System.Windows.Forms.PictureBox();
            this.dgv_Chofer = new System.Windows.Forms.DataGridView();
            this.idChoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICENCIACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nChoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHOFERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet16 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet16();
            this.cHOFERTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet16TableAdapters.CHOFERTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOFERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.Location = new System.Drawing.Point(128, 344);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 31);
            this.btn_Volver.TabIndex = 7;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Añadir.ForeColor = System.Drawing.Color.White;
            this.btn_Añadir.Location = new System.Drawing.Point(9, 344);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(75, 31);
            this.btn_Añadir.TabIndex = 6;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = false;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.txt_Sexo);
            this.panel1.Controls.Add(this.dt_FechaNac);
            this.panel1.Controls.Add(this.txt_Licencia);
            this.panel1.Controls.Add(this.txt_Domicilio);
            this.panel1.Controls.Add(this.txt_Correo);
            this.panel1.Controls.Add(this.txt_Telefono);
            this.panel1.Controls.Add(this.txt_AMaterno);
            this.panel1.Controls.Add(this.txt_APaterno);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.lbl_Licencia);
            this.panel1.Controls.Add(this.lbl_FechaNac);
            this.panel1.Controls.Add(this.lbl_Domicilio);
            this.panel1.Controls.Add(this.lbl_correo);
            this.panel1.Controls.Add(this.lbl_Telefono);
            this.panel1.Controls.Add(this.lbl_Sexo);
            this.panel1.Controls.Add(this.lbl_AMaterno);
            this.panel1.Controls.Add(this.lbl_APaterno);
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Location = new System.Drawing.Point(228, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 469);
            this.panel1.TabIndex = 8;
            // 
            // txt_Sexo
            // 
            this.txt_Sexo.FormattingEnabled = true;
            this.txt_Sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txt_Sexo.Location = new System.Drawing.Point(95, 147);
            this.txt_Sexo.Name = "txt_Sexo";
            this.txt_Sexo.Size = new System.Drawing.Size(34, 21);
            this.txt_Sexo.TabIndex = 21;
            // 
            // dt_FechaNac
            // 
            this.dt_FechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dt_FechaNac.Location = new System.Drawing.Point(209, 345);
            this.dt_FechaNac.Name = "dt_FechaNac";
            this.dt_FechaNac.Size = new System.Drawing.Size(289, 26);
            this.dt_FechaNac.TabIndex = 19;
            // 
            // txt_Licencia
            // 
            this.txt_Licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Licencia.Location = new System.Drawing.Point(117, 385);
            this.txt_Licencia.MaxLength = 13;
            this.txt_Licencia.Name = "txt_Licencia";
            this.txt_Licencia.Size = new System.Drawing.Size(100, 26);
            this.txt_Licencia.TabIndex = 18;
            // 
            // txt_Domicilio
            // 
            this.txt_Domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Domicilio.Location = new System.Drawing.Point(122, 261);
            this.txt_Domicilio.MaxLength = 30;
            this.txt_Domicilio.Multiline = true;
            this.txt_Domicilio.Name = "txt_Domicilio";
            this.txt_Domicilio.Size = new System.Drawing.Size(376, 65);
            this.txt_Domicilio.TabIndex = 17;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Correo.Location = new System.Drawing.Point(190, 224);
            this.txt_Correo.MaxLength = 30;
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(219, 26);
            this.txt_Correo.TabIndex = 16;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Telefono.Location = new System.Drawing.Point(121, 185);
            this.txt_Telefono.MaxLength = 10;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 26);
            this.txt_Telefono.TabIndex = 15;
            // 
            // txt_AMaterno
            // 
            this.txt_AMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AMaterno.Location = new System.Drawing.Point(178, 101);
            this.txt_AMaterno.MaxLength = 30;
            this.txt_AMaterno.Name = "txt_AMaterno";
            this.txt_AMaterno.Size = new System.Drawing.Size(173, 26);
            this.txt_AMaterno.TabIndex = 12;
            // 
            // txt_APaterno
            // 
            this.txt_APaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_APaterno.Location = new System.Drawing.Point(175, 60);
            this.txt_APaterno.MaxLength = 30;
            this.txt_APaterno.Name = "txt_APaterno";
            this.txt_APaterno.Size = new System.Drawing.Size(173, 26);
            this.txt_APaterno.TabIndex = 11;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Nombre.Location = new System.Drawing.Point(115, 22);
            this.txt_Nombre.MaxLength = 30;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(200, 26);
            this.txt_Nombre.TabIndex = 10;
            // 
            // lbl_Licencia
            // 
            this.lbl_Licencia.AutoSize = true;
            this.lbl_Licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Licencia.ForeColor = System.Drawing.Color.White;
            this.lbl_Licencia.Location = new System.Drawing.Point(40, 388);
            this.lbl_Licencia.Name = "lbl_Licencia";
            this.lbl_Licencia.Size = new System.Drawing.Size(71, 20);
            this.lbl_Licencia.TabIndex = 9;
            this.lbl_Licencia.Text = "Licencia:";
            // 
            // lbl_FechaNac
            // 
            this.lbl_FechaNac.AutoSize = true;
            this.lbl_FechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaNac.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaNac.Location = new System.Drawing.Point(40, 350);
            this.lbl_FechaNac.Name = "lbl_FechaNac";
            this.lbl_FechaNac.Size = new System.Drawing.Size(163, 20);
            this.lbl_FechaNac.TabIndex = 8;
            this.lbl_FechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lbl_Domicilio
            // 
            this.lbl_Domicilio.AutoSize = true;
            this.lbl_Domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Domicilio.ForeColor = System.Drawing.Color.White;
            this.lbl_Domicilio.Location = new System.Drawing.Point(40, 264);
            this.lbl_Domicilio.Name = "lbl_Domicilio";
            this.lbl_Domicilio.Size = new System.Drawing.Size(76, 20);
            this.lbl_Domicilio.TabIndex = 7;
            this.lbl_Domicilio.Text = "Domicilio:";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.Color.White;
            this.lbl_correo.Location = new System.Drawing.Point(40, 227);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(144, 20);
            this.lbl_correo.TabIndex = 6;
            this.lbl_correo.Text = "Correo Electronico:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_Telefono.Location = new System.Drawing.Point(40, 188);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(75, 20);
            this.lbl_Telefono.TabIndex = 5;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.ForeColor = System.Drawing.Color.White;
            this.lbl_Sexo.Location = new System.Drawing.Point(40, 145);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(49, 20);
            this.lbl_Sexo.TabIndex = 3;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // lbl_AMaterno
            // 
            this.lbl_AMaterno.AutoSize = true;
            this.lbl_AMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AMaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_AMaterno.Location = new System.Drawing.Point(40, 104);
            this.lbl_AMaterno.Name = "lbl_AMaterno";
            this.lbl_AMaterno.Size = new System.Drawing.Size(132, 20);
            this.lbl_AMaterno.TabIndex = 2;
            this.lbl_AMaterno.Text = "Apellido Materno:";
            // 
            // lbl_APaterno
            // 
            this.lbl_APaterno.AutoSize = true;
            this.lbl_APaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_APaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_APaterno.Location = new System.Drawing.Point(40, 63);
            this.lbl_APaterno.Name = "lbl_APaterno";
            this.lbl_APaterno.Size = new System.Drawing.Size(129, 20);
            this.lbl_APaterno.TabIndex = 1;
            this.lbl_APaterno.Text = "Apellido Paterno:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(40, 25);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(69, 20);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // pb_Usuario
            // 
            this.pb_Usuario.Image = global::SistemaFletesAcarreoB.Properties.Resources.usuariodefault;
            this.pb_Usuario.Location = new System.Drawing.Point(12, 29);
            this.pb_Usuario.Name = "pb_Usuario";
            this.pb_Usuario.Size = new System.Drawing.Size(208, 202);
            this.pb_Usuario.TabIndex = 9;
            this.pb_Usuario.TabStop = false;
            // 
            // dgv_Chofer
            // 
            this.dgv_Chofer.AllowUserToAddRows = false;
            this.dgv_Chofer.AutoGenerateColumns = false;
            this.dgv_Chofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chofer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChoferDataGridViewTextBoxColumn,
            this.lICENCIACDataGridViewTextBoxColumn,
            this.nChoferDataGridViewTextBoxColumn,
            this.apellidoPCDataGridViewTextBoxColumn,
            this.apellidoMCDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.fNacDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.disponibleDataGridViewTextBoxColumn});
            this.dgv_Chofer.DataSource = this.cHOFERBindingSource;
            this.dgv_Chofer.Location = new System.Drawing.Point(9, 411);
            this.dgv_Chofer.Name = "dgv_Chofer";
            this.dgv_Chofer.Size = new System.Drawing.Size(240, 150);
            this.dgv_Chofer.TabIndex = 10;
            this.dgv_Chofer.Visible = false;
            // 
            // idChoferDataGridViewTextBoxColumn
            // 
            this.idChoferDataGridViewTextBoxColumn.DataPropertyName = "Id_Chofer";
            this.idChoferDataGridViewTextBoxColumn.HeaderText = "Id_Chofer";
            this.idChoferDataGridViewTextBoxColumn.Name = "idChoferDataGridViewTextBoxColumn";
            this.idChoferDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lICENCIACDataGridViewTextBoxColumn
            // 
            this.lICENCIACDataGridViewTextBoxColumn.DataPropertyName = "lICENCIA_C";
            this.lICENCIACDataGridViewTextBoxColumn.HeaderText = "lICENCIA_C";
            this.lICENCIACDataGridViewTextBoxColumn.Name = "lICENCIACDataGridViewTextBoxColumn";
            // 
            // nChoferDataGridViewTextBoxColumn
            // 
            this.nChoferDataGridViewTextBoxColumn.DataPropertyName = "N_Chofer";
            this.nChoferDataGridViewTextBoxColumn.HeaderText = "N_Chofer";
            this.nChoferDataGridViewTextBoxColumn.Name = "nChoferDataGridViewTextBoxColumn";
            // 
            // apellidoPCDataGridViewTextBoxColumn
            // 
            this.apellidoPCDataGridViewTextBoxColumn.DataPropertyName = "ApellidoP_C";
            this.apellidoPCDataGridViewTextBoxColumn.HeaderText = "ApellidoP_C";
            this.apellidoPCDataGridViewTextBoxColumn.Name = "apellidoPCDataGridViewTextBoxColumn";
            // 
            // apellidoMCDataGridViewTextBoxColumn
            // 
            this.apellidoMCDataGridViewTextBoxColumn.DataPropertyName = "ApellidoM_C";
            this.apellidoMCDataGridViewTextBoxColumn.HeaderText = "ApellidoM_C";
            this.apellidoMCDataGridViewTextBoxColumn.Name = "apellidoMCDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // fNacDataGridViewTextBoxColumn
            // 
            this.fNacDataGridViewTextBoxColumn.DataPropertyName = "F_Nac";
            this.fNacDataGridViewTextBoxColumn.HeaderText = "F_Nac";
            this.fNacDataGridViewTextBoxColumn.Name = "fNacDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // disponibleDataGridViewTextBoxColumn
            // 
            this.disponibleDataGridViewTextBoxColumn.DataPropertyName = "Disponible";
            this.disponibleDataGridViewTextBoxColumn.HeaderText = "Disponible";
            this.disponibleDataGridViewTextBoxColumn.Name = "disponibleDataGridViewTextBoxColumn";
            // 
            // cHOFERBindingSource
            // 
            this.cHOFERBindingSource.DataMember = "CHOFER";
            this.cHOFERBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet16;
            // 
            // sISTEMAFLETESACARREOSDataSet16
            // 
            this.sISTEMAFLETESACARREOSDataSet16.DataSetName = "SISTEMAFLETESACARREOSDataSet16";
            this.sISTEMAFLETESACARREOSDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHOFERTableAdapter
            // 
            this.cHOFERTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 506);
            this.Controls.Add(this.dgv_Chofer);
            this.Controls.Add(this.pb_Usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Añadir);
            this.Name = "AgregarChofer";
            this.Text = "AgregarChofer";
            this.Load += new System.EventHandler(this.AgregarChofer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOFERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_FechaNac;
        private System.Windows.Forms.TextBox txt_Licencia;
        private System.Windows.Forms.TextBox txt_Domicilio;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_AMaterno;
        private System.Windows.Forms.TextBox txt_APaterno;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Licencia;
        private System.Windows.Forms.Label lbl_FechaNac;
        private System.Windows.Forms.Label lbl_Domicilio;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_AMaterno;
        private System.Windows.Forms.Label lbl_APaterno;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.PictureBox pb_Usuario;
        private System.Windows.Forms.DataGridView dgv_Chofer;
        private SISTEMAFLETESACARREOSDataSet16 sISTEMAFLETESACARREOSDataSet16;
        private System.Windows.Forms.BindingSource cHOFERBindingSource;
        private SISTEMAFLETESACARREOSDataSet16TableAdapters.CHOFERTableAdapter cHOFERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICENCIACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nChoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox txt_Sexo;
    }
}