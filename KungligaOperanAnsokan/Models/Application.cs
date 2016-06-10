using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaOperanAnsokan.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public virtual int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }
        public bool IsChoir { get; set; }
    }
}
