namespace DesafioPratico1;

public static class Exercicio5
{
  public static void Executar()
  {
    // Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    // - A placa deve ter 7 caracteres alfanuméricos;
    // - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    // - Os quatro últimos caracteres são números;
    // Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.

    string? placaDoCarro = CapturaInputDoUsuario();

    if (placaDoCarro != null)
    {
      bool possuiSeteCaracteres = ValidaSePossuiSeteCaracteres(placaDoCarro);
      if (!possuiSeteCaracteres) return;

      bool osTresPrimeirosCaracteresSaoLetras = ValidaSeOsTresPrimeirosCaracteresSaoLetras(placaDoCarro);
      if (!osTresPrimeirosCaracteresSaoLetras) return;

      bool osQuatroUltimosCaracteresSaoNumeros = ValidaSeOsQuatroUltimosCaracteresSaoNumeros(placaDoCarro);
      if (!osQuatroUltimosCaracteresSaoNumeros) return;

      Console.WriteLine($"A placa {placaDoCarro} é uma placa valida !!!");
    }
  }

  private static string? CapturaInputDoUsuario()
  {
    Console.WriteLine("Digite a placa do seu veiculo para ser validada: ");
    Console.WriteLine("Precisa seguir o modelo Brasileiro (3 LETRAS e 4 NUMEROS)");
    Console.WriteLine("Ex: ABC1234");

    string? placaDoCarro = Console.ReadLine();

    if (placaDoCarro != null)
    {
      string placaDoCarroSemEspacos = placaDoCarro.Trim();
      return placaDoCarroSemEspacos;
    }

    return null;
  }

  private static bool ValidaSePossuiSeteCaracteres(string placaDoCarro)
  {
    if (placaDoCarro.Length == 7)
    {
      return true;
    }
    Console.WriteLine($"Falha na validação: a placa {placaDoCarro} precisa ter exatos 7 caracteres.");
    return false;
  }

  private static bool ValidaSeOsTresPrimeirosCaracteresSaoLetras(string placaDoCarro)
  {
    string primeirosTresCaracteresDaPlaca = placaDoCarro.Substring(0, 3);

    if (primeirosTresCaracteresDaPlaca.Any(char.IsDigit))
    {
      Console.WriteLine($"Falha na validação: os 3 primeiros caracteres da placa {placaDoCarro} precisam ser Letras do alfabeto.");
      return false;
    }

    return true;
  }

  private static bool ValidaSeOsQuatroUltimosCaracteresSaoNumeros(string placaDoCarro)
  {
    string ultimosQuatroCaracteresDaPlaca = placaDoCarro.Substring(3, 4);

    if (ultimosQuatroCaracteresDaPlaca.Any(char.IsLetter))
    {
      Console.WriteLine($"Falha na validação: os 4 ultimos caracteres da placa {placaDoCarro} precisam ser numeros.");
      return false;
    }

    return true;
  }
}