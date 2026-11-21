namespace Pibd_22_Zacharov.K.S_OTP;

public interface IFlightOperationRepository
{
    IEnumerable<FlightOperation> GetAll();
    void Add(FlightOperation operation);
}