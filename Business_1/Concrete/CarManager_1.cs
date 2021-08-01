using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarService _carService;

        public CarManager(ICarDal carDal)
        {
            _carService = (ICarService)carDal;
        }

        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }
    }
}
