using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>
    /// Coordena o ciclo principal do jogo textual.
    /// </summary>
    public class Jogo
    {
        private readonly EstadoJogo estado = new EstadoJogo();

        /// <summary>
        /// Executa ciclos sucessivos até que o estado seja encerrado.
        /// </summary>
        public void Executar()
        {
            Console.WriteLine("Jogo Textual");
            Console.WriteLine("Use 1 para avançar um turno ou 0 para encerrar.");

            while (!estado.Encerrado)
            {
                Console.WriteLine();
                Console.WriteLine($"Turno atual: {estado.Turno}");
                Console.Write("Ação: ");

                string? entrada = Console.ReadLine();

                if (entrada == "1")
                {
                    estado.AvancarTurno();
                }
                else if (entrada == "0")
                {
                    estado.Encerrar();
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }

            Console.WriteLine("Jogo encerrado.");
        }
    }
}
