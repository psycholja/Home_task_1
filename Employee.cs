using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Employee
{
    class Employee
    {
        public string name1;
        public string name2;
        public int exp;
        public int qual;
        public int bonus;

        public Employee(string a, string b, int c, int d) {name1=a;name2=b;exp=c;qual=d;}

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name1}\nФамилия: {name2}\nСтаж:{exp}\nКвалификация:{qual}");
        }
        public int GetBonusPercent()
        {
            {
                if (exp < 1)
                {
                    bonus = 0;
                }
                if ((exp>=1)&&(exp<5))

                {
                    bonus = 5;
                }
                
                if ((exp>=5)&&(qual<3)) 
                {
                    bonus=10;
                }
                if ((exp>5)&&(qual>=3)&&(qual<=4)) 
                {
                    bonus=15;
                }
                if ((exp>5)&&(qual==5))
                {
                    bonus = 20;
                }
                return bonus;



            }






        }
    }
}






    

