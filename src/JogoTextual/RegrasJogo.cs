using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>
    /// Reúne regras simples que transformam ações em consequências sobre o estado.
    /// </summary>
    public class RegrasJogo
    {
        /// <summary>Aplica ao estado a consequência associada ao código informado.</summary>
        public void Aplicar(string codigoAcao, EstadoJogo estado)
        {
            if (codigoAcao == "1")
            {
                estado.AvancarProgresso();
                estado.Registrar("O progresso aumentou.");
                estado.AvancarTurno();
            }
            else if (codigoAcao == "2")
            {
                estado.Registrar("O turno passou sem aumento de progresso.");
                estado.AvancarTurno();
            }
            else if (codigoAcao == "0")
            {
                estado.Registrar("A partida foi encerrada.");
                estado.Encerrar();
            }
        }
    }
}
