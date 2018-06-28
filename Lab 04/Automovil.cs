using System;
using System.Collections.Generic;

namespace Lab_04
{
    public class Automovil
    {
        List<Automovil> auto = new List<Automovil>();
        

        public int year { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public String Precio { get; set; }
        public String Tipo { get; set; }
        public String ID { get; set; }

        public override string ToString()
        {
            return "Auto: " + year + "  Modelo: " + Modelo + "  Precio :" + Precio + "  Tipo de Transmision: " + Tipo +" ID: "+ID;
        }
        public void Lista()
        {

            auto.Add(new Automovil() { year = 2018, Modelo = "Tercel", Marca = "Toyota", Precio = "2000000", Tipo = "manual", ID = "1" });
            auto.Add(new Automovil() { year = 2016, Modelo = "Civic", Marca = "Honda", Precio = "4000000", Tipo = "Automatico", ID = "2" });
            auto.Add(new Automovil() { year = 2017, Modelo = "Picanto", Marca = "KIA", Precio = "9000000", Tipo = "manual", ID = "3" });
            auto.Add(new Automovil() { year = 2014, Modelo = "Aventador", Marca = "Lamborguini", Precio = "36000000", Tipo = "manual", ID = "4" });
            auto.Add(new Automovil() { year = 2017, Modelo = "Loca", Marca = "BMW", Precio = "36000000", Tipo = "automatico", ID = "5" });

            foreach (Automovil a in auto)
            {
                Console.WriteLine(a);
            }
        }
        public void Filtrar()
        {
            Console.WriteLine("Escriba el año que desea buscar");
            String useryear = Console.ReadLine();
            Int32 x = Int32.Parse(useryear);


            for (int i = 0; i < auto.Count; i++)
            {
                if (auto[i].year == x)
                {
                    Console.WriteLine(auto[i]);
                }
                else
                {
                    Console.WriteLine("No existe");
                }
            }
            Console.ReadKey();
        }

        public void ObtenerporID()
        {

        }
        public void Agregar()
        {

            Console.WriteLine("Escriba el año del carro");
            String newyear = Console.ReadLine();
            Int32 a = Int32.Parse(newyear);


            Console.WriteLine("Escriba el modelo del carro");
            String newmodelo = Console.ReadLine();

            Console.WriteLine("Escriba la marca del carro");
            String newmarca = Console.ReadLine();


            Console.WriteLine("Escriba el precio del carro");
            String newprecio = Console.ReadLine();


            Console.WriteLine("Escriba el tipo de trasmision");
            String newtipo = Console.ReadLine();

            Console.WriteLine("Escriba el id del carro");
            String newid = Console.ReadLine();

            auto.Add(new Automovil() { year = a, Modelo = newmodelo, Marca = newmarca, Precio = newprecio, Tipo = newtipo, ID = newid });

            Console.WriteLine(auto);
            Console.ReadKey();


        }
    }


}