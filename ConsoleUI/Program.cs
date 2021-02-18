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
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCostumerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());



            //AddingTest(userManager, customerManager, rentalManager);
            //TEST(carManager, brandManager);
            //TEST2(carManager);

        }

        private static void AddingTest(UserManager userManager, CustomerManager customerManager, RentalManager rentalManager)
        {
            userManager.Add(new User { UserId = 1, FirstName = "Elif", LastName = "Çelik", Email = "elifclk@gmail.com", Password = "123456" });

            customerManager.Add(new Customer { CustomerId = 1, UserId = 1, CompanyName = "Çelik" });

            rentalManager.Add(new Rental { RentalId = 1, CarId = 2, CustomerId = 1, RentDate = new DateTime(2021, 02, 20), ReturnDate = new DateTime(2021, 01, 10) });
        }


        private static void TEST2(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Id + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }


        }

        private static void TEST(CarManager carManager, BrandManager brandManager)
        {
            Console.WriteLine("----------TÜM MARKALAR-----------");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("----BrandId'si 2 olan araçların bilgisi----");
            foreach (var car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("---ColorId' si 1 olan araçların modelyılı---");
            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
