using MongoDB.Bson;
using SenaiEnergy.DAO;
using SenaiEnergy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SenaiEnergy.BO
{
    public class RateBO
    {
        private RateDAO _rateDao;

        public RateBO()
        {
            _rateDao = new RateDAO();
        }

        public async Task<Rate> CreateRate(Rate rate)
        {
            rate.Id = ObjectId.GenerateNewId();
            await _rateDao.CreateRate(rate);
            return rate;
        }

        public async Task<List<Rate>> ListAllRate()
        {
            return await _rateDao.ListAllRate();
        }
    }
}