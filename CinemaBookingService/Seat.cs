using System;
namespace CinemaBookingService
{
	public class Seat
	{
		public bool _isAvaiable { get; set; }
		public char _row { get; set; }
		public int _seatNumber { get; set; }
		public Seat(bool isAvaiable, char row, int seatNumber)
		{
			_isAvaiable = isAvaiable;
			_row = row;
			_seatNumber = seatNumber;
        }
	}
}

