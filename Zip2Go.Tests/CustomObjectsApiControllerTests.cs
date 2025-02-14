using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Zip2Go.WebAPI.Controllers;
using Zip2Go.Models;

namespace Zip2Go.Tests
{
    public class CustomObjectsApiControllerTests
    {
        [Fact]
        public void CreateCustomObject_Returns201()
        {
            // Arrange
            var controller = new CustomObjectsApiController();
            var request = new Dictionary<string, object>();

            // Act
            var result = controller.CreateCustomObject(request, "testType", null, null, null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(201, result.StatusCode);
        }

        [Fact]
        public void DeleteCustomObject_Returns204()
        {
            // Arrange
            var controller = new CustomObjectsApiController();

            // Act
            var result = controller.DeleteCustomObject("testType", "testId", null, null, null, null, null, null) as StatusCodeResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(204, result.StatusCode);
        }

        [Fact]
        public void GetCustomObject_Returns200()
        {
            // Arrange
            var controller = new CustomObjectsApiController();

            // Act
            var result = controller.GetCustomObject("testType", "testId", null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void GetCustomObjects_Returns200()
        {
            // Arrange
            var controller = new CustomObjectsApiController();

            // Act
            var result = controller.GetCustomObjects("testType", null, null, null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void UpdateCustomObject_Returns200()
        {
            // Arrange
            var controller = new CustomObjectsApiController();
            var request = new Dictionary<string, object>();

            // Act
            var result = controller.UpdateCustomObject(request, "testType", "testId", null, null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }
    }

}