using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using JWAD.Adapters;
using JWAD.Models;
using Microsoft.AspNet.Identity;

namespace JWAD.Controllers
{
    public class ApiJobSeekerController : ApiController
    {
        private IJobSeeker _adapter;

        public ApiJobSeekerController()
        {
            _adapter = new IJobSeekerAdapter();
        }

        public ApiJobSeekerController(IJobSeeker adapter)
        {
            _adapter = adapter;
        }

        public IHttpActionResult Post(JobSeekerViewModel model)
        {
            string userId = User.Identity.GetUserId();
            model.JobSeekerId = _adapter.AddJobSeeker(model, userId);
            return Ok(model);
        }

        public IHttpActionResult Get()
        {
            List<JobSeekerViewModel> models = _adapter.GetJobSeeker();
            return Ok(models);
        }

        public IHttpActionResult Delete(JobSeekerViewModel model)
        {
            model.JobSeekerId = _adapter.DeleteJobSeeker(model);
            return Ok(model);
        }
    }
}
