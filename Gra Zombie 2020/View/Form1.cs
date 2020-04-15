using Gra_Zombie_2020.Karty.Player.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Zombie_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Round;
        List<MyPlayer> Players = new List<MyPlayer>();

        private void button1_Click(object sender, EventArgs e)
        {
            Round = 1;
            BuildNewPlayer();
            FormGame MyFormGame = new FormGame(Round, Players);
            MyFormGame.Show();
        }

        public void BuildNewPlayer()
        {
            Players.Add(new MyPlayer(textBoxName1.Text, 0));
            Players.Add(new MyPlayer(textBoxName2.Text, 1));
            Players.Add(new MyPlayer(textBoxName3.Text, 2));
            Players.Add(new MyPlayer(textBoxName4.Text, 3));
        }
    }
}
