using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PuppeteerSharp.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace PuppeteerSharp.Tests.ConnectionsTests
{
    [Collection("PuppeteerLoaderFixture collection")]
    public class SlowMoTests : PuppeteerBaseTest
    {
        public SlowMoTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public async Task ShouldWork()
        {
            var options = TestConstants.DefaultBrowserOptions();
            options.SlowMo = 100;

            using (var browser = await Puppeteer.LaunchAsync(options, TestConstants.LoggerFactory))
            using (var page = await browser.NewPageAsync())
            {
                await page.GoToAsync(TestConstants.EmptyPage);
            }
        }
    }
}