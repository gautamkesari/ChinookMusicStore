using SupplyChain.Web.AspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChinookMusicStore.Web.AspNetCore.Utilities
{
    public class RESTClient : IRESTClient
    {
        public HttpClient Client { get; }

        public RESTClient(AppKeys appKeys)
        {
            Client = new HttpClient();
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Client.BaseAddress = new Uri($"{appKeys.BackendUrl}/");
        }

        public void Commit()
        {
        }

        //public void Dispose()
        //{
            
        //}
    }
}
