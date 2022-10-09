using System;
namespace CinemaBookingService
{
	public class Cinema
	{
		public int _NoOfRows { get; set; }
        public int _NoOfSeatsInRow { get; set; }
		public List<Seat> seatList = new List<Seat>();

        public Cinema(int NoOfRows, int NoOfSeatsInRow )
		{
			_NoOfRows = NoOfRows;
			_NoOfSeatsInRow = NoOfSeatsInRow;
		}
        public void SetSeatNumbers()
        {

            char maxRowName = Convert.ToChar(65 + _NoOfRows);

            for (char i = 'A'; i < maxRowName; i++)

            {
                for (var j = 1; j <= _NoOfSeatsInRow; j++) // J is a seatnumber in a row
                {
                   
                    seatList.Add(new Seat(true, i, j));
                }
            }

        }

    }
}

