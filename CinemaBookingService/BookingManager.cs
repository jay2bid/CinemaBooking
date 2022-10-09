using System;
namespace CinemaBookingService
{
    public class BookingManager
    {
     
        public Cinema _cinema;


        public BookingManager(Cinema cinema)
        {
          
            _cinema = cinema;
        }

        public bool BookTickets(int noOfTickets)
        {
            Console.WriteLine($"Booking of: {noOfTickets} tickets");
            int seatsAllocated = 0;
            var getAvailableSeats = _cinema.seatList
                                    .Where(seat => seat._isAvaiable == true)
                                    .OrderBy(seat => seat._row)
                                    .GroupBy(seat => seat._row);
            if (getAvailableSeats.Count() != 0 || noOfTickets < getAvailableSeats.Count())
            {
                foreach (var availableSeats in getAvailableSeats)
                {
                    foreach (Seat x in availableSeats)
                    {
                        x._isAvaiable = false;
                        Console.WriteLine($"Seat Number:{x._row}" + $"{x._seatNumber} has been allocated");
                        seatsAllocated++;
                        if (seatsAllocated == noOfTickets)
                            return true;
                    }
                }
            }
            else
                return false;

            return true;


        }
    }

}

