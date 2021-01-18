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

namespace SistemaFletesAcarreoB
{
    public partial class Pantalla_Principal : Form
    {
        Login PLogin;
        Form fh;
        int control;

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
            AbrirFormularios(new ListaDeMateriales());
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
            AbrirFormularios(new ListaDeChoferes());
            control = 4;
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new VentanaDeVenta());
            control = 5;
        }
        private void btn_Autos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new ListaDeAutos());
            control = 6;
        }
        private void btn_Registro_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new RegistroUsuarioAdmi());
            control = 7;
        }
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            int xd = Int32.Parse(dgv_Usuarios.Rows.Count.ToString());
            for (int i = 0; i < xd - 1; i++)
            {
                if (dgv_Usuarios.Rows[i].Cells[1].Value.ToString() == lbl_SetBienvenida.Text)
                {
                    var nuevoUsuario = new USUARIOS();
                    nuevoUsuario.Nombre = dgv_Usuarios.Rows[i].Cells[1].Value.ToString();
                    nuevoUsuario.Contra = dgv_Usuarios.Rows[i].Cells[2].Value.ToString();
                    nuevoUsuario.Nivel = dgv_Usuarios.Rows[i].Cells[3].Value.ToString();
                    nuevoUsuario.EnUso = "2";
                    ControladorUsuario.crearUsuario(nuevoUsuario);
                    int eliminar = Int32.Parse(dgv_Usuarios.Rows[i].Cells[0].Value.ToString());
                    ControladorUsuario.EliminarUsuario(eliminar);
                }
            }
            PLogin = new Login();
            PLogin.Show();
            this.Hide();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet18.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet18.USUARIOS);

            int xd = (Convert.ToInt32(this.dgv_Usuarios.Rows.Count.ToString()));
            int us = 0;
            if (xd == 1)
            {
                for (int i = 0; i < xd - 1; i++)
                {
                    int usuarioset = Int32.Parse(dgv_Usuarios.Rows[i].Cells[4].Value.ToString());
                    us = usuarioset;
                    if (us == 1)
                    {
                        lbl_SetBienvenida.Text = dgv_Usuarios.Rows[i].Cells[1].Value.ToString();
                        int usuarioadmin = Int32.Parse(dgv_Usuarios.Rows[i].Cells[3].Value.ToString());
                        if (usuarioadmin == 1)
                        {
                            btn_PrecioKilometro.Visible = true;
                            btn_Registro.Visible = true;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < xd - 1; i++)
                {
                    int usuarioset = Int32.Parse(dgv_Usuarios.Rows[i].Cells[4].Value.ToString());
                    us = usuarioset;
                    if (us == 1)
                    {
                        lbl_SetBienvenida.Text = dgv_Usuarios.Rows[i].Cells[1].Value.ToString();
                        int usuarioadmin = Int32.Parse(dgv_Usuarios.Rows[i].Cells[3].Value.ToString());
                        if (usuarioadmin == 1)
                        {
                            btn_PrecioKilometro.Visible = true;
                            btn_Registro.Visible = true;
                        }
                    }
                }
            }

        }

        private void Pantalla_Principal_Activated(object sender, EventArgs e)
        {
            switch (control)
            {
                case 1:
                    AbrirFormularios(new ListaDeMateriales());
                    break;
                case 2:
                    AbrirFormularios(new PKilometro());
                    break;
                case 3:
                    AbrirFormularios(new VerFctura());
                    break;
                case 4:
                    AbrirFormularios(new ListaDeChoferes());
                    break;
                //case 5:
                //    AbrirFormularios(new VentanaDeVenta());
                //    break;
                case 6:
                    AbrirFormularios(new ListaDeAutos());
                    break;
                case 7:
                    AbrirFormularios(new RegistroUsuarioAdmi());
                    break;
                default:
                    break;
            }
        }

        private void Pantalla_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            int xd = Int32.Parse(dgv_Usuarios.Rows.Count.ToString());
            for (int i = 0; i < xd - 1; i++)
            {
                if (dgv_Usuarios.Rows[i].Cells[1].Value.ToString() == lbl_SetBienvenida.Text)
                {
                    var nuevoUsuario = new USUARIOS();
                    nuevoUsuario.Nombre = dgv_Usuarios.Rows[i].Cells[1].Value.ToString();
                    nuevoUsuario.Contra = dgv_Usuarios.Rows[i].Cells[2].Value.ToString();
                    nuevoUsuario.Nivel = dgv_Usuarios.Rows[i].Cells[3].Value.ToString();
                    nuevoUsuario.EnUso = "2";
                    ControladorUsuario.crearUsuario(nuevoUsuario);
                    int eliminar = Int32.Parse(dgv_Usuarios.Rows[i].Cells[0].Value.ToString());
                    ControladorUsuario.EliminarUsuario(eliminar);
                }
            }
        }
    }
}
