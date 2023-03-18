using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        private string titulo;
        private short año;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(string t,short a)
        {
            this.titulo=t; this.año=a;
        }
        public Pelicula()
        {

        }

        //Métodos
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");

        }

        public void setTitulo(string t)
        {
            t=titulo;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public void setAño(short a)
        {
            a=año;
        }
        public short getAño()
        {
            return año;
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
            Pelicula p1=new Pelicula();
            Pelicula p2=new Pelicula();
            p1.setTitulo("Interestelar");
            p1.setAño(2014);
            Console.WriteLine("{0}({1})", p1.getTitulo(), p1.getAño());
            p2.setTitulo("Top Gun");
            p2.setAño(2022);
            Console.WriteLine("{0}({1})", p2.getTitulo(), p2.getAño());
            //Console.WriteLine("Hello");
        }
    }
}
