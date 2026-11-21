namespace Pibd_22_Zacharov.K.S_OTP;

public class DailySales
{
    public int DailySalesId { get; set; }
    public DateOnly Date { get; set; }
    public int TicketsSold { get; set; }
    public decimal Revenue { get; set; }
    public int FlightOperationId { get; set; }
}