using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DadJokes.Models;

namespace DadJokes.Data
{
    public class DadJokesContext : DbContext
    {
        public DadJokesContext (DbContextOptions<DadJokesContext> options)
            : base(options)
        {
        }

        public DbSet<DadJokes.Models.Joke> Joke { get; set; } = default!;
    }
}
