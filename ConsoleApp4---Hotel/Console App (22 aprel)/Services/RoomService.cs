using Console_App__22_aprel_.Exceptions;
using Console_App__22_aprel_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App__22_aprel_.Services;

public class RoomService
{
    public int counter =1 ;
    List<Room> rooms = new List<Room>();
    #region CREATE
    public void AddRoom(Room room)
    {
        room.Id = counter++;
        rooms.Add(room);
       
    }
    #endregion

    #region READ
    public void GetAllRoom()
    {
        if (rooms.Count !=0)
        {
            foreach (var item in rooms)
            {
                Console.WriteLine($"No:{item.Id} name:{item.RoomName}");
            }
        }
        else
        {
            throw new NotAvailableException("Hec bir otaq tapilmadi.");
        }
    }
    #endregion
}
