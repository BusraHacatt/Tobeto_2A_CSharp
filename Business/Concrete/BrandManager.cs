using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        private readonly BrandBusinessRules _brandBusinessRules;
        private IMapper _mapper;

        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper)
        {
            _brandDal = brandDal;
            _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
        }

        public AddBrandResponse Add(AddBrandRequest request)
        { 
            _brandBusinessRules.CheckIfBrandNameExists(request.Name);

           

            Brand brandToAdd = _mapper.Map<Brand>(request);    
            _brandDal.Add(brandToAdd);

          
            AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
            return response;
        }



        public DeleteBrandResponse Delete(int id)
        {
            Brand brandToDelete = _brandBusinessRules.FindBrandId(id);
            brandToDelete.DeletedAt = DateTime.Now;
            DeleteBrandResponse response = _mapper.Map<DeleteBrandResponse>(brandToDelete);
            return response;

        }

        public GetBrandListResponse GetList(GetBrandListRequest request)
        {
            IList<Brand> brandList = _brandDal.GetList();
            

            GetBrandListResponse response = _mapper.Map<GetBrandListResponse>(brandList);
            return response;
        }



        public UpdateBrandResponse Update(int id, UpdateBrandRequest request)
        {

            Brand brandToUpdate = _brandBusinessRules.FindBrandId(id);
            brandToUpdate.Name = request.Name;
            brandToUpdate.UpdatedAt = DateTime.Now;
            UpdateBrandResponse response = _mapper.Map<UpdateBrandResponse>(brandToUpdate);
            return response;


        }



    }
}