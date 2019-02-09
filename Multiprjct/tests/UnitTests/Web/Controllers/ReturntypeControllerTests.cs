using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Xunit;

using Web;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;


// Important: Make sure namespace matches folder structure
namespace Tests.UnitTests.Web.Controllers
{
    public class RetruntypeControllerTests
    {

        // these are not async Tasks, just void methods
        [Fact]
        public void ReturnText_ReturnsAView()
        {
            // Arrange
            var controller = new Returntype();

            // Act
            var result = controller.ReturnText();

            // Assert

            var actual = Assert.IsAssignableFrom<IActionResult>(result);
            Assert.NotNull(actual);
        }
    }
}