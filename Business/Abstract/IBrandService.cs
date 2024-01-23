using Business.Request.Brand;
using Business.Responses.Brand;

namespace Business.Abstract;

public interface IBrandService
{
<<<<<<< Updated upstream
    public AddBrandResponse Add(AddBrandResponse request);
    //commited
    public IList<Brand> GetList();
}
=======
    public AddBrandResponse Add(AddBrandRequest request);
    public UpdateBrandResponse Update(int id, UpdateBrandRequest request);
    public DeleteBrandResponse Delete(int id);
    public GetBrandListResponse GetList(GetBrandListRequest request);
}
>>>>>>> Stashed changes
