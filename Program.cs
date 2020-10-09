using System;

namespace ConsoleApp_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee("","",0,0);

            myEmployee.GetInfo();
            Console.WriteLine(value: $"Бонус: {myEmployee.GetBonusPercent()} %");

            Employee Tom = new Employee("Том","Иванов",6,4);

            Tom.GetInfo();
            Console.WriteLine(value: $"Бонус: {Tom.GetBonusPercent()} %");

            Employee Juan = new Employee("Хуан","Петров",10,5);

            Juan.GetInfo();
            Console.WriteLine(value: $"Бонус: {Juan.GetBonusPercent()} %");

            Employee Helen = new Employee("Хелена","Дудочник",0,1);

            Helen.GetInfo();
            Console.WriteLine(value: $"Бонус: {Helen.GetBonusPercent()} %");
        }
    }
}
