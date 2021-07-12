using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        [StringLength(300)]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }

    }
}
