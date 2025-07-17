using System;
using Microsoft.EntityFrameworkCore;

public class AppointmentsContext : DbContext
{
	public AppointmentsContext()(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
}
