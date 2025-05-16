namespace ValideAPI.Model
{
    public class Category : BaseEntities
    {
        public Category(string categoryName, int categoryNumber, string description) : base()
        {
            CategoryName = categoryName;
            CategoryNumber = categoryNumber;
            Description = description;            
            Products = [];
        }

        public string CategoryName { get; set; }
        public int CategoryNumber { get; set; }
        public string Description { get; set; }        
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
