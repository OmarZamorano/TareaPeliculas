using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private short año;
        private string país;
        private string director;
        private string titulo;
        private List<Actor> actores = new List<Actor>();

        public Pelicula()
        {
        }
        public Pelicula(string t, short a)
        {
            this.titulo = t;
            this.año = a;
        }
        //Métodos
        public void SetTitulo(string t)
        {
            this.titulo = t;
        
        }
        public void SetAño(short a)
        {
            this.año = a;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }
        public short GetAño()
        {
            return this.año;
        }
        public void AgregaActor(Actor a)
        {
            actores.Add(a);
        }
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }
        public void ImprimeActores()
        {
            foreach (Actor actor in actores)
            {
                actor.Imprime();
            }
        }
    }

    public class Actor
    {
        //Propiedades
        private string nombre;
        private short año;
        public Actor(string n, short a)
        {
            this.nombre = n;
            this.año = a;
        }
        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{nombre} ({año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Top Gun");
            p1.SetAño(2022);
            p1.AgregaActor(new Actor("Tom Cruise", 1962));
            p1.AgregaActor(new Actor("Miles Teller", 1987));
            p1.Imprime();
            p1.ImprimeActores();
            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Interestelar");
            p2.SetAño(2014);
            p2.AgregaActor(new Actor("Matthew McConaughey", 1969));
            p2.AgregaActor(new Actor("Jessica Chastain", 1977));
            p2.Imprime();
            p2.ImprimeActores();
        }
    }
}
