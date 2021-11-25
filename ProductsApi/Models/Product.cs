namespace ProductsApi.Models
{
    public class Product
    {
        public long Id {get;set;}
        public string Name {get;set;}
        public string Code { get;set;}
        public decimal Price {get;set;}
        public bool IsActive {get;set;}
        public DateTime Created {get;set;}
        public DateTime Updated {get;set;}        
    }
}
