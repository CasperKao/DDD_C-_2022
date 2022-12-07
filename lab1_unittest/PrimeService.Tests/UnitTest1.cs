namespace Prime.Service.Tests;


public class Tests
{
    [OneTimeSetUp]
    public void init() {
        //Console.WriteLine("一次性的啟動");
        TestContext.Progress.WriteLine("一次性的啟動");
    }
    [OneTimeTearDown]
    public void finalize() {
        //Console.WriteLine("一次性的清理");
        TestContext.Progress.WriteLine("一次性的清理");
    }

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("測試前準備動作");
    }

    [TearDown]
    public void StoreData()
    {
        Console.WriteLine("測試後清理動作");
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("this is test1");
        Assert.Pass();
    }
    //[Test]
    [Ignore("因為還沒寫好")]
    public void Test2()
    {
        Console.WriteLine("this is test2");
        //Assert.Fail("這是預料中會失敗的");
    }
}