namespace FlightCompanySistem.Flights
{
    class BusinessFlight : IFlight
    {
        public void AssignSeat()
        {
            Console.WriteLine("Assign seat for Business Flight!");
        }

        public void BookTicket()
        {
            Console.WriteLine("Book a Ticket for Businees Flight!");
        }
    }
}
