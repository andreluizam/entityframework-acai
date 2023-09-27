using Microsoft.EntityFrameworkCore;
using ProjetoAcai.Modelo;

namespace ProjetoAcai.Contexto
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer(@"Server=ANDRÉ\SQLEXPRESS;Database=ACAI;User Id=SA;Password=001002;Integrated security=True;Encrypt=False");
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Copo> Copos { get; set; }
        public DbSet<Adicionais> Adicionais { get; set; }
    }
}
