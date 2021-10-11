using System;

namespace GerenciadorCondominios.BLL
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }

        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int AluguelId { get; set; }
        public Aluguel Aluguel { get; set; }

        public DateTime? DataPagamento { get; set; }

        public StatusPagamentoEnum Status { get; set; }
    }
}
