using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using CurlServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CurlServices
{
    public class CurlManager : ICurlService
    {
        private readonly ICurlServices _curlServices;

        public CurlManager(ICurlServices curlServices) 
        {
            _curlServices = curlServices;
        }
        public async Task<IDataResult<string>> Login2()
        {
           var response = await _curlServices.Login2();
            return new SuccessDataResult<string>(response, "ok", 200);
        }
    }
}
