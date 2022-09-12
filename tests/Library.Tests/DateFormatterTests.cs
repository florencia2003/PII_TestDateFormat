namespace Library.Tests;
using TestDateFormat;


public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCorrectFormatDate()
    {
        string actualDate = "10/11/1997";
        string expectedDate = "1997-11-10";
        string convertedDate = DateFormatter.ChangeFormat(actualDate);
        Assert.AreEqual(convertedDate, expectedDate);

    }

    [Test]
    public void TestIncorrectFormatDate()
    {
        string wrongDate = "11/10/1997";
        string expectedDate = "1997-11-10";
        string convertedDate = DateFormatter.ChangeFormat(wrongDate);
        Assert.IsFalse(convertedDate.Equals(expectedDate));

    }

    [Test]
    public void TestFormatDateNullOrEmpty()
    {
        string actualDate = "";
        string convertedDate = DateFormatter.ChangeFormat(actualDate);
        Assert.IsNull(convertedDate);

    }
}