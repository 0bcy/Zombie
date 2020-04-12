using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020
{
    public class HandCardPerson : HandCard
    {
        public int Attack;
        public EnumColour Colour;
        public EnumProffesion Proffesion;

        public EnumSpecialCardSkill SpecialSkill;

        public HandCardPerson(EnumType Type, EnumProffesion Proffesion, EnumColour Colour, int Attack) // Ogólny
        {this.Proffesion = Proffesion; this.Type = Type; this.Attack = Attack; this.Colour = Colour; }

        public HandCardPerson(EnumProffesion Proffesion, EnumColour Colour, int Attack) // Sportowcy itp
        { this.Proffesion = Proffesion; this.Type = EnumType.Rubbish; this.Attack = Attack; this.Colour = Colour; }

        public HandCardPerson(EnumType Type, EnumProffesion Proffesion, EnumColour Colour) //Wymienni
        { this.Proffesion = Proffesion; this.Type = Type; this.Attack = 1; this.Colour = Colour; }

        public HandCardPerson(EnumProffesion Proffesion, EnumColour Colour) // Zwykli ludzie
        { this.Proffesion = Proffesion; this.Type = EnumType.Rubbish; this.Attack = 1; this.Colour = Colour; }

        public HandCardPerson(EnumProffesion Proffesion, EnumColour Colour , int Attack, EnumSpecialCardSkill SpecjalSkill) // Żołnierz
        { this.Proffesion = Proffesion; this.Type = EnumType.Rubbish; this.Colour = Colour; this.Attack = Attack; this.SpecialSkill = SpecjalSkill;}

        public HandCardPerson(EnumColour Colour, int Attack) // Zombiak
        { Proffesion = EnumProffesion.Zombie; this.Type = EnumType.Rubbish; this.Attack = Attack; this.Colour = Colour; }

    }
}
