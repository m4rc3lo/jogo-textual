namespace JogoTextual.Dominio
{
    /// <summary>
    /// Registra um acontecimento associado a um turno da partida.
    /// </summary>
    public class RegistroJogo
    {
        /// <summary>Inicializa um registro.</summary>
        public RegistroJogo(int turno, string descricao)
        {
            Turno = turno;
            Descricao = descricao;
        }

        /// <summary>Obtém o turno em que o registro foi criado.</summary>
        public int Turno { get; }

        /// <summary>Obtém a descrição do acontecimento.</summary>
        public string Descricao { get; }
    }
}
