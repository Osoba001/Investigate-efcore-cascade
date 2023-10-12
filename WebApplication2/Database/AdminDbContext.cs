using InvestigatingEfCoreRelationship.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroupChatDemo.Database
{
    internal class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
            //var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            //if (dbCreator != null)
            //{
            //    if (!dbCreator.CanConnect())
            //        dbCreator.Create();
            //    if (!dbCreator.HasTables())
            //        dbCreator.CreateTables();
            //}

        }

        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<Well> Wells { get; set; }
        public virtual DbSet<Reservoir> Reservoirs { get; set; }
        public virtual DbSet<DrainagePoint> DrainagePoints { get; set; }
    }
}
