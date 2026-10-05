using JogoTextual.Dominio;
using Xunit;

namespace JogoTextual.Tests;

public class HistoricoTests
{
    [Fact]
    public void Registrar_DeveAdicionarRegistroComTurnoAtual()
    {
        EstadoJogo estado = new EstadoJogo();

        estado.Registrar("Evento de teste.");

        Assert.Single(estado.Historico);
        Assert.Equal(1, estado.Historico[0].Turno);
        Assert.Equal("Evento de teste.", estado.Historico[0].Descricao);
    }
}
