
namespace DesafioPratico1;

public static class Exercicio3
{
  public static void Executar()
  {
    // Crie um programa com 2 valores do tipo double já declarados que retorne:
    // - A soma entre esses dois números;
    // - A subtração entre os dois números;
    // - A multiplicação entre os dois números;
    // - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    // - A média entre os dois números.

    double primeiroNumero = 2;
    double segundoNumero = 4;

    static void Soma(double number1, double number2)
    {
      Console.WriteLine($"Soma: {number1} + {number2} = {number1 + number2}");
    }

    static void Subtracao(double number1, double number2)
    {
      Console.WriteLine($"Subtração: {number1} - {number2} = {number1 - number2}");
    }

    static void Multiplicacao(double number1, double number2)
    {
      Console.WriteLine($"Multiplicação: {number1} * {number2} = {number1 * number2}");
    }

    static void Divisao(double number1, double number2)
    {
      if (number1 == 0 || number2 == 0)
      {
        Console.WriteLine("Não pode fazer divisao por 0");
        return;
      }
      Console.WriteLine($"Divisão: {number1} / {number2} = {number1 / number2}");
    }

    static void Media(double number1, double number2)
    {
      var result = (number1 + number2) / 2;
      Console.WriteLine($"Média: {number1} + {number2} / 2 = {result}");
    }

    Soma(primeiroNumero, segundoNumero);
    Subtracao(primeiroNumero, segundoNumero);
    Multiplicacao(primeiroNumero, segundoNumero);
    Divisao(primeiroNumero, segundoNumero);
    Media(primeiroNumero, segundoNumero);
  }
}