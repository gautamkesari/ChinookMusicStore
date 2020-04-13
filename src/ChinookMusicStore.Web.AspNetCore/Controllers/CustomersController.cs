using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ChinookMusicStore.Web.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChinookMusicStore.Web.AspNetCore.Controllers
{
    public class CustomersController : Controller
    {
        public HttpClient client = new HttpClient();
        public static List<Customer> customerList;
        public IActionResult Index()
        {
            IEnumerable<Customer> Customers = new List<Customer>();
            using (var httpClient = new HttpClient())
            {
                var listSuppliers = httpClient.GetStringAsync("http://localhost:62573/Customers").Result;
                Customers = JsonConvert.DeserializeObject<IEnumerable<Customer>>(listSuppliers);
                customerList = Customers.ToList();
            }
            return View(Customers);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}