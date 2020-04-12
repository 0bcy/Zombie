using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020.Karty
{
    public class CardCreatorPolicemans
    {
        private List<HandCardPerson> policemans = new List<HandCardPerson>();

        Random Randomizer = new Random();

        public void AddCards()
        {
            for (int i = 0; i <= 10; i++)
            {
                policemans.Add(new HandCardPerson(EnumColour.Blue,   Randomizer.Next(3, 5)));
                policemans.Add(new HandCardPerson(EnumColour.Green,  Randomizer.Next(3, 5)));
                policemans.Add(new HandCardPerson(EnumColour.Red,    Randomizer.Next(3, 5)));
                policemans.Add(new HandCardPerson(EnumColour.Yellow, Randomizer.Next(3, 5)));
            }
        }

        public List<HandCardPerson> UseCardCreator()
        {
            AddCards();
            return policemans;
        }

    }
}
