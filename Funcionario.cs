using System;

namespace AvaliacaoFinal
{
    public class Funcionario
    {
        private string _nome;
        public int CargaHoraria {get; set;}
        public double ValorHora {get; set;}

        public string Nome
        {
            get{return _nome;}
            set{
                if (value.Length < 3)
                {
                    Console.WriteLine("Erro: Nome inválido");
                }
                else
                {
                    _nome = value;
                };
               }
        }

        public Funcionario()
        {
            
        }

        //Sobrecarga
        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            _nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }
        public virtual double calculaSalario(double valorHora, int cargaHoraria)
        {
            return valorHora * cargaHoraria;
        }

        public virtual void retornaInfos()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Salário: R$" + calculaSalario(ValorHora, CargaHoraria).ToString("F2"));
        }
    }
}