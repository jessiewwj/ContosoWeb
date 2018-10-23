using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Role : AuditableEntity
    {
        public String RoleName { get; set; }
        public String Description { get; set; }

        public ICollection<People> Peoples { get; set; }//one to many li de many
    }
}
