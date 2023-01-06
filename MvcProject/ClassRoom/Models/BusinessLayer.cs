namespace DataLayer.Models;
using System.Collections.Generic;
using Students.Models;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
public static class DataStore{



   public static void CollectData(int id,string name,string mail,string pass,List<Student> stud)
   {
      stud.Add(new Student(id,name,mail,pass));
      IoSerealization(stud);
   }

    public static void IoSerealization(List<Student> stud)
    {
        var options=new JsonSerializerOptions {IncludeFields=true};
        var studentJson=JsonSerializer.Serialize<List<Student>>(stud,options);
        string filename=@"D:\DoTNeT\dotnet\MvcProject\ClassRoom\studentDay.json";
        File.WriteAllText(filename,studentJson);

    }

     public static List<Student> DeserializeIo()
    {
        var options=new JsonSerializerOptions {IncludeFields=true};
        string filename=@"D:\DoTNeT\dotnet\MvcProject\ClassRoom\studentDay.json";
        string jsonString=File.ReadAllText(filename);
        List<Student> jsonStudents=JsonSerializer.Deserialize<List<Student>>(jsonString);
        return jsonStudents;

    }


}