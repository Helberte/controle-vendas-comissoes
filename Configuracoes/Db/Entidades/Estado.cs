using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Configuracoes.Db.Entidades
{
    [Table("estado")]
    public class Estado : EntidadeBase
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        [Column("UF")]
        public string UF { get; set; } = string.Empty;
    }
}
