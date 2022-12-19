namespace Application.Command
{
    public class ContactCommand
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public GenderCommand Gender { get; set; }
    }
}
