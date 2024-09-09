using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Configuracoes.Db.Entidades
{
    [Table("menu")]
    public class Menu : EntidadeBase
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public string? Pai { get; set; } = string.Empty;

        public int Ordem { get; set; }

        public string Codigo { get; set; } = string.Empty;

        public string? Icone { get; set; } = string.Empty;
    }
}
 