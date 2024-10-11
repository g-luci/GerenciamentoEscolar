using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEscolar
{
    internal class Turma
    {
        public string Codigo { get; private set; }
        public Disciplina Disciplina { get; private set; }
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();

        public Turma(string codigo, Disciplina disciplina) 
        { 
            Codigo = codigo;
            Disciplina = disciplina;

        }

        public void adicionarAluno(Aluno aluno) 
        { 
            Alunos.Add(aluno);
        }

        public void removerAluno(int matricula) 
        {
            int search = Alunos.FindIndex(x => x.Matricula == matricula);
            Alunos.Remove(Alunos[search]);
        }

        public Aluno buscarAlunoPorMatricula(int matricula) 
        {
            int search = Alunos.FindIndex(x => x.Matricula == matricula);
            return Alunos[search];
        }

        public List<Aluno> listarAlunos() 
        {
            return Alunos;
        }
    }
}
