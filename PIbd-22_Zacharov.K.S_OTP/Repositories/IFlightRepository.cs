namespace Pibd_22_Zacharov.K.S_OTP;

public interface IFlightRepository
{
    IEnumerable<Flight> GetAll();
    Flight? GetById(int id);
    void Add(Flight flight);
    void Update(Flight flight);
    void Delete(int id);
}