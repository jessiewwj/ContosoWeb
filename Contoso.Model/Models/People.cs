using System;
using System.Collections.Generic;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class People : AuditableEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string UnitOrApartmentNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string IsLocked { get; set; }
        public DateTime LastLockedDateTime { get; set; }
        public string FailedAttempts { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Role> Roles { get; set; }//one to many li de many

    }
}
