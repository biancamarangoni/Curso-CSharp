using MVCRazorCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Interfaces
{
    interface IProfessor
    {
        public Professor CadastrarProf(Professor professor);
        List<Professor> ListarProf();
        List<Professor> BuscarPorId(int id);
        void RemoverProf(int id);
        void AtualizarProf(Professor professor);
    }
}
