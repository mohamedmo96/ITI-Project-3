using System.Numerics;

namespace Lap6
{
    internal class Program
    {
        abstract class Qussetion
        {
            
            public string Header { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }
            public Qussetion(string heade, string body, int mark)
            {
                this.Header = heade;
                this.Body = body;
                this.Mark = mark;
            }
            public abstract void display();
            
        }
        class MCQ : Qussetion
        {
            string[] Chooses { get; set; }
            public MCQ(string heade, string body, int mark, string[] Chooses) : base(heade, body, mark)
            {
                this.Chooses = Chooses;
            }
            public override void display()
            {
                Console.WriteLine($" Suject  {Header} , the Qusetuin is {Body} , the mark is {Mark}");
                Console.WriteLine("The choices are:");
                foreach (string choice in Chooses)
                {
                    Console.WriteLine(choice);
                }
            }
        }
        class TOF : Qussetion
        {
            public bool Answer { get; set; }
            public TOF(string heade, string body, int mark, bool answer) : base(heade, body, mark)
            {
                this.Answer = answer;
            }
            public override void display()
            {
                Console.WriteLine($" Suject  {Header} , the Qusetuin is {Body} , the mark is {Mark}");
                Console.WriteLine("The answer is: " + Answer.ToString());
            }
        }
        class calc
        {
            public int num1 { get; set; }
            public int num2 { get; set; }
            public calc()
            {
                this.num1 = num1;
                this.num2 = num2;
            }
            public  static void sum(int num1 , int num2)
            {
                Console.WriteLine($" the sum is {num1 + num2}");
            }
            public static void sub(int num1, int num2)
            {
                Console.WriteLine($" the sub is {num1 - num2}");
            }
            public static void milt(int num1, int num2)
            {
                Console.WriteLine($" the Milt is {num1 * num2}");
            }

        }
        #region Student 
        class Student
        {
            public int id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Student()
            {

            }
            public Student(int id, string name , int age)
            {
                this.id = id;
                this.Name = name;
                   this.Age = age;
            }

            public string getstring()
            {
                return $"{Age}";
            }
            public static Student operator +(Student S1, Student S2)
            {
                Student c3 = new Student();
                c3.Age = S1.Age + S2.Age;
                return c3;

                //return new Student(c1.real + c2.real, c1.img + c2.img);

            }

            public static Student operator ++(Student S1)
            {
                S1.Age++;
                return S1;
            }

            //matching operator ==,!=     <,>   <=,>==
            public static bool operator >(Student S1, Student S2)
            {
                return (S1.Age > S2.Age);
            }
            public static bool operator <(Student S1, Student S2)
            {
                return (S1.Age < S2.Age);
            }

            public static implicit operator int(Student S1)
            {
                return S1.Age;
            }

            public static explicit operator float(Student S1)
            {
                return S1.Age ;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            //MCQ m = new MCQ("Choose All ", "love C# ? ", 50 , new string[] {"Yes ", "No"});
            //m.display();

            Student c1 = new Student(1 , "ahmed" , 50);
            Student c12 = new Student();
            Student c2 = new Student(2 , "mohamed" , 40);
            Student c3 = c1 + c2;
            Console.WriteLine( c3.getstring());
            //Console.WriteLine(c3.getstring());
            //calc c = new calc();
            //calc.sum(2,3);
        }
    }
}