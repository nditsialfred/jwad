using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JWAD.Data;
using JWAD.Data.Model;
using JWAD.Models;

namespace JWAD.Adapters
{
    public class IJobSeekerAdapter : IJobSeeker
    {

        public int AddJobSeeker(Models.JobSeekerViewModel model, string userId)
        {
            int jobSeekerId;
            using (JwadDbContext db = new JwadDbContext())
            {
                JobSeeker jobSeeker = new JobSeeker
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Resume = model.Resume

                };
                db.JobSeekers.Add(jobSeeker);
                db.SaveChanges();
                jobSeekerId = jobSeeker.JobSeekerId;
            }

            return jobSeekerId;

        }

        public List<Models.JobSeekerViewModel> GetJobSeeker()
        {
            List<JobSeekerViewModel> models = null;
            using (JwadDbContext db = new JwadDbContext())
            {
                models = db.JobSeekers.Select(i => new JobSeekerViewModel
                {
                    JobSeekerId = i.JobSeekerId,
                    FirstName = i.FirstName,
                    LastName = i.LastName,
                    Resume = i.Resume


                }).ToList();

            }

            return models;
        }

        public int DeleteJobSeeker(Models.JobSeekerViewModel jobSeeker)
        {
            using (JwadDbContext db = new JwadDbContext())
            {
                var delete = db.JobSeekers.Where(m => m.JobSeekerId == jobSeeker.JobSeekerId).SingleOrDefault();
                db.JobSeekers.Remove(delete);
                db.SaveChanges();
            }
            return jobSeeker.JobSeekerId;
        }
    }
}
