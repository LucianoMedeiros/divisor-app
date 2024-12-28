namespace Application.Services
{
  public interface IDivisorService
  {
    List<int> GetDivisors(int number);
    List<int> GetPrimeDivisors(List<int> divisors);
  }
}
