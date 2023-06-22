# Verificação da Presença de Todas as Letras do Alfabeto em uma String

## Requisitos

- Este algoritmo foi desenvolvido em .NET 7 e C# 11, porém com os devidos ajustes pode ser executado em versões anteriores

## Como usar

1. Clone ou faça o download deste repositório para o seu ambiente local.

2. Abra o projeto em um ambiente de desenvolvimento C#, como o Visual Studio, de preferência o 2022.

3. Na linha 1 do arquivo `Program.cs`, você pode definir a string que deseja verificar, atribuindo um valor à variável `input`. Por exemplo:
   ```csharp
   string input = "a quick brown fox jumps over the lazy dog";
   ```

5. Compile e execute o programa.

6. O resultado da verificação será exibido no console. Se a string contiver todas as letras do alfabeto, será exibida a mensagem "A string contém todas as letras do alfabeto." Caso contrário, será exibida a mensagem "A string não contém todas as letras do alfabeto."

## Como funciona

1. O algoritmo utiliza um array de booleanos chamado `alphabetFlags` para acompanhar quais letras foram encontradas na string.

2. A string de entrada é percorrida, caractere por caractere. Cada caractere é convertido para minúsculo usando o método `ToLower()`.

3. Se o caractere atual for uma letra, a posição correspondente no array `alphabetFlags` é marcada como `true`.

4. Ao final do percurso da string, o algoritmo verifica se todas as posições do array `alphabetFlags` estão marcadas como `true`, ou seja, se todas as letras de 'a' a 'z' estão presentes na string.

5. O resultado da verificação é retornado como um valor booleano: `true` se a string contém todas as letras do alfabeto e `false` caso contrário.
