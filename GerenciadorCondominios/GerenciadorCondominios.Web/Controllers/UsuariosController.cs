using GerenciadorCondominios.BLL;
using GerenciadorCondominios.DAL;
using GerenciadorCondominios.Web.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GerenciadorCondominios.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IWebHostEnvironment webHostEnvironment;

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            this.usuarioRepositorio = usuarioRepositorio;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Registro(RegistroViewModel model, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                if (foto != null)
                {
                    string diretorioFoto = Path.Combine(this.webHostEnvironment.WebRootPath, "imagens");
                    string nomeArquivoFoto = Guid.NewGuid().ToString() + foto.FileName;

                    using (FileStream fileStream = new FileStream(Path.Combine(diretorioFoto, nomeArquivoFoto), FileMode.Create))
                    {
                        await foto.CopyToAsync(fileStream);
                        model.Foto = "~/Imagens/" + nomeArquivoFoto;
                    }
                }

                Usuario usuario = new Usuario();
                IdentityResult usuarioCriado;

                if (this.usuarioRepositorio.VerificarSeExisteRegistro() == 0)
                {
                    usuario.UserName = model.Nome;
                    usuario.CPF = model.CPF;
                    usuario.Email = model.Email;
                    usuario.PhoneNumber = model.Telefone;
                    usuario.Foto = model.Foto;
                    usuario.PrimeiroAcesso = false;
                    usuario.Status = StatusContaEnum.Aprovado;

                    usuarioCriado = await this.usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                    if (usuarioCriado.Succeeded)
                    {
                        await this.usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, "Administrador");
                        await this.usuarioRepositorio.EfetuarLogon(usuario, false);
                        return RedirectToAction("Index", "Usuarios");
                    }
                }

                usuario.UserName = model.Nome;
                usuario.CPF = model.CPF;
                usuario.Email = model.Email;
                usuario.PhoneNumber = model.Telefone;
                usuario.Foto = model.Foto;
                usuario.PrimeiroAcesso = true;
                usuario.Status = StatusContaEnum.Analisando;

                usuarioCriado = await this.usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                if (usuarioCriado.Succeeded)
                {
                    return View("Analise", usuario.UserName);
                }
                else
                {
                    foreach (var erro in usuarioCriado.Errors)
                    {
                        ModelState.AddModelError("", erro.Description);
                    }

                    return View(model);
                }

            }
            return View(model);
        }

        public IActionResult Analise(string nome)
        {
            return View(nome);
        }
    }
}
