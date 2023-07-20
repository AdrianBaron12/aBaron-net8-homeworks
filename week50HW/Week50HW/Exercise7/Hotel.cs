using OOPADV.Exercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPADV.Exercise7
{
    public enum BedType
    {
        SingleSize,
        DoubleSize,
        QueenSize
    };

    public interface IBooking
    {
        bool IsBooked { get; }
        void BookedRoom();
    }

    public interface IClean
    {
        bool IsClean { get; }
        void Clean();
    }

    public abstract class Room
    {

        private int roomId;
        private decimal roomPricePerNight;

        public Room()
        {
        }

        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }

        public decimal RoomPricePerNight
        {
            get { return roomPricePerNight; }
            set { roomPricePerNight = value; }
        }

        public Room(int roomId, decimal roomPricePerNight)
        {
            this.roomId = roomId;
            this.roomPricePerNight = roomPricePerNight;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Room Number : {roomId} , Price per night : {roomPricePerNight}");
        }

        public abstract bool HasChildBed();

    }

    public class StandardRoom : Room, IBooking, IClean
    {
        public static int standardRoomsOccupied = 0;
        private BedType bedtype;
        public bool IsBooked { get; private set; }
        public bool IsClean { get; private set; }

        public StandardRoom(int roomId, decimal roomPricePerNight, BedType bedType)
        {
            this.RoomId = roomId;
            this.RoomPricePerNight = roomPricePerNight;
            this.bedtype = bedType;
            IsBooked = false;
            IsClean = false;
            standardRoomsOccupied++;
        }

        public StandardRoom(int roomId, decimal roomPricePerNight, BedType bedType, int discountAmount)
        {
            this.RoomId = roomId;
            this.RoomPricePerNight = roomPricePerNight - discountAmount;
            this.bedtype = bedType;
            IsBooked = false;
            IsClean = false;
            standardRoomsOccupied++;

        }

        public void BookedRoom()
        {
            if (IsBooked == false)
            {
                IsBooked = true;
                Console.WriteLine($"Room Number : {RoomId} is booked now");
            }
            else
            {
                Console.WriteLine($"Room Number: {RoomId} is already booked");
            }
        }

        public void Clean()
        {
            if (IsClean == false)
            {
                Console.WriteLine($"You need to clean Room number : {RoomId} ");
                IsClean = true;

            }
            else
            {
                Console.WriteLine($"Room number {RoomId} is cleaned ");
            }
        }

        public override bool HasChildBed()
        {
            return false;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The room {RoomId} , has the price {RoomPricePerNight}. The bed available are {bedtype}. Booked : {(IsBooked ? "Yes" : "No")}, Cleaned : {(IsClean ? "Yes" : "No")}. Is Child Bed available? : {HasChildBed()}");
            Console.WriteLine($"Number of standard rooms occupied : {standardRoomsOccupied}");
        }


    }

    public class ExclusiveRoom : Room, IBooking, IClean
    {
        public static int exclusiveRoomsOccupied = 0;
        private BedType bedtype;
        public bool IsBooked { get; private set; }
        public bool IsClean { get; private set; }

        public ExclusiveRoom(int roomId, decimal roomPricePerNight, BedType bedType)
        {
            this.RoomId = roomId;
            this.RoomPricePerNight = roomPricePerNight;
            this.bedtype = bedType;
            IsBooked = false;
            IsClean = false;
            exclusiveRoomsOccupied++;
        }

        public ExclusiveRoom(int roomId, decimal roomPricePerNight, BedType bedType, int discountAmount)
        {
            this.RoomId = roomId;
            this.RoomPricePerNight = roomPricePerNight - discountAmount;
            this.bedtype = bedType;
            IsBooked = false;
            IsClean = false;
            exclusiveRoomsOccupied++;

        }



        public void BookedRoom()
        {
            if (IsBooked == false)
            {
                IsBooked = true;
                Console.WriteLine($"Room Number : {RoomId} is booked now");
            }
            else
            {
                Console.WriteLine($"Room Number: {RoomId} is already booked");
            }
        }

        public void Clean()
        {
            if (IsClean == false)
            {
                Console.WriteLine($"You need to clean Room number : {RoomId} ");
                IsClean = true;

            }
            else
            {
                Console.WriteLine($"Room number {RoomId} is cleaned ");
            }
        }

        public override bool HasChildBed()
        {
            return true;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The room {RoomId} , has the price {RoomPricePerNight}. The bed available are {bedtype}. Booked : {(IsBooked ? "Yes" : "No")}, Cleaned : {(IsClean ? "Yes" : "No")}. Is Child Bed available? : {HasChildBed()}");
            Console.WriteLine($"Number of exclusive rooms occupied : {exclusiveRoomsOccupied}");
        }
    }
}
