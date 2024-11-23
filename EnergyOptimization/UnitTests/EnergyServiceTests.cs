using EnergyOptimization.DTOs;
using EnergyOptimization.Services;
using EnergyOptimization.Entities;
using Moq;
using Xunit;
using EnergyOptimization.Interfaces;
using EnergyOptimization.Factories;

public class EnergyServiceTests
{
    private readonly Mock<IRepository<EnergyConsumption>> _repositoryMock;
    private readonly Mock<IReportFactory> _reportFactoryMock;
    private readonly IEnergyService _service;

    public EnergyServiceTests()
    {
        _repositoryMock = new Mock<IRepository<EnergyConsumption>>();
        _reportFactoryMock = new Mock<IReportFactory>();
        _service = new EnergyService(_repositoryMock.Object, _reportFactoryMock.Object);
    }

    [Fact]
    public async Task AnalyzeConsumptionAsync_ShouldReturnReport()
    {
        // Arrange
        var dto = new EnergyConsumptionDTO
        {
            ClientId = "123",
            ConsumptionData = new List<double> { 100, 200, 300 }
        };

        _reportFactoryMock.Setup(x => x.GenerateReportAsync(It.IsAny<EnergyConsumption>()))
                          .ReturnsAsync("Relatório de Eficiência");

        // Act
        var result = await _service.AnalyzeConsumptionAsync(dto);

        // Assert
        Assert.Equal("Relatório de Eficiência", result);
    }
}

