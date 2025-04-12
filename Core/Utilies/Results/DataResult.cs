using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilies.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success, string message) : base(success, message)
        {
           
            Data = data;
        }

        public DataResult(T data,bool success):base(success) 
        {
            //burada datayı mesajsız göndeririz.
            //base resulttır.
            Data = data;
        }

        public T Data {  get; set; }

       
    }
}
