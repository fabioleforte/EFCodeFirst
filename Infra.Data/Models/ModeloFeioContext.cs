using Infra.Data.Models.Mapping;
using System.Data.Entity;

namespace Infra.Data.Models
{
    public partial class ModeloFeioContext : DbContext
    {
        static ModeloFeioContext()
        {
            Database.SetInitializer<ModeloFeioContext>(null);
        }

        public ModeloFeioContext()
            : base("Name=ModeloFeioContext")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new PessoaMap());

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
    }
}
