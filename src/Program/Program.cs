using System;
using System.Net;
using JuegoDeRoles;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos personaje 1:
            Personaje mago1 = new Personaje ("Mago", "Voldemort", true);
            //Creamos personaje 2:

            //Items de personaje 1:
            ConstructorItem bastonmagico = new ConstructorItem ("Bastón Mágico", 10, 0);
            ConstructorItem tunica = new ConstructorItem ("Túnica", 5, 0);

            //Equipamos ítems: 
            bastonmagico.EquiparItem(mago1);
            tunica.EquiparItem(mago1);

            //Batalla:
           /* Batalla.CalcularResultadoBatalla(mago1, personaje2);
            Batalla.Hechizo(mago1, personaje2, "Llamas Ardientes");
            Batalla.CuraciónElfo(elfo, otropersonaje);
            Batalla.CalcularResultadoBatalla(/dos personajes)*/


        }
    }
}
