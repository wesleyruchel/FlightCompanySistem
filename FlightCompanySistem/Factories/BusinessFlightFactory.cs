using FlightCompanySistem.Flights;

namespace FlightCompanySistem.Factories
{
    class BusinessFlightFactory : IFlightFactory
    {
        public IFlight CreateFlight() => new BusinessFlight();
    }
}
