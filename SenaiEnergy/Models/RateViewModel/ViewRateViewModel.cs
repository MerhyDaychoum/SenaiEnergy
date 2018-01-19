using MongoDB.Bson;
using Newtonsoft.Json;
using SenaiEnergy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SenaiEnergy.Models.RateViewModel
{
    public class ViewRateViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public ObjectId Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        public ViewRateViewModel(Rate rate)
        {
            Id = rate.Id;
            Name = rate.Name;
            Value = rate.Value;
        }

        public ViewRateViewModel()
        {

        }

        public static List<ViewRateViewModel> ToList(List<Rate> rates)
        {
            List<ViewRateViewModel> ratesList = new List<ViewRateViewModel>();

            foreach (var rate in rates)
            {
                ratesList.Add(new ViewRateViewModel(rate));
            }

            return ratesList;
        }
    }
}