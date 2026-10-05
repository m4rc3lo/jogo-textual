using System.Text.Json;
using JogoTextual.Dominio;

namespace JogoTextual
{
    /// <summary>Salva e carrega o estado do jogo em formato JSON.</summary>
    public class PersistenciaJogo
    {
        private readonly string caminhoArquivo;

        /// <summary>Inicializa a persistência usando o caminho informado.</summary>
        public PersistenciaJogo(string caminhoArquivo = "savegame.json")
        {
            this.caminhoArquivo = caminhoArquivo;
        }

        /// <summary>Serializa o estado e grava o arquivo JSON.</summary>
        public void Salvar(EstadoJogo estado)
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = false
            };

            string json = JsonSerializer.Serialize(estado, opcoes);
            File.WriteAllText(caminhoArquivo, json);
        }

        /// <summary>Carrega o estado salvo ou retorna null se o arquivo não existir.</summary>
        public EstadoJogo? Carregar()
        {
            if (!File.Exists(caminhoArquivo))
            {
                return null;
            }

            string json = File.ReadAllText(caminhoArquivo);
            return JsonSerializer.Deserialize<EstadoJogo>(json);
        }
    }
}
