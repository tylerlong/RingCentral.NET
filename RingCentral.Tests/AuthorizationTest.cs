using System;
using Xunit;

namespace RingCentral.Tests
{
    public class AuthorizationTest
    {
        [Fact]
        public async void TestPasswordFlow()
        {
            var env = Environment.GetEnvironmentVariables();
            var rc = new RestClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSG_URL"] as string
            );
            var r = await rc.Authorize(
                env["RINGCENTRAL_USERNAME"] as string,
                env["RINGCENTRAL_EXTENSION"] as string,
                env["RINGCENTRAL_PASSWORD"] as string
            );
            Console.WriteLine(r);
        }
    }
}