namespace Pibd_22_Zacharov.K.S_OTP;

public class FlightOperationRepositoryStub : IFlightOperationRepository
{
    private readonly List<FlightOperation> _operations = new();

    public IEnumerable<FlightOperation> GetAll() => _operations;
    public void Add(FlightOperation operation) => _operations.Add(operation);
}