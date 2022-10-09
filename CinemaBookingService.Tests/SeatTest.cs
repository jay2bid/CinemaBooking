using FluentAssertions;
using CinemaBookingService;
namespace CinemaBookingService.Tests;

public class SeatTest
{
    private Seat _seat;

    [SetUp]
    public void Setup()
    {
        _seat = new Seat(true, 'A', 1);
    }

    [Test]
    public void Given_variable_Should_access_variables()
    {
        _seat._isAvaiable.Should().Be(true);
      
    }
}