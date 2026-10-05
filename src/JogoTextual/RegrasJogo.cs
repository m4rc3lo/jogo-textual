using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>
    /// Reúne regras simples que transformam ações em consequências sobre o estado.
    /// </summary>
    public class RegrasJogo
    {
        /// <summary>
        /// Aplica ao estado a consequência associada ao código informado.
        /// </summary>
        /// <param name="codigoAcao">Código de uma ação válida.</param>
        /// <param name="estado">Estado que será alterado.</param>
        public void Aplicar(string codigoAcao, EstadoJogo estado)
        {
            if (codigoAcao == "1")
            {
                estado.AvancarProgresso();
                estado.AvancarTurno();
            }
            else if (codigoAcao == "2")
            {
                estado.AvancarTurno();
            }
            else if (codigoAcao == "0")
            {
                estado.Encerrar();
            }
        }
    }
}
