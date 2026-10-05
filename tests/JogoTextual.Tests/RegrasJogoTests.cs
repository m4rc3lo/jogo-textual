using JogoTextual.Dominio;
using Xunit;

namespace JogoTextual.Tests;

public class RegrasJogoTests
{
    [Fact]
    public void Progredir_DeveAumentarProgressoEAvancarTurno()
    {
        EstadoJogo estado = new EstadoJogo();
        RegrasJogo regras = new RegrasJogo();

        regras.Aplicar("1", estado);

        Assert.Equal(1, estado.Progresso);
        Assert.Equal(2, estado.Turno);
    }

    [Fact]
    public void Aguardar_DeveSomenteAvancarTurno()
    {
        EstadoJogo estado = new EstadoJogo();
        RegrasJogo regras = new RegrasJogo();

        regras.Aplicar("2", estado);

        Assert.Equal(0, estado.Progresso);
        Assert.Equal(2, estado.Turno);
    }
}
