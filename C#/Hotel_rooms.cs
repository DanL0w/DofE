using System;
using System.Collections.Generic;
using System.Text;

namespace AS_prog_FULL
{
    internal class Hotel_rooms
    {
        public static void Run()
        {
            int total = 0;
            int[,] HotelRooms = { { 101, 102, 103, 104, 105}, 
                                  { 201, 202, 203, 204, 205},
                                  { 301, 302, 303, 304, 305},
                                  { 401, 402, 403, 404, 405},
                                  { 501, 502, 503, 504, 505}
            };
            for (int Floor = 0; Floor < HotelRooms.GetLength(0); Floor++)
            {
                for (int Room = 0; Room < HotelRooms.GetLength(1); Room++)
                {
                    total = total + HotelRooms[Floor, Room];
                };
            }
            Console.WriteLine(total);
        }
    }
}
