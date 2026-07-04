using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.Domain.Courses
{
    public class EnrollmentModule
    {
        //foregin key
        public int EnrollmentId { get; set; } // primary key  

        public Enrollment Enrollment { get; set; } = default!;
        //foregin key
        public int ModuleId { get; set; }// primary key 

        public Module Module { get; set; } = default!;
    }
}
