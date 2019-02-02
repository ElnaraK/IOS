using System;
namespace PP2
{
    class Task_1
    {
        public static void Main_2 (string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            int [] array = new int [num];

            for (int i = 0; i < num; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                Console.Write(array[i] + " " + array[i]);
            }
            Console.ReadKey();
        }
    }
}
