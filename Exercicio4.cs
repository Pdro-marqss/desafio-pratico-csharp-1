
namespace DesafioPratico1;

public static class Exercicio4
{
  public static void Executar()
  {
    // Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

    Console.WriteLine("Digite uma palavra ou frase e veja quantos caracteres ela tem: ");
    string? inputUsuario = Console.ReadLine();

    if (inputUsuario != null)
    {
      // Sem usar laço de repetição
      string inputUsuarioTratado = inputUsuario.Trim().Replace(" ", "");
      int quantidadeCaracteres = inputUsuarioTratado.Length;
      Console.WriteLine($"[sem while] A palavra digitada tem: {quantidadeCaracteres} caracteres.");

      // Usando While
      int count = 0;
      int quantidadeDeCaracteresWhile = 0;

      while (count < inputUsuario.Count())
      {
        if (inputUsuario[count] == ' ')
        {
          count++;
          continue;
        }

        quantidadeDeCaracteresWhile++;
        count++;
      }

      Console.WriteLine($"[com while] Quantidade de Caracteres: {quantidadeDeCaracteresWhile}");
    }
  }
}