// See https://aka.ms/new-console-template for more information
using Console_App__22_aprel_.Exceptions;
using Console_App__22_aprel_.Models;
using Console_App__22_aprel_.Services;

HotelService hotelService = new HotelService();
RoomService roomService = new RoomService();
do
{
start:
    Console.WriteLine("1.Sisteme giris\r\n0.Cixis\r\n2.Temizle");
    string userNumber1 = Console.ReadLine();
    switch (userNumber1)
    {
        case "1":
        start2: Console.WriteLine("1.Hotel yarat\r\n2.Butun Hotelleri gor\r\n3.Hotel sec\r\n0.Exit\r\n");
        string userNumber2 = Console.ReadLine();
        switch (userNumber2)
        {
            //Hotelin yaradilmasi
            case "1":
                Console.WriteLine("Hotelin adini daxil edin:");
                string nameofHotel = Console.ReadLine();
                Hotel hotel1 = new Hotel(nameofHotel);
                try
                {
                    hotelService.AddHotel(hotel1);
                    goto start;
                }
                catch (NotAvailableException ex)
                {
                      
                    Console.WriteLine(ex.Message);
                }
                break;
            //Hotelin gosterilmesi
            case "2":
                try
                {
                    hotelService.ShowAllHotel();
                }
                catch (NotAvailableException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                break;
            //Hotelin seçilmesi
            case "3":
                start3: Console.WriteLine("1.Room yarat\r\n2.Roomlari gor\r\n3.Rezervasya et\r\n4.Evvelki menuya qayit.\r\n0.Exit\r\n");
                string userNumber3 = Console.ReadLine();
                switch (userNumber3)
                {
                    case "1":
                        Console.WriteLine("Otaqin adini daxil edin:");
                        string roomofName = Console.ReadLine();

                            Console.WriteLine("Otaqin qiymetini daxil edin:");
                            double roomPrice = 0;
                            try
                            {
                                roomPrice = double.Parse(Console.ReadLine());
                          
                        }
                        catch (NotAvailableException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto case "1";
                        }
                            if (roomPrice<=50)
                            {
                                Console.Clear();
                                Console.WriteLine($"{roomPrice} AZN-e otaq elave etmek mumkun deyil.Yeniden yoxlayin. min 50 AZN olmalidir");
                                goto start3;
                            }
                            else
                            {
                                try
                                {

                                    Console.WriteLine("Otaq nece neferlikdir?");
                                    byte personCapacity = byte.Parse(Console.ReadLine());
                                    Room room = new Room(roomofName, roomPrice, personCapacity);

                                    roomService.AddRoom(room);
                                    Console.WriteLine("added room");

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    goto case "1";

                                }
                            }
                        break;
                    case "2":
                        try
                        {

                            roomService.GetAllRoom();
                        }
                        catch (NotAvailableException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto start2;
                        }
                        break;
                    case "4":
                            goto start2;
                            
                    default:
                        break;
                }
                break;

            default:
                break;
        }
        break;

    case "2":
        Console.Clear();
        break;
    case "3":
            goto start;
    case "0":
            Console.WriteLine("Sistem sonduruldu");
            return;
    default:
        break;
    }

} while (true);
