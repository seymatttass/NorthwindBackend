using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //load konfigurasyonu yaptığımız yer.
        protected override void Load(ContainerBuilder builder)
        {
            //birisi ıproductservices isterse constructırnda biz ona productmanager veriyor olacağız.
            builder.RegisterType<ProductManager>().As<IProductService>();
            //business ıproductdal istiyordu.isterse ona efproductdal ver.
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            
        
        }
    }
}
