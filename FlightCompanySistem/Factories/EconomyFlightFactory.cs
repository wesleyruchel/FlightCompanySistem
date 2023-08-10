using FlightCompanySistem.Flights;

namespace FlightCompanySistem.Factories
{
    class EconomyFlightFactory : IFlightFactory
    {
        public IFlight CreateFlight() => new EconomyFlight();
    }
}
