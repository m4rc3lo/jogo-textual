namespace JogoTextual.Dominio
{
    /// <summary>
    /// Representa uma ação que pode ser apresentada como escolha ao jogador.
    /// </summary>
    public class AcaoJogo
    {
        /// <summary>
        /// Inicializa uma ação com um código e uma descrição.
        /// </summary>
        /// <param name="codigo">Código digitado para selecionar a ação.</param>
        /// <param name="descricao">Texto que descreve a ação.</param>
        public AcaoJogo(string codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        /// <summary>
        /// Obtém o código usado para selecionar a ação.
        /// </summary>
        public string Codigo { get; }

        /// <summary>
        /// Obtém a descrição apresentada ao jogador.
        /// </summary>
        public string Descricao { get; }
    }
}
