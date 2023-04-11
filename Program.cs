using System.Diagnostics.SymbolStore;

namespace Lecture_2_Constructor
{
    internal class Program
    {
        List<Student> _students;
        static List<Bullet> _bullets = new List<Bullet>();
        static void Main(string[] args)
        {
            // internal
            // private
            // protected
            // public
            Preload();
            Bullet bill = new Bullet("Bill", 0, 0, 1, 50);
            Player player1 = new Player(100);

            Console.WriteLine(player1.Hp);
            player1.OnImpact(bill);

            Console.WriteLine(player1.Hp);


            //int count = 0;
            //int end = 1000;
            //while (count <= end)
            //{
            //    //Console.WriteLine(bill);
            //    //bill.UpdateLocation();
            //    //count++;
            //    //Thread.Sleep(300);
            //    //Console.Clear();
            //    foreach (Bullet bullet in _bullets)
            //    {
            //        bullet.UpdateLocation();
            //        Console.WriteLine(bullet);
            //    }
            //    Thread.Sleep(100);
            //    count++;
            //    Console.Clear();

            //}




        }

        public static void Preload()
        {
            string[] names = { "Bill", "Sam", "George", "Bob", "Tom" };
            Random rand = new Random();
            foreach (string name in names)
            {
                int x = rand.Next(0, 11);
                int y = rand.Next(0, 21);
                float v = rand.Next(-3, 3) + (float)rand.NextDouble();
                _bullets.Add(new Bullet(name, x, y, v, 1));
            }
        }

        public static void ExampleStudent()
        {
            Student student1 = new Student("Ronda", 100, 110);
            Student student2 = new Student("Will", 57, 23);
            student1.Average();

            GradeAverage(student1.CsiGrade, student2.GenEdGrade);
        }

        public static double GradeAverage(double a, double b)
        {
            return (a + b) / 2;
        }
            
    }
}