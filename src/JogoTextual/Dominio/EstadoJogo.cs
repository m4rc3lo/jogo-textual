namespace JogoTextual.Dominio
{
    /// <summary>
    /// Representa informações mutáveis que descrevem a situação atual do jogo.
    /// </summary>
    public class EstadoJogo
    {
        /// <summary>Obtém o número do turno atual.</summary>
        public int Turno { get; private set; } = 1;

        /// <summary>Obtém o progresso acumulado durante a partida.</summary>
        public int Progresso { get; private set; }

        /// <summary>Obtém um valor que indica se a execução foi encerrada.</summary>
        public bool Encerrado { get; private set; }

        /// <summary>Obtém o histórico de acontecimentos da partida.</summary>
        public List<RegistroJogo> Historico { get; private set; } = new List<RegistroJogo>();

        /// <summary>Avança a contagem para o próximo turno.</summary>
        public void AvancarTurno() => Turno++;

        /// <summary>Acrescenta uma unidade ao progresso.</summary>
        public void AvancarProgresso() => Progresso++;

        /// <summary>Marca o estado como encerrado.</summary>
        public void Encerrar() => Encerrado = true;

        /// <summary>Adiciona uma descrição ao histórico usando o turno atual.</summary>
        public void Registrar(string descricao)
        {
            Historico.Add(new RegistroJogo(Turno, descricao));
        }
    }
}
