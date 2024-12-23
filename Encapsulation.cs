using System;
public class Encapsulation{
    private string name="";
    private int rollnumber;
    private string grade="";

    
    public string Name
    {
        get => name; // Use shorthand for getter
        set => name = value; // Use shorthand for setter
    }
public int Rollnumber{
    get =>rollnumber;
    set=> rollnumber=value;
}
public string Grade{
    get=> grade;
    set{
        if(value=="A+" || value=="A" ||value=="B+" || value=="B"|| value=="C" || value =="D" || value =="E" || value=="F" ){
            grade=value;
        }
        else{
            Console.WriteLine("Invalid grade! Please enter a valid grade.");
        }
    }  
}
public void PrintDetail(){
    Console.WriteLine($"Name : {Name}\n RollNumber : {Rollnumber}\n Grade :{Grade}");
}
}