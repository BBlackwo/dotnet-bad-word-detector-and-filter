using DotnetBadWordDetector;

namespace DotnetBadWordDetectorTests;

public class ProfanityDetectorTests
{
    private ProfanityDetector _detector;

    public ProfanityDetectorTests()
    {
        _detector = new ProfanityDetector();
    }

    [Fact]
    public void IsProfaneShouldReturnTrue()
    {
        Assert.True(_detector.IsProfane("Damn"));
    }

    [Fact]
    public void IsProfaneShouldReturnFalse()
    {
        Assert.False(_detector.IsProfane("Hello"));
    }

    [Fact]
    public void IsPhraseProfaneShouldReturnTrue()
    {
        Assert.True(_detector.IsPhraseProfane("Damn you"));
    }

    [Fact]
    public void IsPhraseProfaneShouldReturnFalse()
    {
        Assert.False(_detector.IsPhraseProfane("Hello world"));
    }
}