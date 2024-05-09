using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Sunday_may_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name1 = "Oqtay";
            //string surname1 = "Babayev";
            //int age1 = 18;

            //string name2 = "Samir";
            //string surname2 = "Qasimov";
            //int age2 = 18;


            //Console.WriteLine($"{name1} {surname1}");
            //Console.WriteLine($"{name2} {surname2}");

            Animal animal = new Animal("Rex", "German Shepherd", "Brown", 8);
            animal.GetDetails();
            Building building = new Building("Flame Towers", 120, 82, "Mehdi Huseyn str.");
            building.Characteristics();
            Student student = new Student("Arif", "Babayev", 30, new int[] { 90, 87, 88, 90, 99, 100 }, new int[] { 90, 88, 100 }, new int[] { 60, 70, 80 }, 80, new bool[] { true, true, true, true, true });
            Gun gun = new Gun("AK-47", 30, 23, 30, "assault");
            gun.StatusofaGun();
           
            
            Console.WriteLine("Enter number1");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number2");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator ");
            char _operator = Convert.ToChar(Console.ReadLine());
            char[] _operators = { '+', '-', '*', '/' };
            foreach (char opt in _operators)
            {
                if (_operator == opt)
                {
                    Calculator calculator = new Calculator(number1, number2, _operator);
                    calculator.SelectOperation();

                }

            }   
        }

    }

    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public int age;
        public Animal(string name, string breed, string color, int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{name},{breed},{color},{age}");
        }
    }

    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string addres;

        public Building(string name, int height, int area, string addres)
        {
            this.name = name;
            this.height = height;
            this.area = area;
            this.addres = addres;
        }
        public void Characteristics()
        {
            Console.WriteLine($"{name} {height} {area} {addres}");
        }

    }

    public class Student
    {
        public Student(string name, string surname, int age,
                       int[] HomeworkGrades, int[] ProjectGrades,
                       int[] QuizGrades, int FinalGrade, bool[] Continuity)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.FinalGrade = FinalGrade;
            this.Continuity = Continuity;
            this.HomeworkGrades = HomeworkGrades;
            this.QuizGrades = QuizGrades;
            this.ProjectGrades = ProjectGrades;
        }

        public string name;
        public string surname;
        public int age;
        public int[] HomeworkGrades;
        public int[] ProjectGrades;
        public int[] QuizGrades;
        int FinalGrade;
        bool[] Continuity;


    }

    public class Gun
    {

        public Gun(string name, int maxCapacity, int CurrentBullet, int TotalBullet, string type)
        {
            this.name = name;
            this.TotalBullet = TotalBullet;
            this.maxCapacity = maxCapacity;
            this.CurrentBullet = CurrentBullet;
            this.type = type;

        }
        public string name;
        public int maxCapacity;
        public int CurrentBullet;
        public int TotalBullet;
        public string type;

        public void Fire(string assault, string sniper)
        {

            if (type == assault)
                Console.WriteLine(TotalBullet - CurrentBullet);

            else if (type == sniper)
                Console.WriteLine(CurrentBullet - 1);

        }
        public void Reload()
        {
            Console.WriteLine((TotalBullet - CurrentBullet) + CurrentBullet);
        }
        public void StatusofaGun()
        {
            if (TotalBullet > maxCapacity)
            {
                Console.Write($"There is a mistake ");
            }
            Console.WriteLine($"{name} {TotalBullet} {CurrentBullet} {type}");
        }

    }

    public class Calculator
    {
        public Calculator(double number1, double number2, char _operator)
        {
            this.number1 = number1;
            this.number2 = number2;
            this._operator = _operator;
        }
        public double number1;
        public double number2;
        public char _operator;
        public double Addition()
        { 
            
            return  number1 + number2;

        }
        public double Subtraction()
        {
            
            return number1 - number2;
        }
        public double Multiplication()
        {
            
            
           return number1 * number2;
        }
        public double Division()
        {
            
        return number1 / number2;
        }
        public void SelectOperation()
        {
            
            if ( _operator == '+' )
            {
                Console.WriteLine( Addition());
            }
            else if(_operator == '-' )
            {
                Console.WriteLine( Subtraction());
            }
            else if (_operator == '*')
            {
                Console.WriteLine(Multiplication());
            }
            else if(_operator == '/')
            {
                Console.WriteLine(Division());
            }
            else 
            {
                return;
            }
          
        }
    }

}





