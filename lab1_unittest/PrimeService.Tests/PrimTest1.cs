namespace Prime.Service.Tests;
[TestFixture]
public class PrimeTest1 {
    [Test]
    public void test1() {
        Console.WriteLine("開始測試PrimeService");
        PrimeService s1 = new PrimeService();
        bool result = s1.IsPrime(1);
        Assert.IsFalse(result,"1 should not be prime");
    }



}