namespace Issue692;

public class UnitTest1(Xunit.Abstractions.ITestOutputHelper testOutputHelper)
{
    [FsCheck.Xunit.Property]
    public void Test1()
    {
        testOutputHelper.WriteLine($"{nameof(Test1)}");
    }

    [Xunit.Fact]
    public void Test2()
    {
        testOutputHelper.WriteLine($"{nameof(Test2)}");
    }
}
