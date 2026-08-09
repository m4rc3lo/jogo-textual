# Jogo Textual

Projeto-base didático em construção para a disciplina de **Lógica de Programação**, oferecida no curso de **Design de Games**.

O repositório será usado para desenvolver, de forma progressiva, um jogo textual executado em terminal ou console. O objetivo é apoiar o estudo de lógica, estados, ações, regras, organização de código, testes e documentação sem introduzir complexidade desnecessária para uma disciplina introdutória.

## Tecnologias previstas

- C# e .NET;
- xUnit;
- DocFX;
- Markdown e Mermaid;
- GitHub Actions;
- GitHub Pages;
- Ruby para eventuais scripts auxiliares.

## Estado atual

O repositório está no **Incremento 04 — integração contínua básica**.

A solução possui:

- uma aplicação Console em `src/JogoTextual`;
- um projeto de testes xUnit em `tests/JogoTextual.Tests`;
- configuração mínima para Visual Studio Code;
- convenções editoriais básicas;
- um guia inicial de preparação do ambiente;
- validação automática de compilação e testes com GitHub Actions.

O projeto usa `net9.0` como alvo para manter compatibilidade com o laboratório da disciplina. O `global.json` permite utilizar SDKs .NET 9 ou posteriores, incluindo .NET 10.

Ainda não existe modelo de jogo: não há `Jogo`, `Jogador`, estados, ações, regras ou persistência.

## Começando

As instruções detalhadas para preparar o ambiente estão em [docs/getting-started.md](docs/getting-started.md).

Na raiz do repositório, o fluxo básico é:

```powershell
dotnet restore
dotnet build
dotnet test
dotnet run --project src/JogoTextual
```

A execução deve apresentar:

```text
Projeto-base Jogo Textual configurado.
```

## Integração contínua

O workflow `.github/workflows/ci.yml` executa automaticamente a restauração das dependências, a compilação em configuração `Release` e os testes em todo `push` ou Pull Request direcionado à branch `main`.

Nesta etapa, a automação serve apenas para **validar o projeto**. Ainda não há publicação de documentação ou GitHub Pages.

## Licença

Este projeto é disponibilizado sob a [Apache License 2.0](LICENSE). Consulte também o arquivo [NOTICE](NOTICE).
