using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SupplyChain.Web.AspNetCore.Repositories
{
    public interface IRESTClient
    {
        HttpClient Client { get; }
        void Commit();
    }
}
