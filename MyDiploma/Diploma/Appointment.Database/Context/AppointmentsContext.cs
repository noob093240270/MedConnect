using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointment.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Appointment.Database.Context
{
    public class AppointmentsContext : DbContext
    {
        public const string SchemaName = "mimo_orders";
        public AppointmentsContext(DbContextOptions<AppointmentsContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
