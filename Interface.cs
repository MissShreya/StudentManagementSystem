using System;
public abstract class PersonInt{
    public string ? Name {get;set;}
    public int Age{get;set;}

    public PersonInt(string name,int age){
        Name=name;
        Age=age;
    }

    public abstract string PrintDetailIns();
}

public interface IAttendance{
    void MarkAttendance();
}

public class StudentIns:PersonInt,IAttendance{
    public string StudentID{get;set;}
    public StudentIns(string name, int age, string studentid):base(name,age){
        StudentID=studentid;
    }
    public override string PrintDetailIns()
    {
        return $"Name : {Name}\n Age :{Age}\n Student ID :{StudentID}";
    }
    public void MarkAttendance(){
        Console.WriteLine($"Student {Name} marked as present.");
    }
}
public class TeacherIns:PersonInt,IAttendance{
    public string Subject { get; set; }
    public TeacherIns(string name, int age, string subject):base(name,age){
        Subject=subject;
    }
    public override string PrintDetailIns()
    {
        return $"Teacher Name : {Name}\n Age :{Age}\n Subject :{Subject}";
    }
    public void MarkAttendance(){
         Console.WriteLine($"Teacher {Name} marked as present.");
    }
}