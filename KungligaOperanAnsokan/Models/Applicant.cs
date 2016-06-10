using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KungligaOperanAnsokan.Models
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public virtual ICollection<ReferenceContact> Contacts { get; set; }
        public virtual ICollection<Application> Applications { get; set; }

    }

    public enum Gender
    {
        Man,
        Kvinna,
        Annan
    }
}