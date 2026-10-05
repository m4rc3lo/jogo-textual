# Coleção significativa: histórico da partida

Coleções devem existir porque o problema precisa armazenar vários elementos, e não apenas para demonstrar sintaxe.

O projeto agora mantém uma coleção de `RegistroJogo` em `EstadoJogo`.

## O que é armazenado

Cada registro contém:

- o turno em que aconteceu;
- uma descrição curta da consequência.

As regras acrescentam registros quando modificam o estado. A interface mostra o registro mais recente.

## Relação entre objeto e coleção

```text
EstadoJogo
└── Historico : List<RegistroJogo>
    ├── RegistroJogo
    ├── RegistroJogo
    └── ...
```

Essa estrutura demonstra uma coleção de objetos com significado no domínio.

## Possíveis adaptações

Um projeto próprio poderia manter coleções de locais visitados, decisões tomadas, eventos, objetivos, personagens conhecidos ou recursos. A escolha depende da proposta do jogo.

A recomendação é a mesma: primeiro identificar o dado repetitivo necessário ao problema; depois escolher a coleção adequada.
