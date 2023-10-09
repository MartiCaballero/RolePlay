using System;

namespace JuegoDeRoles
{
    public class Armas : IItems
    { 
        public string NombreItem {get;}
        public int ValorDefensa {get;}
        public int ValorAtaque {get;}

        public Armas (string NombreArmas, int valorataque)
        {
            NombreItem = NombreArmas;
            ValorAtaque = valorataque;   
        }

        public static Armas CrearEspada()
        {
            return new Armas ("Espada", 2);
            //Agrega 2 de valor de ataque
        }

        public static Armas CrearBastonMagico()
        {
            return new Armas("Bastón Mágico", 3);
            //Agrega 3 de valor de ataque
        }
    }
}