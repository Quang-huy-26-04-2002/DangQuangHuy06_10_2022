using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CourseSignupSystem.Application.Catalog.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public interface IManageProductServise
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int productId);
        Task<List<ProducViewModel>> GetAll();
        Task<PagedViewModel<ProducViewModel>> GetAllpaging(String TimKiem , int SoTT, int KichCo);

    }
}
