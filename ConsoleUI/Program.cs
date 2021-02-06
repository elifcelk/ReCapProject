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

            carManager.Add(new Car { Id=1,BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = -127, Description = "Dizel ve manuel" });
            brandManager.Add(new Brand { BrandId = 1 , BrandName="x"});
           

           

           
        }
    }
}
