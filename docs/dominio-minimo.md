# Domínio mínimo do jogo

Nesta etapa aparecem os primeiros tipos que representam conceitos do jogo. A intenção ainda não é criar um gênero específico, mas separar **dados do estado** e **ações possíveis**.

## Estado do jogo

`EstadoJogo` guarda informações que podem mudar durante uma partida. Por enquanto existem apenas duas:

- `Turno`: indica em qual ciclo da execução o jogo se encontra;
- `Encerrado`: indica se a partida deve terminar.

Esse estado é propositalmente pequeno. Novos dados só devem ser acrescentados quando uma regra real do projeto precisar deles.

## Ação do jogo

`AcaoJogo` representa uma escolha que pode ser apresentada ao jogador. Ela possui:

- `Codigo`: valor usado para selecionar a ação;
- `Descricao`: texto apresentado ao usuário.

A classe não executa uma regra. Ela apenas descreve uma ação disponível. Separar a representação da ação de sua consequência permite evoluir o projeto sem transformar textos de menu em regras escondidas.

## Relação entre os conceitos

Neste ponto, o projeto ainda não possui um ciclo principal. Os tipos apenas estabelecem vocabulário para os próximos incrementos:

```text
EstadoJogo  → situação atual
AcaoJogo    → escolha possível
```

O próximo passo será introduzir uma classe responsável por coordenar a execução e modificar o estado ao longo de vários ciclos.

## O que ainda não existe

Ainda não há personagem, inventário, combate, mapa, inimigos ou persistência.

Esses elementos não são obrigatórios para um jogo textual. O projeto-base deve permanecer genérico para que diferentes propostas possam ser construídas sobre a mesma estrutura lógica.
