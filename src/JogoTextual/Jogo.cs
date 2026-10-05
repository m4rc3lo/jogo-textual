using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>Coordena o ciclo principal do jogo textual.</summary>
    public class Jogo
    {
        private EstadoJogo estado = new EstadoJogo();
        private readonly InterfaceConsole interfaceConsole = new InterfaceConsole();
        private readonly RegrasJogo regras = new RegrasJogo();
        private readonly PersistenciaJogo persistencia = new PersistenciaJogo();

        private readonly List<AcaoJogo> acoes = new List<AcaoJogo>
        {
            new AcaoJogo("1", "Progredir"),
            new AcaoJogo("2", "Aguardar"),
            new AcaoJogo("8", "Salvar"),
            new AcaoJogo("9", "Carregar"),
            new AcaoJogo("0", "Encerrar o jogo")
        };

        /// <summary>Executa ciclos sucessivos até que o estado seja encerrado.</summary>
        public void Executar()
        {
            interfaceConsole.ExibirMensagem("Jogo Textual");

            while (!estado.Encerrado)
            {
                interfaceConsole.ExibirEstado(estado);
                interfaceConsole.ExibirAcoes(acoes);
                string codigoAcao = interfaceConsole.LerOpcaoValida(acoes);

                if (codigoAcao == "8")
                {
                    persistencia.Salvar(estado);
                    interfaceConsole.ExibirMensagem("Jogo salvo.");
                }
                else if (codigoAcao == "9")
                {
                    EstadoJogo? carregado = persistencia.Carregar();

                    if (carregado is null)
                    {
                        interfaceConsole.ExibirMensagem("Nenhum jogo salvo foi encontrado.");
                    }
                    else
                    {
                        estado = carregado;
                        interfaceConsole.ExibirMensagem("Jogo carregado.");
                    }
                }
                else
                {
                    regras.Aplicar(codigoAcao, estado);
                }
            }

            interfaceConsole.ExibirMensagem("Jogo encerrado.");
        }
    }
}
