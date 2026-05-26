using Soenneker.Tests.HostedUnit;

namespace Soenneker.DNSimple.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DNSimpleOpenApiClientRunnerTests : HostedUnitTest
{
    public DNSimpleOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
