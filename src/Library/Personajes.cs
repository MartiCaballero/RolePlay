using System;

namespace JuegoDeRoles
{
    public class Personaje
    {
        public string TipoPersonaje {get; set;}
        public string NombrePersonaje {get; set;}
        public int ValorAtaque {get;set;}
        public int ValorDefensa {get; set;}
        public bool LibroHechizos {get;set;}

        public Personaje(string tipopersonaje, string nombrepersonaje, bool librohechizos=false)
        {
            NombrePersonaje = nombrepersonaje;
            TipoPersonaje = tipopersonaje; 
            if (string.Equals(tipopersonaje, "Mago", StringComparison.OrdinalIgnoreCase))
            {
                LibroHechizos=librohechizos;
            }
            else 
            {
                LibroHechizos=false;
            }

            switch (TipoPersonaje.ToLower())
            {
                case "mago": 
                    ValorAtaque = 100;
                    ValorDefensa = 30;
                    break;
                case "elfo":
                    ValorAtaque = 50;
                    ValorDefensa = 50; 
                    break;
                case "enano":
                    ValorAtaque = 30;
                    ValorDefensa = 100; 
                    break;
                default:
                    ValorAtaque = 20;
                    ValorDefensa = 20;
                    break;
            }

            if (LibroHechizos)
            {
                Console.WriteLine($"\n Se ha creado un personaje de tipo {TipoPersonaje} llamado {NombrePersonaje} equipado con un libro de hechizos.");
            }
            else
            {
                Console.WriteLine($"\n Se ha creado un personaje de tipo {TipoPersonaje} llamado {NombrePersonaje}.");
            }
        }
    }
}