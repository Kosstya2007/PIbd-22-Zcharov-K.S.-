namespace AirlineAccounting;

public class FlightOperation
{
    public int FlightOperationId { get; set; }
    public DateOnly Date { get; set; }
    public int OccupiedSeats { get; set; }
    public int Capacity { get; set; }
    public int FlightId { get; set; }
    public int AircraftId { get; set; }

    public int FreeSeats
    {
        get { return Capacity - OccupiedSeats; }
    }
}