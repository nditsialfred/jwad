using JWAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWAD.Adapters
{
    public interface IJobAdapter
    {
        int AddJob(JobViewModel model, string userId);
        List<JobViewModel> GetJob();
        int DeleteJob(JobViewModel job);
    }
}
