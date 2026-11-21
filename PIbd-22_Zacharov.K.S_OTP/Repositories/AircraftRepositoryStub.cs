namespace Pibd_22_Zacharov.K.S_OTP;

public class AircraftRepositoryStub : IAircraftRepository
{
    private readonly List<Aircraft> _aircrafts = new();

    public IEnumerable<Aircraft> GetAll() => _aircrafts;
    public Aircraft? GetById(int id) => _aircrafts.FirstOrDefault(a => a.AircraftId == id);
    public void Add(Aircraft aircraft) => _aircrafts.Add(aircraft);

    public void Update(Aircraft aircraft)
    {
        var index = _aircrafts.FindIndex(a => a.AircraftId == aircraft.AircraftId);
        if (index != -1) _aircrafts[index] = aircraft;
    }

    public void Delete(int id) => _aircrafts.RemoveAll(a => a.AircraftId == id);
}