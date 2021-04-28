using System;

namespace AvaliacaoFinal
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public string EmpresaOrigem {get; set;}
        public double TaxaServico {get; set;}

        public FuncionarioTerceirizado()
        {

        }

         public FuncionarioTerceirizado(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico) 
            : base (nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }

        public override double calculaSalario(double valorHora, int cargaHoraria)
        {
            double resultado = base.calculaSalario(valorHora, cargaHoraria);
            resultado += adicionaTaxaServico(resultado);
            return resultado;
        }

        public override void retornaInfos()
        {
            Console.WriteLine("Empresa: " + EmpresaOrigem);
            base.retornaInfos();                        
        }
        
        private double adicionaTaxaServico(double valor)
        {
            return (valor * TaxaServico)/100;
        }
    }
}