namespace TrueMuromez.Models
{
    public class Content
    {
        public int Id { get; set; }     
        public int ProductId { get; set; }
        public string URL { get; set; }
        Product Product { get; set; }

    }
}
