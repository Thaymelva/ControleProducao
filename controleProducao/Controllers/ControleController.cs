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

           ControleModel contato = _controleRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            ControleModel controle = _controleRepositorio.ListarPorId(id);
            return View(controle);
        }

        public IActionResult ApagarConfirm (int id)
        {
            _controleRepositorio.ApagarConfirm(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ControleModel controle)
        {
            _controleRepositorio.Adicionar(controle);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ControleModel controle)
        {
            _controleRepositorio.Atualizar(controle);
            return RedirectToAction("Index");
        }
    }
}
