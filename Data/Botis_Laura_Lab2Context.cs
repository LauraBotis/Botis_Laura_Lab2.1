using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Botis_Laura_Lab2.Models;

namespace Botis_Laura_Lab2.Data
{
    public class Botis_Laura_Lab2Context : DbContext
    {
        public Botis_Laura_Lab2Context (DbContextOptions<Botis_Laura_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Botis_Laura_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Botis_Laura_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
