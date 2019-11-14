using System;

namespace DesignPatternStudy.SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                God god = God.Instance();
                god.Say();
            }

            Console.Read();
        }
    }
}