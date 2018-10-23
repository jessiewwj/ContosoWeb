using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class OfficeAssignment : AuditableEntity
    {
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Instructors")]
        public int InstructorID { get; set; }
        public string Location { get; set; }

        public Instructor Instructors { get; set; }
    }
}
