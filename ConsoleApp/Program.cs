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
        var divisors = GetDivisors(numero);
        var primeDivisors = GetPrimeDivisors(divisors);

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

  static List<int> GetDivisors(int number)
  {
    var divisors = new List<int>();
    for (int i = 1; i <= Math.Abs(number); i++)
    {
      if (number % i == 0)
      {
        divisors.Add(i);
      }
    }
    return divisors;
  }

  static List<int> GetPrimeDivisors(List<int> divisors)
  {
    var primes = new List<int>();

    foreach (var divisor in divisors)
    {
      if (IsPrime(divisor))
      {
        primes.Add(divisor);
      }
    }
    return primes;
  }

  static bool IsPrime(int number)
  {
    if (number < 1) return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
      if (number % i == 0)
      {
        return false;
      }
    }

    return true;
  }
}


