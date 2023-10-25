using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCelulares
{
    internal class Program
    {
        static int VentasProducto(string producto)
        {
            int ventas = 0;
            Console.Clear();
            Console.WriteLine($"================================\nRegistrar venta de: {producto}\n================================");
            Console.WriteLine($"Se va a registrar la venta de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí\n2: No");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Write($"Ingrese unidades vendidas de {producto}: ");
                ventas = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se han registrado {ventas} ventas para {producto}.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            return ventas;
        }

        static int DevolucionesProducto(string producto)
        {
            int devoluciones = 0;
            Console.Clear();
            Console.WriteLine($"================================\nRegistrar devolución de: {producto}\n================================");
            Console.WriteLine($"Se va a registrar la devolución de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí\n2: No");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Write($"Ingrese unidades a devolver de {producto}: ");
                devoluciones = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se han registrado {devoluciones} devoluciones para {producto}.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            return devoluciones;
        }

        static void Main()
        {
            int ventas_mPhone3000 = 0;
            int devoluciones_mPhone3000 = 0;
            int ventas_mPad3500 = 0;
            int devoluciones_mPad3500 = 0;
            int ventas_MAPBrook3800 = 0;
            int devoluciones_MAPBrook3800 = 0;
            int ventas_mWatch8000 = 0;
            int devoluciones_mWatch8000 = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================\nProductos de mPhone\n================================");
                Console.WriteLine("1: Ventas de mPhone 3000\n2: Ventas de mPad 3500\n3: Ventas de MAPBrook 3800\n4: Ventas de mWatch 8000\n5: Salir");
                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("================================\nRegistrar Venta de mPhone 3000\n================================");
                        Console.WriteLine("1: Registrar Venta\n2: Registrar Devolución\n3: Menu Principal");
                        Console.Write("Ingrese una opción: ");
                        int opcionVenta1 = int.Parse(Console.ReadLine());
                        if (opcionVenta1 == 1)
                        {
                            ventas_mPhone3000 += VentasProducto("mPhone 3000");
                        }
                        else if (opcionVenta1 == 2)
                        {
                            devoluciones_mPhone3000 += DevolucionesProducto("mPhone 3000");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("================================\nRegistrar Venta de mPad 3500\n================================");
                        Console.WriteLine("1: Registrar Venta\n2: Registrar Devolución\n3: Menu Principal");
                        Console.Write("Ingrese una opción: ");
                        int opcionVenta2 = int.Parse(Console.ReadLine());
                        if (opcionVenta2 == 1)
                        {
                            ventas_mPad3500 += VentasProducto("mPad 3500");
                        }
                        else if (opcionVenta2 == 2)
                        {
                            devoluciones_mPad3500 += DevolucionesProducto("mPad 3500");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("================================\nRegistrar Venta de MAPBrook 3800\n================================");
                        Console.WriteLine("1: Registrar Venta\n2: Registrar Devolución\n3: Menu Principal");
                        Console.Write("Ingrese una opción: ");
                        int opcionVenta3 = int.Parse(Console.ReadLine());
                        if (opcionVenta3 == 1)
                        {
                            ventas_MAPBrook3800 += VentasProducto("MAPBrook 3800");
                        }
                        else if (opcionVenta3 == 2)
                        {
                            devoluciones_MAPBrook3800 += DevolucionesProducto("MAPBrook 3800");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("================================\nRegistrar Venta de mWatch 8000\n================================");
                        Console.WriteLine("1: Registrar Venta\n2: Registrar Devolución\n3: Menu Principal");
                        Console.Write("Ingrese una opción: ");
                        int opcionVenta4 = int.Parse(Console.ReadLine());
                        if (opcionVenta4 == 1)
                        {
                            ventas_mWatch8000 += VentasProducto("mWatch 8000");
                        }
                        else if (opcionVenta4 == 2)
                        {
                            devoluciones_mWatch8000 += DevolucionesProducto("mWatch 8000");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("================================\nCerrando programa...\n================================");
                        Console.WriteLine($"Totales ventas de mPhone 3000: {ventas_mPhone3000 - devoluciones_mPhone3000}");
                        Console.WriteLine($"Totales ventas de mPad 3500: {ventas_mPad3500 - devoluciones_mPad3500}");
                        Console.WriteLine($"Totales ventas de MAPBrook 3800: {ventas_MAPBrook3800 - devoluciones_MAPBrook3800}");
                        Console.WriteLine($"Totales ventas de mWatch 8000: {ventas_mWatch8000 - devoluciones_mWatch8000}");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
      
        }

    }
}