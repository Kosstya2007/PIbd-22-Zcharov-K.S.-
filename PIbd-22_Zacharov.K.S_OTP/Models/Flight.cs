namespace Pibd_22_Zacharov.K.S_OTP;

public class Flight
{
    public int FlightId { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public TimeOnly DepartureTime { get; set; }
    public TimeOnly ArrivalTime { get; set; }
    public WeekDays OperatingDays { get; set; } = WeekDays.None;

    public bool IsOperatedOn(WeekDays day)
    {
        return OperatingDays.HasFlag(day);
    }
}