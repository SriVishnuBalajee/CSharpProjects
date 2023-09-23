// See https://aka.ms/new-console-template for more information
using EmployeeClient;
Console.WriteLine("Hello, World!");
//EmpCLient.CallGetEmployee().Wait();
//EmpCLient.CallGetEmployeeObj().Wait();
//EmpCLient.AddEmployee().Wait();
//EmpCLient.ModifyEmployee().Wait();
EmpCLient.DeleteEmployee().Wait();
Console.ReadLine();