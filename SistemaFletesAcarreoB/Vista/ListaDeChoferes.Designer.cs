namespace SistemaFletesAcarreoB
{
    partial class ListaDeChoferes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_VolverLC = new System.Windows.Forms.Button();
            this.btn_AñadirC = new System.Windows.Forms.Button();
            this.dgv_Choferes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SetLicencia = new System.Windows.Forms.Label();
            this.lbl_SetDomicilio = new System.Windows.Forms.Label();
            this.lbl_SetCorreo = new System.Windows.Forms.Label();
            this.lbl_SetTelefono = new System.Windows.Forms.Label();
            this.lbl_SetEdad = new System.Windows.Forms.Label();
            this.lbl_SetSexo = new System.Windows.Forms.Label();
            this.lbl_SetAMaterno = new System.Windows.Forms.Label();
            this.lbl_SetAPaterno = new System.Windows.Forms.Label();
            this.lbl_SetNombre = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Licencia = new System.Windows.Forms.Label();
            this.lbl_FechaNac = new System.Windows.Forms.Label();
            this.lbl_Domicilio = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_AMaterno = new System.Windows.Forms.Label();
            this.lbl_APaterno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Choferes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_VolverLC
            // 
            this.btn_VolverLC.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_VolverLC.ForeColor = System.Drawing.Color.White;
            this.btn_VolverLC.Location = new System.Drawing.Point(297, 521);
            this.btn_VolverLC.Name = "btn_VolverLC";
            this.btn_VolverLC.Size = new System.Drawing.Size(75, 35);
            this.btn_VolverLC.TabIndex = 8;
            this.btn_VolverLC.Text = "Volver";
            this.btn_VolverLC.UseVisualStyleBackColor = false;
            this.btn_VolverLC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AñadirC
            // 
            this.btn_AñadirC.BackColor = System.Drawing.Color.DarkRed;
            this.btn_AñadirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AñadirC.ForeColor = System.Drawing.Color.White;
            this.btn_AñadirC.Location = new System.Drawing.Point(135, 521);
            this.btn_AñadirC.Name = "btn_AñadirC";
            this.btn_AñadirC.Size = new System.Drawing.Size(75, 35);
            this.btn_AñadirC.TabIndex = 7;
            this.btn_AñadirC.Text = "Añadir";
            this.btn_AñadirC.UseVisualStyleBackColor = false;
            this.btn_AñadirC.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // dgv_Choferes
            // 
            this.dgv_Choferes.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Choferes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Choferes.ColumnHeadersHeight = 29;
            this.dgv_Choferes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Apellido_Paterno,
            this.Apellido_Materno});
            this.dgv_Choferes.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_Choferes.Location = new System.Drawing.Point(54, 72);
            this.dgv_Choferes.Name = "dgv_Choferes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Choferes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Choferes.Size = new System.Drawing.Size(517, 420);
            this.dgv_Choferes.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.HeaderText = "Apellido Paterno";
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.HeaderText = "Apellido Materno";
            this.Apellido_Materno.Name = "Apellido_Materno";
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(54, 521);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 35);
            this.btn_Editar.TabIndex = 29;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre.Location = new System.Drawing.Point(54, 37);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(156, 20);
            this.lbl_Nombre.TabIndex = 30;
            this.lbl_Nombre.Text = "Listado de Choferes:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lbl_SetLicencia);
            this.panel1.Controls.Add(this.lbl_SetDomicilio);
            this.panel1.Controls.Add(this.lbl_SetCorreo);
            this.panel1.Controls.Add(this.lbl_SetTelefono);
            this.panel1.Controls.Add(this.lbl_SetEdad);
            this.panel1.Controls.Add(this.lbl_SetSexo);
            this.panel1.Controls.Add(this.lbl_SetAMaterno);
            this.panel1.Controls.Add(this.lbl_SetAPaterno);
            this.panel1.Controls.Add(this.lbl_SetNombre);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lbl_Licencia);
            this.panel1.Controls.Add(this.lbl_FechaNac);
            this.panel1.Controls.Add(this.lbl_Domicilio);
            this.panel1.Controls.Add(this.lbl_Correo);
            this.panel1.Controls.Add(this.lbl_Telefono);
            this.panel1.Controls.Add(this.lbl_Edad);
            this.panel1.Controls.Add(this.lbl_Sexo);
            this.panel1.Controls.Add(this.lbl_AMaterno);
            this.panel1.Controls.Add(this.lbl_APaterno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(654, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 420);
            this.panel1.TabIndex = 31;
            // 
            // lbl_SetLicencia
            // 
            this.lbl_SetLicencia.AutoSize = true;
            this.lbl_SetLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetLicencia.ForeColor = System.Drawing.Color.White;
            this.lbl_SetLicencia.Location = new System.Drawing.Point(105, 353);
            this.lbl_SetLicencia.Name = "lbl_SetLicencia";
            this.lbl_SetLicencia.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetLicencia.TabIndex = 28;
            this.lbl_SetLicencia.Text = "----------";
            // 
            // lbl_SetDomicilio
            // 
            this.lbl_SetDomicilio.AutoSize = true;
            this.lbl_SetDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetDomicilio.ForeColor = System.Drawing.Color.White;
            this.lbl_SetDomicilio.Location = new System.Drawing.Point(110, 260);
            this.lbl_SetDomicilio.Name = "lbl_SetDomicilio";
            this.lbl_SetDomicilio.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetDomicilio.TabIndex = 27;
            this.lbl_SetDomicilio.Text = "----------";
            // 
            // lbl_SetCorreo
            // 
            this.lbl_SetCorreo.AutoSize = true;
            this.lbl_SetCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetCorreo.ForeColor = System.Drawing.Color.White;
            this.lbl_SetCorreo.Location = new System.Drawing.Point(174, 228);
            this.lbl_SetCorreo.Name = "lbl_SetCorreo";
            this.lbl_SetCorreo.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetCorreo.TabIndex = 26;
            this.lbl_SetCorreo.Text = "----------";
            // 
            // lbl_SetTelefono
            // 
            this.lbl_SetTelefono.AutoSize = true;
            this.lbl_SetTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetTelefono.ForeColor = System.Drawing.Color.White;
            this.lbl_SetTelefono.Location = new System.Drawing.Point(109, 194);
            this.lbl_SetTelefono.Name = "lbl_SetTelefono";
            this.lbl_SetTelefono.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetTelefono.TabIndex = 25;
            this.lbl_SetTelefono.Text = "----------";
            // 
            // lbl_SetEdad
            // 
            this.lbl_SetEdad.AutoSize = true;
            this.lbl_SetEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetEdad.ForeColor = System.Drawing.Color.White;
            this.lbl_SetEdad.Location = new System.Drawing.Point(85, 161);
            this.lbl_SetEdad.Name = "lbl_SetEdad";
            this.lbl_SetEdad.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetEdad.TabIndex = 24;
            this.lbl_SetEdad.Text = "----------";
            // 
            // lbl_SetSexo
            // 
            this.lbl_SetSexo.AutoSize = true;
            this.lbl_SetSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetSexo.ForeColor = System.Drawing.Color.White;
            this.lbl_SetSexo.Location = new System.Drawing.Point(83, 129);
            this.lbl_SetSexo.Name = "lbl_SetSexo";
            this.lbl_SetSexo.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetSexo.TabIndex = 23;
            this.lbl_SetSexo.Text = "----------";
            // 
            // lbl_SetAMaterno
            // 
            this.lbl_SetAMaterno.AutoSize = true;
            this.lbl_SetAMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetAMaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_SetAMaterno.Location = new System.Drawing.Point(166, 93);
            this.lbl_SetAMaterno.Name = "lbl_SetAMaterno";
            this.lbl_SetAMaterno.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetAMaterno.TabIndex = 22;
            this.lbl_SetAMaterno.Text = "----------";
            // 
            // lbl_SetAPaterno
            // 
            this.lbl_SetAPaterno.AutoSize = true;
            this.lbl_SetAPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetAPaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_SetAPaterno.Location = new System.Drawing.Point(159, 57);
            this.lbl_SetAPaterno.Name = "lbl_SetAPaterno";
            this.lbl_SetAPaterno.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetAPaterno.TabIndex = 21;
            this.lbl_SetAPaterno.Text = "----------";
            // 
            // lbl_SetNombre
            // 
            this.lbl_SetNombre.AutoSize = true;
            this.lbl_SetNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetNombre.ForeColor = System.Drawing.Color.White;
            this.lbl_SetNombre.Location = new System.Drawing.Point(103, 24);
            this.lbl_SetNombre.Name = "lbl_SetNombre";
            this.lbl_SetNombre.Size = new System.Drawing.Size(59, 20);
            this.lbl_SetNombre.TabIndex = 20;
            this.lbl_SetNombre.Text = "----------";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // lbl_Licencia
            // 
            this.lbl_Licencia.AutoSize = true;
            this.lbl_Licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Licencia.ForeColor = System.Drawing.Color.White;
            this.lbl_Licencia.Location = new System.Drawing.Point(24, 353);
            this.lbl_Licencia.Name = "lbl_Licencia";
            this.lbl_Licencia.Size = new System.Drawing.Size(75, 20);
            this.lbl_Licencia.TabIndex = 9;
            this.lbl_Licencia.Text = "Licencia: ";
            // 
            // lbl_FechaNac
            // 
            this.lbl_FechaNac.AutoSize = true;
            this.lbl_FechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaNac.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaNac.Location = new System.Drawing.Point(24, 293);
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
            this.lbl_Domicilio.Location = new System.Drawing.Point(24, 260);
            this.lbl_Domicilio.Name = "lbl_Domicilio";
            this.lbl_Domicilio.Size = new System.Drawing.Size(80, 20);
            this.lbl_Domicilio.TabIndex = 7;
            this.lbl_Domicilio.Text = "Domicilio: ";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.ForeColor = System.Drawing.Color.White;
            this.lbl_Correo.Location = new System.Drawing.Point(24, 228);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(144, 20);
            this.lbl_Correo.TabIndex = 6;
            this.lbl_Correo.Text = "Correo Electronico:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_Telefono.Location = new System.Drawing.Point(24, 194);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(79, 20);
            this.lbl_Telefono.TabIndex = 5;
            this.lbl_Telefono.Text = "Telefono: ";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edad.ForeColor = System.Drawing.Color.White;
            this.lbl_Edad.Location = new System.Drawing.Point(24, 161);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(55, 20);
            this.lbl_Edad.TabIndex = 4;
            this.lbl_Edad.Text = "Edad: ";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.ForeColor = System.Drawing.Color.White;
            this.lbl_Sexo.Location = new System.Drawing.Point(24, 129);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(53, 20);
            this.lbl_Sexo.TabIndex = 3;
            this.lbl_Sexo.Text = "Sexo: ";
            // 
            // lbl_AMaterno
            // 
            this.lbl_AMaterno.AutoSize = true;
            this.lbl_AMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AMaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_AMaterno.Location = new System.Drawing.Point(24, 93);
            this.lbl_AMaterno.Name = "lbl_AMaterno";
            this.lbl_AMaterno.Size = new System.Drawing.Size(136, 20);
            this.lbl_AMaterno.TabIndex = 2;
            this.lbl_AMaterno.Text = "Apellido Materno: ";
            // 
            // lbl_APaterno
            // 
            this.lbl_APaterno.AutoSize = true;
            this.lbl_APaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_APaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_APaterno.Location = new System.Drawing.Point(24, 57);
            this.lbl_APaterno.Name = "lbl_APaterno";
            this.lbl_APaterno.Size = new System.Drawing.Size(129, 20);
            this.lbl_APaterno.TabIndex = 1;
            this.lbl_APaterno.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(216, 521);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 35);
            this.btn_Eliminar.TabIndex = 32;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // ListaDeChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 568);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.dgv_Choferes);
            this.Controls.Add(this.btn_VolverLC);
            this.Controls.Add(this.btn_AñadirC);
            this.Name = "ListaDeChoferes";
            this.Text = "ListaDeChoferes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Choferes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VolverLC;
        private System.Windows.Forms.Button btn_AñadirC;
        private System.Windows.Forms.DataGridView dgv_Choferes;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_SetLicencia;
        private System.Windows.Forms.Label lbl_SetDomicilio;
        private System.Windows.Forms.Label lbl_SetCorreo;
        private System.Windows.Forms.Label lbl_SetTelefono;
        private System.Windows.Forms.Label lbl_SetEdad;
        private System.Windows.Forms.Label lbl_SetSexo;
        private System.Windows.Forms.Label lbl_SetAMaterno;
        private System.Windows.Forms.Label lbl_SetAPaterno;
        private System.Windows.Forms.Label lbl_SetNombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Licencia;
        private System.Windows.Forms.Label lbl_FechaNac;
        private System.Windows.Forms.Label lbl_Domicilio;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_AMaterno;
        private System.Windows.Forms.Label lbl_APaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}