using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public void Add(Transmission transmission);
        public void Update(Transmission transmission);
        public void Delete(Transmission transmission);
        public IList<Transmission> GetAll();
        public Transmission GetById(int id);
    }
}
