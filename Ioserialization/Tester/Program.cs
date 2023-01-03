using Catalog;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


Student s1=new Student(2,"Prathmesh","prath@gmail.com",new DateTime(1996,08,22),"565656",12345);
Student s2=new Student(3,"Akshay","aksh@gmail.com",new DateTime(1996,08,23),"575757",54321);
Student s3=new Student(4,"akshobhya","aksho@gmail.com",new DateTime(1996,08,24),"585858",45678);
Student s4=new Student(5,"sourav","saou@gmail.com",new DateTime(1996,08,25),"595959",87654);
Student s5=new Student(6,"suraj","bhau@gmail.com",new DateTime(1996,08,26),"606060",78945);

List<Student> students=new List<Student>();
students.Add(s1);
students.Add(s2);
students.Add(s3);
students.Add(s4);
students.Add(s5);
IOconnection.SerializationIo(students);
//string jsonString = JsonSerializer.Serialize(employee);
 
bool exit=false;

           
    while(!exit)
    {
        Console.WriteLine("Choose Options \n1:Insert\n2:Update\n3:Delete\n4:Get By Id\n5:Get All Records\n6:Exit");
        int choice=Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
        Console.WriteLine("Enter Student Info As StudentID  Name Email PassWord MobileNo");
        int sid=Convert.ToInt32(Console.ReadLine());
        string sname=Console.ReadLine();
        string smail=Console.ReadLine();
        DateTime dob=new DateTime(1999,01,08);
        string pass=Console.ReadLine();
        int mno=Convert.ToInt32(Console.ReadLine());
        Student s=new Student(sid,sname,smail,dob,pass,mno);
        students.Add(s);
        IOconnection.SerializationIo(students);

        break;
        case 2:
        Console.WriteLine("Enter Student Id ");
        int id=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i< students.Count;i++)
        {
            if(students[i].StudentId==id)
            {
              Console.WriteLine("Enter New MobileNo");
              students[i].MobileNo=Convert.ToInt32(Console.ReadLine());
              IOconnection.SerializationIo(students);
              break;
            }
        }
        break;
        case 5:
        Console.WriteLine("________ALL DATA_______");
        
            List<Student> jsonStudents=IOconnection.DeserializeIo();
            foreach (Student a in jsonStudents)
            {
                Console.WriteLine($"{a.StudentId} : {a.Name} : {a.Email} : {a.Dob} : {a.Password} : {a.MobileNo}");
            }
        break;
        case 6:
        exit=true;
        break;

        
    }
    }

