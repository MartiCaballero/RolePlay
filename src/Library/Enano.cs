using System;
using System.Data;

namespace JuegoDeRoles
{
    public class Enano : IPersonaje
    {
        public string NombrePersonaje {get;}
        public int ValorAtaque {get; set;}
        public int ValorDefensa {get; set;}
        public bool LibroHechizos {get; set;}

        public Enano (string nombrepersonaje)
        {
            NombrePersonaje = nombrepersonaje;

            InicializarPersonaje();
            
            Console.WriteLine($"\n Se ha creado un enano llamado {NombrePersonaje}");
        }

        private void InicializarPersonaje()
        {
            ValorAtaque = 5;
            ValorDefensa = 10; 
        }

        public void Ataque (IPersonaje objetivo)
        {
            int daño = ValorAtaque;
            if (daño > 0)
            {
                Console.WriteLine($"\n{NombrePersonaje} ataca a {objetivo.NombrePersonaje} y le causa {daño} puntos de daño.");
                objetivo.ValorDefensa = objetivo.ValorDefensa - daño;

                if (objetivo.ValorDefensa <=0)
                {
                    Console.WriteLine($"\n {objetivo.NombrePersonaje} ha sido derrotado.");
                }
            }
        }

        public void Curar (IPersonaje personaje)
        {
            Console.WriteLine($"\n{NombrePersonaje} no puede lanzar hechizos ya que no es un mago.");
            //Incluimos un método vacío para cumplir con la interfaz ya que los enanos no pueden lanzar hechizos
        }
    }
}