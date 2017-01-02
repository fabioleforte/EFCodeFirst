using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.Models.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            // Primary Key
            this.HasKey(t => t.PessoaId);

            // Properties
            this.Property(t => t.PessoaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Apelido)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("TB_Pessoa");
            this.Property(t => t.PessoaId).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("STR_Nome");
            this.Property(t => t.Apelido).HasColumnName("STR_Apelido");
            this.Property(t => t.Idade).HasColumnName("INT_Idade");
            this.Property(t => t.DataCadastro).HasColumnName("DATE_Data_Cadastro");
            this.Property(t => t.Ativo).HasColumnName("BOOL_Ativo");
        }
    }
}
