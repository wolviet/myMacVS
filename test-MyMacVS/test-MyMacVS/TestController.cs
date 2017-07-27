using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using myMacVS.Controllers;

namespace test_MyMacVS
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
