using System;
using CinemaBookingService;
Console.WriteLine("Welcome to the Cinnamon cinema booking system demo!");
Cinema Cinnamon = new Cinema(3, 5);
Cinnamon.SetSeatNumbers();
bool isSeatsAvailable = true;
while (isSeatsAvailable)
{
    Random rnd = new Random();
    int tickets = rnd.Next(1, 4);
    BookingManager booking = new BookingManager(Cinnamon);
    isSeatsAvailable = booking.BookTickets(tickets);
    if (isSeatsAvailable == false)
    {
        Console.WriteLine("Cinema is full. No Seats Available.");
        break;
    }
}