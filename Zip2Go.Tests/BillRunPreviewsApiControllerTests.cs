using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Zip2Go.WebAPI.Controllers;
using Zip2Go.Models;

namespace Zip2Go.Tests
{
public class BillRunPreviewsApiControllerTests
    {
        [Fact]
        public void CreateBillRunPreview_Returns201()
        {
            // Arrange
            var controller = new BillRunPreviewsApiController();
            var request = new BillRunPreviewCreateRequest();

            // Act
            var result = controller.CreateBillRunPreview(request, null, null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(201, result.StatusCode);
        }

        [Fact]
        public void GetBillRunPreview_Returns200()
        {
            // Arrange
            var controller = new BillRunPreviewsApiController();

            // Act
            var result = controller.GetBillRunPreview("testId", null, null, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }
    }
}