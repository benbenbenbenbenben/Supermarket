using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Checkout
    {
        public void CheckBasket(Basket basket)
        {
            foreach (var item in basket.Items)
            {
                switch (item.ItemType)
                {
                    case ItemTypeEnum.NonAlcoholicDrink:
                        break;
                    case ItemTypeEnum.AlcoholicDrink:
                        throw new Exception("Cannot process an alcoholic item without approval.");
                    case ItemTypeEnum.FreshFood:
                        break;
                    case ItemTypeEnum.FrozenFood:
                        break;
                    case ItemTypeEnum.Confectionary:
                        break;
                    case ItemTypeEnum.Book:
                        break;
                    case ItemTypeEnum.LotteryTicket:
                    case ItemTypeEnum.ScratchCard:
                        throw new Exception("Cannot process a lottery ticket or scratch card without approval.");
                    case ItemTypeEnum.Bra:
                        break;
                    case ItemTypeEnum.Gizmo:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                    
                    
                    
                    //    if (item.ItemType == ItemTypeEnum.AlcoholicDrink)
            //    {
            //        throw new Exception("Cannot process an alcoholic item without approval.");
            //    }
            //    if (item.ItemType == ItemTypeEnum.LotteryTicket || item.ItemType == ItemTypeEnum.ScratchCard)
            //    {
            //        throw new Exception("Cannot process a lottery ticket or scratch card without approval.");
            //    }
            }
        }

        public Bill ProcessBasket(Basket basket)
        {
            var bill = new Bill();
            for (var i = 0; i < basket.Items.Count; i++)
            {
                // add bill line for basket item i
                // line should look like: Book 20.99 for example
                var itemType = basket.Items[i].ItemType;
                var itemPrice = basket.Items[i].Price.ToString();
                bill.Lines.Add(itemType + " " + itemPrice);
            }

            bill.Lines.Add(string.Empty);
            bill.Lines.Add("Sub Total: " + basket.SubTotal());
            bill.Lines.Add("Tax: " + basket.Tax());
            bill.Lines.Add("Discount: " + basket.Discount());
            bill.Lines.Add("Total: " + basket.Total());

            return bill;
        }
    }
}
