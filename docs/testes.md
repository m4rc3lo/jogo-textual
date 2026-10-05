# Testes automatizados como documentação executável

Os testes deste projeto não existem para alcançar uma porcentagem artificial de cobertura. Eles registram comportamentos importantes e permitem verificar automaticamente se esses comportamentos continuam válidos.

## Estrutura de um teste

Um teste pode ser lido como três momentos:

```text
organizar o estado inicial
→ executar uma ação
→ verificar a consequência
```

Por exemplo, o teste de **Progredir** cria um estado, aplica a regra e verifica progresso, turno e histórico.

## O que testar

Priorize comportamentos que expressem regras:

- uma ação altera os valores esperados;
- uma condição de encerramento é respeitada;
- um registro é criado;
- salvar e carregar preserva o estado.

Evite testes que apenas repetem a implementação sem verificar um comportamento relevante.

## Testes e projeto longitudinal

Ao adaptar o projeto-base, cada grupo deve identificar regras importantes de seu próprio jogo e criar testes para elas.

Se uma regra puder ser descrita como:

```text
dado um estado inicial
quando uma ação acontece
então uma consequência deve ocorrer
```

ela é uma boa candidata a teste automatizado.

## Executar

Na raiz do repositório:

```powershell
dotnet test
```

Antes de entregar uma alteração, o esperado é que a solução compile e todos os testes passem.
