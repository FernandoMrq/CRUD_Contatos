namespace Domain.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public GenderModel Gender { get; set; }
        public bool Enable { get; set; }

        public bool Validate()
        {
            if ((Birthday - DateTime.Now).TotalDays > 0)
                return false;

            if (Birthday.AddYears(18) > DateTime.Now)
                return false;

            return true;
        }
    }
}
