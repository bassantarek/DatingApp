using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
        /* This creates a table named Users in your database based on your AppUser blueprint */
    }
}

/* 
The Database Bridge (EF Core)
This file is the bridge and manager between your C# code and your database. 
*/