using System;

namespace ConsoleApp_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            myEmployee.exp=3;
            myEmployee.qual=4;
            myEmployee.name1="Том";
            myEmployee.name2="Иванов";
            
           


            Console.WriteLine($"Имя: {myEmployee.name1} \nФамилия: {myEmployee.name2} \nСтаж:{myEmployee.exp} (лет) \nКвалификация:{myEmployee.qual} (1-5)");
            Console.WriteLine(value: $"Бонус: {myEmployee.GetBonusPercent()} %");

            Console.ReadKey();
        }
    }
}
