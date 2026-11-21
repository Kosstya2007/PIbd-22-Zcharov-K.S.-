
namespace Pibd_22_Zacharov.K.S_OTP;

public class DailySalesRepositoryStub : IDailySalesRepository
{
    private readonly List<DailySales> _sales = new();

    public IEnumerable<DailySales> GetAll() => _sales;
    public void Add(DailySales sales) => _sales.Add(sales);
}