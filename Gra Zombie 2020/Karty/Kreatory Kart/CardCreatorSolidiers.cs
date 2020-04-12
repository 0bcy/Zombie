using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020.Karty
{
    public class CardCreatorSolidiers
    {
        private List<HandCardPerson> solidiers = new List<HandCardPerson>();

        Random Randomizer = new Random();

        public void AddCards()
        {
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Blue,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś5));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Green,  Randomizer.Next(4, 8), EnumSpecialCardSkill.coś4));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Red,    Randomizer.Next(4, 8), EnumSpecialCardSkill.coś3));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Yellow, Randomizer.Next(4, 8), EnumSpecialCardSkill.coś2));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Grey,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś1));

            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Blue,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś4));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Green,  Randomizer.Next(4, 8), EnumSpecialCardSkill.coś3));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Red,    Randomizer.Next(4, 8), EnumSpecialCardSkill.coś2));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Yellow, Randomizer.Next(4, 8), EnumSpecialCardSkill.coś5));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Grey,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś1));

            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Blue,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś3));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Green,  Randomizer.Next(4, 8), EnumSpecialCardSkill.coś2));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Red,    Randomizer.Next(4, 8), EnumSpecialCardSkill.coś5));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Yellow, Randomizer.Next(4, 8), EnumSpecialCardSkill.coś4));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Grey,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś1));

            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Blue,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś2));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Green,  Randomizer.Next(4, 8), EnumSpecialCardSkill.coś5));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Red,    Randomizer.Next(4, 8), EnumSpecialCardSkill.coś4));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Yellow, Randomizer.Next(4, 8), EnumSpecialCardSkill.coś3));
            solidiers.Add(new HandCardPerson(EnumProffesion.Solidier, EnumColour.Grey,   Randomizer.Next(4, 8), EnumSpecialCardSkill.coś1));

        }


        public List<HandCardPerson> UseCardCreator()
        {
            AddCards();
            return solidiers;
        }
    }
}
