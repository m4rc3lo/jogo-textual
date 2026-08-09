# Começando

Este guia mostra como preparar o ambiente e executar o projeto-base pela primeira vez.

A disciplina é introdutória. Você não precisa conhecer toda a estrutura do .NET antes de começar. Nesta etapa, o objetivo é reconhecer onde estão a aplicação e os testes e aprender os comandos básicos usados durante o semestre.

## Requisitos

Você precisa de:

- Git;
- SDK do .NET 9 ou do .NET 10;
- um terminal;
- um editor de código.

O Visual Studio Code é recomendado por ser leve e funcionar em diferentes sistemas operacionais, mas não é obrigatório. Os comandos apresentados neste projeto são executados pelo terminal e não dependem de uma IDE específica.

O laboratório da disciplina possui .NET 9. Por esse motivo, o projeto usa `net9.0` como versão mínima de destino. Em máquinas com SDK mais recente, como o .NET 10, o mesmo projeto também pode ser desenvolvido e compilado.

## Verificando o .NET

Na raiz do repositório, execute:

```powershell
dotnet --version
```

Para visualizar todos os SDKs instalados:

```powershell
dotnet --list-sdks
```

O arquivo `global.json` informa que o projeto aceita um SDK a partir da família 9 e permite avançar para uma versão principal mais recente instalada.

É importante distinguir duas ideias:

- **SDK**: ferramentas usadas para restaurar, compilar, testar e executar o projeto;
- **Target Framework**: conjunto de APIs para o qual o projeto é compilado.

Neste projeto, o alvo é `net9.0` para manter compatibilidade com o laboratório. O SDK 10 pode ser usado quando estiver disponível.

## Estrutura inicial

A solução contém dois projetos:

```text
JogoTextual.sln
│
├── src/
│   └── JogoTextual/
│       └── aplicação Console
│
└── tests/
    └── JogoTextual.Tests/
        └── testes automatizados
```

Uma **Solution** (`.sln`) organiza projetos relacionados.

Um **Project** (`.csproj`) descreve uma aplicação ou biblioteca .NET e suas configurações.

Neste repositório:

- `src/` contém o código da aplicação;
- `tests/` contém código usado para verificar automaticamente o comportamento da aplicação.

Manter essas duas responsabilidades separadas facilita a leitura e a evolução do projeto.

## Restaurando dependências

Execute:

```powershell
dotnet restore
```

Esse comando verifica os projetos da solução e obtém as dependências necessárias.

## Compilando

Execute:

```powershell
dotnet build
```

Compilar significa transformar o código-fonte em uma forma que o .NET possa executar e, ao mesmo tempo, verificar diversos erros de sintaxe e de tipos.

## Executando os testes

Execute:

```powershell
dotnet test
```

Nesta etapa existe apenas um teste simples. Ele serve para confirmar que a infraestrutura de testes com xUnit está configurada.

## Executando a aplicação

Execute:

```powershell
dotnet run --project src/JogoTextual
```

A saída esperada é:

```text
Projeto-base Jogo Textual configurado.
```

O arquivo `src/JogoTextual/Program.cs` contém explicitamente a classe `Main.Program` e o método `Main()`. Esse método é o ponto de entrada da aplicação: é por ele que a execução começa.

## Sequência recomendada

Durante as primeiras atividades, uma sequência segura é:

```text
restaurar → compilar → testar → executar
```

Em comandos:

```powershell
dotnet restore
dotnet build
dotnet test
dotnet run --project src/JogoTextual
```

Quando uma etapa falhar, leia a mensagem apresentada no terminal antes de seguir para a próxima. Aprender a interpretar mensagens de compilação e de teste faz parte do processo de programação.
