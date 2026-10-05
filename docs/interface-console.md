# Interface de console e validação de entrada

A interação com terminal agora foi separada da coordenação do jogo. A classe `InterfaceConsole` concentra a responsabilidade de escrever mensagens, apresentar o estado, listar ações e ler uma opção válida.

## Por que separar

No incremento anterior, `Jogo` fazia duas coisas ao mesmo tempo:

- coordenava o ciclo da partida;
- realizava diretamente entrada e saída com `Console`.

As duas responsabilidades funcionavam, mas estavam misturadas. Com a nova organização:

```text
Jogo
├── coordena o ciclo
├── decide qual ação básica executar
└── modifica o estado

InterfaceConsole
├── mostra mensagens
├── mostra o estado
├── mostra as ações
└── lê e valida a entrada
```

Essa separação torna cada classe mais fácil de ler e prepara o projeto para novas regras sem concentrar tudo em um único arquivo.

## Validação da entrada

`LerOpcaoValida()` usa repetição para continuar perguntando até que o código digitado corresponda a alguma ação disponível.

O procedimento pode ser descrito assim:

```text
repetir
    ler entrada
    percorrer ações disponíveis
    se o código existir
        retornar o código
    informar que a opção é inválida
até obter uma opção válida
```

Observe que uma entrada inválida não altera `EstadoJogo`. Primeiro a entrada é validada; somente depois `Jogo` decide o que fazer.

## Coleção de ações

`Jogo` mantém uma `List<AcaoJogo>` com as opções disponíveis neste momento:

- avançar um turno;
- encerrar o jogo.

A lista ainda é pequena, mas já permite que a apresentação e a validação usem a mesma fonte de dados. Isso evita manter um menu textual separado dos códigos considerados válidos.

## O que continua simples de propósito

Ainda não criamos interfaces C#, herança, injeção de dependência ou uma hierarquia de comandos. Para este estágio da disciplina, essas abstrações acrescentariam mais conceitos do que benefícios.

Nos próximos incrementos, as ações começarão a produzir regras e consequências mais significativas, mantendo a estrutura atual legível.
