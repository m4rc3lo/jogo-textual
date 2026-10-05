# Jogo Textual

Este site reúne a documentação do projeto-base utilizado na disciplina de **Lógica de Programação** do curso de **Design de Games**.

O projeto tem natureza didática. Ele evolui de forma incremental para tornar visíveis conceitos de programação usados na construção de um jogo textual em C#/.NET. A prioridade é manter código, regras e documentação compreensíveis para estudantes em uma disciplina introdutória.

## Como usar a documentação

A navegação acompanha a evolução do próprio projeto. É possível começar pela preparação do ambiente e pelo guia de estudo, avançar pelos conceitos implementados no código e consultar depois o guia de adaptação e a arquitetura consolidada.

A seção **API** é gerada automaticamente a partir do código C# e dos comentários XML.

## Conteúdo conceitual e API

Os arquivos Markdown em `docs/` explicam conceitos, responsabilidades e procedimentos. A documentação da API descreve tipos e membros públicos existentes no código.

Essas fontes são complementares: os textos explicam **por que** e **como** os elementos são usados; a API mostra **o que existe** no código.

## Arquitetura atual

O projeto já possui estado, ações, regras, histórico, interação por console, persistência e testes. A página **Arquitetura atual** reúne essas relações e inclui diagramas Mermaid produzidos a partir da implementação existente.

A arquitetura continua propositalmente pequena. O objetivo é favorecer leitura, modificação e experimentação, e não antecipar estruturas de software que a disciplina ainda não exige.

## Adaptação pelos grupos

O projeto-base não define um gênero de jogo. Os exemplos de `Progresso`, ações e regras são demonstrativos e devem ser substituídos ou ampliados quando não forem adequados à proposta desenvolvida.

Consulte **Adaptando o projeto** antes de iniciar mudanças maiores.

## Diagramas Mermaid

O site utiliza o template `modern` do DocFX, que permite incorporar diagramas Mermaid diretamente nos documentos Markdown. Os diagramas são usados quando ajudam a explicar relações reais do projeto.
