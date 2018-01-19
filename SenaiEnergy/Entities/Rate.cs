using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SenaiEnergy.Entities
{
    public class Rate
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("value")]
        public double Value { get; set; }

        [BsonElement("deletedAt"), BsonIgnoreIfNull]
        public DateTime? DeletedAt { get; set; }
    }
}