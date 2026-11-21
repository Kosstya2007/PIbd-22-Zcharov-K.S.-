namespace Pibd_22_Zacharov.K.S_OTP;

public interface IDailySalesRepository
{
    IEnumerable<DailySales> GetAll();
    void Add(DailySales sales);
}