using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.DNSimple.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public class DNSimpleOpenApiClientRunnerTests : FixturedUnitTest
{
    public DNSimpleOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
