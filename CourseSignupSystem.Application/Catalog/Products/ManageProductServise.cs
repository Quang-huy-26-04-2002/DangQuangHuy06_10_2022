using CourseSignupSystem.Application.Catalog.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos;
using CourseSignupSystem.Data.EF;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public class ManageProductServise : IManageProductServise
    {
        private readonly CSSDbContext _context;
        public ManageProductServise(CSSDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
          
        }
        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProducViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<ProducViewModel>> GetAllpaging(string TimKiem, int SoTT, int KichCo)
        {
            throw new NotImplementedException();
        }

    }
}
