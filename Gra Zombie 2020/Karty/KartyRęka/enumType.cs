using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020
{
    public enum EnumType
    {
        // Podstawowe
        Rubbish = 0, // reszta ludzi

        Wood = 1, // Ciesla
        Tools = 2, // Inżynier
        Money = 3, // Handlarz

        // Wyjątkowe
        Map = 4,

        // Luksusowe (drogie do sprzedania, można za coś zamienić)
        Can = 5, // Dodatkowy ruch
        Warm_clothing = 6,
        Jewellery = 7,
        Medicine = 8,
               
        // Składane
        Fuel = 9,
        Generator = 10,
        Battery = 11, // Benzyna + Prądnica + 1 ruch = Akumulator
    }
}
