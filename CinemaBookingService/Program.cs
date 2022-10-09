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
        Console.WriteLine("Apologies, Cinnamon Cinema is fully booked.There are no more seats available.");
        break;
    }
}
Console.WriteLine("Press Enter key to exit the demo");
Console.ReadLine();