using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DadJokes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DadJokes.Data
{
    public class DadJokesContext : IdentityDbContext
    {
        public DadJokesContext (DbContextOptions<DadJokesContext> options)
            : base(options)
        {
        }

        public DbSet<DadJokes.Models.Joke> Joke { get; set; } = default!;
    }
}
