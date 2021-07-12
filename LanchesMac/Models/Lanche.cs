using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [Display(Name = "Descrição Curta")]
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [Display(Name = "Descrição Detalhada")]
        [StringLength(300)]
        public string DescricaoDetalhada { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]

        public decimal Preco { get; set; }
        [StringLength(100)]

        public string ImagemUrl { get; set; }
        [StringLength(100)]
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Em Estoque")]

        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
