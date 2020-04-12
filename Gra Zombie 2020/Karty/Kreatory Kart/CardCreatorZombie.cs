using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020.Karty
{
    public class CardCreatorZombie
    {
        private List<HandCardPerson> zombies = new List<HandCardPerson>();

        Random Randomizer = new Random();

        public void AddCards(int Round)
        {
            for (int i = 0; i <= 15; i++)
            {
                zombies.Add(new HandCardPerson(EnumColour.Blue,   Randomizer.Next(2, 10 + Round)));
                zombies.Add(new HandCardPerson(EnumColour.Green,  Randomizer.Next(2, 10 + Round)));
                zombies.Add(new HandCardPerson(EnumColour.Red,    Randomizer.Next(2, 10 + Round)));
                zombies.Add(new HandCardPerson(EnumColour.Yellow, Randomizer.Next(2, 10 + Round)));
            }
        }

        public List<HandCardPerson> UseCardCreator(int Round)
        {
            AddCards(Round);
            return zombies;
        }

    }
}
