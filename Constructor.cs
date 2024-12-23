public class Student{
    public string? Name {get;set;}
    public  int ? Roll {get;set;}
    public string ? Grade {get;set;}

    public Student(){
        Name="Unknown";
        Roll=0;
        Grade="Not Declare";
    }
    public Student(string name,int roll,string grade){
        Name=name;
        Roll =roll;
        Grade=grade;
    }

    public void PrintDetail(){
        Console.WriteLine($"Name:{Name}\n Roll :{Roll}\n Grade :{Grade}");
    }


}