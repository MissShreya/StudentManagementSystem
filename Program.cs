
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


//Encapsulation Code
Console.WriteLine("\n\n Encapsulation Code");
Encapsulation encapsulationCode1=new Encapsulation();
encapsulationCode1.Name="Shikhar Srivastava";
encapsulationCode1.Rollnumber=12;
encapsulationCode1.Grade="ABC";


Encapsulation encapsulationCode2=new Encapsulation();
encapsulationCode2.Name="Rambha Singh";
encapsulationCode2.Rollnumber=13;
encapsulationCode2.Grade="A";


encapsulationCode1.PrintDetail();
encapsulationCode2.PrintDetail();

  // Creating objects of Student and Teacher
        Students student1 = new Students("John Doe", 20);
        Teacher teacher1 = new Teacher("Mrs. Smith", 35, "Mathematics");

        student1.DisplayDetail(); 
        teacher1.DisplayDetail(); 

//Creating objects for Polymorphism code
Console.WriteLine("\n\n Polymorphism Concept using code");

Person1 person1=new Person1{Name="ABC"};
Student1 stusdent1=new Student1{Name="Shreyanshi",Age =1,Grade ="ABCD"};

Teacher1 teacdher1=new Teacher1{Name="Karunesh Kumar",Subject="Hindi"};

person1.PrintDetail();
stusdent1.PrintDetail();
teacdher1.PrintDetail();

//Abstraction Code
Console.WriteLine("Abstraction Code");
StudentAbs studentabs= new StudentAbs{Name="Shreyanshi Sri",Age=22,Grade="A"};
TeacherAbs teacherabs= new TeacherAbs{Name="Shreyanshi Sri",Age=22,Subject="Programming"};
studentabs.PrintDetail();
teacherabs.PrintDetail();

//Interface Code
Console.WriteLine("Interface Code");
StudentIns studentins= new StudentIns("Shreyanshi Sri",22,"A");
TeacherIns teacherins= new TeacherIns("Shreyanshi Sri",22,"Programming");
studentins.PrintDetailIns();
studentins.MarkAttendance();
teacherins.PrintDetailIns();
teacherins.MarkAttendance();


    }
} 