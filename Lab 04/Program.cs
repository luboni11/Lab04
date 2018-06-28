using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {

            //El menu es un ciclo que lee de la consola una tecla, y ejecuta un codigo basado en el numero seleccionado. 
            //Reemplazar el texto con la llamada a la funcion correspondiente. 
            int opcion;
            do
            {

                opcion = DisplayMenu();
                switch (opcion)
                {
                    case 1:
                        Automovil mio = new Automovil();
                        mio.Lista();
                        break;
                    case 2:
                        Automovil year = new Automovil();
                        year.Filtrar();
                        break;
                    case 3:
                       
                        break;
                    case 4:
                        Automovil add = new Automovil();
                        add.Agregar();
                        break;
                    default:
                        break;

                }
            } while (opcion != 5);

        }

        private static int DisplayMenu()
        {
            Console.Write(@"
                            SELECCIONE UNA OPCION DE LA LISTA
                              ----------------------------------
                              1. Listar los vehículos
                              2. Filtrar los vehículos por año
                              3. Obtener los detalles de un vehículo por ID
                              4. Agregar un vehículo
                              5. Salir
                              ----------------------------------
                                  ");

            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }

    }
}
