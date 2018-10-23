using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Course : AuditableEntity
    {
        public string Title { get; set; }
        public int Credits { get; set; }

        [ForeignKey("Department")]
        [Required]
        public int DepartmentID { get; set; }

        public Department Department { get; set; } // One to many----One
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
