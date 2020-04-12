using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020.Karty
{
    public class CardCreatorMercenary
    {
        private List<HandCardPerson> mercenary = new List<HandCardPerson>();

        Random Randomizer = new Random();

        private void AddCards(int Round)
        {
            for (int i = 0; i <= 7; i++)
            {
                mercenary.Add(new HandCardPerson(EnumProffesion.Mercenary, EnumColour.Blue, Randomizer.Next(1, 5 + Round)));
                mercenary.Add(new HandCardPerson(EnumProffesion.Mercenary, EnumColour.Green, Randomizer.Next(1, 5 + Round)));
                mercenary.Add(new HandCardPerson(EnumProffesion.Mercenary, EnumColour.Red, Randomizer.Next(1, 5 + Round)));
                mercenary.Add(new HandCardPerson(EnumProffesion.Mercenary, EnumColour.Yellow, Randomizer.Next(1, 5 + Round)));
            }
        }

        public List<HandCardPerson> UseCardCreator(int Round)
        {
            AddCards(Round);
            return mercenary;
        }
    }
}