using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Model : Entity<int>
    {
        
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public string Name { get; set; }
        [MinLength(2, ErrorMessage = "İsim en az 2 karakterden oluşabilir.")]
        public decimal DailyPrice { get; set; }
        [Range(0.01, double.MinValue, ErrorMessage = "Günlük Fiyat 0 dan büyük olmalıdır.")]
        public short Year {  get; set; }
      
        public Model()
        {

        }
        public Model(int brandid, int fuelid, int transmissionid, string name, decimal dailyPrice, short year)
        {
            BrandId = brandid;
            FuelId = fuelid;
            TransmissionId = transmissionid;
            Name = name;
            DailyPrice = dailyPrice;
            Year = year;
        }

    }
}