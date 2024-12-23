public class Constructor{
    public required string Name {get;set;}
    public  int ? Roll {get;set;}
    public string ? Grade {get;set;}

    public Constructor(){
        Name="Unknown";
        Roll=0;
        Grade="Not Declare";
    }

    public void PrintDetail(){
        Console.WriteLine($"Name:{Name}\n Roll :{Roll}\n Grade :{Grade}");
    }


}