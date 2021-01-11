using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Controlador;

namespace SistemaFletesAcarreoB.GOF
{
    
    class Strategy
    {
    }

    public interface ICalculateInterface
    {
        //define method  
        int Calculate(int value1, int value2);
    }

    class SubTotal : ICalculateInterface
    {
        public int Calculate(int totalventas, int sumadorkilmetro)
        {
            
            for (int i = 0; i < totalventas - 1; i++)
            {
                int KMRec = Int32.Parse(dgv_Venta.Rows[i].Cells[5].Value.ToString());
                int PrecKM = Int32.Parse(dgv_Venta.Rows[0].Cells[6].Value.ToString());
                sumadorkilmetro = sumadorkilmetro + (KMRec * PrecKM);
            }

            return sumadorkilmetro;
        }
    }

    class Total : ICalculateInterface
    {
        public int Calculate(int totalventas, int sumadorkilometro)
        {          
            for (int i = 0; i < totalventas - 1; i++)
            {
                int KMRec = Int32.Parse(dgv_Venta.Rows[i].Cells[5].Value.ToString());
                int PrecKM = Int32.Parse(dgv_Venta.Rows[0].Cells[6].Value.ToString());
                sumadorkilometro = sumadorkilometro + (KMRec * PrecKM);
            }
            double SumaIva = sumadorkilometro * .16;
            sumadorkilometro = sumadorkilometro + Convert.ToInt32(SumaIva);
            return sumadorkilometro;
        }
    }

    class IVA : ICalculateInterface
    {
        public int Calculate(int totalventas, int sumadorkilometro)
        {        
            for (int i = 0; i < totalventas - 1; i++)
            {
                int KMRec = Int32.Parse(dgv_Venta.Rows[i].Cells[5].Value.ToString());
                int PrecKM = Int32.Parse(dgv_Venta.Rows[0].Cells[6].Value.ToString());
                sumadorkilometro = sumadorkilometro + (KMRec * PrecKM);
            }

            double SumaIva = sumadorkilometro * .16;
            return Convert.ToInt32(SumaIva);
        }
    }

    class CalcularVenta
    {
        private ICalculateInterface calculateInterface;

        //Constructor: assigns strategy to interface  
        public CalcularVenta(ICalculateInterface strategy)
        {
            calculateInterface = strategy;
        }

        //Executes the strategy  
        public int Calculate(int value1, int value2)
        {
            return calculateInterface.Calculate(value1, value2);
        }
    }


}
