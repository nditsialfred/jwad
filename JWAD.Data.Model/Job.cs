using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWAD.Data.Model
{
    public class Job
    {
        [Key]
        public int JobRequirementId { get; set; }

        public string JobTitle { get; set; }

        public decimal Salary { get; set; }

        public string JobDescription { get; set; }

        public string JobCity { get; set; }
        public string JobState { get; set; }
        public int JobZipCode { get; set; }

        //public int EmployerId { get; set; }
        //[ForeignKey("EmployerId")]
        //public virtual Employer Employer { get; set; }

    }
}
