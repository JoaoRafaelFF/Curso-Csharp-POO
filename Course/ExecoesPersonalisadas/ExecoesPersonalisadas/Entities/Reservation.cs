using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExecoesPersonalisadas.Entities.Exceptions;

namespace ExecoesPersonalisadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {

            if (checkOut <= checkIn)
            {
                throw new domainException("Error in reservation: Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Dutation()
        {
            TimeSpan dutation = CheckOut.Subtract(CheckIn);
            return (int)dutation.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new domainException("Error in reservation: Reservetion dates for updates must be future dates ");
            }
            if (checkOut <= checkIn)
            {
                throw new domainException("Error in reservation: Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Dutation() + " nights";
        }
    }
}
