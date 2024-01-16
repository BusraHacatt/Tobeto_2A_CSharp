using Business.Requests.Brand;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using ConsoleUI;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IFuelService
    {
        public void Add(Fuel fuel);
        public void Update(Fuel fuel);
        public void Delete(Fuel fuel);
        public IList<Fuel> GetAll();
        public Fuel GetById(int id);
    }
}
