namespace Application.Dto
{
    public class ContactDto
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public GenderDto Gender { get; set; }
        public int Age { get; set; }
    }
}
