using System.Globalization;

namespace DesafioPratico1;

public static class Exercicio6
{
  public static void Executar()
  {
    // Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    // - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    // - Apenas a data no formato "01/03/2024".
    // - Apenas a hora no formato de 24 horas.
    // - A data com o mês por extenso.

    string opcaoEscolhida = CapturaOpcaoDeDataEscolhidaPeloUsuario();
    if (opcaoEscolhida == "") return;

    DefineFormatoDeDataEscolhido(opcaoEscolhida);
  }

  private static string CapturaOpcaoDeDataEscolhidaPeloUsuario()
  {
    // 4 opcoes de data
    Console.WriteLine("Escolha uma das seguintes opções de exibição da data atual: \n 1- Data completa; \n 2- Formato DD/MM/AAAA \n 3- Apenas a hora (24h) \n 4- Data com mês por extenso");

    string opcaoEscolhida = Console.ReadLine()!;

    if (opcaoEscolhida == "")
    {
      Console.WriteLine("Digite uma das opções validas.");
      return "";
    }

    return opcaoEscolhida;
  }

  private static void DefineFormatoDeDataEscolhido(string opcaoEscolhida)
  {
    DateTime dataAtual = DateTime.Now;
    string dataFormatada = "";

    switch (opcaoEscolhida)
    {
      case "1":
        //dia da semana, dia do mes, mes, ano, hora, minuto, segundo
        dataFormatada = dataAtual.ToString("dddd, dd/MM/yyyy HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine($"Data Formatada: {dataFormatada}");
        break;

      case "2":
        // basica DD/MM/AAAA
        dataFormatada = dataAtual.ToShortDateString();
        Console.WriteLine($"Data Formatada: {dataFormatada}");
        break;

      case "3":
        // Apenas a Hora;
        dataFormatada = dataAtual.ToString("HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine($"Data Formatada: {dataFormatada}");
        break;

      case "4":
        // A data com o mês por extenso
        dataFormatada = dataAtual.ToString("dd' de 'MMMMM' de 'yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine($"Data Formatada: {dataFormatada}");
        break;

      default:
        Console.WriteLine("Nenhuma opção valida escolhida.");
        break;
    }
  }

}