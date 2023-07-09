using Backend.Models;
using MongoDB.Driver;

namespace Backend.Services
{
    public class CalcService : ICalcService
    {
        private readonly IMongoCollection<Calculation> _calculation;

        public CalcService(IDbConfig settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DbName);
            _calculation = database.GetCollection<Calculation>(settings.CollectionName);
        }
        public Calculation Create(Calculation calculation)
        {
            _calculation.InsertOne(calculation);
            return calculation;
        }
        public List<Calculation> Get()
        {
            return _calculation.Find(calculation => true).ToList();
        }

        public Calculation Get(string id)
        {
            return _calculation.Find(calculation => calculation.Id == id).FirstOrDefault();
        }
    }
}
