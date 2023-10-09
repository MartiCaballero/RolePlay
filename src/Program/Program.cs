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
            Mago mago1 = new Mago ( "Voldemort", true);
            //Creamos personaje 2:
<<<<<<< HEAD
            Elfo elfo1 = new Elfo ("Harrius");

            Armaduras armadura1 = Armaduras.CrearArmaduraPlata();
            EquiparItem.Equipar(mago1,armadura1);
            Armaduras tunica = Armaduras.CrearTunica();
            EquiparItem.Equipar(elfo1, tunica);

            Armas bastonmagico = Armas.CrearBastonMagico();
            EquiparItem.Equipar(mago1,bastonmagico);
            mago1.Hechizo(elfo1, TipoHechizo.LlamasArdientes);
            
            Armas espada = Armas.CrearEspada();
            EquiparItem.Equipar(elfo1, espada);
            elfo1.Ataque(mago1);
=======
            Personaje elfo1 = new Personaje ("Elfo", "Harrius");
            //Items de personaje 1:
            ConstructorItem bastonmagico = new ConstructorItem ("Bastón Mágico", 10, 0);
            ConstructorItem tunica = new ConstructorItem ("Túnica", 5, 0);
            //Items de personaje 2:
            ConstructorItem hachaMágica = new ConstructorItem ("Hacha Mágica", 5, 10);
            ConstructorItem capa = new ConstructorItem ("capa", 10, 10);

            //Equipamos ítems: 
            bastonmagico.EquiparItem(mago1);
            tunica.EquiparItem(mago1);
            hachaMágica.EquiparItem(elfo1);
            capa.EquiparItem(elfo1);

            //Batalla:
            Batalla.CalcularResultadoBatalla(mago1, elfo1);
            Batalla.Hechizo(mago1, elfo1, "Llamas Ardientes");
            Batalla.CuraciónElfo(elfo1, mago1);
            Batalla.CalcularResultadoBatalla(mago1, elfo1);
>>>>>>> 6f04d3e772be798158f4245b04497819df49c6b7
        }
    }
}