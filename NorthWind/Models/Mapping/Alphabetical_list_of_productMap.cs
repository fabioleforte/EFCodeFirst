using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NorthWind.Models.Mapping
{
    public class ListaAlfabeticaDoProdutoMap : EntityTypeConfiguration<ListaAlfabeticaDoProduto>
    {
        public ListaAlfabeticaDoProdutoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CategoriaId, t.NomeProduto, t.Interrompido, t.NomeCategoria });

            // Properties
            this.Property(t => t.ProdutoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NomeProduto)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.QtdePorUnidade)
                .HasMaxLength(20);

            this.Property(t => t.NomeCategoria)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Alphabetical list of products");
            this.Property(t => t.ProdutoId).HasColumnName("ProductID");
            this.Property(t => t.NomeProduto).HasColumnName("ProductName");
            this.Property(t => t.ForcedorId).HasColumnName("SupplierID");
            this.Property(t => t.CategoriaId).HasColumnName("CategoryID");
            this.Property(t => t.QtdePorUnidade).HasColumnName("QuantityPerUnit");
            this.Property(t => t.PrecoUnitario).HasColumnName("UnitPrice");
            this.Property(t => t.UnidadesEmEstoque).HasColumnName("UnitsInStock");
            this.Property(t => t.UnidadesEmOrdem).HasColumnName("UnitsOnOrder");
            this.Property(t => t.NivelAbastecimento).HasColumnName("ReorderLevel");
            this.Property(t => t.Interrompido
                ).HasColumnName("Discontinued");
            this.Property(t => t.NomeCategoria).HasColumnName("CategoryName");
        }
    }
}
