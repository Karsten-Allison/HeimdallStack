using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend;

namespace backend.data
{
    public class WorkInstructionDatabaseContext : DbContext
    {
        public WorkInstructionDatabaseContext(DbContextOptions<WorkInstructionDatabaseContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<WorkInstructionSet> WorkInstructionSets { get; set; }

        public DbSet<Instruction> Instructions { get; set; }

    }
}
