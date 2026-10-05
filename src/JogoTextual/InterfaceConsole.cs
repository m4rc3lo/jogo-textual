using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>Centraliza a entrada e a saída de texto realizadas pelo console.</summary>
    public class InterfaceConsole
    {
        /// <summary>Exibe uma mensagem no console.</summary>
        public void ExibirMensagem(string mensagem) => Console.WriteLine(mensagem);

        /// <summary>Exibe informações resumidas do estado atual.</summary>
        public void ExibirEstado(EstadoJogo estado)
        {
            Console.WriteLine();
            Console.WriteLine($"Turno atual: {estado.Turno}");
            Console.WriteLine($"Progresso: {estado.Progresso}");

            if (estado.Historico.Count > 0)
            {
                RegistroJogo ultimo = estado.Historico[^1];
                Console.WriteLine($"Último registro: turno {ultimo.Turno} — {ultimo.Descricao}");
            }
        }

        /// <summary>Exibe as ações disponíveis.</summary>
        public void ExibirAcoes(IReadOnlyList<AcaoJogo> acoes)
        {
            foreach (AcaoJogo acao in acoes)
            {
                Console.WriteLine($"{acao.Codigo} - {acao.Descricao}");
            }
        }

        /// <summary>Lê repetidamente até receber o código de uma ação disponível.</summary>
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
