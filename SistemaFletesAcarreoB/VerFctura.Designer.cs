namespace SistemaFletesAcarreoB
{
    partial class VerFctura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fechafactura = new System.Windows.Forms.Label();
            this.dtp_FechaFactura = new System.Windows.Forms.DateTimePicker();
            this.btn_BuscarFac = new System.Windows.Forms.Button();
            this.btn_VolverPPVF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.btn_VolverPPVF);
            this.panel1.Controls.Add(this.btn_BuscarFac);
            this.panel1.Controls.Add(this.dtp_FechaFactura);
            this.panel1.Controls.Add(this.lbl_fechafactura);
            this.panel1.Location = new System.Drawing.Point(50, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 374);
            this.panel1.TabIndex = 0;
            // 
            // lbl_fechafactura
            // 
            this.lbl_fechafactura.AutoSize = true;
            this.lbl_fechafactura.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechafactura.Location = new System.Drawing.Point(193, 98);
            this.lbl_fechafactura.Name = "lbl_fechafactura";
            this.lbl_fechafactura.Size = new System.Drawing.Size(311, 28);
            this.lbl_fechafactura.TabIndex = 0;
            this.lbl_fechafactura.Text = "Introduzca fecha de factura:";
            // 
            // dtp_FechaFactura
            // 
            this.dtp_FechaFactura.Location = new System.Drawing.Point(254, 162);
            this.dtp_FechaFactura.Name = "dtp_FechaFactura";
            this.dtp_FechaFactura.Size = new System.Drawing.Size(195, 20);
            this.dtp_FechaFactura.TabIndex = 1;
            // 
            // btn_BuscarFac
            // 
            this.btn_BuscarFac.BackColor = System.Drawing.Color.DarkRed;
            this.btn_BuscarFac.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarFac.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarFac.Location = new System.Drawing.Point(548, 322);
            this.btn_BuscarFac.Name = "btn_BuscarFac";
            this.btn_BuscarFac.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarFac.TabIndex = 2;
            this.btn_BuscarFac.Text = "Buscar";
            this.btn_BuscarFac.UseVisualStyleBackColor = false;
            this.btn_BuscarFac.Click += new System.EventHandler(this.btn_BuscarFac_Click);
            // 
            // btn_VolverPPVF
            // 
            this.btn_VolverPPVF.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverPPVF.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverPPVF.ForeColor = System.Drawing.Color.White;
            this.btn_VolverPPVF.Location = new System.Drawing.Point(77, 322);
            this.btn_VolverPPVF.Name = "btn_VolverPPVF";
            this.btn_VolverPPVF.Size = new System.Drawing.Size(75, 23);
            this.btn_VolverPPVF.TabIndex = 3;
            this.btn_VolverPPVF.Text = "Volver";
            this.btn_VolverPPVF.UseVisualStyleBackColor = false;
            this.btn_VolverPPVF.Click += new System.EventHandler(this.btn_VolverPPVF_Click);
            // 
            // VerFctura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VerFctura";
            this.Text = "VerFctura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_VolverPPVF;
        private System.Windows.Forms.Button btn_BuscarFac;
        private System.Windows.Forms.DateTimePicker dtp_FechaFactura;
        private System.Windows.Forms.Label lbl_fechafactura;
    }
}