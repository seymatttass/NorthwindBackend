using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //business katmanında opersayonları saf bir şwkilde yazıyoruz generic değil.
    //parmaetre gönderilebilir.busines repositoryye uygun değildir.
    public interface IProductService
    {
        Product GetById(int productId);
        List<Product> GetList();
        List<Product> GetListByCategory(int categoryId);

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
