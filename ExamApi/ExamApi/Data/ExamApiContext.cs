using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamApi.Models;

namespace ExamApi.Data
{
    public class ExamApiContext : DbContext
    {
        public ExamApiContext (DbContextOptions<ExamApiContext> options)
            : base(options)
        {
        }

        public DbSet<ExamApi.Models.Employee> Employee { get; set; } = default!;
    }
}
