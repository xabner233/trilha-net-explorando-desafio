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
            try
            {
                if (Suite.Capacidade >= hospedes.Count)
                {

                    Hospedes = hospedes;

                }
                else
                {
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"O numero de pessoas nao pode ser maior que a capacidade da suite; {ex.Message}");
            }
           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int count = Hospedes.Count;
            return count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = 0;

            valor = Suite.ValorDiaria* DiasReservados;
           
            if (DiasReservados >= 10)
            {
                decimal porc = 10;
                decimal desconto = valor * porc / 100;
                valor = valor - desconto;


            }

            return valor;
        }
    }
}