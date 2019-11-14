using System;

namespace DesignPatternStudy.AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractChinaFactory chinaFactory = new JingDeZhenChinaFactory();
            AbstractBowl bowl = chinaFactory.CreateBowl();
            AbstractPlate plate = chinaFactory.CreatePlate();
            Console.WriteLine($"生产了一个{bowl.GetColor()}{bowl.GetShape()}的碗");
            Console.WriteLine($"生产了一个{plate.GetColor()}{plate.GetShape()}的盘子");

            chinaFactory = new YuZhouChinaFactory();
            bowl = chinaFactory.CreateBowl();
            plate = chinaFactory.CreatePlate();
            Console.WriteLine($"生产了一个{bowl.GetColor()}{bowl.GetShape()}的碗");
            Console.WriteLine($"生产了一个{plate.GetColor()}{plate.GetShape()}的盘子");

            Console.ReadLine();
        }
    }
}