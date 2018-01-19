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
    public class EquipmentBO
    {
        private EquipmentDAO _equipmentDao;

        public EquipmentBO()
        {
            _equipmentDao = new EquipmentDAO();
        }

        public async Task<Equipment> CreateEquipment(Equipment equipment)
        {
            equipment.Id = ObjectId.GenerateNewId();
            await _equipmentDao.CreateEquipment(equipment);
            return equipment;
        }

        public async Task<List<Equipment>> ListAllEquipment()
        {
            return await _equipmentDao.ListAllEquipments();
        } 
    }
}