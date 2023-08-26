using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_Sample_Project.Models;

namespace WebAPI_Sample_Project.Data
{
    public class CryptoContext : DbContext
    {
        public CryptoContext (DbContextOptions<CryptoContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_Sample_Project.Models.Crypto> Crypto { get; set; } = default!;
    }
}
