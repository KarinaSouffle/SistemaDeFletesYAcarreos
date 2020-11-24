namespace SistemaFletesAcarreoB
{
    partial class VentanaDeVenta
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
            this.dgv_Venta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Caja = new System.Windows.Forms.Label();
            this.lbl_FechaHora = new System.Windows.Forms.Label();
            this.dtp_FechaHora = new System.Windows.Forms.DateTimePicker();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_SetIVA = new System.Windows.Forms.Label();
            this.lbl_SetTotal = new System.Windows.Forms.Label();
            this.lbl_Encargado = new System.Windows.Forms.Label();
            this.lbl_Chofer = new System.Windows.Forms.Label();
            this.lbl_Vehiculo = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_SetEncargado = new System.Windows.Forms.Label();
            this.lbl_SetChofer = new System.Windows.Forms.Label();
            this.lbl_SetVehiculo = new System.Windows.Forms.Label();
            this.lbl_SetNumero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Venta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Venta
            // 
            this.dgv_Venta.AllowUserToDeleteRows = false;
            this.dgv_Venta.AllowUserToOrderColumns = true;
            this.dgv_Venta.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Venta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Venta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Venta.Location = new System.Drawing.Point(13, 70);
            this.dgv_Venta.Name = "dgv_Venta";
            this.dgv_Venta.Size = new System.Drawing.Size(817, 303);
            this.dgv_Venta.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Importe";
            this.Column5.Name = "Column5";
            // 
            // lbl_Caja
            // 
            this.lbl_Caja.AutoSize = true;
            this.lbl_Caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Caja.Location = new System.Drawing.Point(42, 27);
            this.lbl_Caja.Name = "lbl_Caja";
            this.lbl_Caja.Size = new System.Drawing.Size(63, 20);
            this.lbl_Caja.TabIndex = 1;
            this.lbl_Caja.Text = "Caja 01";
            // 
            // lbl_FechaHora
            // 
            this.lbl_FechaHora.AutoSize = true;
            this.lbl_FechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_FechaHora.Location = new System.Drawing.Point(222, 26);
            this.lbl_FechaHora.Name = "lbl_FechaHora";
            this.lbl_FechaHora.Size = new System.Drawing.Size(104, 20);
            this.lbl_FechaHora.TabIndex = 2;
            this.lbl_FechaHora.Text = "Fecha y Hora";
            // 
            // dtp_FechaHora
            // 
            this.dtp_FechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_FechaHora.Location = new System.Drawing.Point(332, 21);
            this.dtp_FechaHora.Name = "dtp_FechaHora";
            this.dtp_FechaHora.Size = new System.Drawing.Size(286, 26);
            this.dtp_FechaHora.TabIndex = 3;
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Numero.Location = new System.Drawing.Point(639, 27);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(25, 20);
            this.lbl_Numero.TabIndex = 4;
            this.lbl_Numero.Text = "N°";
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_IVA.Location = new System.Drawing.Point(737, 406);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(48, 20);
            this.lbl_IVA.TabIndex = 5;
            this.lbl_IVA.Text = "I.V.A.";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Total.Location = new System.Drawing.Point(737, 434);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(48, 20);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Total:";
            // 
            // lbl_SetIVA
            // 
            this.lbl_SetIVA.AutoSize = true;
            this.lbl_SetIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetIVA.Location = new System.Drawing.Point(791, 406);
            this.lbl_SetIVA.Name = "lbl_SetIVA";
            this.lbl_SetIVA.Size = new System.Drawing.Size(39, 20);
            this.lbl_SetIVA.TabIndex = 7;
            this.lbl_SetIVA.Text = "------";
            // 
            // lbl_SetTotal
            // 
            this.lbl_SetTotal.AutoSize = true;
            this.lbl_SetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetTotal.Location = new System.Drawing.Point(791, 434);
            this.lbl_SetTotal.Name = "lbl_SetTotal";
            this.lbl_SetTotal.Size = new System.Drawing.Size(39, 20);
            this.lbl_SetTotal.TabIndex = 8;
            this.lbl_SetTotal.Text = "------";
            // 
            // lbl_Encargado
            // 
            this.lbl_Encargado.AutoSize = true;
            this.lbl_Encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Encargado.Location = new System.Drawing.Point(562, 406);
            this.lbl_Encargado.Name = "lbl_Encargado";
            this.lbl_Encargado.Size = new System.Drawing.Size(95, 20);
            this.lbl_Encargado.TabIndex = 9;
            this.lbl_Encargado.Text = "Encargado: ";
            // 
            // lbl_Chofer
            // 
            this.lbl_Chofer.AutoSize = true;
            this.lbl_Chofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Chofer.Location = new System.Drawing.Point(562, 434);
            this.lbl_Chofer.Name = "lbl_Chofer";
            this.lbl_Chofer.Size = new System.Drawing.Size(65, 20);
            this.lbl_Chofer.TabIndex = 10;
            this.lbl_Chofer.Text = "Chofer: ";
            // 
            // lbl_Vehiculo
            // 
            this.lbl_Vehiculo.AutoSize = true;
            this.lbl_Vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Vehiculo.Location = new System.Drawing.Point(562, 462);
            this.lbl_Vehiculo.Name = "lbl_Vehiculo";
            this.lbl_Vehiculo.Size = new System.Drawing.Size(74, 20);
            this.lbl_Vehiculo.TabIndex = 11;
            this.lbl_Vehiculo.Text = "Vehiculo:";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(131, 427);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 37);
            this.btn_Aceptar.TabIndex = 12;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(257, 427);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 37);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_SetEncargado
            // 
            this.lbl_SetEncargado.AutoSize = true;
            this.lbl_SetEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetEncargado.Location = new System.Drawing.Point(663, 406);
            this.lbl_SetEncargado.Name = "lbl_SetEncargado";
            this.lbl_SetEncargado.Size = new System.Drawing.Size(39, 20);
            this.lbl_SetEncargado.TabIndex = 15;
            this.lbl_SetEncargado.Text = "------";
            // 
            // lbl_SetChofer
            // 
            this.lbl_SetChofer.AutoSize = true;
            this.lbl_SetChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetChofer.Location = new System.Drawing.Point(633, 434);
            this.lbl_SetChofer.Name = "lbl_SetChofer";
            this.lbl_SetChofer.Size = new System.Drawing.Size(39, 20);
            this.lbl_SetChofer.TabIndex = 16;
            this.lbl_SetChofer.Text = "------";
            // 
            // lbl_SetVehiculo
            // 
            this.lbl_SetVehiculo.AutoSize = true;
            this.lbl_SetVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetVehiculo.Location = new System.Drawing.Point(642, 462);
            this.lbl_SetVehiculo.Name = "lbl_SetVehiculo";
            this.lbl_SetVehiculo.Size = new System.Drawing.Size(39, 20);
            this.lbl_SetVehiculo.TabIndex = 17;
            this.lbl_SetVehiculo.Text = "------";
            // 
            // lbl_SetNumero
            // 
            this.lbl_SetNumero.AutoSize = true;
            this.lbl_SetNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetNumero.Location = new System.Drawing.Point(670, 27);
            this.lbl_SetNumero.Name = "lbl_SetNumero";
            this.lbl_SetNumero.Size = new System.Drawing.Size(29, 20);
            this.lbl_SetNumero.TabIndex = 18;
            this.lbl_SetNumero.Text = "----";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(855, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 63);
            this.button1.TabIndex = 19;
            this.button1.Text = "Asignar Chofer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(855, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 63);
            this.button2.TabIndex = 20;
            this.button2.Text = "Asignar Vehiculo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(855, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 63);
            this.button3.TabIndex = 21;
            this.button3.Text = "Añadir Material";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Venta);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lbl_SetChofer);
            this.panel1.Controls.Add(this.lbl_Total);
            this.panel1.Controls.Add(this.lbl_Caja);
            this.panel1.Controls.Add(this.lbl_IVA);
            this.panel1.Controls.Add(this.lbl_Chofer);
            this.panel1.Controls.Add(this.lbl_SetEncargado);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbl_SetVehiculo);
            this.panel1.Controls.Add(this.lbl_Vehiculo);
            this.panel1.Controls.Add(this.lbl_SetIVA);
            this.panel1.Controls.Add(this.lbl_FechaHora);
            this.panel1.Controls.Add(this.lbl_Numero);
            this.panel1.Controls.Add(this.lbl_Encargado);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_SetNumero);
            this.panel1.Controls.Add(this.btn_Aceptar);
            this.panel1.Controls.Add(this.lbl_SetTotal);
            this.panel1.Controls.Add(this.dtp_FechaHora);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 505);
            this.panel1.TabIndex = 22;
            // 
            // VentanaDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 572);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaDeVenta";
            this.Text = "Ventana De Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Venta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lbl_Caja;
        private System.Windows.Forms.Label lbl_FechaHora;
        private System.Windows.Forms.DateTimePicker dtp_FechaHora;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_SetIVA;
        private System.Windows.Forms.Label lbl_SetTotal;
        private System.Windows.Forms.Label lbl_Encargado;
        private System.Windows.Forms.Label lbl_Chofer;
        private System.Windows.Forms.Label lbl_Vehiculo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_SetEncargado;
        private System.Windows.Forms.Label lbl_SetChofer;
        private System.Windows.Forms.Label lbl_SetVehiculo;
        private System.Windows.Forms.Label lbl_SetNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}