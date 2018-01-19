using MongoDB.Bson;
using SenaiEnergy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SenaiEnergy.Models.EquimentViewModel
{
    public class CreateEquimentViewModel
    {
        [Required(ErrorMessage = "O nome do equipamento é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A energia é obrigatória")]
        public float Power { get; set; }

        public Equipment ToEquipment()
        {
            return new Equipment
            {
                Name = Name,
                Power = Power
            };
        }
    }
}