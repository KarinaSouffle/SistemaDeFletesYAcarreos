namespace SistemaFletesAcarreoB
{
    partial class VerChoferesYAutos
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
            this.btn_volverppvca = new System.Windows.Forms.Button();
            this.btn_VerAutos = new System.Windows.Forms.Button();
            this.btn_VerChofer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_volverppvca);
            this.panel1.Controls.Add(this.btn_VerAutos);
            this.panel1.Controls.Add(this.btn_VerChofer);
            this.panel1.Location = new System.Drawing.Point(53, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_volverppvca
            // 
            this.btn_volverppvca.BackColor = System.Drawing.Color.DarkRed;
            this.btn_volverppvca.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volverppvca.ForeColor = System.Drawing.Color.White;
            this.btn_volverppvca.Location = new System.Drawing.Point(31, 371);
            this.btn_volverppvca.Name = "btn_volverppvca";
            this.btn_volverppvca.Size = new System.Drawing.Size(93, 35);
            this.btn_volverppvca.TabIndex = 2;
            this.btn_volverppvca.Text = "Volver";
            this.btn_volverppvca.UseVisualStyleBackColor = false;
            this.btn_volverppvca.Click += new System.EventHandler(this.btn_volverppvca_Click);
            // 
            // btn_VerAutos
            // 
            this.btn_VerAutos.Image = global::SistemaFletesAcarreoB.Properties.Resources.p8;
            this.btn_VerAutos.Location = new System.Drawing.Point(374, 34);
            this.btn_VerAutos.Name = "btn_VerAutos";
            this.btn_VerAutos.Size = new System.Drawing.Size(281, 292);
            this.btn_VerAutos.TabIndex = 1;
            this.btn_VerAutos.UseVisualStyleBackColor = true;
            this.btn_VerAutos.Click += new System.EventHandler(this.btn_VerAutos_Click);
            // 
            // btn_VerChofer
            // 
            this.btn_VerChofer.Image = global::SistemaFletesAcarreoB.Properties.Resources.P7;
            this.btn_VerChofer.Location = new System.Drawing.Point(64, 34);
            this.btn_VerChofer.Name = "btn_VerChofer";
            this.btn_VerChofer.Size = new System.Drawing.Size(180, 275);
            this.btn_VerChofer.TabIndex = 0;
            this.btn_VerChofer.UseVisualStyleBackColor = true;
            this.btn_VerChofer.Click += new System.EventHandler(this.btn_VerChofer_Click);
            // 
            // VerChoferesYAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VerChoferesYAutos";
            this.Text = "VerChoferesYAutos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_VerAutos;
        private System.Windows.Forms.Button btn_VerChofer;
        private System.Windows.Forms.Button btn_volverppvca;
    }
}