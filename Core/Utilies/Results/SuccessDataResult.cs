using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilies.Results
{
    //Data old. için dönüş tipini belirtiyoruz.
    public class SuccessDataResult<T> : DataResult<T>
    {
        //genelde ilk ikisi(method) kullanılır.diğerleri farklı kullanımları
        //succes i parametre olarak vermeye gerek yok.true olarak verdik.çinkü zaten succesdeyiz.
        public SuccessDataResult(T data, string message) : base(data, success:true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, success:true)
        {
        }

        public SuccessDataResult(string message) : base(default,success:true,message)
        {
        }

        public SuccessDataResult() :base(default,success:true)
        {
        }
    }
}
