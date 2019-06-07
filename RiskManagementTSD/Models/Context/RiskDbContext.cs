using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;  
  
namespace RiskManagementTSD.Models.Context
{
    public class RiskDbContext : DbContext
    {
        public RiskDbContext(DbContextOptions options) : base(options)

        {
           
        }

        public DbSet<AddRisk> AddRisk { get; set; }
    }
}