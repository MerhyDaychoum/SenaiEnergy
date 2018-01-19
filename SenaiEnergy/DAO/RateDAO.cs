using MongoDB.Driver;
using SenaiEnergy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SenaiEnergy.DAO
{
    public class RateDAO : ContextAsyncDAO<Rate>
    {
        public RateDAO()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        public async Task CreateRate(Rate rate)
        {
            await Collection.InsertOneAsync(rate);
        }

        public async Task<List<Rate>> ListAllRate()
        {
            var filter = FilterBuilder.Exists(a => a.DeletedAt, false);

            return await Collection.Find(filter).ToListAsync();
        }
    }
}