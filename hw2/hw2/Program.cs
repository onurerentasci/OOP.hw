using hw2;

var product1 = new Product()
{
    ProductId = 1,
    Price = 4000,
    ProductName = "Monitor"
};

var product2 = new Product() { ProductId = 2, Price = 25000, ProductName = "Mobile Phone" };

var card1 = new CardItem()
{
    CardId = 1,
    Product = product1,
    Quantity = 6
};

var card2 = new CardItem()
{
    CardId = 2,
    Product = product2,
    Quantity = 2
};

var cardmanager = new ShoppingCard();

cardmanager.Add(card1);
cardmanager.Add(card2);
cardmanager.Remove(2);
cardmanager.GetList();
Console.WriteLine(cardmanager.GetBalance());

