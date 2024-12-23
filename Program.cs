
using System;
class Program{
    public static void Main(string[] args){
        Application StudentData1= new Application{Name = "Shreyanshi Srivastava",Rollnumber = 1,Grade ="A"};
        Application StudentData2= new Application{Name ="Rahul Gupta",Rollnumber = 2,Grade="B"};
        Console.WriteLine("Students Detail:-");
        StudentData1.PrintStudentDetail();
        StudentData2.PrintStudentDetail();
    }
} 