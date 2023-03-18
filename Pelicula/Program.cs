using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo;
        public short año;
        public string pais;
        public string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(string t,short a)
        {
            this.titulo=t; this.año=a;
        }
        //Métodos
     
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            //Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {

            Pelicula p1=new Pelicula("Interestelar",2014);
            Pelicula p2=new Pelicula("Top Gun",2022);
            p1.Imprime();
            p1.Imprime();
            //Console.WriteLine("Hello");
        }
    }
}
