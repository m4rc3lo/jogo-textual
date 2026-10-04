# Jogo Textual

Este site reúne a documentação do projeto-base utilizado na disciplina de **Lógica de Programação** do curso de **Design de Games**.

O projeto tem natureza didática. Ele será desenvolvido de forma incremental para tornar visíveis conceitos de programação que serão usados posteriormente na construção de um jogo textual em C#/.NET. A prioridade é manter o código e sua organização compreensíveis para estudantes que estão iniciando seus estudos de programação.

## Como a documentação está organizada

A documentação está dividida inicialmente em três pontos de entrada:

- **Início**: apresenta a finalidade e o contexto do projeto;
- **Começando**: explica como preparar o ambiente, compilar, testar e executar a solução;
- **API**: apresenta a documentação gerada a partir do código C# e de seus comentários XML.

Ainda não há documentação de arquitetura, estados, ações ou regras do jogo porque esses elementos ainda não foram implementados. Eles serão acrescentados conforme o código-base evoluir.

## Documentação conceitual e documentação da API

Os arquivos Markdown em `docs/` formam a documentação conceitual. Eles explicam o projeto em linguagem voltada ao estudo.

A documentação da API é produzida automaticamente pelo DocFX a partir do projeto C#. Ela ajuda a localizar namespaces, classes e membros públicos e, quando presentes, exibe também os comentários XML escritos no código.

Esses dois tipos de documentação são complementares: a documentação conceitual explica o contexto e as decisões; a documentação da API descreve os elementos existentes no código.

## Diagramas Mermaid

O site utiliza o template `modern` do DocFX. Esse template oferece suporte a blocos Mermaid em arquivos Markdown. Diagramas serão adicionados somente quando houver um conceito real do projeto que se beneficie de uma representação visual; não são necessários diagramas artificiais nesta etapa.
