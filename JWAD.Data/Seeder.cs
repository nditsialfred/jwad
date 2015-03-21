using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JWAD.Data.Model;
using System.Data.Entity.Migrations;

namespace JWAD.Data
{
    public static class Seeder
    {
        public static void Seed(JwadDbContext context)
        {
            UserStore<JwadUser> store = new UserStore<JwadUser>(context);
            UserManager<JwadUser> manager = new UserManager<JwadUser>(store);

            JwadUser tdavis = manager.FindByEmail("tdavis@gmail.com");

            if (tdavis == null)
            {
                tdavis = new JwadUser
                {
                    Email = "tdavis@gmail.com",
                    UserName = "TreDavis"
                };
                manager.Create(tdavis, "123456");
            }

            context.JobRequirements.AddOrUpdate(m => m.JobTitle,
                 new Job
                 {
                     JobTitle = "Junior Software Developer",
                     JobState = "CA",
                     JobCity = "San Franciso",
                     JobZipCode = 94110,
                     JobDescription = "Have skills with these languages JavaScript, HTML5, C#, .NET Framework",
                     Salary = 100000m
                    
                 });
            context.JobRequirements.AddOrUpdate(m => m.JobTitle,
                new Job
                {
                    JobTitle = "Software Developer",
                    JobState = "TX",
                    JobCity = "Lewisville",
                    JobZipCode = 75057,
                    JobDescription = "Have skills",
                    Salary = 120000m

                });

            context.Employers.AddOrUpdate(m => m.EmployerName,
                new Employer
                {
                    EmployerName = "Coder Camps",
                    EmployerUrl = "https://www.codercamps.com/",

                });
            
            context.Employers.AddOrUpdate(m => m.EmployerName,
            new Employer
            {
                EmployerName = "Coder For Rent",
                EmployerUrl = "https://www.codercamps.com/",
                
            })
            ;


        }
    }
}
