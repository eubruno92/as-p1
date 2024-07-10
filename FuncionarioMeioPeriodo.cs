 public class FuncionarioMeioPeriodo : Funcionario, IBonus //heranca
    {
        private double SalarioPorHora { get; set; }
        private int HorasTrabalhadas { get; set; }

        public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int horasTrabalhadas)
            : base(nome, matricula)
        {
            SalarioPorHora = salarioPorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public override double CalcularSalario()
        {
            return SalarioPorHora * HorasTrabalhadas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário por Hora: {SalarioPorHora}, Horas Trabalhadas: {HorasTrabalhadas}");
        }

        public double CalcularBonus()
        {
            return CalcularSalario() * 0.05;
        }
    }