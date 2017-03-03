using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApplication2 {


  class Program {
    static void Main(string[] args) {
      MainAsync5().Wait();

      Console.WriteLine("Press enter to exit");
      Console.ReadLine();
    }

    static async Task MainAsync5() {

      var client = new MongoClient();

      IMongoDatabase db = client.GetDatabase("schoool6");

      var collection = db.GetCollection<Student>("students");
      await collection.Find(student =>  student.FirstName != "Peter")
          .ForEachAsync(student => Console.WriteLine(student.FirstName + " " + student.LastName));
    }
     
    static async Task MainAsync() {

      var client = new MongoClient();

      IMongoDatabase db = client.GetDatabase("schoool");

      var collection = db.GetCollection<Student>("students");
      var newStudents = CreateNewStudents();

      await collection.InsertManyAsync(newStudents);
 
    }

    private static object ModifiedStudents(IEnumerable<Student> newStudents) {
      throw new NotImplementedException();
    }

    private static IEnumerable<Student> CreateNewStudents() {
      var student1 = new Student
      {
        FirstName = "Hugo",
        LastName = "Damian",
        Subjects = new List<Course>()  {Course.English, Course.Math, Course.ProgrammingC },
        Class = "JSS 3",
        Age= 12
    };

      var student2 = new Student
      {
        FirstName = "Don",
        LastName = "Perez",
        Subjects = new List<Course>() { Course.ProgrammingC, Course.ProgrammingCSharp, Course.ProgrammingJquery },
        Class = " JKD 32",
        Age = 23
      };

      var student3 = new Student
      {
        FirstName = "Jorge",
        LastName = "Stop",
        Subjects = new List<Course> { Course.ProgrammingJquery, Course.ProgrammingJavascript },
        Class = "JDK 323",
        Age = 32 
    };

      var newStudents = new List<Student>();
      newStudents.Add(student1);
      newStudents.Add(student2);
      newStudents.Add(student3);

      return newStudents;
    }
  }







}
