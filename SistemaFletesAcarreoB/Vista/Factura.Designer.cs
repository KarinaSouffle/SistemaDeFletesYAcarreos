namespace SistemaFletesAcarreoB
{
    partial class Factura
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
            this.dtv_Factura = new System.Windows.Forms.DataGridView();
            this.pb_Banner = new System.Windows.Forms.PictureBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_SetSubtotal = new System.Windows.Forms.Label();
            this.lbl_SetIVA = new System.Windows.Forms.Label();
            this.lbl_SetTotal = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Factura
            // 
            this.dtv_Factura.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_Factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtv_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtv_Factura.Location = new System.Drawing.Point(12, 145);
            this.dtv_Factura.Name = "dtv_Factura";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_Factura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtv_Factura.Size = new System.Drawing.Size(1096, 398);
            this.dtv_Factura.TabIndex = 8;
            // 
            // pb_Banner
            // 
            this.pb_Banner.Image = global::SistemaFletesAcarreoB.Properties.Resources.banner2;
            this.pb_Banner.Location = new System.Drawing.Point(140, 12);
            this.pb_Banner.Name = "pb_Banner";
            this.pb_Banner.Size = new System.Drawing.Size(841, 127);
            this.pb_Banner.TabIndex = 7;
            this.pb_Banner.TabStop = false;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(14, 580);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(81, 42);
            this.btn_Aceptar.TabIndex = 14;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_Imprimir.Location = new System.Drawing.Point(97, 580);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(81, 42);
            this.btn_Imprimir.TabIndex = 15;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(180, 580);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(81, 42);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Subtotal.Location = new System.Drawing.Point(580, 562);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(73, 20);
            this.lbl_Subtotal.TabIndex = 17;
            this.lbl_Subtotal.Text = "Subtotal:";
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_IVA.Location = new System.Drawing.Point(580, 583);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(48, 20);
            this.lbl_IVA.TabIndex = 18;
            this.lbl_IVA.Text = "I.V.A.";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Total.Location = new System.Drawing.Point(580, 605);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(48, 20);
            this.lbl_Total.TabIndex = 19;
            this.lbl_Total.Text = "Total:";
            // 
            // lbl_SetSubtotal
            // 
            this.lbl_SetSubtotal.AutoSize = true;
            this.lbl_SetSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetSubtotal.Location = new System.Drawing.Point(659, 562);
            this.lbl_SetSubtotal.Name = "lbl_SetSubtotal";
            this.lbl_SetSubtotal.Size = new System.Drawing.Size(34, 20);
            this.lbl_SetSubtotal.TabIndex = 20;
            this.lbl_SetSubtotal.Text = "-----";
            // 
            // lbl_SetIVA
            // 
            this.lbl_SetIVA.AutoSize = true;
            this.lbl_SetIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetIVA.Location = new System.Drawing.Point(634, 583);
            this.lbl_SetIVA.Name = "lbl_SetIVA";
            this.lbl_SetIVA.Size = new System.Drawing.Size(34, 20);
            this.lbl_SetIVA.TabIndex = 21;
            this.lbl_SetIVA.Text = "-----";
            // 
            // lbl_SetTotal
            // 
            this.lbl_SetTotal.AutoSize = true;
            this.lbl_SetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_SetTotal.Location = new System.Drawing.Point(634, 605);
            this.lbl_SetTotal.Name = "lbl_SetTotal";
            this.lbl_SetTotal.Size = new System.Drawing.Size(34, 20);
            this.lbl_SetTotal.TabIndex = 22;
            this.lbl_SetTotal.Text = "-----";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kilometraje";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Meterial";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total M3";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Viajes";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Boleta No.";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Precio p/metro p/viaje";
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 634);
            this.Controls.Add(this.lbl_SetTotal);
            this.Controls.Add(this.lbl_SetIVA);
            this.Controls.Add(this.lbl_SetSubtotal);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_IVA);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.dtv_Factura);
            this.Controls.Add(this.pb_Banner);
            this.Name = "Factura";
            this.Text = "Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Banner;
        private System.Windows.Forms.DataGridView dtv_Factura;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_SetSubtotal;
        private System.Windows.Forms.Label lbl_SetIVA;
        private System.Windows.Forms.Label lbl_SetTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}