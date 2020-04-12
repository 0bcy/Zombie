using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020.Karty
{
    public class CardCreatorPersons
    {
        private List<HandCardPerson> persons = new List<HandCardPerson>();

        public void AddCards()
        {
            persons.Add(new HandCardPerson(EnumType.Wood, EnumProffesion.Carpenter, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumType.Wood, EnumProffesion.Carpenter, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumType.Wood, EnumProffesion.Carpenter, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumType.Wood, EnumProffesion.Carpenter, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumType.Tools, EnumProffesion.Locksmith, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumType.Tools, EnumProffesion.Locksmith, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumType.Tools, EnumProffesion.Locksmith, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumType.Tools, EnumProffesion.Locksmith, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumType.Money, EnumProffesion.Dealer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumType.Money, EnumProffesion.Dealer, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumType.Money, EnumProffesion.Dealer, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumType.Money, EnumProffesion.Dealer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumType.Fuel, EnumProffesion.Mechanic, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumType.Fuel, EnumProffesion.Mechanic, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumType.Fuel, EnumProffesion.Mechanic, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumType.Fuel, EnumProffesion.Mechanic, EnumColour.Blue));

            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Engineer, EnumColour.Blue));

            persons.Add(new HandCardPerson(EnumProffesion.Sportsman, EnumColour.Blue, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Sportsman, EnumColour.Red, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Sportsman, EnumColour.Green, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Sportsman, EnumColour.Blue, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Security_guard, EnumColour.Blue, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Security_guard, EnumColour.Red, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Security_guard, EnumColour.Green, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Security_guard, EnumColour.Blue, 2));
            persons.Add(new HandCardPerson(EnumProffesion.Policeman, EnumColour.Blue, 3));
            persons.Add(new HandCardPerson(EnumProffesion.Policeman, EnumColour.Red, 3));
            persons.Add(new HandCardPerson(EnumProffesion.Policeman, EnumColour.Green, 3));
            persons.Add(new HandCardPerson(EnumProffesion.Policeman, EnumColour.Blue, 3));

            persons.Add(new HandCardPerson(EnumProffesion.Artist, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Artist, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Attorney, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Attorney, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Baker, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Baker, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Carpenter, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Carpenter, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Clerk, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Clerk, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Dentist, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Dentist, EnumColour.Blue));

            persons.Add(new HandCardPerson(EnumProffesion.Glazier, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Glazier, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Hairdresser, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Hairdresser, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Historian, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Historian, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Lawyer, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Lawyer, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Mathematician, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Mathematician, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Miner, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Miner, EnumColour.Blue));

            persons.Add(new HandCardPerson(EnumProffesion.Musician, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Musician, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Ophthalmologist, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Ophthalmologist, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Painter, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Painter, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Philologist, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Philologist, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Sociologist, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Sociologist, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Solicitor, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Solicitor, EnumColour.Blue));

            persons.Add(new HandCardPerson(EnumProffesion.Teacher, EnumColour.Blue));
            persons.Add(new HandCardPerson(EnumProffesion.Teacher, EnumColour.Red));
            persons.Add(new HandCardPerson(EnumProffesion.Veterinarian, EnumColour.Green));
            persons.Add(new HandCardPerson(EnumProffesion.Veterinarian, EnumColour.Blue));
        }

        public List<HandCardPerson> UseCardCreator()
        {
            AddCards();
            return persons;
        }

    }
}
