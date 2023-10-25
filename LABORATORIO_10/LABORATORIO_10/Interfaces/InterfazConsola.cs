using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_10.Interfaces
{
    public class InterfazConsola
    {
        public static int menuPrincipal()
        {
            Console.Clear();
            Console.Write("" +
                            "================================\n" +
                            "Productos de mPhone\n" +
                            "================================\n" +
                            "1: Ventas de mPhone 3000\n" +
                            "2: Ventas de mPad 3500\n" +
                            "3: Ventas de MAPBrook 3800\n" +
                            "4: Ventas de mWatch 8000\n" +
                            "5: Salir\n" +
                            "================================\n" +
                            "Ingrese una opción:");
            return getOpcion();
        }
        public static int Ventas_mPhone3000()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar Venta de mPhone 3000\n" +
                        "================================\n" +
                        "1: Registrar Venta\n" +
                        "2: Registrar Devolución\n" +
                        "3: Menu Principal\n" +
                        "================================\n" +
                        "Ingrese una opción: ");
            int opcion = getOpcion();
           
            switch (opcion)
            {
                case 1:
                    ConfirmacionVenta_mPhone3000();
                    break;
                case 2:
                    ConfirmarDevolucion_mPhone3000();
                    break;
                case 3:
                    return 0;
                    
            }
            return opcion;
        }
        public static int Ventas_mPad3500()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar Venta de mPad 3500\n" +
                        "================================\n" +
                        "1: Registrar Venta\n" +
                        "2: Registrar Devolución\n" +
                        "3: Menu Principal\n" +
                        "================================\n" +
                        "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion == 3) return 0;
            return opcion;
        }
        public static int Ventas_MAPBrook3800()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar Venta de MAPBrook 3800\n" +
                        "================================\n" +
                        "1: Registrar Venta\n" +
                        "2: Registrar Devolución\n" +
                        "3: Menu Principal\n" +
                        "================================\n" +
                        "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion == 3) return 0;
            return opcion;
        }
        public static int Ventas_mWatch8000()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar Venta de mWatch 8000\n" +
                        "================================\n" +
                        "1: Registrar Venta\n" +
                        "2: Registrar Devolución\n" +
                        "3: Menu Principal\n" +
                        "================================\n" +
                        "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion == 3) return 0;
            return opcion;
        }
        public static int ConfirmacionVenta_mPhone3000()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar venta de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "mPhone 3000 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {
            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();

        }
        public static int ConfirmacionVenta_mPad3500()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar venta de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "mPad 3500 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {

            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();

        }
        public static int ConfirmacionVenta_MAPBrook3800()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar venta de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "MAPBrook 3800 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {

            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();

        }
        public static int ConfirmacionVenta_mWatch8000()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar venta de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "mWatch 8000 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {

            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();

        }
        public static int ConfirmarDevolucion_mPhone3000()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar devolución de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "mPhone 3000 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {

            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();
        }
        public static int ConfirmarDevolucion_mPad3500()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar devolución de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "mPad 3500 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {

            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();
        }
        public static int ConfirmarDevolucion_MAPBrook3800()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar devolución de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "MAPBrook 3800 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {

            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();
        }
        public static int ConfirmarDevolucion_mWatch8000()
        {
            Console.Clear();
            Console.Write("================================\n" +
                        "Registrar devolución de:\n" +
                        "================================\n" +
                        "Se va a registrar la venta de un\n" +
                        "mWatch 8000 ¿Desea Continuar\n" +
                        "1: Sí\n" +
                        "2: No\n" +
                        "================================\n" +
                        "Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {

            }
            else if (opcion == 2)
            {
                menuPrincipal();
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            return getOpcion();
        }
        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }

        public static void MostrarEstadisticas(int totalMPhones, int totalMPads, int totalMAPBrooks, int totalMWatches)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Reporte Final");
            Console.WriteLine("================================");
            Console.WriteLine("Productos Vendidos | Cantidad");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"mPhones      | {totalMPhones}");
            Console.WriteLine($"mPads        | {totalMPads}");
            Console.WriteLine($"MAPBrooks    | {totalMAPBrooks}");
            Console.WriteLine($"mWatches     | {totalMWatches}");
            Console.WriteLine("--------------------------------");
            int totalProductosVendidos = totalMPhones + totalMPads + totalMAPBrooks + totalMWatches;
            Console.WriteLine($"Total        | {totalProductosVendidos}");
            Console.WriteLine("================================");
            Console.WriteLine("¡Hasta Luego!");
            Console.WriteLine("Diseñado Por: CRISTIAN RAYO MONTOYA");
        }
    }
}
