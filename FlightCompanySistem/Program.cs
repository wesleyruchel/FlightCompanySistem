using FlightCompanySistem.Factories;
using FlightCompanySistem.Flights;

IFlightFactory factory = new EconomyFlightFactory();
IFlight flight = factory.CreateFlight();

flight.BookTicket();
flight.AssignSeat();

Console.ReadLine();
