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
    public void Given_Cinema_SetSeatNumber_Should_Assign_All_Seats_As_Avaiable()
    {
        cinnamon.SetSeatNumbers();
        cinnamon.seatList[0]._isAvaiable.Should().Be(true);
        cinnamon.seatList[4]._isAvaiable.Should().Be(true);

    }
    [Test]
    public void SetSeatNumber_Should_define_correct_number_of_seats()
    {
        cinnamon.SetSeatNumbers();
        int totalCapacity = cinnamon._NoOfRows * cinnamon._NoOfSeatsInRow;
        cinnamon.seatList.Count.Should().Be(totalCapacity);
       
    }


}