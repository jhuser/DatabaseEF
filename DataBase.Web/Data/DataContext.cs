

namespace DataBase.Web.Data
{
    using DataBase.Web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using System;
    public class DataContext:DbContext
    {
        public DbSet<User> Users { set; get; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}
