using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{

    public class Professor
    {
       //Propriedades (Atributos encapsulados)
       public string Nome { get;private set; }
       public string Cpf { get;private set; }
       public string Email { get; set; }
       public string Registro { get;private set; }
       public string Titulo { get; set; }
       public string Departamento { get; set; }

        // Construtor para garantir a inicialização de dados obrigatórios 
        public Professor(string nome, string cpf, string email, string registro, string titulo, string departamento)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Registro = registro;
            Titulo = titulo;
            Departamento = departamento;
        }

        // Comportamento / Ação do Professor
        public void MinistrarAula(string disciplina)
        {
            Console.WriteLine($"O(A) professor(a) {Nome} está ministrando aula da disciplina {disciplina}.");
        }

        // Outro comportamento comum no sistema acadêmico
        public void LacrarNotas(string disciplina)
        {
            Console.WriteLine($"O(A) professor(a) {Nome} acessou o sistema para lacrar nota.");
        }
    }
}
