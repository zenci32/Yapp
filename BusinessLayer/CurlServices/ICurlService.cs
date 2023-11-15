using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.CurlServices
{
    public interface ICurlService
    {
        Task<IDataResult<string>> Login2();
    }
}
