﻿
using System;
class Program{
    public static void Main(string[] args){
     // Normal Class & Object
     Console.WriteLine("\n\n Normal Class & Object Code: ");
        Application StudentData1= new Application{Name = "Shreyanshi Srivastava",Rollnumber = 1,Grade ="A"};
        Application StudentData2= new Application{Name ="Rahul Gupta",Rollnumber = 2,Grade="B"};
        Console.WriteLine("Students Detail:-");
        StudentData1.PrintStudentDetail();
        StudentData2.PrintStudentDetail();


//Default Constructor
Console.WriteLine("\n\n Default Constructor Code: ");
Student defaultconstructor1=new Student{Name="Shreya Srivastava" ,Grade="B"};
Student defaultconstructor2=new Student{Name="Priya Singh" };
Student defaultconstructor3=new Student{Name="Jagreeti Singh" ,Grade="C"};
defaultconstructor1.PrintDetail();
defaultconstructor2.PrintDetail();
defaultconstructor3.PrintDetail();


//Parameterized Constructor
Console.WriteLine("\n\n Parameterized Constructor Code: ");
Student parameterizedConstructor = new Student("Shreyanshi Srivastava", 1, "A");
parameterizedConstructor.PrintDetail();
    }
} 