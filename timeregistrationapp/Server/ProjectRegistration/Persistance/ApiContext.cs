using System;
using Microsoft.EntityFrameworkCore;
using ProjectRegistration.Models;

namespace ProjectRegistration.Persistance
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options): base(options)
        {
        }

        public DbSet<TimeRegistration> TimeRegistrations { get; set; }
    }
}
