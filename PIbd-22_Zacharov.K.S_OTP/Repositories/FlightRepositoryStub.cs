namespace Pibd_22_Zacharov.K.S_OTP;

public class FlightRepositoryStub : IFlightRepository
{
    private readonly List<Flight> _flights = new();

    public IEnumerable<Flight> GetAll() => _flights;
    public Flight? GetById(int id) => _flights.FirstOrDefault(f => f.FlightId == id);
    public void Add(Flight flight) => _flights.Add(flight);

    public void Update(Flight flight)
    {
        var index = _flights.FindIndex(f => f.FlightId == flight.FlightId);
        if (index != -1) _flights[index] = flight;
    }

    public void Delete(int id) => _flights.RemoveAll(f => f.FlightId == id);
}