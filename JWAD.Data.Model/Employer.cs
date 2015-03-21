using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWAD.Data.Model
{
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }
        public string  EmployerName { get; set; }

        public string EmployerUrl { get; set; }
    }
}
