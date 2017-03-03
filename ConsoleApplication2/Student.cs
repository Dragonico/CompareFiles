using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
  [BsonIgnoreExtraElements]
  public class Student {
    public ObjectId id { get; set; } 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Class { get; set; }
    public int Age { get; set; }
    public IEnumerable<Course> Subjects { get; set; }
  }
}
