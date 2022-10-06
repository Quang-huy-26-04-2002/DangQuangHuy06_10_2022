using CourseSignupSystem.Application.Catalog.Dtos;
using CourseSignupSystem.Application.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public interface IPublicProductServise
    {
        PagedViewModel<ProducViewModel> GetAllByCategory(int categoryId, int SoTT, int KichCo);
    }
}
