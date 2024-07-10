public class FuncionarioTempoIntegral : Funcionario, IBonus //herenca
    {
        private double SalarioMensal { get; set; }

        public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal)
            : base(nome, matricula)
        {
            SalarioMensal = salarioMensal;
        }

        public override double CalcularSalario()
        {
            return SalarioMensal;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário Mensal: {SalarioMensal}");
        }

        public double CalcularBonus()
        {
            return SalarioMensal * 0.10;
        }
    }
