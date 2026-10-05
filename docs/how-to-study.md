# Como estudar com este projeto

Este repositório é um material didático incremental. A proposta não é apenas executar um programa pronto, mas observar como o código evolui e relacionar cada mudança aos conceitos trabalhados na disciplina.

## Uma sequência de estudo

Ao trabalhar com o projeto, siga um ciclo simples:

1. leia a documentação relacionada ao conteúdo atual;
2. execute o projeto antes de modificar o código;
3. localize as classes e os métodos envolvidos;
4. faça uma alteração pequena por vez;
5. compile e execute novamente;
6. rode os testes;
7. compare o comportamento obtido com o comportamento esperado.

## Ler antes de alterar

Comece pelo `Program.cs` para identificar o ponto de entrada. Em seguida, acompanhe as chamadas para as demais classes. Quando encontrar um tipo ou método público que não esteja claro, consulte a seção **API** deste site.

Evite alterar vários arquivos ao mesmo tempo sem compreender a responsabilidade de cada um. Mudanças pequenas tornam mais fácil localizar erros e entender suas causas.

## Usar o terminal como ferramenta de estudo

Na raiz do repositório, os comandos básicos são:

```powershell
dotnet restore
dotnet build
dotnet test
dotnet run --project src/JogoTextual
```

`dotnet build` deve ser usado com frequência. Erros de compilação fazem parte do processo de desenvolvimento e as mensagens do compilador são uma fonte importante de informação.

## Modificar com intenção

Antes de escrever código, formule o que deseja mudar em termos de comportamento. Por exemplo: **quando determinada opção for escolhida, qual estado deve mudar?**

Depois identifique onde essa regra pertence.

Evite transformar o projeto apenas por substituição de textos. O objetivo da disciplina é trabalhar dados, regras, decisões, estados, ações e comportamentos.

## Testar depois de alterar

Depois de uma mudança, execute novamente:

```powershell
dotnet build
dotnet test
```

Em seguida, execute a aplicação e verifique manualmente o comportamento alterado. Mais adiante, o projeto terá testes associados às regras do jogo; esses testes complementam, mas não substituem, a compreensão do código.

## Consultar a documentação

A documentação tem funções complementares:

- os textos em `docs/` explicam conceitos e procedimentos;
- a seção **API** descreve os tipos e membros públicos existentes no código;
- o próprio código, incluindo comentários XML, mostra como esses elementos são implementados.

Use essas fontes em conjunto. A documentação não substitui a leitura do código e o código não substitui a explicação conceitual.

## Quando algo não funcionar

Antes de alterar várias partes do projeto, identifique em qual etapa o problema aparece: restauração, compilação, teste ou execução.

Leia a mensagem completa e procure reproduzir o problema com a menor sequência de passos possível. Esse hábito faz parte do desenvolvimento: observar, formular uma hipótese, fazer uma alteração pequena e verificar o resultado.
