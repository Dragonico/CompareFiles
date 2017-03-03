using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1 {
  public class BusinessManager {

    public async void Instantiate(Student newStudent) {

      var client = new MongoClient();

      IMongoDatabase db = client.GetDatabase("schoool");

      var collection = db.GetCollection<Student>("students");

      await collection.InsertOneAsync(newStudent);
    }
  }
}
