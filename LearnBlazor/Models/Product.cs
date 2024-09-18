namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } = 0;
        public bool IsActive { get; set; } = false;
        public IEnumerable<Product_Prop> ProductProperties { get; set; }
    }
}
