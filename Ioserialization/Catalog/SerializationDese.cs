using Catalog;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
public static class IOconnection{

    public static void SerializationIo(List<Student> students)
    {
        Console.WriteLine("-----------------------------");
         var options=new JsonSerializerOptions {IncludeFields=true};
         var studentJson=JsonSerializer.Serialize<List<Student>>(students,options);
         string filename=@"D:\DoTNeT\dotnet\Ioserialization\student.json";
          File.WriteAllText(filename,studentJson);
    }

    public static List<Student> DeserializeIo()
    {
        string filename=@"D:\DoTNeT\dotnet\Ioserialization\student.json";
        string jsonString=File.ReadAllText(filename);
        List<Student> jsonStudents=JsonSerializer.Deserialize<List<Student>>(jsonString);
        return jsonStudents;

    }
}