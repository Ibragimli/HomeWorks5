using System;

namespace homeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Product classi yaradin ve asagidaki xususiyyetleri olsun Name - mehsulun adini ifade eden xususiyyet BrandName - Mehsulun brand adi
            //Price - Mehsulun qiymeti.

            //2.1-ci tapsiriqda yaratdiginiz product classiin istifade edeceksiniz.  Program.cs fayinda (dunen ki ev tapsiriqlarind da etdiyimiz kimi) bir metod yaradin,
            //o metod parametr olaraq  Product arrayi,double olaraq minPrice ve maxPrice deyerleri qebul etsin ve gonderilen product arrayinde
            //Price xususiyyetinin deyeri gonderilen minPrice ve maxPrice araliginda olan productlardan ibaret yeni bir array qaytarsin


            //3.Vehicle class-i yaradin Color ve Name xususiyyetleri olsun.Car classi yaradin Vehicleden miras alsin ve elave olaraq Brand,Model xususiyyetleri olsun



            #region Product

            Product product1 = new Product
            {
                Name = "Iphone 13 Pro",
                BrandName = "Iphone",
                Price = 500.08
            };

            Product product2 = new Product
            {
                Name = "Iphone 13",
                BrandName = "Iphone",
                Price = 450
            };

            Product product3 = new Product
            {
                Name = "A53",
                BrandName = "Samsung",
                Price = 300
            };

            Product product4 = new Product
            {
                Name = "Note 4",
                BrandName = "Xiaomi",
                Price = 320.56

            };

            Product product5 = new Product();
            product5.Name = "Poco X3 pro";
            product5.BrandName = "Xiaomi";
            product5.Price = 430;

            Product product6 = new Product
            {
                Name = "S12",
                BrandName = "Samsung",
                Price = 490
            };
            Product product7 = new Product
            {
                Name = "Redmi 3",
                BrandName = "Xiaomi",
                Price = 200
            };
            Product product8 = new Product
            {
                Name = "POCO F3",
                BrandName = "Xiaomi",
                Price = 480.45
            };
            Product product9 = new Product
            {
                Name = "S6",
                BrandName = "Samsung",
                Price = 250.23
            };
            Product product10 = new Product
            {
                Name = "Iphone 12 Pro",
                BrandName = "Iphone",
                Price = 600.40
            };
            #endregion

            Product[] products = new Product[] { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };


            #region Car

            Car car1 = new Car
            {
                Name = "M3",
                Model = "Sport",
                Brand = "BMW",
                Color = "Black"
            };

            Car car2 = new Car
            {
                Name = "X6",
                Model = "Offroader / SUV",
                Brand = "BMW",
                Color = "White"
            };

            Car car3 = new Car
            {
                Name = "GLS 580",
                Model = "Offroader / SUV",
                Brand = "Mercedes",
                Color = "Red"
            };

            Car car4 = new Car
            {
                Name = "C240",
                Model = "Sedan",
                Brand = "Mercedes",
                Color = "Black"
            };

            Car car5 = new Car
            {
                Name = "Cruze",
                Model = "Sedan",
                Brand = "Chevrolet",
                Color = "Red"
            };
            #endregion

            Car [] cars = new Car[] { car1, car2, car3, car4, car5 };
            foreach (var car in cars)
            {
                Console.WriteLine($"BrandName-{car.Brand}, Name-{car.Name}, Model-{car.Model},  Color-{car.Color} ");
            }
        }



        #region priceMinMax
        //static Product[] PriceMaxMin(Product[] product, double minPrice, double maxPrice)
        //{
        //    Product[] arry = { };
        //    foreach (var item in product)

        //    {
        //        double  priceDB = Convert.ToDouble(item.Price);

        //        Console.WriteLine(priceDB);
        //    }
        //    return arry;
        //}

        #endregion

        

    }
}
