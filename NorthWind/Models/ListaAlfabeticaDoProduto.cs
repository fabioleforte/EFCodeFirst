using System;
using System.Collections.Generic;

namespace NorthWind.Models
{
    public class ListaAlfabeticaDoProduto
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public Nullable<int> ForcedorId { get; set; }
        public Nullable<int> CategoriaId { get; set; }
        public string QtdePorUnidade { get; set; }
        public Nullable<decimal> PrecoUnitario { get; set; }
        public Nullable<short> UnidadesEmEstoque { get; set; }
        public Nullable<short> UnidadesEmOrdem { get; set; }
        public Nullable<short> NivelAbastecimento { get; set; }
        public bool Interrompido { get; set; }
        public string NomeCategoria { get; set; }
    }
}
