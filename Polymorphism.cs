using System;
using System.Reflection;
public class Person1{
    public string? Name{get;set;}
    public virtual void PrintDetail(){
        Console.WriteLine($"Person Name : {Name}");
    }
}
public class Student1:Person1{
    public int Age{get;set;}
    public string? Grade{get;set;}
    public override void PrintDetail()
    {
        Console.WriteLine($"Student Name : {Name}\n Age : {Age}\n Grade : {Grade}");
    }

} 
public class Teacher1 : Person1{
    public string? Subject {get;set;}
    public override void PrintDetail()
    {
        Console.WriteLine($"Teacher Name : {Name}\n Subject : {Subject}");
    }
}