using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
     class Program
    {
        static void Main(string[] args)
        {
            //Instanciando (criando) um projeto do tipo Professor
            Professor prof1 = new Professor(
                nome: "Ana Souza",
                cpf:"123.456.789-00",
                email: "anasouza@gmail.com",
                registro: "PROF-2026-042",
                titulo: "Doutora",
                departamento: "Ciência da Computação"
            );

            // Utilizado os  comportamentos
            prof1.MinistrarAula("Estrutura de Dados");
                prof1.LacrarNotas("Estruturas de Dado");
        }
    }
}
