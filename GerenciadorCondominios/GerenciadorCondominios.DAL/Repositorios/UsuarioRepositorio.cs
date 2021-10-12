using GerenciadorCondominios.BLL;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto contexto;
        private readonly UserManager<Usuario> gerenciadorUsuarios;
        private readonly SignInManager<Usuario> gerenciadorLogin;

        public UsuarioRepositorio(Contexto contexto, UserManager<Usuario> gerenciadorUsuarios, SignInManager<Usuario> gerenciadorLogin) : base(contexto)
        {
            this.contexto = contexto;
            this.gerenciadorUsuarios = gerenciadorUsuarios;
            this.gerenciadorLogin = gerenciadorLogin;
        }

        public async Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            try
            {
                return await this.gerenciadorUsuarios.CreateAsync(usuario, senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task EfetuarLogon(Usuario usuario, bool lembrarDoLogin)
        {
            try
            {
                await this.gerenciadorLogin.SignInAsync(usuario, lembrarDoLogin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao)
        {
            try
            {
                await this.gerenciadorUsuarios.AddToRoleAsync(usuario, funcao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int VerificarSeExisteRegistro()
        {
            try
            {
                return this.contexto.Usuarios.Count();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
