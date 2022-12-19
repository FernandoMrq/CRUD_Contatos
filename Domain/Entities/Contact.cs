using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }

    }
}
