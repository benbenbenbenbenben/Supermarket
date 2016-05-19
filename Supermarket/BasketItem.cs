using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class BasketItem
    {
        public string ItemName;
        public decimal Price;
        public string ItemType;

        public BasketItem()
        {
            
        }

        public BasketItem(decimal price)
        {
            this.Price = price;
        }
    }
}
