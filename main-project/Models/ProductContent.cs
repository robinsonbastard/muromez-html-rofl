namespace TrueMuromez.Models
{
    public class ProductContent
    {
        public int Id { get; set; }     
        public int ProductID { get; set; }
        public string URL { get; set; }
        Product Product { get; set; }

    }
}
