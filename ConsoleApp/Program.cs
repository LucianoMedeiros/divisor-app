using Application.Services;

class Program
{
  static void Main(string[] args)
  {
    bool _continue = true;

    while (_continue)
    {
      Console.WriteLine("Digite um número inteiro:");
      if (int.TryParse(Console.ReadLine(), out int numero))
      {
        var service = new DivisorService();
        var divisors = service.GetDivisors(numero);
        var primeDivisors = service.GetPrimeDivisors(divisors);

        Console.WriteLine($"Número de Entrada: {numero}");
        Console.WriteLine($"Os divisores de {numero} são: {string.Join(", ", divisors)}");
        Console.WriteLine($"Os primos de {numero} são: {string.Join(", ", primeDivisors)}");
      }
      else
      {
        Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro.");
      }

      Console.WriteLine("Deseja digitar um novo número? (s/n):");
      string response = Console.ReadLine().Trim().ToLower();

      if (response != "s")
      {
        _continue = false;
      }
    }
  }

 
}


