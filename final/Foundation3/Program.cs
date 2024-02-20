using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture1 = new Lecture();
        lecture1.SetTitle("Making Study Not Suck");
        lecture1.SetDescription("Learn how to take advantage of micro-studying and increase your grades and freetime.");
        lecture1.SetDate("Thursday, February 29, 2024");
        lecture1.SetTime("7am");
        lecture1.SetAddress("19 E Wallaby Way, Sydney, Austraila");
        lecture1.SetLimit("250");
        lecture1.SetSpeaker("Spencer Matthews");
//-------------------------------------------------------------
        Console.WriteLine("\n--------------------------------------------------\n");

        Console.WriteLine(lecture1.GetStandardDetails(lecture1.GetTitle(), lecture1.GetDescription(), lecture1.GetDate(), lecture1.GetTime(), lecture1.GetAddress()));
        
        Console.WriteLine("");

        Console.WriteLine(lecture1.GetFullDetails(lecture1.GetTitle(), lecture1.GetDescription(), lecture1.GetDate(), lecture1.GetTime(), lecture1.GetAddress(), "Lecture", lecture1.GetLimit(), lecture1.GetSpeaker()));

        Console.WriteLine("");

        Console.WriteLine(lecture1.GetShortDescription(lecture1.GetTitle(), lecture1.GetDate()));
//-------------------------------------------------------------
        Reception reception1 = new Reception();
        reception1.SetTitle("Jake and Shae's Wedding Celebration");
        reception1.SetDescription("Celebrate with Jake and Shae Romm as they start their lives together!");
        reception1.SetDate("Wednesday, July 15, 2024");
        reception1.SetTime("6:30pm");
        reception1.SetAddress("97 W 1600 S, Provo, Utah");
        reception1.SetRsvp("jakenshaewedding@gmail.com");
//-------------------------------------------------------------
        Console.WriteLine("\n--------------------------------------------------\n");

        Console.WriteLine(reception1.GetStandardDetails(reception1.GetTitle(), reception1.GetDescription(), reception1.GetDate(), reception1.GetTime(), reception1.GetAddress()));

        Console.WriteLine("");

        Console.WriteLine(reception1.GetFullDetails(reception1.GetTitle(), reception1.GetDescription(), reception1.GetDate(), reception1.GetTime(), reception1.GetAddress(), "Reception", "na", "na", reception1.GetRsvp()));

        Console.WriteLine("");

        Console.WriteLine(reception1.GetShortDescription(reception1.GetTitle(), reception1.GetDate()));
//-------------------------------------------------------------
        Outdoor outdoor1 = new Outdoor();
        outdoor1.SetTitle("The Salt Lake Music Festival");
        outdoor1.SetDescription("Local bands and feature artists showcasing their newest material.");
        outdoor1.SetDate("Saturday, September 20, 2024");
        outdoor1.SetTime("5pm");
        outdoor1.SetAddress("501 W South Temple, Salt Lake City, Utah");
        outdoor1.SetWeather("65 degrees and partly cloudy");
//-------------------------------------------------------------
        Console.WriteLine("\n--------------------------------------------------\n");

        Console.WriteLine(outdoor1.GetStandardDetails(outdoor1.GetTitle(), outdoor1.GetDescription(), outdoor1.GetDate(), outdoor1.GetTime(), outdoor1.GetAddress()));

        Console.WriteLine("");

        Console.WriteLine(outdoor1.GetFullDetails(outdoor1.GetTitle(), outdoor1.GetDescription(), outdoor1.GetDate(), outdoor1.GetTime(), outdoor1.GetAddress(), "Outdoor Event", "na", "na", "no", outdoor1.GetWeather()));

        Console.WriteLine("");

        Console.WriteLine(outdoor1.GetShortDescription(outdoor1.GetTitle(), outdoor1.GetDate()));
//-------------------------------------------------------------
        Console.WriteLine("\n--------------------------------------------------\n");
    }
}