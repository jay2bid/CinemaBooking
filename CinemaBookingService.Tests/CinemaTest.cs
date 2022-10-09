using FluentAssertions;
using CinemaBookingService;
namespace CinemaBookingService.Tests;

public class CinemaTest
{
    private Cinema cinnamon;

    [SetUp]
    public void Setup()
    {
        cinnamon = new Cinema(3, 5);
    }

    [Test]
    public void Given_Cinema_Defined_All_Seats_are_empty()
    {
        cinnamon.SetSeatNumbers();
        cinnamon.seatList[0]._isAvaiable.Should().Be(true);
        cinnamon.seatList[4]._isAvaiable.Should().Be(true);

    }
    
}