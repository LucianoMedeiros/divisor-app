namespace Application.Services
{
  public class DivisorService : IDivisorService
  {
    private static readonly Dictionary<long, bool> primeCache = new();

    public List<long> GetDivisors(long number)
    {
      if (number == 0)
      {
        throw new ArgumentException("O número não pode ser zero.");
      }

      var divisors = new List<long>();
      long limit = (long)Math.Sqrt(Math.Abs(number));

      for (long i = 1; i <= limit; i++)
      {
        if (number % i == 0)
        {
          divisors.Add(i);
          if (i != number / i)
          {
            divisors.Add(number / i);
          }
        }
      }

      divisors.Sort();
      return divisors;
    }

    public List<long> GetPrimeDivisors(List<long> divisors)
    {
      if (divisors == null || divisors.Count == 0)
      {
        throw new ArgumentException("A lista de divisores não pode ser nula ou vazia.");
      }

      var primes = new List<long>();

      foreach (var divisor in divisors)
      {
        if (IsPrime(divisor))
        {
          primes.Add(divisor);
        }
      }

      return primes.OrderBy(x => x).ToList();
    }

    private static bool IsPrime(long number)
    {
      if (number < 1) return false;
      if (number == 1 || number == 2 || number == 3) return true;
      if (number % 2 == 0 || number % 3 == 0) return false;

      if (primeCache.TryGetValue(number, out bool isCachedPrime))
      {
        return isCachedPrime;
      }

      bool result = true;

      for (long i = 5; i * i <= number; i += 6)
      {
        if (number % i == 0 || number % (i + 2) == 0)
        {
          result = false;
          break;
        }
      }

      primeCache[number] = result;
      return result;
    }
  }
}
