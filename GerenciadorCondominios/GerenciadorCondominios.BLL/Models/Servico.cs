using System.Collections.Generic;

namespace GerenciadorCondominios.BLL
{
    public class Servico
    {
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public StatusServicoEnum Status { get; set; }

        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public ICollection<ServicoPredio> ServicoPredios { get; set; }
    }
}
