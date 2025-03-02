using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Zip2Go.WebAPI.Controllers;
using Zip2Go.Models;

namespace Zip2Go.Tests
{
    public class QueryRunsApiControllerTests
    {
        [Fact]
        public void CancelQueryRun_Returns200()
        {
            // Arrange
            var controller = new QueryRunsApiController();

            // Act
            var result = controller.CancelQueryRun("testId", null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void CreateQueryRun_Returns201()
        {
            // Arrange
            var controller = new QueryRunsApiController();
            var request = new QueryRunCreateRequest();

            // Act
            var result = controller.CreateQueryRun(request, null, null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(201, result.StatusCode);
        }

        [Fact]
        public void GetQueryRun_Returns200()
        {
            // Arrange
            var controller = new QueryRunsApiController();

            // Act
            var result = controller.GetQueryRun("testId", null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }
    }
}
