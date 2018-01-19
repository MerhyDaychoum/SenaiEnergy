using SenaiEnergy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SenaiEnergy.Models.RateViewModel
{
    public class CreateRateViewModel
    {
        [Required(ErrorMessage = "Nome da taxa é obrigatória!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Valor da taxa é obrigatório!")]
        public double Value { get; set; }

        public Rate ToRate()
        {
            return new Rate
            {
                Name = Name,
                Value = Value
            };
        }
    }
}