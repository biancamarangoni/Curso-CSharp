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
        [Route("Aluno")]
        public IActionResult Index()
        {
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

            return View();
        }

        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
