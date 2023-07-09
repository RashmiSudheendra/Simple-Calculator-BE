using Backend.Models;

namespace Backend.Services
{
    public interface ICalcService
    {
        List<Calculation> Get();    
        Calculation Get(string id);
        Calculation Create(Calculation calculation);

    }
}
