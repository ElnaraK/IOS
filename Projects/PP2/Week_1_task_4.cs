using System;

namespace PP2
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            char[,] array = new char [num,num];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("[*]");                        
                        }else{
                        continue;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
