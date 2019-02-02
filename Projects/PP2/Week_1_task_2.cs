using System;
namespace PP2
{
    class Student 
    {
        private int id;
        private static int idIncrement = 0;
        private string name;
        private int year;
        public Student (string name, int year)
        {
            this.id = idIncrement++;
            this.name = name;
            this.year = year;
        }
        public string Getname()
        {
            return this.name;
        }
        public int GetYear()
        {
            return this.year;
        }
        public int GetId()
        {
            return this.id;
        }
        public void IncrementYear()
        {
            year++;
        }
    }
    class MainClass
    {
        public static void Main (string[ ] args)
        {
            Student W = new Student("gfhfkj", 4);
            Student Q = new Student("gfhfkj", 1);
            Console.WriteLine(W.Getname() + " " + W.GetId() + " " + W.GetYear());

            Console.WriteLine(Q.Getname() + " " + Q.GetId() + " " + Q.GetYear());

            Q.IncrementYear();

            Console.WriteLine(Q.Getname() + " " + Q.GetId() + " " + Q.GetYear());

        }
    }
}
