# Changelog

Todas as mudanças relevantes deste projeto serão registradas neste arquivo.

O formato segue os princípios do [Keep a Changelog](https://keepachangelog.com/pt-BR/1.1.0/). O projeto adotará versionamento explícito na primeira versão estável destinada aos estudantes.

## [Não publicado]

Nenhuma alteração registrada após a versão `student-base-v1.0.0`.

## [1.0.0] - 2026-10-17

### Adicionado

- solução .NET com aplicação Console e projeto de testes xUnit;
- configuração didática para .NET 9/10 e Visual Studio Code;
- integração contínua com GitHub Actions;
- documentação com DocFX e publicação no GitHub Pages;
- guias de ambiente, estudo e adaptação;
- tipos de domínio `EstadoJogo`, `AcaoJogo` e `RegistroJogo`;
- ciclo principal coordenado por `Jogo`;
- interação textual em `InterfaceConsole`;
- regras demonstrativas em `RegrasJogo`;
- histórico como coleção de objetos;
- persistência local do estado com JSON;
- testes automatizados de estado, regras, histórico e persistência;
- diretrizes públicas de uso de IA generativa;
- documentação consolidada da arquitetura com diagramas Mermaid;
- README orientado ao onboarding dos estudantes.

### Alterado

- documentação reorganizada para acompanhar a evolução real do código;
- navegação do DocFX consolidada em um único `toc.yml` na raiz;
- projeto-base mantido genérico, sem impor gênero de jogo.

### Removido

- diretório auxiliar `scripts/`, que permaneceu sem uso após a decisão de não adicionar automações artificiais em Ruby.
