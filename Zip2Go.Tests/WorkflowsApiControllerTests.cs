using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Zip2Go.WebAPI.Controllers;
using Zip2Go.Models;

namespace Zip2Go.Tests
{
    public class WorkflowsApiControllerTests
    {
        [Fact]
        public void RunWorkflow_Returns201()
        {
            // Arrange
            var controller = new WorkflowsApiController();
            var request = new RunWorkflowRequest();

            // Act
            var result = controller.RunWorkflow(request, 1, null, null, null, null, null, null) as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(201, result.StatusCode);
        }
    }
}