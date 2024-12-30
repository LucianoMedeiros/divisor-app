using Application.Services;

namespace Tests.Services
{
  public class DivisorServiceTests
  {
    private readonly DivisorService _divisorService;
    private readonly long _simpleNumber;
    private readonly long _largeNumber;

    public DivisorServiceTests()
    {
      _divisorService = new DivisorService();
      _simpleNumber = 45;
      _largeNumber = 9223372036854775807;
    }

    [Fact]
    public void GetDivisors_ReturnsCorrectDivisors()
    {
      var divisors = _divisorService.GetDivisors(_simpleNumber);
      var expectedDivisors = new long[] { 1, 3, 5, 9, 15, 45 };

      Assert.Equal(expectedDivisors, divisors);
    }


    [Fact]
    public void GetPrimeDivisors_ReturnsCorrectPrimeDivisors()
    {
      var divisors = _divisorService.GetDivisors(_simpleNumber);
      var primeDivisors = _divisorService.GetPrimeDivisors(divisors);
      var expectedPrimes = new long[] { 1,3,5 };

      Assert.Equal(expectedPrimes, primeDivisors);
    }

    [Fact]
    public void GetDivisors_ReturnsCorrectDivisors_ForLargeNumber()
    {
      var divisors = _divisorService.GetDivisors(_largeNumber);

      var expectedDivisors = new long[]
      {
        1, 7, 49, 73, 127, 337, 511, 889, 2359, 3577, 6223, 9271, 16513, 24601, 42799, 64897,
        92737, 172207, 299593, 454279, 649159, 649657, 1205449, 2097151, 3124327, 4544113,
        4547599, 6769801, 11777599, 21870289, 31252369, 31833193, 47388607, 47424961, 82443193,
        82506439, 153092023, 218766583, 218934409, 331720249, 331974727, 577102351, 577545073,
        859764727, 1531366081, 1532540863, 2281422937, 2323823089, 3969050863, 4042815511,
        6018353089, 6022970047, 10727786041, 15969960559, 15982211857, 27783356041, 27804669943,
        42128471623, 42160790329, 60247241209, 111789723913, 111875482999, 194483492287,
        194632689601, 289740712999, 295125532303, 421730688463, 783128380993, 1362428827207,
        2028184990993, 2029740905839, 2952114819241, 4398048608257, 7651399633543, 14197294936951,
        14208186340873, 20303320287433, 30786340257799, 53559797434801, 99457304386111,
        142123242012031, 215504381804593, 374918582043607, 558552173248639, 994862694084217,
        1482142380982609, 2578521676503991, 3909865212740473, 10374996666878263, 18049651735527937,
        27369056489183311, 72624976668147841, 126347562148695559, 188232082384791343,
        1317624576693539401, 9223372036854775807
      };

      Assert.Equal(expectedDivisors, divisors);
    }

    [Fact]
    public void GetPrimeDivisors_ReturnsCorrectPrimeDivisors_ForLargeNumber()
    {
      var divisors = _divisorService.GetDivisors(_largeNumber);
      var primeDivisors = _divisorService.GetPrimeDivisors(divisors);
      var expectedPrimeDivisors = new long[] { 1, 7, 73, 127, 337, 92737, 649657 };

      Assert.Equal(expectedPrimeDivisors, primeDivisors);
    }
  }
}