namespace DesafioPratico1;

public static class Exercicio1
{
  public static void Executar()
  {
    // Usuário digita um nome e recebe uma mensagem de boas vindas com o nome dele:  Olá, Welisson! Seja muito bem-vindo!
    Console.WriteLine("Digite o seu nome: ");
    string? nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome))
    {
      Console.WriteLine("Erro ao ler o seu nome.");
      return;
    }

    Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
  }
}