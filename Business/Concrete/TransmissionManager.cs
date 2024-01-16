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
    public class TransmissionManager : ITransmissionService
    {
        private readonly ITransmissionDal _transmissionDal;

        public TransmissionManager(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }

        public void Add(Transmission transmission)
        {
            _transmissionDal.Add(transmission);
        }

        public void Delete(Transmission transmission)
        {
            _transmissionDal.Delete(transmission);
        }

        public IList<Transmission> GetAll()
        {
            return _transmissionDal.GetList();
        }

        public Transmission GetById(int id)
        {
            return _transmissionDal.GetById(id);
        }

        public void Update(Transmission transmission)
        {
            _transmissionDal.Update(transmission);
        }
    }
}
