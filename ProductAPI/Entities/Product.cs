namespace ProductAPI.Entities
{
    public class Product:BaseEntity
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public double SalePrice {  get; set; }
        public double CostPrice { get; set; }
    }
}
