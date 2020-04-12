using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Zombie_2020.Karty
{
    public class CardCreatorItems
    {
        private List<HandCardItem> items = new List<HandCardItem>();

        private void AddCards()
        {
            for (int i = 1; i < 10; i++)
                items.Add(new HandCardItem(EnumType.Rubbish));

            for (int i = 1; i<15; i++)
                items.Add(new HandCardItem(EnumType.Wood));
            for (int i = 1; i < 15; i++)
                items.Add(new HandCardItem(EnumType.Tools));
            for (int i = 1; i < 10; i++)
                items.Add(new HandCardItem(EnumType.Money));

            for (int i = 1; i < 5; i++)
                items.Add(new HandCardItem(EnumType.Map));

            for (int i = 1; i < 6; i++)
                items.Add(new HandCardItem(EnumType.Jewellery));
            for (int i = 1; i < 5; i++)
                items.Add(new HandCardItem(EnumType.Can));
            for (int i = 1; i < 4; i++)
                items.Add(new HandCardItem(EnumType.Medicine));
            for (int i = 1; i < 3; i++)
                items.Add(new HandCardItem(EnumType.Warm_clothing));

            for (int i = 1; i < 2; i++)
                items.Add(new HandCardItem(EnumType.Fuel));
        }

        public List<HandCardItem> UseCardCreator()
        {
            AddCards();
            return items;
        }

    }
}
