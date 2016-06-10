using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using KungligaOperanAnsokan.Models;

namespace KungligaOperanAnsokan.DataAccess
{
    //DropCreateDatabaseAlways, DropCreateDatabaseIfModelChanges
    public class ApplicationInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            //var applicants = new List<Applicant>
            //{
            //    new Applicant
            //    {
            //        FirstName = "Stephen",
            //        LastName = "Curry",
            //        Email = "Stephen.Curry@Warriors.com",
            //        PhoneNumber = "12345678",
            //        Gender = Gender.Man,
            //        Age = 28
            //    },
            //    new Applicant
            //    {
            //        FirstName = "Klay",
            //        LastName = "Thompson",
            //        Email = "Klay.Thompson@Warriors.com",
            //        PhoneNumber = "23456789",
            //        Gender = Gender.Man,
            //        Age = 26
            //    }
            //};
            ////TODO: Complete the seed
            //applicants.ForEach(a => context.Applicants.Add(a));
            //context.SaveChanges();
        }
    }
}