using FlightCompanySistem.Flights;

namespace FlightCompanySistem.Factories
{
    class FirstClassFlightFactory : IFlightFactory
    {
        public IFlight CreateFlight() => new FirstClassFlight();
    }
}
