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
            this.btn_VolverLC = new System.Windows.Forms.Button();
            this.btn_AñadirC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VolverLC
            // 
            this.btn_VolverLC.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverLC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverLC.ForeColor = System.Drawing.Color.White;
            this.btn_VolverLC.Location = new System.Drawing.Point(283, 203);
            this.btn_VolverLC.Name = "btn_VolverLC";
            this.btn_VolverLC.Size = new System.Drawing.Size(75, 23);
            this.btn_VolverLC.TabIndex = 8;
            this.btn_VolverLC.Text = "Volver";
            this.btn_VolverLC.UseVisualStyleBackColor = false;
            this.btn_VolverLC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AñadirC
            // 
            this.btn_AñadirC.BackColor = System.Drawing.Color.DarkRed;
            this.btn_AñadirC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AñadirC.ForeColor = System.Drawing.Color.White;
            this.btn_AñadirC.Location = new System.Drawing.Point(202, 203);
            this.btn_AñadirC.Name = "btn_AñadirC";
            this.btn_AñadirC.Size = new System.Drawing.Size(75, 23);
            this.btn_AñadirC.TabIndex = 7;
            this.btn_AñadirC.Text = "Añadir";
            this.btn_AñadirC.UseVisualStyleBackColor = false;
            this.btn_AñadirC.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 185);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Chofer";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Licencia";
            this.Column3.Name = "Column3";
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(121, 203);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 29;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaDeChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 253);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_VolverLC);
            this.Controls.Add(this.btn_AñadirC);
            this.Name = "ListaDeChoferes";
            this.Text = "ListaDeChoferes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VolverLC;
        private System.Windows.Forms.Button btn_AñadirC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_Editar;
    }
}