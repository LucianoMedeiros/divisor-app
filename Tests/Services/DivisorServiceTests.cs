using Application.Services;

namespace Tests.Services
{
  public class DivisorServiceTests
  {
    private readonly DivisorService _divisorService;

    public DivisorServiceTests()
    {
      _divisorService = new DivisorService();
    }

    [Fact]
    public void GetDivisors_ReturnsCorrectDivisors()
    {
      var divisors = _divisorService.GetDivisors(45);

      Assert.Contains(1, divisors);
      Assert.Contains(3, divisors);
      Assert.Contains(5, divisors);
      Assert.Contains(9, divisors);
      Assert.Contains(15, divisors);
      Assert.Contains(45, divisors);
    }


    [Fact]
    public void GetPrimeDivisors_ReturnsCorrectPrimeDivisors()
    {
      var divisors = _divisorService.GetDivisors(45);
      var primeDivisors = _divisorService.GetPrimeDivisors(divisors);

      Assert.Contains(1, primeDivisors);
      Assert.Contains(3, primeDivisors);
      Assert.Contains(5, primeDivisors);
    }
  }
}