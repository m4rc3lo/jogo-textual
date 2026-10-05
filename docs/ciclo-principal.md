# Ciclo principal do jogo

A classe `Jogo` introduz o primeiro ciclo executável do projeto. Ela coordena a repetição dos passos necessários para manter uma partida em andamento.

## Estrutura do ciclo

Enquanto o estado não estiver encerrado, a aplicação:

1. apresenta o turno atual;
2. recebe uma entrada;
3. decide qual ação básica executar;
4. modifica o estado;
5. volta ao início do ciclo.

Em forma resumida:

```text
apresentar estado
→ receber entrada
→ decidir
→ alterar estado
→ verificar encerramento
→ repetir
```

Esse padrão será reutilizado quando o jogo ganhar regras e ações mais significativas.

## Por que existe uma classe `Jogo`

`Program.Main()` deve continuar pequeno. Sua responsabilidade é iniciar a aplicação, e não concentrar todas as regras.

Por isso o ponto de entrada agora cria um objeto `Jogo` e chama `Executar()`.

A classe `Jogo` passa a coordenar a partida. `EstadoJogo`, por sua vez, continua responsável somente pelos dados mutáveis da partida.

## Uma interface ainda provisória

Neste incremento, `Jogo` escreve diretamente no console e lê `Console.ReadLine()`. Isso é intencional: primeiro tornamos o ciclo explícito; no próximo incremento, a entrada e a saída serão separadas em uma classe própria.

Também existe apenas uma validação mínima com `if`/`else`. A próxima etapa tornará essa responsabilidade mais clara.

## Relação com lógica de programação

O ciclo combina conceitos fundamentais já estudados:

- repetição com `while`;
- decisão com `if` e `else`;
- variáveis e valores;
- chamadas de métodos;
- mudança de estado ao longo da execução;
- condição de encerramento.

O jogo começa a existir como sistema de estados e transições, e não apenas como uma sequência fixa de mensagens.
