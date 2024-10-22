using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("cidade")]
    public class Cidade : EntidadeBase
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Sigla { get; set; } = string.Empty;

        public int EstadoId { get; set; }
    }
}
