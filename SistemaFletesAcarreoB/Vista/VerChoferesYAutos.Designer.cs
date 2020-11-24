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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_VerAutos = new System.Windows.Forms.Button();
            this.btn_VerChofer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Volver);
            this.panel1.Controls.Add(this.btn_VerAutos);
            this.panel1.Controls.Add(this.btn_VerChofer);
            this.panel1.Location = new System.Drawing.Point(136, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.Location = new System.Drawing.Point(31, 371);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(93, 35);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_volverppvca_Click);
            // 
            // btn_VerAutos
            // 
            this.btn_VerAutos.Image = global::SistemaFletesAcarreoB.Properties.Resources.p8;
            this.btn_VerAutos.Location = new System.Drawing.Point(370, 46);
            this.btn_VerAutos.Name = "btn_VerAutos";
            this.btn_VerAutos.Size = new System.Drawing.Size(281, 292);
            this.btn_VerAutos.TabIndex = 1;
            this.btn_VerAutos.UseVisualStyleBackColor = true;
            this.btn_VerAutos.Click += new System.EventHandler(this.btn_VerAutos_Click);
            // 
            // btn_VerChofer
            // 
            this.btn_VerChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_VerChofer.Image = global::SistemaFletesAcarreoB.Properties.Resources.P7;
            this.btn_VerChofer.Location = new System.Drawing.Point(55, 46);
            this.btn_VerChofer.Name = "btn_VerChofer";
            this.btn_VerChofer.Size = new System.Drawing.Size(281, 292);
            this.btn_VerChofer.TabIndex = 0;
            this.btn_VerChofer.UseVisualStyleBackColor = false;
            this.btn_VerChofer.Click += new System.EventHandler(this.btn_VerChofer_Click);
            // 
            // VerChoferesYAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(968, 545);
            this.Controls.Add(this.panel1);
            this.Name = "VerChoferesYAutos";
            this.Text = "VerChoferesYAutos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_VerAutos;
        private System.Windows.Forms.Button btn_VerChofer;
        private System.Windows.Forms.Button btn_Volver;
    }
}