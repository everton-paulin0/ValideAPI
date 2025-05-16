namespace ValideAPI.Model
{
    public class Product : BaseEntities
    {
        public Product(string productName,int productNumber, double price, int amount, DateTime register, int categoryId):base()
        {
            ProductName = productName;
            ProductNumber = productNumber;
            Price = price;
            Amount = amount;
            Register = register;
            CategoryId = categoryId;
        }

        public string ProductName { get; set; }
        public int ProductNumber { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public DateTime Register { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
