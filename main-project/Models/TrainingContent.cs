namespace TrueMuromez.Models
{
    public class TrainingContent
    {
        public int Id { get; set; }
        public int TrainingID { get; set; }
        public string URL { get; set; }
        public Training Training { get; set; }
    }
}
