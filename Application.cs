public class Application{
    public required string Name{get;set;}
    public required int Rollnumber{get;set;}
    public string ? Grade{get;set;}

    public void PrintStudentDetail(){
        Console.WriteLine($"Name:{Name}\n Roll Number : {Rollnumber}\n Grade : {Grade}");
    }


}