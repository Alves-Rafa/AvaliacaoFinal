namespace AvaliacaoFinal
{
    public class FuncionarioProprio : Funcionario
    {
        
        public FuncionarioProprio()
        {

        }

        public FuncionarioProprio(string nome, int cargaHoraria, double valorHora)
            : base (nome, cargaHoraria, valorHora) {}
    }
}