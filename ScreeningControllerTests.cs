using KanzWayScreeningAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

public class ScreeningControllerTests
{
    [Fact]
    public void GetScreeningResult_ReturnsExpectedResults()
    {
        // Arrange
        var controller = new ScreeningController();
        int input = 15;

        // Act
        var result = controller.GetScreeningResult(input) as OkObjectResult;
        var data = result?.Value as dynamic;

        // Assert
        Assert.NotNull(data);
        Assert.Equal("Kanz", data.results[2]);
        Assert.Equal("Way", data.results[4]);
        Assert.Equal("KanzWay", data.results[14]);
    }
}