using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWAD.Data.Model
{
   public class JobApplication
    {
       [Key]
       public int JobApplicationId  { get; set; }

       public int JwadUserId { get; set; }
       [ForeignKey("JwadUserId")]
       public virtual JwadUser JwadUser { get; set; }

       public int EmployerId { get; set; }
       [ForeignKey("EmployerId")]
       public virtual Employer Employer { get; set; }



    }
}
