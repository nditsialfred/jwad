using JWAD.Data.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWAD.Data
{
    public class JwadDbContext : IdentityDbContext<JwadUser>
    {
        public JwadDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Job> JobRequirements { get; set; }

        public DbSet<Employer> Employers { get; set; }
        //public DbSet<JobApplication> JobApplications { get; set; }
        public static JwadDbContext Create()
        {
            return new JwadDbContext();
        }
    }
}
