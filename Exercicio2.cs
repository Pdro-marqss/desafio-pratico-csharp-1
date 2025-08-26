namespace DesafioPratico1;

public static class Exercicio2
{
  public static void Executar()
  {
    // Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
    Console.WriteLine("Digite o seu primeiro nome: ");
    string? primeiroNome = Console.ReadLine();

    if (string.IsNullOrEmpty(primeiroNome))
    {
      Console.WriteLine("Erro ao ler seu primeiro nome.");
      return;
    }

    Console.WriteLine("Agora digite o seu sobrenome: ");
    string? sobrenome = Console.ReadLine();
    if (string.IsNullOrEmpty(sobrenome))
    {
      Console.WriteLine("Erro ao ler o seu sobrenome.");
      return;
    }

    Console.WriteLine($"Seu nome completo é: {primeiroNome} {sobrenome}");
  }
}