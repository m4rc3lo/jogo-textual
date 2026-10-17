# Jogo Textual

Projeto-base didático da disciplina de **Lógica de Programação** do curso de **Design de Games**.

O projeto apresenta um jogo textual em C#/.NET com estado, ações, regras, ciclo principal, coleção de objetos, persistência em JSON e testes automatizados. A implementação é propositalmente pequena: o objetivo é servir como base de estudo e adaptação, e não como um jogo completo.

## Para começar

Requisitos principais:

- SDK .NET 9 ou posterior;
- terminal PowerShell no Windows;
- Visual Studio Code com suporte a C#.

Na raiz do repositório:

```powershell
dotnet restore
dotnet build
dotnet test
dotnet run --project src/JogoTextual
```

Durante a execução, as ações demonstrativas permitem progredir, aguardar, salvar, carregar e encerrar a partida.

Para a preparação detalhada do ambiente, consulte [Começando](docs/getting-started.md).

## Estude antes de adaptar

A sequência recomendada é:

1. execute o projeto sem alterações;
2. leia `Program.cs` e acompanhe a criação de `Jogo`;
3. identifique onde ficam estado, ações, regras, interface e persistência;
4. execute os testes;
5. consulte a documentação da arquitetura;
6. somente depois adapte o projeto à proposta do grupo.

O guia [Como estudar com este projeto](docs/how-to-study.md) detalha esse processo.

## Estrutura principal

```text
src/JogoTextual/
├── Program.cs
├── Jogo.cs
├── InterfaceConsole.cs
├── RegrasJogo.cs
├── PersistenciaJogo.cs
└── Dominio/
    ├── AcaoJogo.cs
    ├── EstadoJogo.cs
    └── RegistroJogo.cs

tests/JogoTextual.Tests/
└── testes do estado, regras, histórico e persistência
```

As responsabilidades e relações entre essas classes estão explicadas em [Arquitetura atual](docs/arquitetura.md).

## Ideia central

O jogo não é apenas a sequência de textos mostrados no console. Ele é um sistema de estados, ações, regras e transições.

```text
estado atual
→ apresentar ações
→ receber uma escolha válida
→ aplicar uma regra
→ produzir consequências
→ atualizar o estado
→ verificar encerramento
→ repetir
```

A interface atual é o console. Os grupos podem adaptar o domínio sem precisar introduzir interface gráfica ou motor de jogos.

## O que deve ser adaptado

Os exemplos `Progresso`, `Progredir` e `Aguardar` são demonstrativos. Eles não definem o gênero do projeto.

Cada grupo deve revisar os dados do estado, as ações, regras, consequências, coleção, condição de encerramento, persistência e testes.

Use [Guia de adaptação do projeto-base](docs/adaptacao-projeto.md) como roteiro.

## Documentação

A documentação publicada está disponível em:

**https://m4rc3lo.github.io/jogo-textual/**

Ela reúne os textos conceituais, diagramas Mermaid e a documentação de API gerada a partir dos comentários XML do código.

Para gerar localmente:

```powershell
dotnet tool restore
dotnet tool run docfx docfx.json
```

O resultado é gravado em `_site/`.

## Testes

Os testes usam xUnit e devem ser executados sempre que o projeto for alterado:

```powershell
dotnet test
```

Ao adaptar o projeto, os testes existentes devem ser atualizados ou complementados para representar as novas regras.

## Uso de IA generativa

Ferramentas de IA generativa podem ser usadas como apoio, desde que o uso seja transparente e o grupo compreenda, revise e teste o que incorporar ao projeto.

Consulte [Uso de IA generativa no projeto](docs/uso-ia-generativa.md).

## Automação

O repositório utiliza GitHub Actions em dois fluxos separados:

- `.github/workflows/ci.yml`: restaura dependências, compila e executa os testes;
- `.github/workflows/pages.yml`: valida o projeto, gera a documentação com DocFX e publica no GitHub Pages.

## Compatibilidade

O projeto tem como alvo `net9.0` para manter compatibilidade com o ambiente de laboratório da disciplina. O `global.json` permite roll-forward para SDKs posteriores, incluindo .NET 10.

## Licença e citação

O material é disponibilizado sob a [Apache License 2.0](LICENSE). Consulte também [NOTICE](NOTICE) e [CITATION.cff](CITATION.cff).

O repositório é mantido como material didático. Não há compromisso de manutenção de contribuições externas; consulte [CONTRIBUTING.md](CONTRIBUTING.md).
