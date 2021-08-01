using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete.InMemory
{
     public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car {CarId=104,CategoryId=1,ColorId=12,BrandId=17,ModelYear=2007,DailyPrice=150,Description="Sedan"},
                new Car {CarId=105,CategoryId=4,ColorId=13,BrandId=34,ModelYear=2009,DailyPrice=250,Description="Hatchback"},
                new Car {CarId=108,CategoryId=7,ColorId=14,BrandId=156,ModelYear=2013,DailyPrice=300,Description="Cabrio"},
                new Car {CarId=110,CategoryId=13,ColorId=15,BrandId=224,ModelYear=2016,DailyPrice=350,Description="SUV"},
                new Car {CarId=120,CategoryId=17,ColorId=16,BrandId=121,ModelYear=2021,DailyPrice=400,Description="Pick up"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }
        public void Delete(Car car)
        {
            //LINQ - Language Integrated Query
            //Lambda işareti
            Car CarToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);

            _car.Remove(CarToDelete);
        }
        public List<Car> GetAll()
        {
            return _car;
        }
        public List<Car> GetAllCategory(int categoryId)
        {
            return _car.Where(p => p.CategoryId == categoryId).ToList();
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = carToUpdate.DailyPrice;
            carToUpdate.Description = carToUpdate.Description;
        }
    }
}
