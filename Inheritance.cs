using System;
public class Person{
     public string Name { get; set; }
    public int Age { get; set; }
public Person( string name,int age){
    Name=name;
    Age=age;
}
public virtual void DisplayDetail(){
    Console.WriteLine($"Name : {Name}\n  Age :  {Age}");
}

}

public class Students:Person{
    public Students(string name,int age):base(name,age){
        
    }
    public override void DisplayDetail()
    {
        Console.WriteLine($"Student Name : {Name}\n Age :{Age}\n ");
    }

}
public class Teacher : Person{
    public string ? Subject{get;set;}
    public Teacher(string name,int age,string subject):base(name,age){
        Subject=subject;
    }
    public override void DisplayDetail()
    {
        Console.WriteLine($"Teacher Name: {Name}\n Age :{Age} \n Subject : {Subject}");

    }
}

