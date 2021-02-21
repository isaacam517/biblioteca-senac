using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult ListaDeUsuarios()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificarSeUsuarioEAdmin(this);

            return View(new UsuarioService().Listar());
        }

        public IActionResult editarUsuario(int id)
        {
            Usuario u = new UsuarioService().Listar(id);

            return View();
        }
        [HttpPost]
        public IActionResult editarUsuario(Usuario userEditado)
        {
            UsuarioService us = new UsuarioService();
            us.editarUsuario(userEditado);

            return RedirectToAction("ListaDeUsuarios");
        }

        public IActionResult RegistrarUsuarios()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificarSeUsuarioEAdmin(this);
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarUsuarios(Usuario novoUser)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificarSeUsuarioEAdmin(this);

            novoUser.senha = Criptografo.TextoCriptografado(novoUser.senha);

            UsuarioService us = new UsuarioService();
            us.incluirUsuario(novoUser);

            return RedirectToAction("cadastroRealizado");
        }

        public IActionResult ExcluirUsuario(int id)
        {
            return View(new UsuarioService().Listar(id));
        }
        
        [HttpPost]
        public IActionResult ExcluirUsuario(string decisao, int id)
        {
            if(decisao=="EXCLUIR")
            {
                ViewData["Mensagem"] = "Exclusão de usuario" +new UsuarioService().Listar(id).Nome+" realizada com sucesso";
                new UsuarioService().excluirUsuario(id);
                return View("ListaDeUsuarios", new UsuarioService().Listar());
            }
            else{
                ViewData["Mensagem"] = "Exclusão cancelada";
                return View("ListaDeUsuaraios", new UsuarioService().Listar());
            }
        }

        public IActionResult cadastroRealizado()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificarSeUsuarioEAdmin(this);

            return View();
        }

        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}