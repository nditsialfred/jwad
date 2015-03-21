using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWAD.Models
{
    public class JobViewModel
    {
        public int JobRequirementId { get; set; }

        public string JobTitle { get; set; }

        public decimal Salary { get; set; }

        public string JobDescription { get; set; }

        public string JobCity { get; set; }
        public string JobState { get; set; }
        public int JobZipCode { get; set; }
    }
}
