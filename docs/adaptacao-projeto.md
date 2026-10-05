# Guia de adaptação do projeto-base

O projeto-base demonstra uma estrutura pequena para um jogo textual. A proposta da disciplina não é trocar apenas nomes e mensagens, mas **adaptar dados, regras, ações e consequências** para representar a proposta de cada grupo.

## Antes de alterar o código

Retome a proposta do seu projeto e identifique quatro elementos:

1. quais dados precisam representar a situação atual da partida;
2. quais ações o jogador pode realizar;
3. quais regras determinam as consequências dessas ações;
4. quais condições fazem a partida continuar ou terminar.

Só depois relacione esses elementos às classes do projeto-base.

## Onde cada tipo de alteração tende a acontecer

| Necessidade do projeto | Ponto de partida |
| --- | --- |
| adicionar ou substituir dados do estado | `EstadoJogo` |
| descrever opções disponíveis | `AcaoJogo` e a coleção de ações em `Jogo` |
| transformar ações em consequências | `RegrasJogo` |
| modificar o ciclo geral da partida | `Jogo` |
| alterar apresentação e leitura no terminal | `InterfaceConsole` |
| registrar acontecimentos repetidos | `RegistroJogo` e `Historico` |
| salvar e recuperar dados | `PersistenciaJogo` |
| verificar regras automaticamente | projeto `JogoTextual.Tests` |

A tabela é um mapa inicial, não uma regra absoluta. Se uma alteração exigir muitas responsabilidades em uma única classe, considere criar uma nova classe com uma responsabilidade clara.

## Uma sequência recomendada de adaptação

Comece pelo estado. Remova ou substitua `Progresso` se esse dado não fizer sentido para a proposta e acrescente apenas os valores realmente necessários.

Depois revise as ações. Cada ação deve representar uma possibilidade real do jogo, não apenas um texto diferente no menu.

Em seguida, implemente as consequências em `RegrasJogo`. Para cada ação, pergunte:

```text
qual condição precisa ser verdadeira?
→ o que muda no estado?
→ o que deve ser registrado?
→ o jogo continua ou termina?
```

Somente depois ajuste mensagens, persistência e testes.

## Exemplo de raciocínio

Imagine uma proposta em que o jogador investiga um local e acumula pistas. Uma adaptação possível seria:

```text
EstadoJogo
├── Turno
├── PistasEncontradas
├── TempoRestante
└── Historico

Ações
├── Investigar
├── Mover
└── Encerrar investigação
```

A regra de `Investigar` poderia aumentar `PistasEncontradas`, consumir tempo e registrar a consequência. Outro projeto pode utilizar recursos completamente diferentes.

O importante é que os dados e regras tenham relação com a proposta do grupo.

## O que evitar

Evite:

- manter `Progresso` apenas porque ele existe no projeto-base;
- criar várias ações que produzem exatamente a mesma consequência;
- concentrar toda a implementação em `Program.cs`;
- colocar regras de jogo dentro de `InterfaceConsole`;
- persistir dados que não fazem parte do estado relevante;
- remover os testes sem substituí-los por testes das novas regras;
- criar classes vazias apenas para aumentar artificialmente a quantidade de arquivos.

## Critério de uma adaptação significativa

Uma adaptação é significativa quando é possível observar no código que a proposta do grupo possui:

- estado próprio;
- ações coerentes;
- decisões ou regras;
- consequências observáveis;
- evolução ao longo de ciclos;
- condição de encerramento;
- uso justificado de uma coleção;
- persistência de dados relevante.

A interface pode continuar sendo o console. O jogo é definido pelo sistema de estados, regras e transições, e não pela quantidade de elementos gráficos.

## Depois de cada alteração

Use:

```powershell
dotnet build
dotnet test
dotnet run --project src/JogoTextual
```

Faça alterações pequenas, execute novamente e mantenha os testes coerentes com as novas regras.
