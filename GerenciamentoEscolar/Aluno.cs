using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEscolar
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }

        public Aluno(string nome, int matricula, string email)
        {
            Nome= nome;
            Matricula= matricula;
            Email= email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \nMatricula: {Matricula} \nEmail:{Email} \n--------------------------------------------";
        }
    }
}
