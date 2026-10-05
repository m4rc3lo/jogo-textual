using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>
    /// Centraliza a entrada e a saída de texto realizadas pelo console.
    /// </summary>
    public class InterfaceConsole
    {
        /// <summary>
        /// Exibe uma mensagem no console.
        /// </summary>
        /// <param name="mensagem">Mensagem a ser apresentada.</param>
        public void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        /// <summary>
        /// Exibe informações resumidas do estado atual.
        /// </summary>
        /// <param name="estado">Estado que será apresentado.</param>
        public void ExibirEstado(EstadoJogo estado)
        {
            Console.WriteLine();
            Console.WriteLine($"Turno atual: {estado.Turno}");
            Console.WriteLine($"Progresso: {estado.Progresso}");
        }

        /// <summary>
        /// Exibe as ações disponíveis.
        /// </summary>
        /// <param name="acoes">Coleção de ações que podem ser escolhidas.</param>
        public void ExibirAcoes(IReadOnlyList<AcaoJogo> acoes)
        {
            foreach (AcaoJogo acao in acoes)
            {
                Console.WriteLine($"{acao.Codigo} - {acao.Descricao}");
            }
        }

        /// <summary>
        /// Lê repetidamente até receber o código de uma ação disponível.
        /// </summary>
        /// <param name="acoes">Coleção de ações válidas.</param>
        /// <returns>Código de uma ação existente na coleção.</returns>
        public string LerOpcaoValida(IReadOnlyList<AcaoJogo> acoes)
        {
            while (true)
            {
                Console.Write("Ação: ");
                string entrada = Console.ReadLine()?.Trim() ?? string.Empty;

                foreach (AcaoJogo acao in acoes)
                {
                    if (entrada == acao.Codigo)
                    {
                        return entrada;
                    }
                }

                Console.WriteLine("Opção inválida. Escolha um dos códigos apresentados.");
            }
        }
    }
}
