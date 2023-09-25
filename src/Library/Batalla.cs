using System; 

namespace JuegoDeRoles
{
    public class Batalla
    {
        public static void CalcularResultadoBatalla (Personaje PersonajeAtaque, Personaje PersonajeDefensa)
        {
            int DañoPersonaje = PersonajeAtaque.ValorAtaque;

            if (DañoPersonaje>0)
            {
                Console.WriteLine($"\n{PersonajeAtaque.NombrePersonaje} ataca a {PersonajeDefensa.NombrePersonaje} y le causa {DañoPersonaje} puntos de daño.");
                PersonajeDefensa.ValorDefensa -= DañoPersonaje;

                if (PersonajeDefensa.ValorDefensa <=0)
                {
                    Console.WriteLine($"\n {PersonajeDefensa.NombrePersonaje} ha sido derrotado.");

                }
            }

        }

        public static void CuraciónElfo (Personaje PersonajeAtaque, Personaje PersonajeDefensa)
        {
            if (string.Equals(PersonajeAtaque.TipoPersonaje, "Elfo", StringComparison.OrdinalIgnoreCase))
            {
                PersonajeDefensa.ValorDefensa += 20;
                Console.WriteLine($"\n {PersonajeDefensa.NombrePersonaje} ha sido curado por {PersonajeAtaque.NombrePersonaje}");
            }
            else 
            {
                Console.WriteLine($"\n{PersonajeAtaque.NombrePersonaje} no puede curar debido a que no es un elfo.");
            }
        }

        public static void Hechizo (Personaje PersonajeAtaque, Personaje PersonajeDefensa, string hechizo)
        {
            if (string.Equals(PersonajeAtaque.TipoPersonaje, "Mago", StringComparison.OrdinalIgnoreCase)&& PersonajeAtaque.LibroHechizos)
            {
                int DañoPersonaje = 0; 
                switch (hechizo.ToLower())
                {
                    case "llamas ardientes":
                        DañoPersonaje =15;
                        break;
                    case "escudo de luz":
                        DañoPersonaje =10;
                        break;
                    default:
                        Console.WriteLine("\nHechizo no válido");
                        return;
                }
                PersonajeDefensa.ValorDefensa-= DañoPersonaje;
                Console.WriteLine($"\n{PersonajeAtaque.NombrePersonaje} ha lanzado {hechizo} a {PersonajeDefensa.NombrePersonaje}, y le ha causado {DañoPersonaje} puntos de daño.");

                if (PersonajeDefensa.ValorDefensa <=0)
                {
                    Console.WriteLine($"\n {PersonajeDefensa.NombrePersonaje} ha sido derrotado.");
                }
            }
            else
            {
                Console.WriteLine($"\n{PersonajeAtaque.NombrePersonaje} no puede lanzar hechizos");
            }
        }

        public static void LlamasArdientes (Personaje PersonajeAtaque, Personaje PersonajeDefensa)
        {
            Hechizo(PersonajeAtaque, PersonajeDefensa, "llamas ardientes");
        }

        public static void EscudoDeLuz(Personaje PersonajeAtaque, Personaje PersonajeDefensa)
        {
            Hechizo(PersonajeAtaque, PersonajeDefensa, "escudo de luz");
        }

    }
}
