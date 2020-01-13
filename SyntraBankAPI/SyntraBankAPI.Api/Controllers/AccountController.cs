using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SyntraBankAPI.Api.Services;
using SyntraBankAPI.Models;

namespace SyntraBankAPI.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        //Api get method to get all bank account
        [HttpGet]
        public IActionResult Get()
        {
            var accounts = _accountService.GetAllAccounts();
            return Ok(accounts.ToArray());
        }

        //Api post method to create a new bank account
        [HttpPost]
        public IActionResult CreateNewAccount(Account item)
        {
            _accountService.AddNewAccount(item);

            return Ok();

        }
    }
}