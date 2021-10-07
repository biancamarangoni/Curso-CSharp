using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRazorCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Controllers
{
    public class ProfessorController : Controller
    {
        Professor profModel = new Professor();
        public IActionResult Index()
        {
            ViewBag.ListaDeProfessores = profModel.ListarProf();
            return View();
        }

        [Route("~/Professor/Cadastrar")] //para acessar esse > Professor/Cadastro
        public IActionResult Cadastrar(IFormCollection formulario)
        {
            Professor professor = new Professor();
            //recebe os dados do formulário
            professor.Nome = formulario["nomeProf"];
            professor.Email = formulario["emailProf"];
            professor.Endereco = formulario["enderecoProf"];
            professor.Telefone = formulario["telefoneProf"];
            professor.Cargo = formulario["cargoProf"];

            professor.CadastrarProf(professor);

            return LocalRedirect("/");
        }

        [Route("~/Professor/Atualizar")] //para acessar esse > Professor/Cadastro
        public IActionResult Atualizar(IFormCollection formulario)
        {
            Professor professor = new Professor();
            //recebe os dados do formulário
            professor.Nome = formulario["nomeProf"];
            professor.Email = formulario["emailProf"];
            professor.Endereco = formulario["enderecoProf"];
            professor.Telefone = formulario["telefoneProf"];
            professor.Cargo = formulario["cargoProf"];

            professor.AtualizarProf(professor);

            return LocalRedirect("/");
        }

        [Route("~/Professor/Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }

        [Route("~/Professor/{id}")]
        public IActionResult Remover(int id)
        {
            profModel.RemoverProf(id);

            return LocalRedirect("/Professor");
        }

        [Route("~/Professor/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            var listaRetornada = profModel.BuscarPorId(id);
            var profRetornado = listaRetornada.Find(professor => professor.Id == id);

            ViewBag.profRetornado = profRetornado;

            return View();
        }
    }
}
