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

O repositório está no **Incremento 02 — solução .NET mínima**.

Nesta etapa, a solução possui somente:

- uma aplicação Console em `src/JogoTextual`;
- um projeto de testes xUnit em `tests/JogoTextual.Tests`;
- uma mensagem mínima de execução;
- um teste simples para verificar a infraestrutura de testes.

Ainda não existe modelo de jogo: não há `Jogo`, `Jogador`, estados, ações, regras ou persistência.

A solução utiliza o target framework `net10.0`. A versão exata do SDK será padronizada em uma etapa posterior.

## Restaurar, compilar, testar e executar

Na raiz do repositório:

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

## Licença

Este projeto é disponibilizado sob a [Apache License 2.0](LICENSE). Consulte também o arquivo [NOTICE](NOTICE).
