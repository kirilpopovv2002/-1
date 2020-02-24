using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            Console.WriteLine("введите название");
            gun.NameEdit(Console.ReadLine());
            Console.WriteLine("введите калибр");
            gun.CaliberEdit(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("введите дальность");
            gun.RangeEdit(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Название:{0}\nКалибр:{1}\nДальность:{2}",gun.NameInfo(), gun.CaliberInfo(), gun.RangeInfo());
            gun.ToString();
            Console.ReadKey();
        }
    }
}
