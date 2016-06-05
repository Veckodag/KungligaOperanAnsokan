namespace KungligaOperanAnsokan.Models
{
    public class ReferenceContact
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}