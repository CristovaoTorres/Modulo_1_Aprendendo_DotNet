
# ConsolePegadinhas

Bem-vindo ao repositório **ConsolePegadinhas**! Este projeto é uma série de pequenos desafios em C# com erros de lógica comuns. O objetivo é que novos desenvolvedores identifiquem e corrijam esses problemas para melhorar suas habilidades em programação e depuração.

## Objetivo

Este projeto contém três desafios de lógica. Cada desafio apresenta um erro ou problema no código, que os desenvolvedores devem corrigir para alcançar o resultado esperado. As descrições estão no próprio código para orientar a correção.

## Desafios

### 1. Loop Infinito
**Problema**: O programa entra em um loop infinito, exibindo o valor da variável `i` continuamente.  
**Objetivo**: Corrigir a lógica para que o loop pare quando `i` atingir o valor limite.  
**Dica**: Verifique a condição e o que está faltando dentro do loop.

### 2. Conversão Incorreta
**Problema**: Ao converter um número decimal para outro tipo, o valor resultante não é o esperado (123.456).  
**Objetivo**: Ajustar a conversão para que o valor exibido seja o correto.  
**Dica**: Observe o tipo de conversão que está sendo utilizado.

### 3. Cálculo Errado na Média
**Problema**: O cálculo da média de três números não está correto.  
**Objetivo**: Corrigir o cálculo para que a média calculada corresponda ao valor esperado (20).  
**Dica**: Revise a fórmula de média e o divisor utilizado.

---

## Como Executar o Código

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu_usuario/ConsolePegadinhas.git
   cd ConsolePegadinhas
   ```

2. **Abra o projeto**:
   - Você pode abrir o projeto em um editor de código, como o [Visual Studio](https://visualstudio.microsoft.com/) ou o [Visual Studio Code](https://code.visualstudio.com/).

3. **Compile e execute**:
   - No Visual Studio, pressione `F5` para compilar e executar o programa.
   - Se estiver usando o terminal, execute o seguinte comando:
     ```bash
     dotnet run
     ```

4. **Siga as instruções**:
   - O console exibirá os desafios e mostrará mensagens indicando se a correção foi bem-sucedida.

## Estrutura do Código

O código está estruturado em três métodos, cada um representando um desafio:

- **`LoopInfinito()`**: Contém um loop que precisa de ajuste para não ficar infinito.
- **`ConversaoIncorreta()`**: Executa uma conversão de tipo que causa perda de dados.
- **`CalcularMedia()`**: Realiza um cálculo de média incorreto.

## Contribuindo

Este projeto foi criado para aprendizado e prática. Sinta-se à vontade para enviar sugestões, melhorias ou novos desafios!

## Licença

Este projeto é distribuído sob a licença MIT. Consulte o arquivo `LICENSE` para obter mais detalhes.
