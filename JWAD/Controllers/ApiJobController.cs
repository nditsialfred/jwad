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
    public class ApiJobController : ApiController
    {
        private IJobAdapter _adapter;

        public ApiJobController()
        {
            _adapter = new JobDataAdapter();
        }

        public ApiJobController(IJobAdapter adapter)
        {
            _adapter = adapter;
        }

        public IHttpActionResult Post(JobViewModel model)
        {
            string userId = User.Identity.GetUserId();
            model.JobRequirementId = _adapter.AddJob(model, userId);
            return Ok(model);
        }

        public IHttpActionResult Get()
        {
            List<JobViewModel> models = _adapter.GetJob();
            return Ok(models);
        }

        public IHttpActionResult Delete(JobViewModel model)
        {
            model.JobRequirementId = _adapter.DeleteJob(model);
            return Ok(model);
        }
    }
}
