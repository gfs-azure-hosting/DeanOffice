using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DeanOffice_Azure.Models;
namespace DeanOffice_Azure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       public DbSet<Student> Students { get; set; }
       public DbSet<Group> Groups { get; set; }
       public DbSet<Faculty> Faculties{ get; set; }
    }
}
