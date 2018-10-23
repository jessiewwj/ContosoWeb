using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Enrollment : AuditableEntity
    {

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }

        public string Grade { get; set; }

    }
}
