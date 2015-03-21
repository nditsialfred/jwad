using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JWAD.Models;

namespace JWAD.Adapters
{
    public interface IJobSeeker
    {
        int AddJobSeeker(JobSeekerViewModel model, string userId);
        List<JobSeekerViewModel> GetJobSeeker();
        int DeleteJobSeeker(JobSeekerViewModel job);
    }
}
