# Persistência inicial com JSON

Persistência permite interromper a execução e recuperar posteriormente os dados relevantes da partida.

O projeto usa `System.Text.Json`, que já faz parte do .NET.

## Salvar

`PersistenciaJogo.Salvar()` serializa `EstadoJogo` e grava o resultado em `savegame.json`.

O arquivo contém dados, não código. Como é um estado local de execução, ele é ignorado pelo Git e não deve ser versionado.

## Carregar

`Carregar()` verifica primeiro se o arquivo existe. Se existir, o JSON é desserializado e um novo objeto `EstadoJogo` é obtido.

No menu:

- `8` salva;
- `9` carrega.

## Por que separar persistência de `Jogo`

`Jogo` decide **quando** salvar ou carregar. `PersistenciaJogo` sabe **como** transformar o estado em JSON e recuperá-lo.

Essa separação evita colocar leitura e escrita de arquivos diretamente no ciclo principal.

## Transparência dos dados

Depois de salvar, abra `savegame.json` em um editor de texto. Observe como turno, progresso e histórico aparecem representados.

Essa inspeção ajuda a relacionar objetos em memória com uma representação persistente dos mesmos dados.
