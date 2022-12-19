namespace Domain.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public GenderModel Gender { get; set; }
        public bool Enable { get; set; }
    }
}
