using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetModel("Лада");

            car.SetSpeed(150);


            Car secondCar = new Car();
            secondCar.SetModel("Мерс");
            secondCar.SetSpeed(1000);

            Car thirdcar = new Car();
            thirdcar.SetModel("Ferrari");
            thirdcar.SetSpeed(2000);

            Car fourthcar = new Car();
            fourthcar.SetModel("BMW");
            fourthcar.SetSpeed(1300);


            List<Car> CarList = new List<Car>();
            CarList.Add(car);
            CarList.Add(secondCar);
            CarList.Add(thirdcar);
            CarList.Add(fourthcar);

            LadaVSMerceVSFerrariVSBMW(CarList);
        }

        static public void PrintModel(Car car)
        {
            Console.WriteLine(car.GetModel());
        }

        static public void LadaVSMerceVSFerrariVSBMW(List<Car> cars)
        {
            int time = 0;
            while(true)
            {
                foreach (Car car in cars)
                {
                    int numberspace = car.GetSpeed() / 50 * time;
                    for (int i = 0; i < numberspace; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(car.GetModel());
                    Console.WriteLine();
                }
                time++;
                Thread.Sleep(1000);
                Console.Clear();
                

            }
            
        }
    }

}
