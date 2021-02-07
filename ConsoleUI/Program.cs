using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());




            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Id + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }



            //TEST(carManager, brandManager);

        }

        private static void TEST(CarManager carManager, BrandManager brandManager)
        {
            Console.WriteLine("----------TÜM MARKALAR-----------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("----BrandId'si 2 olan araçların bilgisi----");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("---ColorId' si 1 olan araçların modelyılı---");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
