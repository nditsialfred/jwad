using JWAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using JWAD.Data;
using JWAD.Data.Model;

namespace JWAD.Adapters
{
    public class JobDataAdapter : IJobAdapter
    {

        public int AddJob(JobViewModel model, string userId)
        {
            int jobId;
            using (JwadDbContext db = new JwadDbContext())
            {
                Job job = new Job
                {
                    
                    JobCity = model.JobCity,
                    JobDescription = model.JobDescription,
                    JobTitle = model.JobTitle,
                    JobState = model.JobState,
                    JobZipCode = model.JobZipCode
                };
                db.JobRequirements.Add(job);
                db.SaveChanges();
                jobId = job.JobRequirementId;
            }

       return jobId;
        }


        public List<JobViewModel> GetJob()
        {
            List<JobViewModel> models = null;
            using (JwadDbContext db = new JwadDbContext())
            {
                models = db.JobRequirements.Select(i => new JobViewModel
                {
                    JobRequirementId = i.JobRequirementId,
                    JobTitle = i.JobTitle,
                    JobDescription = i.JobDescription,
                    JobState = i.JobState,
                    JobCity = i.JobCity,
                    JobZipCode = i.JobZipCode

                }).ToList();
             
            }

            return models;
        }

        public int DeleteJob(JobViewModel job)
        {
            using (JwadDbContext db = new JwadDbContext())
            {
                var delete = db.JobRequirements.Where(m => m.JobRequirementId == job.JobRequirementId).SingleOrDefault();
                db.JobRequirements.Remove(delete);
                db.SaveChanges();
            }
            return job.JobRequirementId;
        }
    }
}
