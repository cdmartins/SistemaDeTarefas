using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemasDeTarefasDBContex : DbContext
    {
        //Trabalhando com ORM? URM? ele facilita trabalhar com banco de dados
        public SistemasDeTarefasDBContex(DbContextOptions<SistemasDeTarefasDBContex> options)
            :base(options)
        {
        }

        //Representa uma tabela no banco de dados Usuarios
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
