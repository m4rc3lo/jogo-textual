using JogoTextual.Dominio;
using Xunit;

namespace JogoTextual.Tests;

public class RegrasJogoTests
{
    [Fact]
    public void Progredir_DeveAumentarProgressoAvancarTurnoERegistrar()
    {
        EstadoJogo estado = new EstadoJogo();
        RegrasJogo regras = new RegrasJogo();

        regras.Aplicar("1", estado);

        Assert.Equal(1, estado.Progresso);
        Assert.Equal(2, estado.Turno);
        Assert.Single(estado.Historico);
        Assert.Equal("O progresso aumentou.", estado.Historico[0].Descricao);
    }

    [Fact]
    public void Aguardar_DeveAvancarTurnoSemAumentarProgresso()
    {
        EstadoJogo estado = new EstadoJogo();
        RegrasJogo regras = new RegrasJogo();

        regras.Aplicar("2", estado);

        Assert.Equal(0, estado.Progresso);
        Assert.Equal(2, estado.Turno);
        Assert.Single(estado.Historico);
    }

    [Fact]
    public void Encerrar_DeveEncerrarERegistrarConsequencia()
    {
        EstadoJogo estado = new EstadoJogo();
        RegrasJogo regras = new RegrasJogo();

        regras.Aplicar("0", estado);

        Assert.True(estado.Encerrado);
        Assert.Single(estado.Historico);
    }
}
