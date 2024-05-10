namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            int qtdHospedes = hospedes.Count;
            int qtdSuite = Suite.Capacidade;
            var resultado = qtdHospedes <= qtdSuite ? Hospedes = hospedes : throw new Exception($"Olá! Infelizmente esta suíte possui limitação para no máximo {qtdSuite} hóspedes.");

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valorDaDiaria = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            var diaria = DiasReservados >= 10 ? valorDaDiaria * 0.90M : valorDaDiaria;
            return diaria;
           
        }
    }
}
