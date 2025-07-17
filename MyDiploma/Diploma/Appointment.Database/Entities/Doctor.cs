using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointment.Database.Common;

namespace Appointment.Database.Entities
{
    public class Doctor
    {
        public int IdentityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatronymicName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid? ExternalId { get; set; }
        public bool IsBanned { get; set; }
        public string FullName => $"{LastName} {FirstName} {PatronymicName}";
        public DoctorType DoctorType { get; set; }
        public int Id { get => IdentityId; set => IdentityId = value; }
        public string Title => FullName;
    }
}
