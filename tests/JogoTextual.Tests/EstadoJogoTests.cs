using JogoTextual.Dominio;
using Xunit;

namespace JogoTextual.Tests;

public class EstadoJogoTests
{
    [Fact]
    public void NovoEstado_DeveComecarNoPrimeiroTurnoENaoEncerrado()
    {
        EstadoJogo estado = new EstadoJogo();

        Assert.Equal(1, estado.Turno);
        Assert.False(estado.Encerrado);
    }

    [Fact]
    public void AvancarTurno_DeveIncrementarTurno()
    {
        EstadoJogo estado = new EstadoJogo();

        estado.AvancarTurno();

        Assert.Equal(2, estado.Turno);
    }

    [Fact]
    public void Encerrar_DeveMarcarEstadoComoEncerrado()
    {
        EstadoJogo estado = new EstadoJogo();

        estado.Encerrar();

        Assert.True(estado.Encerrado);
    }
}
