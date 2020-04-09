using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChinookMusicStore.Web.AspNetCore.Utilities
{
    public interface IRESTClient
    {
        HttpClient Client { get; }
        void Commit();
    }
}
