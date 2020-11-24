namespace SistemaFletesAcarreoB
{
    partial class PKilometro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GuardarNPK = new System.Windows.Forms.Button();
            this.btn_VolverPKPP = new System.Windows.Forms.Button();
            this.txt_NuevoPrecio = new System.Windows.Forms.TextBox();
            this.lbl_Nprecio = new System.Windows.Forms.Label();
            this.lbl_PrecioK = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_GuardarNPK);
            this.panel1.Controls.Add(this.btn_VolverPKPP);
            this.panel1.Controls.Add(this.txt_NuevoPrecio);
            this.panel1.Controls.Add(this.lbl_Nprecio);
            this.panel1.Controls.Add(this.lbl_PrecioK);
            this.panel1.Location = new System.Drawing.Point(119, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 458);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "-------";
            // 
            // btn_GuardarNPK
            // 
            this.btn_GuardarNPK.BackColor = System.Drawing.Color.DarkRed;
            this.btn_GuardarNPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_GuardarNPK.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarNPK.Location = new System.Drawing.Point(577, 370);
            this.btn_GuardarNPK.Name = "btn_GuardarNPK";
            this.btn_GuardarNPK.Size = new System.Drawing.Size(83, 38);
            this.btn_GuardarNPK.TabIndex = 4;
            this.btn_GuardarNPK.Text = "Guardar";
            this.btn_GuardarNPK.UseVisualStyleBackColor = false;
            this.btn_GuardarNPK.Click += new System.EventHandler(this.btn_GuardarNPK_Click);
            // 
            // btn_VolverPKPP
            // 
            this.btn_VolverPKPP.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverPKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_VolverPKPP.ForeColor = System.Drawing.Color.White;
            this.btn_VolverPKPP.Location = new System.Drawing.Point(62, 370);
            this.btn_VolverPKPP.Name = "btn_VolverPKPP";
            this.btn_VolverPKPP.Size = new System.Drawing.Size(83, 38);
            this.btn_VolverPKPP.TabIndex = 3;
            this.btn_VolverPKPP.Text = "Volver";
            this.btn_VolverPKPP.UseVisualStyleBackColor = false;
            this.btn_VolverPKPP.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // txt_NuevoPrecio
            // 
            this.txt_NuevoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NuevoPrecio.Location = new System.Drawing.Point(298, 243);
            this.txt_NuevoPrecio.Name = "txt_NuevoPrecio";
            this.txt_NuevoPrecio.Size = new System.Drawing.Size(133, 26);
            this.txt_NuevoPrecio.TabIndex = 2;
            // 
            // lbl_Nprecio
            // 
            this.lbl_Nprecio.AutoSize = true;
            this.lbl_Nprecio.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nprecio.Location = new System.Drawing.Point(284, 191);
            this.lbl_Nprecio.Name = "lbl_Nprecio";
            this.lbl_Nprecio.Size = new System.Drawing.Size(160, 28);
            this.lbl_Nprecio.TabIndex = 1;
            this.lbl_Nprecio.Text = "Nuevo Precio:";
            // 
            // lbl_PrecioK
            // 
            this.lbl_PrecioK.AutoSize = true;
            this.lbl_PrecioK.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioK.Location = new System.Drawing.Point(220, 96);
            this.lbl_PrecioK.Name = "lbl_PrecioK";
            this.lbl_PrecioK.Size = new System.Drawing.Size(196, 28);
            this.lbl_PrecioK.TabIndex = 0;
            this.lbl_PrecioK.Text = "Precio Kilometro:";
            this.lbl_PrecioK.Click += new System.EventHandler(this.label1_Click);
            // 
            // PKilometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(947, 530);
            this.Controls.Add(this.panel1);
            this.Name = "PKilometro";
            this.Text = "PKilometro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_PrecioK;
        private System.Windows.Forms.Button btn_GuardarNPK;
        private System.Windows.Forms.Button btn_VolverPKPP;
        private System.Windows.Forms.TextBox txt_NuevoPrecio;
        private System.Windows.Forms.Label lbl_Nprecio;
        private System.Windows.Forms.Label label1;
    }
}