using Business.Abstract;
using ConsoleUI;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FuelManager:IFuelService
    {
        private readonly IFuelDal _fuelDal;

        public FuelManager(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }

        public void Add(Fuel fuel)
        {
            _fuelDal.Add(fuel);
        }

        public void Delete(Fuel fuel)
        {
            _fuelDal.Delete(fuel);

        }

        public IList<Fuel> GetAll()
        {
           return _fuelDal.GetList();
        }

        public Fuel GetById(int id)
        {
          return  _fuelDal.GetById(id);
        }

        public void Update(Fuel fuel)
        {
            _fuelDal.Update(fuel);
        }
    }
}
