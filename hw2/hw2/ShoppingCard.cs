using System.Security.AccessControl;

namespace hw2
{
    public class ShoppingCard
    {
        private List<CardItem> _cardItems;


        public ShoppingCard()
        {
            _cardItems = new List<CardItem>();
        }

        public void Add(CardItem item)
        {
            _cardItems.Add(item);
        }

        public void Remove(int id)
        {
            var item = _cardItems.FirstOrDefault(x => x.CardId == id);
            if (item != null)
            {
                _cardItems.Remove(item);
            }
        }

        public void GetList()
        {
            foreach (var item in _cardItems)
            {
                Console.WriteLine($"{item.CardId} {item.Product.ProductName} {item.Quantity}");
            }
        }

        public double GetBalance()
        {
            double balance = 0;
            foreach (var item in _cardItems)
            {
                balance += item.Product.Price * item.Quantity;
            }
            return balance;
        }
    }
}