namespace FlightCompanySistem.Flights
{
    class EconomyFlight : IFlight
    {
        public void AssignSeat()
        {
            Console.WriteLine("Assign seat for Economy Flight!");
        }

        public void BookTicket()
        {
            Console.WriteLine("Book a Ticket for Economy Flight!");
        }
    }
}
