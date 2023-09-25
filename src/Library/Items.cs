using System;

namespace JuegoDeRoles
{
    public class ConstructorItem
    {
        public string TipoItem {get; set;}
        public int BonusAtaque {get; set;}
        public int BonusDefensa {get; set;}

        public ConstructorItem (string tipoitem, int bonusataque, int bonusdefensa)
        {
            TipoItem= tipoitem;
            BonusAtaque = bonusataque;
            BonusDefensa = bonusdefensa;
        }

        public void EquiparItem (Personaje personaje)
        {
            if (TipoItem == "Bastón Mágico")
            {
                if (personaje.TipoPersonaje != "Mago")
                {
                    Console.WriteLine($"\n{personaje.TipoPersonaje} no puede equiparse con un bastón mágico, ya que no es un Mago.");
                }
                else
                {
                    personaje.ValorAtaque += BonusAtaque;
                    personaje.ValorDefensa += BonusDefensa;

                    if (BonusAtaque == 0)
                    {
                        Console.WriteLine($"\n{personaje.TipoPersonaje} ha equipado un item de tipo {TipoItem}, y ha ganado {BonusDefensa} puntos de defensa.");
                    }
                    else
                    {
                        Console.WriteLine($"\n{personaje.TipoPersonaje} ha equipado un item de tipo {TipoItem}, y ha ganado {BonusAtaque} puntos de defensa.");
                    }
                }
            }

            if (TipoItem == "Hacha Mágica")
            {
                if (personaje.TipoPersonaje != "Elfo")
                {
                    Console.WriteLine($"\n{personaje.TipoPersonaje} no puede equipaese con un Hecha Mágica, ya que no es un Elfo");
                }
                else
                {
                    personaje.ValorAtaque += BonusAtaque;
                    personaje.ValorDefensa += BonusDefensa;

                    if (BonusAtaque == 0)
                    {
                        Console.WriteLine($"\n{personaje.TipoPersonaje} ha equipado un item de tipo {TipoItem}, y ha ganado {BonusDefensa} puntos de defensa.");
                    }
                    else
                    {
                        Console.WriteLine($"\n{personaje.TipoPersonaje} ha equipado un item de tipo {TipoItem}, y ha ganado {BonusAtaque} puntos de ataque.");
                    }
                }
            }

            if (TipoItem == "Espada")
            {
                if (personaje.TipoPersonaje!= "Enano")
                {
                    Console.WriteLine($"\n{personaje.TipoPersonaje} no puede equiparse con una espada, ya que no pertenece a la clase enano.");
                }
                else
                {
                    personaje.ValorAtaque += BonusAtaque;
                    personaje.ValorDefensa += BonusDefensa;

                    if (BonusAtaque == 0)
                    {
                        Console.WriteLine($"\n{personaje.TipoPersonaje} ha equipado un item de tipo {TipoItem}, y ha ganado {BonusDefensa} puntos de defensa.");
                    }
                    else
                    {
                        Console.WriteLine($"\n{personaje.TipoPersonaje} ha equipado un item de tipo {TipoItem}, y ha ganado {BonusAtaque} puntos de ataque.");
                    }
                }
            }
        }

    }
}
