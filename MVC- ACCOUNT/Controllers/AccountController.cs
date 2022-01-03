using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC__ACCOUNT.Models;

namespace MVC__ACCOUNT.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<Account> accounts = new List<Account>();
            accounts.Add(new Account() { ID = 203, AccountHolderName = "Sowmya", AccountHolderAddress = "Subhash Road, Anantapur" });
            accounts.Add(new Account() { ID = 204, AccountHolderName = "Chinni", AccountHolderAddress = "Ramachandra Nagar, Anantaput" });
            accounts.Add(new Account() { ID = 205, AccountHolderName = "Arun Kumar", AccountHolderAddress = "KLD Bypass, Anantapur" });
            ViewData["accounts"] = accounts;
            return View();
        }
    }
}
