using Microsoft.EntityFrameworkCore;
using TesteEFCore.Models;

namespace TesteEFCore.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) 
        {            

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
