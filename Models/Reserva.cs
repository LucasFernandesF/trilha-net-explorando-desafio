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
            // *IMPLEMENTE AQUI*
            Hospedes = hospedes;
            if (Suite.Capacidade >= Hospedes.Count())
            {
                Console.WriteLine("Os seguintes hospedes foram cadastrados na suite: ");
                foreach (var hospede in Hospedes)
                {
                    Console.WriteLine(hospede.Nome);
                }
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                Console.WriteLine("A suite não suporta essa capacidade de pessoas");


            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            if (Suite.Capacidade >= Hospedes.Count())
            {
                return Hospedes.Count;
            }
            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= Hospedes.Count())
            {
                if (DiasReservados >= 10)
                {
                    return valor = valor - (valor * 10 / 100);
                }
                return valor;
            }
            return 0;
        }
    }
}