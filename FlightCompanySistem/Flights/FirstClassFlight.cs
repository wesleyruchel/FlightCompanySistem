namespace FlightCompanySistem.Flights
{
    class FirstClassFlight : IFlight
    {
        public void AssignSeat()
        {
            Console.WriteLine("Assign seat for First Class Flight!");
        }

        public void BookTicket()
        {
            Console.WriteLine("Book a Ticket for First Class Flight!");
        }
    }
}
