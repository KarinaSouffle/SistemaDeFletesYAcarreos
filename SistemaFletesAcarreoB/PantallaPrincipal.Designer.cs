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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChoferesAutos = new System.Windows.Forms.Button();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_Materiales = new System.Windows.Forms.Button();
            this.btn_VerFacturas = new System.Windows.Forms.Button();
            this.btn_PrecioKilometro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(19, 28);
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
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.panel1);
            this.Name = "Pantalla_Principal";
            this.Text = "Pantalla_Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PrecioKilometro;
        private System.Windows.Forms.Button btn_VerFacturas;
        private System.Windows.Forms.Button btn_Materiales;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Button btn_ChoferesAutos;
        private System.Windows.Forms.Panel panel1;
    }
}