using Core.Utilies.Results;
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
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);

        IResults Add(Product product);//ıresult döndürüyoruz başarılımı değil mi veya messaj döndürmüş oluruz.data değil.?
        IResults Update(Product product);
        IResults Delete(Product product);
    }
}
