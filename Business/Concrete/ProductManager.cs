using Business.Abstract;
using Business.Contants;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //MAGİC STRİNG den uzak durmak gerekli.(Messages.ProductAdded)kurtulduk.
    //işleri yazdığımız yer. yani if leri yazdığımız kısım.
    // iş katmanıda veri erişim katmanını çağırmamız gerek.
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResults Add(Product product)
        {
            //iş kuralı yazılacak .Örneğin bir eklenen bir daha eklenmesin gibi.
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResults Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);

        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(filter: p => p.ProductId == productId));

        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(filter:p=> p.CategoryId == categoryId).ToList());
        }

        public IResults Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUptaded);

        }
    }
}
