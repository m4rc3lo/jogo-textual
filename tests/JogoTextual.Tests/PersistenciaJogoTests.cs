using JogoTextual.Dominio;
using Xunit;

namespace JogoTextual.Tests;

public class PersistenciaJogoTests
{
    [Fact]
    public void SalvarECarregar_DevePreservarEstado()
    {
        string caminho = Path.Combine(Path.GetTempPath(), $"jogo-textual-{Guid.NewGuid()}.json");

        try
        {
            EstadoJogo original = new EstadoJogo();
            original.AvancarProgresso();
            original.Registrar("Registro persistido.");
            original.AvancarTurno();

            PersistenciaJogo persistencia = new PersistenciaJogo(caminho);
            persistencia.Salvar(original);

            EstadoJogo? carregado = persistencia.Carregar();

            Assert.NotNull(carregado);
            Assert.Equal(original.Turno, carregado.Turno);
            Assert.Equal(original.Progresso, carregado.Progresso);
            Assert.Single(carregado.Historico);
            Assert.Equal("Registro persistido.", carregado.Historico[0].Descricao);
        }
        finally
        {
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
            }
        }
    }

    [Fact]
    public void Carregar_SemArquivo_DeveRetornarNull()
    {
        string caminho = Path.Combine(Path.GetTempPath(), $"jogo-textual-{Guid.NewGuid()}.json");
        PersistenciaJogo persistencia = new PersistenciaJogo(caminho);

        EstadoJogo? carregado = persistencia.Carregar();

        Assert.Null(carregado);
    }
}
