using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Qa431.Pages
{
    public class Index_Tests : Qa431WebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
