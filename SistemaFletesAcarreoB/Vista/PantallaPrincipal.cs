using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFletesAcarreoB.Vista;
using SistemaFletesAcarreoB.Modelo;
using SistemaFletesAcarreoB.Controlador;
using System.Data.SqlClient;
using System.IO;

namespace SistemaFletesAcarreoB
{
    public partial class Pantalla_Principal : Form
    {
        Login PLogin;
        Form fh;
        int control;
        int segundos = 0;
        int minutos = 10;

        public Pantalla_Principal()
        {
            InitializeComponent();

        }

        private void AbrirFormularios(object formhijo)
        {
            if (this.pnl_Contenedor.Controls.Count > 0)
            {
                this.pnl_Contenedor.Controls.RemoveAt(0);
            }
            fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(fh);
            this.pnl_Contenedor.Tag = fh;
            fh.Show();

        }
        //Chain of responsability
        public interface IHandler
        {
            IHandler SetNext(IHandler handler);

            object Handle(object request);
        }
        abstract class AbstractHandler : IHandler
        {
            private IHandler _nextHandler;

            public IHandler SetNext(IHandler handler)
            {
                this._nextHandler = handler;
                return handler;
            }

            public virtual object Handle(object request)
            {
                if (this._nextHandler != null)
                {
                    return this._nextHandler.Handle(request);
                }
                else
                {
                    return null;
                }
            }
        }

        private void btn_Materiales_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new VisorMateriales());
            control = 1;
        }

        private void btn_PrecioKilometro_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new PKilometro());
            control = 2;
        }

        private void btn_VerFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new VerFctura());
            control = 3;
        }

        private void btn_ChoferesAutos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new VisorChoferes());
            control = 4;
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new VentanaDeVenta());
            control = 5;
        }
        private void btn_Autos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new VisorAutos());
            control = 6;
        }
        private void btn_Registro_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new RegistroUsuarioAdmi());
            control = 7;
        }
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            PLogin = new Login();
            PLogin.Show();
            this.Hide();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            
            lbl_SetBienvenida.Text = Login.nombre;
            string usuarioadmin = Login.nivel; 
            if (usuarioadmin == "1")
            {
                btn_PrecioKilometro.Visible = true;
                btn_Registro.Visible = true;
                btn_Respaldo.Visible = true;
                btn_Restaurar.Visible = true;
            }

        }

        private void Pantalla_Principal_Activated(object sender, EventArgs e)
        {
            minutos = 10;
            segundos = 0;
            lbl_Time.Text = "10:00";
            TiempoCierre.Stop();

        }

        private void Pantalla_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBoxTemporal.Show("Hola, esto se cierra en 10 segunditos", "OwO", 10, true);
            MessageBoxAutoClose.m_show("Hola, esto se cierra en 10 segunditos", "OwO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, 10, true);
        }

        private void TiempoCierre_Tick(object sender, EventArgs e)
        {
            if (minutos >= 1)
            {
                lbl_Time.Text = minutos + ":" + segundos;
            }
            if (segundos == 0)
            {
                minutos = minutos - 1;
                segundos = 59;
            }
            else
            {
                segundos = segundos - 1;
            }
            if (segundos <= 9)
            {
                lbl_Time.Text = minutos + ":0" + segundos;
            }
            else
            {
                lbl_Time.Text = minutos + ":" + segundos;
            }
            if (minutos == 0 && segundos == 0)
            {
                TiempoCierre.Stop();
                this.Dispose();
                Login xd = new Login();
                xd.Visible = true;

            }
        }

        private void Pantalla_Principal_Deactivate(object sender, EventArgs e)
        {
            TiempoCierre.Start();
        }

        private void btn_Respaldo_Click(object sender, EventArgs e)
        {
            SqlConnection connect;
            string con = "Data Source=LAPTOP-8U0TMPPT/SQLEXPRESS;Initial Catalog=SISTEMAFLETESACARREOS;Integrated Security=True";
            connect = new SqlConnection(con);
            SISTEMAFLETESACARREOSEntities cone = new SISTEMAFLETESACARREOSEntities();

            string dbname = cone.Database.Connection.Database;
            string sqlCommand = @"BACKUP DATABASE [SISTEMAFLETESACARREOS] TO  DISK = N'C:\SistemaAcarreos\Respaldo\SISTEMAFLETESACARREOS.bak' WITH NOFORMAT, NOINIT,  NAME = N'SISTEMAFLETESACARREOS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            cone.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, "Amin9999999999999"));
            

            MessageBox.Show("El Respaldo de la base de datos fue realizado satisfactoriamente", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\SistemaAcarreos\Respaldo\SISTEMAFLETESACARREOS.bak"))
                {
                    if (MessageBox.Show("¿Está seguro de restaurar?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection connect;
                        string con = "Data Source=LAPTOP-8U0TMPPT/SQLEXPRESS;Initial Catalog=SISTEMAFLETESACARREOS;Integrated Security=True";
                        connect = new SqlConnection(con);
                        SISTEMAFLETESACARREOSEntities cone = new SISTEMAFLETESACARREOSEntities();

                        string dbname = cone.Database.Connection.Database;
                        string sqlCommand = @"USE [master]";
                        cone.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, "Amin9999999999999"));

                        //string sqlCommand1 = @"RESTORE DATABASE[SISTEMAFLETESACARREOS] FROM DISK = N'C:\SistemaAcarreos\Respaldo\SISTEMAFLETESACARREOS.bak' WITH FILE = 1, NOUNLOAD, STATS = 5";
                        //cone.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand1, dbname, "Amin9999999999999"));
                        
                        MessageBox.Show("Se ha restaurado la base de datos", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"No haz hecho ningun respaldo anteriormente (o no está en la ruta correcta)", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
