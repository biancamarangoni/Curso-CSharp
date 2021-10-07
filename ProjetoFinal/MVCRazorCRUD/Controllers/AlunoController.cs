using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRazorCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Controllers
{
    public class AlunoController : Controller
    {
        //[Route("Aluno")]

        Aluno alunoModel = new Aluno();
        public IActionResult Index()
        {
            ViewBag.ListaDeAlunos = alunoModel.ListarAluno();
            return View();
        }

        [Route("Cadastrar")] //para acessar esse > Aluno/Cadastro
        public IActionResult Cadastrar(IFormCollection formulario)
        {
            Aluno aluno = new Aluno();
            //recebe os dados do formulário
            aluno.Nome = formulario["nomeAluno"];
            aluno.Email = formulario["emailAluno"];
            aluno.Endereco = formulario["enderecoAluno"];
            aluno.Telefone = formulario["telefoneAluno"];
            aluno.Escolaridade = formulario["escolaridadeAluno"];

            aluno.CadastrarAluno(aluno);

            return LocalRedirect("/");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection formulario)
        {
            Aluno aluno = new Aluno();
            //recebe os dados do formulário
            aluno.Id = int.Parse(formulario["idAluno"]);
            aluno.Nome = formulario["nomeAluno"];
            aluno.Email = formulario["emailAluno"];
            aluno.Endereco = formulario["enderecoAluno"];
            aluno.Telefone = formulario["telefoneAluno"];
            aluno.Escolaridade = formulario["escolaridadeAluno"];

            aluno.AtualizarAluno(aluno);

            return LocalRedirect("/");
        }

        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }

        [Route("~/Aluno/{id}")]
        public IActionResult Remover(int id)
        {
            alunoModel.RemoverAluno(id);

            return LocalRedirect("/Aluno");
        }

        [Route("~/Aluno/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            var listaRetornada = alunoModel.BuscarPorId(id);
            var alunoRetornado = listaRetornada.Find(aluno => aluno.Id == id);

            ViewBag.alunoRetornado = alunoRetornado;

            return View();
        }
    }
}
