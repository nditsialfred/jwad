﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWAD.Models
{
   public class JobSeekerViewModel
    {
        public int JobSeekerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Resume { get; set; }
    }
}
