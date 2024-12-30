namespace Application.Services
{
  public interface IDivisorService
  {
    List<long> GetDivisors(long number);
    List<long> GetPrimeDivisors(List<long> divisors);
  }
}
