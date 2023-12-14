var HotelBooking1 = new HotelBooking("Joao", new DateTime(2008, 8, 29, 19, 27, 15), 15);

Console.WriteLine(HotelBooking1.GuestName);
Console.WriteLine(HotelBooking1.StartDate);
Console.WriteLine(HotelBooking1.EndDate);

public class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
    }
}

class Test
{
    public string Test1;
    public string Test2;

    public Test(string test1, string test2)
    {
        Test1 = test1;
        Test2 = test2;
    }
}