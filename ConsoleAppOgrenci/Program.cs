using System;

namespace ConsoleAppOgrenci
{
   class Talebe
    {
        public string name;
        public int number;
        public int grade;


        public void info()
        {

            Console.WriteLine("Student Name:{0}",name);
            Console.WriteLine("Student Number:{0}", number);
            Console.WriteLine("Student Grade:{0}", grade);
        }


    }

    
    class Program
    {
        static void Main(string[] args)
        {

            Talebe tb1 = new Talebe();
            
            tb1.name = "MARK TYSON";
            tb1.number = 265;
            tb1.grade = 9;

            tb1.info();
            
        }
    }
}
