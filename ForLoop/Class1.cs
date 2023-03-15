using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Class1
    {

        int num { get; set; }

        private void GetNumberFromUser()
        {
            Console.WriteLine("Enter Any Number");
            num = Convert.ToInt32(Console.ReadLine());

        }

        public void StarPattern1()
        {
            GetNumberFromUser();

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }
        }
        public void StarPattern2()
        {
            GetNumberFromUser();
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }
        }
        public void StarPattern3()
        {
            GetNumberFromUser();
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }
        }
        public void StarPattern4()
        {
            GetNumberFromUser();
            for (int i = 1; i <= num; i++)
            {
                for (int k = num - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }
        }
        public void StarPattern5()
        {
            GetNumberFromUser();
            for (int i = 1; i <= num; i++)
            {
                Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }
            for (int i = num - 1; i >= 1; i--)
            {
                Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }

        }
        public void StarPattern6()
        {
            GetNumberFromUser();
            for (int i = 1; i <= num; i++)
            {
                Console.Write("  ");
                for (int k = num - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }
            for (int i = num - 1; i >= 1; i--)
            {
                Console.Write("  ");
                for (int k = num - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                    Console.Write(" *");
                {
                    Console.WriteLine();
                }
            }

        }
    }
}