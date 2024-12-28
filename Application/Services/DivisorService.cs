namespace Application.Services
{
  public class DivisorService : IDivisorService
  {
    public List<int> GetDivisors(int number)
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

    public List<int> GetPrimeDivisors(List<int> divisors)
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


    private static bool IsPrime(int number)
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
}
