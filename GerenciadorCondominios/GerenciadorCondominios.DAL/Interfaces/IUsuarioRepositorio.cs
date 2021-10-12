using GerenciadorCondominios.BLL;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        int VerificarSeExisteRegistro();
        Task EfetuarLogon(Usuario usuario, bool lembrarDoLogin);
        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);
        Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao);
    }
}
