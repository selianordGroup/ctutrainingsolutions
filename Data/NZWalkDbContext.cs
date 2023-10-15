using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctutrainingsolutions.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ctutrainingsolutions.Data
{
    public class NZWalkDbContext :DbContext
    {
       public NZWalkDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
       {
        
       }

       //Add DbSet collection here 

       public DbSet<Difficulty> Difficulties { get; set; }

       public DbSet<Region> Regions { get; set; }

       public DbSet<Walk> Walks { get; set; }
    }
}