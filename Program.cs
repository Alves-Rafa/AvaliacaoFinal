using System;

namespace AvaliacaoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem = string.Empty;
            string resultado = string.Empty;

            Funcionario colaborador1 = new FuncionarioProprio{
                Nome = "Rogério", 
                CargaHoraria = 220, 
                ValorHora = 32.50
            }; 

            Funcionario colaborador2 = new FuncionarioTerceirizado{
                Nome = "Clara",
                CargaHoraria = 220,
                ValorHora = 32.50,
                EmpresaOrigem = "Empresa Terceira Ltda",
                TaxaServico = 1.5
            };

            //Usuário informa se funcionário é terceirizado ou não.
            mensagem = "O funcionário é terceirizado? (s/n)";
            while(resultado != "s" || resultado != "n") 
            {
                Console.WriteLine(mensagem);
                resultado = Console.ReadLine().ToLower();
                if (resultado == "n") //Caso não seja funcionário próprio, imprima seu nome e seu salário
                {
                    Console.WriteLine("É Funcionário próprio");
                    colaborador1.retornaInfos();
                    break;                    
                }
                else if (resultado == "s")  //Caso seja funcionário terceirizado, imprima seu nome, sua empresa de origem e seu salário.
                {
                    Console.WriteLine("É Funcionário terceirizado");
                    colaborador2.retornaInfos();
                    break;
                }
                else
                {
                    Console.WriteLine("Digite s para Sim ou n para Não.");
                }
            }
                        
        }
    }

}
