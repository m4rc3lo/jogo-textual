using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>
    /// Coordena o ciclo principal do jogo textual.
    /// </summary>
    public class Jogo
    {
        private readonly EstadoJogo estado = new EstadoJogo();
        private readonly InterfaceConsole interfaceConsole = new InterfaceConsole();

        private readonly List<AcaoJogo> acoes = new List<AcaoJogo>
        {
            new AcaoJogo("1", "Avançar um turno"),
            new AcaoJogo("0", "Encerrar o jogo")
        };

        /// <summary>
        /// Executa ciclos sucessivos até que o estado seja encerrado.
        /// </summary>
        public void Executar()
        {
            interfaceConsole.ExibirMensagem("Jogo Textual");

            while (!estado.Encerrado)
            {
                interfaceConsole.ExibirEstado(estado);
                interfaceConsole.ExibirAcoes(acoes);

                string codigoAcao = interfaceConsole.LerOpcaoValida(acoes);

                if (codigoAcao == "1")
                {
                    estado.AvancarTurno();
                }
                else if (codigoAcao == "0")
                {
                    estado.Encerrar();
                }
            }

            interfaceConsole.ExibirMensagem("Jogo encerrado.");
        }
    }
}
