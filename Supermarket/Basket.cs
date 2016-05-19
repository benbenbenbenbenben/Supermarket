using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Basket
    {
        public List<BasketItem> Items = new List<BasketItem>();
        public List<Func<decimal>> DiscountRules = new List<Func<decimal>>();

        public decimal SubTotal()
        {
            return Items.Sum(item => item.Price);
        }

        public decimal Tax()
        {
            return Items.Sum(item => item.Tax);
        }

        public decimal Discount()
        {
            return DiscountRules.Sum(f => f());
        }

        public decimal Total()
        {
            return SubTotal() + Tax() - Discount();
        }

        public void AddDiscount(Func<Basket, IEnumerable<BasketItem>> query, Func<BasketItem, decimal> modifier)
        {
            this.DiscountRules.Add(() => query(this).Sum(modifier));
        }
    }
}
