using System;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Model.Models
{
    public class Instructor:People
    {
        public DateTime HireDate { get; set; }

        public ICollection<Course> Courses { get; set; }

        //public OfficeAssignment OfficeAssignments { get; set; }

        public ICollection<Department> Departments { get; set; }

    }
}
