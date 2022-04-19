using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
