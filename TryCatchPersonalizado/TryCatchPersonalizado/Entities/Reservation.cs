using System;
using System.Text;
using TryCatchPersonalizado.Entities.Exceptions;

namespace TryCatchPersonalizado.Entities
{
    class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                // Lança uma exceção
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan days = CheckOut.Subtract(CheckIn);
            return int.Parse(days.ToString("dd"));
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Room {RoomNumber}, ");
            builder.Append($"check-in: {CheckIn.ToShortDateString()}, ");
            builder.Append($"check-out: {CheckOut.ToShortDateString()}, ");
            builder.Append($"{Duration()} days");

            return builder.ToString();
        }
    }
}
