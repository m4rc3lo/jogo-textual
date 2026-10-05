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

O repositório está no **Incremento 08 — domínio mínimo do jogo**.

A solução possui:

- uma aplicação Console em `src/JogoTextual`;
- um projeto de testes xUnit em `tests/JogoTextual.Tests`;
- configuração mínima para Visual Studio Code;
- convenções editoriais básicas;
- um guia inicial de preparação do ambiente;
- validação automática de compilação e testes com GitHub Actions;
- documentação conceitual e de API gerada com DocFX;
- publicação automática da documentação no GitHub Pages;
- um guia de estudo para orientar leitura, execução, modificação e teste do projeto;
- os primeiros tipos de domínio: `EstadoJogo` e `AcaoJogo`.

O projeto usa `net9.0` como alvo para manter compatibilidade com o laboratório da disciplina. O `global.json` permite utilizar SDKs .NET 9 ou posteriores, incluindo .NET 10.

O domínio inicial contém apenas estado e representação de ações. Ainda não existe a classe coordenadora `Jogo`, nem regras específicas, persistência ou estruturas associadas a um gênero.

## Começando

As instruções detalhadas para preparar o ambiente estão em [docs/getting-started.md](docs/getting-started.md). Para orientar o estudo incremental do código, consulte também [docs/how-to-study.md](docs/how-to-study.md).

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

O workflow de CI continua responsável pela validação de build e testes. A publicação da documentação é realizada separadamente pelo workflow `.github/workflows/pages.yml`.

## Gerando a documentação localmente

O DocFX é registrado como uma ferramenta local do repositório. Na primeira utilização, restaure a ferramenta:

```powershell
dotnet tool restore
```

Depois gere o site estático:

```powershell
dotnet tool run docfx docfx.json
```

Os arquivos resultantes são gravados em `_site/`. Para visualizar o site em um servidor local:

```powershell
dotnet tool run docfx docfx.json --serve
```

O site combina a documentação conceitual escrita em Markdown com a documentação da API C# gerada pelo DocFX.

## Publicação da documentação

O workflow `.github/workflows/pages.yml` é executado em todo `push` para `main` ou manualmente pela aba Actions. Antes de publicar, ele restaura as dependências, compila, executa os testes, restaura o DocFX e gera `_site/`.

Somente o conteúdo de `_site/` é enviado como artefato para o GitHub Pages.

Para a primeira publicação, o repositório deve estar configurado em **Settings → Pages → Build and deployment → Source → GitHub Actions**. Depois dessa configuração, novas alterações em `main` publicam automaticamente a documentação quando o workflow termina com sucesso.

## Licença

Este projeto é disponibilizado sob a [Apache License 2.0](LICENSE). Consulte também o arquivo [NOTICE](NOTICE).
