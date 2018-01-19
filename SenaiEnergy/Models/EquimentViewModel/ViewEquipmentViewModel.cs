using MongoDB.Bson;
using Newtonsoft.Json;
using SenaiEnergy.BO;
using SenaiEnergy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SenaiEnergy.Models.EquimentViewModel
{
    public class ViewEquipmentViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public ObjectId Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "power")]
        public float Power { get; set; }

        public ViewEquipmentViewModel(Equipment equipment)
        {
            Id = equipment.Id;
            Name = equipment.Name;
            Power = equipment.Power;
        }

        public ViewEquipmentViewModel()
        {

        }

        public static List<ViewEquipmentViewModel> ToList(List<Equipment> equipments)
        {
            List<ViewEquipmentViewModel> equipmentsList = new List<ViewEquipmentViewModel>();

            foreach (var equipment in equipments)
            {
                equipmentsList.Add(new ViewEquipmentViewModel(equipment));
            }

            return equipmentsList;
        }
    }
}