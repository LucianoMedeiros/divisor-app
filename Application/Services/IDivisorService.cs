namespace Application.Services
{
  internal interface IDivisorService
  {
    List<int> GetDivisors(int number);
    List<int> GetPrimeDivisors(List<int> divisors);
  }
}
