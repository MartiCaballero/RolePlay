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
        }
    }
}