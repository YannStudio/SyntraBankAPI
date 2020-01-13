using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraBankAPI.Api.Repositories
{
    public interface IRepository<T>
    {
        IList<T> Get();

    }
}
