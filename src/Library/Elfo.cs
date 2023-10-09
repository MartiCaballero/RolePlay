using System;

namespace JuegoDeRoles
{
    public class Elfo : IPersonaje
    {
        public string NombrePersonaje {get;}
        public int ValorAtaque {get; set;}
        public int ValorDefensa {get; set;}
        public bool LibroHechizos {get; set;}

        public  Elfo (string nombrepersonaje)
        {
            NombrePersonaje = nombrepersonaje;
            InicializarPersonaje(); 
            Console.WriteLine($"\nSe ha creado un Elfo llamado {NombrePersonaje}");
        }

        private void InicializarPersonaje()
        {
            ValorAtaque = 5;
            ValorDefensa = 10;
        }

        public void Ataque (IPersonaje objetivo)
        {
            if (objetivo is Elfo)
            {
                Curar(objetivo);
                //Si el objetivo es otro elfo amigo, lo cura.
            }
            else
            {
                int daño = ValorAtaque;
                if (daño >0)
                {
                    Console.WriteLine($"\n{NombrePersonaje} ataca a {objetivo.NombrePersonaje} y le causa {daño} puntos de daño.");
                    objetivo.ValorDefensa = objetivo.ValorDefensa - daño;

                    if (objetivo.ValorDefensa <=0)
                    {
                        Console.WriteLine ($"\n{objetivo.NombrePersonaje} ha sido derrotado");
                    }
                }
            }
        }

        public void Curar (IPersonaje objetivo)
        {
            objetivo.ValorDefensa += 6;
            Console.WriteLine($"\n{NombrePersonaje} cura a {objetivo.NombrePersonaje}");
        }

        public void Hechizo(IPersonaje objetivo, TipoHechizo hechizo)
        {
             Console.WriteLine($"\n{NombrePersonaje} no puede lanzar hechizos ya que no es un mago.");
            //Incluimos un método vacío para cumplir con la interfaz ya que los elfos no pueden lanzar hechizos
        }
    }
}