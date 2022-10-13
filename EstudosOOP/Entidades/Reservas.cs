using EstudosOOP.Entidades.Exceções;
namespace EstudosOOP.Entidades
{
    internal class Reservas
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservas(int NumeroQuarto, DateTime CheckIn, DateTime CheckOut)
        {

            DateTime dataAgora = DateTime.Now;

            // Classe DominioException criada para tratamento de exceções expecíficas.
            if (CheckIn < dataAgora || CheckOut < dataAgora)
            {
                throw new DominioException("Para fazer a reserva, a data deve ser futura!");
            }
            else if (CheckOut <= CheckIn)
            {
                throw new DominioException("A data de saída deve ser após a data de entrada!");
            }
            else {
                this.NumeroQuarto = NumeroQuarto;
                this.CheckIn = CheckIn;
                this.CheckOut = CheckOut;
            }            
        }

        public Reservas()
        {
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void AtualizarDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime dataAgora = DateTime.Now;

            if (checkIn < dataAgora || checkOut < dataAgora)
            {
                throw new DominioException("Para atualizar as datas elas devem ser datas futuras!");
            }
            else if (checkOut <= checkIn)
            {
                throw new DominioException("A data de saída deve ser após a data de entrada!");
            }
            else
            {
                this.CheckOut = checkOut;
                this.CheckIn = checkIn;
            }
        }

        public override string ToString()
        {
            return $"Quarto: {NumeroQuarto}," +
                $" check-in: {CheckIn.ToString("dd/MM/yyyy")}, " +
                $" check-out: {CheckOut.ToString("dd/MM/yyyy")}, " +
                $"{Duracao()} noite(s).";
        }
    }
}
