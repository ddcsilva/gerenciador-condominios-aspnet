using Microsoft.AspNetCore.Identity;

namespace GerenciadorCondominios.BLL
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
