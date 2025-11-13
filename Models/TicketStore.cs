namespace C__Day_3_ASP.NET_MVC.Models
{
    public static class TicketsStore
    {
        public static Dictionary<string, int> Tickets = new() 
        {
            { "North Hall", 12 },
            { "East Hall", 5 },
            { "South Hall", 17 }
        };
    }
}
