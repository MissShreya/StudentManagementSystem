using System;
public abstract class PersonAbs{
    public string ? Name{get;set;}
    public int Age{get;set;}
public abstract void PrintDetail();
}
public class StudentAbs:PersonAbs{
    public string? Grade{get;set;}
public override void PrintDetail(){
    Console.WriteLine($"Abstraction Student Name : {Name}\n Age :{Age}\n Grade : {Grade}");
}
}
public class TeacherAbs:PersonAbs{
    public string? Subject{get;set;}
public override void PrintDetail(){
    Console.WriteLine($"Abstraction Teacher Name : {Name}\n Age :{Age}\n Subject: {Subject}");
}
}

