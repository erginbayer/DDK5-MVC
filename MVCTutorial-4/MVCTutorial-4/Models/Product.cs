namespace MVCTutorial_4.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        


        public Product(string name, decimal price, decimal dPrice) {
        
            this.Name = name;
            this.Price = price;
            this.DiscountPrice = dPrice;
        }
    }

    
}
