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
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;
using System.IO;
using System.Diagnostics;
using PdfSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net;

namespace SistemaFletesAcarreoB.Vista
{
    public partial class VisorFactura : Form
    {
        public VisorFactura()
        {
            InitializeComponent();
        }

        private void VisorFactura_Load(object sender, EventArgs e)
        {
            this.Hide();
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.FACTURA);

            string Busqueda = dgv_Factura.Rows[dgv_Factura.Rows.Count - 1].Cells[2].Value.ToString();
            var buscarFactura = ModeloFactura.buscarFacturaPorCriterio(Busqueda);
            dgv_Factura.DataSource = buscarFactura;

            string NFact = dgv_Factura.Rows[dgv_Factura.Rows.Count - 1].Cells[1].Value.ToString();
            CrearDocumento(NFact);

            string pdfPath = Path.Combine(Application.StartupPath, "" + NFact + ".pdf");

            Process.Start("C:/SistemaAcarreos/Facturas/" + NFact + ".pdf");

            this.Close();
        }

        public void CrearDocumento(string Num_Factura)
        {
            int filas = dgv_Factura.Rows.Count - 1;
            string Fecha = dgv_Factura.Rows[filas].Cells[2].Value.ToString(); string Hora = dgv_Factura.Rows[filas].Cells[3].Value.ToString();
            string Subtotal = dgv_Factura.Rows[filas].Cells[8].Value.ToString(); string IVA = dgv_Factura.Rows[filas].Cells[9].Value.ToString(); ;
            string Total = dgv_Factura.Rows[filas].Cells[10].Value.ToString(); string Licencia = dgv_Factura.Rows[filas].Cells[12].Value.ToString();
            string PKilometro = dgv_Factura.Rows[filas].Cells[14].Value.ToString();
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("C:/SistemaAcarreos/Facturas/" + Num_Factura + ".pdf", FileMode.Create));

            doc.Open();
            //Agregar imagen header

            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile("https://i.ibb.co/qkm19Jp/PPP1.png", "C:/SistemaAcarreos/PPP1.png");

            iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance("C:/SistemaAcarreos/PPP1.png");
            //image1.ScalePercent(50f);
            image1.ScaleAbsoluteWidth(550);
            image1.ScaleAbsoluteHeight(155);
            doc.Add(image1);

            doc.Add(new Paragraph("______________________________________________________________________________"));

            // Agregamos un parrafo vacio como separacion.
            doc.Add(new Paragraph(" "));

            //Primer parrafo
            doc.Add(new Paragraph("Fecha de Facturación: "+Fecha+"                                                                           N°. Factura: "+Num_Factura));

            doc.Add(new Paragraph("Hora de Facturación: "+Hora+"                                                                           Precio Kilometro: "+PKilometro));

            // Agregamos un parrafo vacio como separacion.
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("______________________________________________________________________________"));

            // Agregamos un parrafo vacio como separacion.
            doc.Add(new Paragraph(" "));
            // Empezamos a crear la tabla, definimos una tabla de 6 columnas
            PdfPTable table = new PdfPTable(6);
            // Esta es la primera fila
            table.AddCell("Nombre Material");
            table.AddCell("Precio del Material");
            table.AddCell("Total M3");
            table.AddCell("Total de Viajes");
            table.AddCell("Total de Km Recorridos");
            table.AddCell("Placas del Auto");

            string Compara = dgv_Factura.Rows[dgv_Factura.Rows.Count - 1].Cells[1].Value.ToString();

            int Filas = Convert.ToInt32(dgv_Factura.Rows.Count.ToString())-1;
            for (int i = 0; i <= Filas; i++)
            {
                if (Compara == dgv_Factura.Rows[i].Cells[1].Value.ToString())
                {
                    // Fila
                    table.AddCell(dgv_Factura.Rows[i].Cells[4].Value.ToString());
                    table.AddCell(dgv_Factura.Rows[i].Cells[11].Value.ToString());
                    table.AddCell(dgv_Factura.Rows[i].Cells[5].Value.ToString());
                    table.AddCell(dgv_Factura.Rows[i].Cells[6].Value.ToString());
                    table.AddCell(dgv_Factura.Rows[i].Cells[7].Value.ToString());
                    table.AddCell(dgv_Factura.Rows[i].Cells[13].Value.ToString());
                }
                
            }
            
            // Agregamos la tabla al documento
            doc.Add(table);

            //Subtotales
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("______________________________________________________________________________"));
            doc.Add(new Paragraph("                                                                                                                     Subtotal: "+Subtotal));
            doc.Add(new Paragraph("                                                                                                                     IVA: "+IVA));
            doc.Add(new Paragraph("Licencia del Chofer: "+Licencia+"                                                           Total: "+Total));

            //Pie de pagina
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("______________________________________________________________________________"));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Registro Patronal:                                 RFC: FAB-170322-8D2                       CONTACTO:"));
            doc.Add(new Paragraph("Igancio Salazar 451 Santa Isabel                                                          Isidro Castelo Villaescusa"));
            doc.Add(new Paragraph("Hermosillo Sonora                                                                        Teléfono celular (662) 328 0161"));
            doc.Add(new Paragraph("C. P. 83130 MPIO, E64 Sec. Not. 08                                                   rosaurabg05@hotmail.com"));
            doc.Add(new Paragraph("7102 Transporte de Carga                                                                          tim2817@outlook.es"));

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("______________________________________________________________________________"));
            doc.Add(new Paragraph(" "));

            doc.Close();
        }
    }
}
