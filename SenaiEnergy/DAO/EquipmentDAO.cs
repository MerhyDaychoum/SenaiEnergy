using MongoDB.Driver;
using SenaiEnergy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SenaiEnergy.DAO
{
    public class EquipmentDAO : ContextAsyncDAO<Equipment>
    {
        public EquipmentDAO()
        {

        }

        /// <summary>
        /// Use this method for help for create equipment.
        /// </summary>
        /// <param name="equipment"></param>
        public async Task CreateEquipment(Equipment equipment)
        {
            await Collection.InsertOneAsync(equipment);
        }

        /// <summary>
        /// List all equipment if deletedAt equal false.
        /// </summary>
        /// <returns> return Equipments </returns>
        public async Task<List<Equipment>> ListAllEquipments()
        {
            var filter = FilterBuilder.Exists(a => a.DeletedAt, false);

            return await Collection.Find(filter).ToListAsync();
        }
    }
}