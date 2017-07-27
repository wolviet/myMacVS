using Xunit;
using myMacVS.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace test_mymacvs
{
    public class TestController
    {
        [Fact]
        public void TestAbout()
        {
            var controller = new HomeController();
            var result = controller.About() as ViewResult;

            Assert.Equal("Your application description page.", result.ViewData["Message"]);
        }
    }
}
