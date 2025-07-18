using System;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Database.Entities
{
    public class Appointment
    {
        public virtual int Id { get; set; }
        [MaxLength(2048)]
        public virtual string Title { get; set; }
        public virtual DateTimeOffset CreatedOn { get; set; }
        public virtual DateTimeOffset AppointmentDate { get; set; }
        public virtual DateTimeOffset LastChangedOn { get; set; }
        public virtual int DoctorId { get; set; }
        public virtual int ClientId { get; set; }
        public virtual int? AgreementId { get; set; }
        [MaxLength(2048)]
        public virtual string Comment { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
    
