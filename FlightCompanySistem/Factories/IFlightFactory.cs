using FlightCompanySistem.Flights;

namespace FlightCompanySistem.Factories
{
    interface IFlightFactory
    {
        abstract IFlight CreateFlight();
    }
}
