using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using myMacVS.Controllers;



namespace TestLibrary
{
    public class HomeController_tests

    {
        [Fact]
        public void Indextest()
        {
            var controller = new HomeController();

        }
    }
}
