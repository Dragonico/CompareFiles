using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2 {
  [BsonIgnoreExtraElements]
  public class Player {
    public ObjectId id { get; set; } 
    public string firstName { get; set; }

    public string lastName { get; set; }
  }
}
