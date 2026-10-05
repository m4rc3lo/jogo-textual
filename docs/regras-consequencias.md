# Ações, regras e consequências

Uma ação deixa de ser apenas um item de menu quando produz uma consequência sobre o estado.

Neste incremento, `RegrasJogo` transforma códigos de ação em mudanças explícitas em `EstadoJogo`.

## Regras demonstrativas

As regras continuam genéricas:

- **Progredir** aumenta `Progresso` e avança o turno;
- **Aguardar** avança somente o turno;
- **Encerrar** marca a partida como encerrada.

O objetivo não é definir um gênero, mas mostrar a relação:

```text
estado atual + ação
        ↓
       regra
        ↓
consequência sobre o estado
```

## Separação de responsabilidades

`Jogo` coordena o ciclo. `InterfaceConsole` cuida da entrada e saída. `RegrasJogo` concentra as transformações do estado.

Com isso, uma regra pode ser testada sem precisar simular teclado ou console.

## Por que `Progresso`

`Progresso` é deliberadamente genérico. Cada projeto poderá substituí-lo ou complementá-lo por variáveis coerentes com sua proposta: reputação, distância, recursos, pistas, tempo, pontuação ou outros estados significativos.

O importante não é o nome do recurso, mas compreender que ações modificam dados e que essas mudanças afetam a evolução do sistema.
