using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("classificacao")]
    public class Classificacao : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
    }
}
