using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gra_Zombie_2020.Karty.Player.View
{
    public partial class FormGame : Form
    {
        public FormGame(int Round)
        {
            InitializeComponent();
            this.Round = Round;
            GameCreator(Round);
        }

        int Round;
        List<HandCardItem> GameItems;
        List<HandCardPerson> GamePersons;
        List<HandCardPerson> GameZombies;
        List<HandCardPerson> GamePoliceman;
        List<HandCardPerson> GameSolidier;
        List<HandCardPerson> GameMercenary;

        List<MyPlayer> Players;
        int ActivePlayer;

        public void GameCreator(int Round)
        {
            CardCreatorItems CreateItems = new CardCreatorItems();
            CardCreatorPersons CreatePersons = new CardCreatorPersons();
            CardCreatorZombie CreateZombies = new CardCreatorZombie();
            CardCreatorPolicemans CreatePoliceman = new CardCreatorPolicemans();
            CardCreatorSolidiers CreateSolidier = new CardCreatorSolidiers();
            CardCreatorMercenary CreateMercenary = new CardCreatorMercenary();

            GameItems = CreateItems.UseCardCreator();
            GamePersons = CreatePersons.UseCardCreator();
            GameZombies=CreateZombies.UseCardCreator(Round) ;
            GamePoliceman=CreatePoliceman.UseCardCreator() ;
            GameSolidier=CreateSolidier.UseCardCreator() ;
            GameMercenary= CreateMercenary.UseCardCreator(Round);
        }

        private void button2_Click(object sender, EventArgs e) // Szukaj przedmiotów
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
