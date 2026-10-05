using JogoTextual;

namespace Main
{
    /// <summary>
    /// Define o ponto de entrada da aplicação de console do projeto-base.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Cria o jogo e inicia seu ciclo principal.
        /// </summary>
        public static void Main()
        {
            Jogo jogo = new Jogo();
            jogo.Executar();
        }
    }
}
