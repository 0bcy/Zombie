using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Zombie_2020
{
    public class MyPlayer
    {
        String Name;
        int Level;
        int MaxRound;
        int MaxPerson;
        int MaxItem;

        int Round;

        List<EnumSpecialCardSkill> MySkills = new List<EnumSpecialCardSkill>();

        List<HandCardItem> PlayerItems = new List<HandCardItem>();
        List<HandCardPerson> PlayerPersons = new List<HandCardPerson>();

        public MyPlayer(string Name, List<EnumSpecialCardSkill> MySkills)
        { this.Name = Name; this.MySkills = MySkills; MaxItem = 5; MaxPerson = 5; MaxRound = 3; }

        public void NewRound()
        { Round = MaxRound; }

        public bool CanIGo()
        { return Round > 0; }






        public void RemoveItem(int A) // ODEJMIJ PRZEDMIOT
        { PlayerItems.RemoveAt(A); }

        public void RemovePerson(int A) // ODEJMI OSOBE
        { PlayerPersons.RemoveAt(A); }

        public void AddItem(HandCardItem MyItem) // DODAJ PRZEDMIOT
        {
            if (Round > 0)
            {
                if (PlayerItems.Count <= MaxItem)
                {
                    PlayerItems.Add(MyItem);
                    Round--;
                }
                else
                { MessageBox.Show("Nie masz miejsca"); }
            }
        }

        public void AddPerson(HandCardPerson MyPerson) // DODAJ OSOBE
        {
            if (Round > 0)
            {
                if (PlayerPersons.Count <= MaxPerson)
                {
                    PlayerPersons.Add(MyPerson);
                    Round--;
                }
                else
                { MessageBox.Show("Nie masz miejsca"); }
            }
        }
    }
}
