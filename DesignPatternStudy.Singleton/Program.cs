using System;
using System.Threading.Tasks;

namespace DesignPatternStudy.Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    LimitedGod god = LimitedGod.Instance();
                    god.Say();
                });
            }

            Console.Read();
        }
    }
}