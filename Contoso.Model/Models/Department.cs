using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Department : AuditableEntity
    {
        public String Name { get; set; }
        public Decimal Budget { get; set; }
        public DateTime? StartDate { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public int RowVersion { get; set; }

        public ICollection<Course> Courses { get; set; }//one to many li collection the many de course//course shi many
        public Instructor Instructor { get; set; }
    }
}
