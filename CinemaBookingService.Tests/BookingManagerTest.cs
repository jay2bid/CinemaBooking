using FluentAssertions;
using CinemaBookingService;
namespace CinemaBookingService.Tests;

public class BookingManagerTest
{
    private BookingManager cinnamonBooking;
    private Cinema cinnamon;

    [SetUp]
    public void Setup()
    {
        cinnamon = new Cinema(3, 5);
        cinnamonBooking = new BookingManager(cinnamon);
        cinnamon.SetSeatNumbers();
       
    }

    [Test]
    public void Given_4_Tickets_Booked_The_First_4_Seats_Should_Be_NotAvaiable()
    {
        cinnamonBooking.BookTickets(4);
        cinnamon.seatList[0]._isAvaiable.Should().Be(false);
        cinnamon.seatList[1]._isAvaiable.Should().Be(false);
        cinnamon.seatList[2]._isAvaiable.Should().Be(false);
        cinnamon.seatList[3]._isAvaiable.Should().Be(false);
        cinnamon.seatList[4]._isAvaiable.Should().Be(true);

    }
    


}