using System;
using GuestBookLibrary;

namespace GuestBook;

class Program
{
    private static List<GuestModel> guests = new List<GuestModel>();

    static void Main(string[] args)
    {
        Console.WriteLine("=== Guest Book ===");

        GetGuestInformation();
        PrintGuestInformation();

        Console.ReadLine();
    }

    private static void GetGuestInformation()
    {
        string moreGuestsComing = "";

        do // Run it at least once
        {
            GuestModel guest = new GuestModel(); // This represents ONE guest!
            
            guest.FirstName = GetInfoFromConsole("What is your first name: ");
            guest.LastName = GetInfoFromConsole("What is your last name: ");
            guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
            moreGuestsComing = GetInfoFromConsole("Are more guests coming? (yes/no)");
            
            guests.Add(guest);

            Console.Clear();

        } while (moreGuestsComing.ToLower() == "yes"); // As long as..
    }

    private static void PrintGuestInformation()
    {
        foreach (GuestModel guest in guests)
        {
            Console.WriteLine(guest.GuestInfo);
        }
    }

    private static string GetInfoFromConsole(string message) // Refactors 
    {
        string output = "";

        Console.Write(message);
        output = Console.ReadLine();

        return output;
    }
}
