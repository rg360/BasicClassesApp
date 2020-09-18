using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();


            Car myCar = new Car();

            myCar.CarMake = "Jeep";
            myCar.CarModel = "Wrangler";
            myCar.CarYear = 2019;

            Console.WriteLine(myCar.CarYear + " " + myCar.CarMake + " " + myCar.CarModel);


        }
    }
}
