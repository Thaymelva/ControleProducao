using controleProducao.Models;
using controleProducao.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleProducao.Controllers
{
    public class ControleController : Controller
    {
        private readonly IControleRepositorio _controleRepositorio;
        public ControleController(IControleRepositorio controleRepositorio)
        {
            _controleRepositorio = controleRepositorio;
        }
        public IActionResult Index()
        {
            List<ControleModel> controle =_controleRepositorio.BuscarTodos();
            return View(controle);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
     
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ControleModel controle)
        {
            _controleRepositorio.Adicionar(controle);
            return RedirectToAction("Index");
        }
    }
}
