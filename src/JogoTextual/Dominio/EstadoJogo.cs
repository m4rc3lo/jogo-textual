namespace JogoTextual.Dominio
{
    /// <summary>
    /// Representa informações mutáveis que descrevem a situação atual do jogo.
    /// </summary>
    public class EstadoJogo
    {
        /// <summary>
        /// Obtém o número do turno atual.
        /// </summary>
        public int Turno { get; private set; } = 1;

        /// <summary>
        /// Obtém um valor que indica se a execução do jogo foi encerrada.
        /// </summary>
        public bool Encerrado { get; private set; }

        /// <summary>
        /// Avança a contagem para o próximo turno.
        /// </summary>
        public void AvancarTurno()
        {
            Turno++;
        }

        /// <summary>
        /// Marca o estado como encerrado.
        /// </summary>
        public void Encerrar()
        {
            Encerrado = true;
        }
    }
}
