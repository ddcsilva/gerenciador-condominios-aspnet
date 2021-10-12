using GerenciadorCondominios.BLL;

namespace GerenciadorCondominios.DAL
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
