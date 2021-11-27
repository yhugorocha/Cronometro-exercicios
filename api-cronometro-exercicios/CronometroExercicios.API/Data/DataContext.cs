using Microsoft.EntityFrameworkCore;
using CronometroExercicios.API.Model;



namespace Exercicio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Atividade> Exercicios { get; set; }
    }
}