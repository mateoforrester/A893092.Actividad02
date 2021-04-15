using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A893092.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {

            //A

           List<Producto> Productos = new List<Producto>();

            string Id;
           
            string Nombre;
            string Sino;        
            string Acumulador = "";
            int SalidaId = 0;
            int SalidaStock = 0;
            bool Flag = false;

            do
            {
                string Stock;


                do
                {
                    Console.Write("Ingrese el numero de identificacion del producto: ");
                    Id = Console.ReadLine();
                    Flag = ValidarPositivo(Id, ref SalidaId, "numero de identificacion");

                } while (Flag == false);
              
                Console.Write("Ingrese el nombre del producto: ");
                Nombre = Console.ReadLine();

                do
                {
                    Console.Write("Ingrese el stock inicial del producto: ");
                    Stock = Console.ReadLine();
                    Flag = ValidarPositivo(Stock, ref SalidaStock, "stocl inicial");
                } while (Flag == false);


                Producto P = new Producto(
                    SalidaId,
                    Nombre,
                    SalidaStock);

                Productos.Add(P);


                Console.WriteLine("¿Desea continuar ingresando productos? (S/N)");
                Sino = Console.ReadLine();

            } while (Sino == "S" );





            foreach (Producto P in Productos)
            {
                Acumulador += P.ToString() + System.Environment.NewLine;

            }
            Console.WriteLine("El catalogo de productos es: " + System.Environment.NewLine + "Id - Producto - Stock " + System.Environment.NewLine + Acumulador);


            bool ValidarPositivo(string numero, ref int Salida, string Campo)
            {             

                if (!int.TryParse(numero, out Salida))
                {
                    Console.WriteLine($"El {Campo} debe ser numerico.");
                }
                else if (Salida <= 0)
                {
                    Console.WriteLine($"El {Campo} debe ser mayor a cero.");
                }
                else
                {
                    Flag = true;
                }
                return Flag;
            }


            //B

            string proceso;
            int Salida2 = 0;
            Producto P1;
            int num;
            

           
            do
            {
                Console.Write("¿Que desea ingresar? (Pedir/Entregar) ");
                proceso = Console.ReadLine();

                Console.Write($"¿Que producto quiere {proceso}?: ");
                Id = Console.ReadLine();
                Flag = ValidarPositivo(Id, ref Salida2, "numero de identificacion");

                P1 = BuscarProducto(Salida2);

                if (P1 == null)
                {
                    Console.WriteLine("No existe dicho producto");
                }
                else
                {
                    Console.WriteLine("El producto es : " + P1.Nombre);
                }

                Console.Write($"Ingrese la cantidad de {P1.Nombre} que desea {proceso}: ");
                num = Convert.ToInt32(Console.ReadLine());

               

                if(proceso == "Pedir")
                {
                    P1.Stock= P1.Stock - num;
                }
                if (proceso == "Entregar")
                {
                    P1.Stock = P1.Stock + num;
                }

            } while (P1 == null || P1.Stock<0);

           


            Producto BuscarProducto(int id)
            {
                return Productos.Find(p => p.Id == id);
            }



            //C

            Console.WriteLine("Reporte de Stock: ");
            foreach (Producto Producto in Productos)
            {
                Console.WriteLine($"ID: {Producto.Id} - Producto: {Producto.Nombre} - Stock: {Producto.Stock} ");
            }


























            Console.ReadKey();


         







        }
    }
}
