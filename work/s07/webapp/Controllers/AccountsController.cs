using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapp.Models;
using webapp.Services;

namespace webapp.Controllers {
    
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase {
        
        public AccountsController(JsonFileAccountService accountService) {
            AccountService = accountService;
        }

        public JsonFileAccountService AccountService { get; }

        [HttpGet]
        public IEnumerable<Account> Get() {
            return AccountService.GetAccounts();
        }

        [HttpGet("{nr}")]
        public IEnumerable<object> Get(int nr) {
            var accounts = AccountService.GetAccounts().Where(account => account.Number == nr).ToArray();
            return accounts.Any() ? (IEnumerable<object>) accounts : new []{"Error: No Data"};
        }


    }
}