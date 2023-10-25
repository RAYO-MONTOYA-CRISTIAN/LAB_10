using LABORATORIO_10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalMPhones = 0;
            int totalMPads = 0;
            int totalMAPBrooks = 0;
            int totalMWatches = 0;

            int opcion;
            do
            {
                opcion = InterfazConsola.menuPrincipal();
                
                switch (opcion)
                {
                    case 0:
                        InterfazConsola.menuPrincipal();
                        break;
                    case 1:
                        totalMPhones++;
                        InterfazConsola.Ventas_mPhone3000();
                        break;
                    case 2:
                        totalMPads++;
                        InterfazConsola.Ventas_mPad3500();
                        break;
                    case 3:
                        totalMAPBrooks++;
                        InterfazConsola.Ventas_MAPBrook3800();
                        break;
                    case 4:
                        totalMWatches++;
                        InterfazConsola.Ventas_mWatch8000();
                        break;
                }
            } while (opcion != 5);
            InterfazConsola.MostrarEstadisticas(totalMPhones, totalMPads, totalMAPBrooks, totalMWatches);
        }
        
    }
}
