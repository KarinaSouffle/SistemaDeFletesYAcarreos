
namespace SistemaFletesAcarreoB.Vista
{
    partial class VisorAutos
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
            this.pnl_Contenedor2 = new System.Windows.Forms.Panel();
            this.btn_VolverPKPP = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet20 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20();
            this.uSUARIOSTableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20TableAdapters.USUARIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Contenedor2
            // 
            this.pnl_Contenedor2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Contenedor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Contenedor2.Location = new System.Drawing.Point(0, 0);
            this.pnl_Contenedor2.Name = "pnl_Contenedor2";
            this.pnl_Contenedor2.Size = new System.Drawing.Size(1101, 557);
            this.pnl_Contenedor2.TabIndex = 7;
            // 
            // btn_VolverPKPP
            // 
            this.btn_VolverPKPP.BackColor = System.Drawing.Color.DarkRed;
            this.btn_VolverPKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_VolverPKPP.ForeColor = System.Drawing.Color.White;
            this.btn_VolverPKPP.Location = new System.Drawing.Point(664, 313);
            this.btn_VolverPKPP.Name = "btn_VolverPKPP";
            this.btn_VolverPKPP.Size = new System.Drawing.Size(75, 35);
            this.btn_VolverPKPP.TabIndex = 32;
            this.btn_VolverPKPP.Text = "Añadir";
            this.btn_VolverPKPP.UseVisualStyleBackColor = false;
            this.btn_VolverPKPP.Visible = false;
            this.btn_VolverPKPP.Click += new System.EventHandler(this.btn_VolverPKPP_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(762, 313);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 40);
            this.btn_Regresar.TabIndex = 33;
            this.btn_Regresar.Text = "Volver";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Visible = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sISTEMAFLETESACARREOSDataSet20;
            // 
            // sISTEMAFLETESACARREOSDataSet20
            // 
            this.sISTEMAFLETESACARREOSDataSet20.DataSetName = "SISTEMAFLETESACARREOSDataSet20";
            this.sISTEMAFLETESACARREOSDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // VisorAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 557);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_VolverPKPP);
            this.Controls.Add(this.pnl_Contenedor2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisorAutos";
            this.Text = "VisorMateriales";
            this.Load += new System.EventHandler(this.VisorAutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Contenedor2;
        private System.Windows.Forms.Button btn_VolverPKPP;
        private System.Windows.Forms.Button btn_Regresar;
        private SISTEMAFLETESACARREOSDataSet20 sISTEMAFLETESACARREOSDataSet20;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private SISTEMAFLETESACARREOSDataSet20TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
    }
}