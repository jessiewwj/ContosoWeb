using System;
using System.Collections.Generic;

namespace Contoso.Model.Models
{
    public class Student : People
    {
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
