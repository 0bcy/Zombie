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
        public String Name;
        public int Number;
        public int MaxRound;
        public int MyRound;
        public int MaxPerson;
        public int MaxItem;

        List<EnumSpecialCardSkill> MySkills = new List<EnumSpecialCardSkill>();

        List<HandCardItem> PlayerItems = new List<HandCardItem>();
        List<HandCardPerson> PlayerPersons = new List<HandCardPerson>();

        public MyPlayer(string Name, int Number)
        {
            this.Name = Name; MaxItem = 5; MaxPerson = 5; MaxRound = 3; this.Number = Number; MyRound = 0;
            if(Number==0)
            { MyRound = 3; }
        }

        public MyPlayer(string Name, List<EnumSpecialCardSkill> MySkills)
        { this.Name = Name; this.MySkills = MySkills; MaxItem = 5; MaxPerson = 5; MaxRound = 3; }

        public void NewRound()
        { MyRound = MaxRound; }

        public bool CanIGo()
        { return MyRound > 0; }

    


        public void RemoveItem(int A) // ODEJMIJ PRZEDMIOT
        { PlayerItems.RemoveAt(A); }

        public void RemovePerson(int A) // ODEJMI OSOBE
        { PlayerPersons.RemoveAt(A); }

        public void AddItem(HandCardItem MyItem) // DODAJ PRZEDMIOT
        {
            if (MyRound > 0)
            {
                if (PlayerItems.Count <= MaxItem)
                {
                    PlayerItems.Add(MyItem);
                    MyRound--;
                }
                else
                { MessageBox.Show("Nie masz miejsca"); }
            }
        }

        public void AddPerson(HandCardPerson MyPerson) // DODAJ OSOBE
        {
            if (MyRound > 0)
            {
                if (PlayerPersons.Count <= MaxPerson)
                {
                    PlayerPersons.Add(MyPerson);
                    MyRound--;
                }
                else
                { MessageBox.Show("Nie masz miejsca"); }
            }
        }
    }
}
