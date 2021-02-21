using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Autenticacao.CheckLogin(this);
            ViewData["mensagem"] = "Seja bem vindo! 'Mantenha o cadastro sempre Atualizado!'";
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string senha)
        {
            //Foi adicionado vericação de login mostrando mensagem de erro no caso de senha errada
            if(Autenticacao.verificarLoginSenha(login,senha,this))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Erro"] = "Senha inválida - Digite a senha correta!";
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
