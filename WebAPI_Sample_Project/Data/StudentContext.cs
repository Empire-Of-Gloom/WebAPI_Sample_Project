using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_Sample_Project.Models;

namespace WebAPI_Sample_Project.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_Sample_Project.Models.Student> Student { get; set; } = default!;
    }
}
