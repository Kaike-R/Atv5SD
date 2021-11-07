using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TokenApi.Repositories;

using System.Linq;
using TokenApi.Models;
using System.Collections.Generic;

namespace TokenApi.Controllers
{
    [Route("v1/Costumer")]

    public class CostumerController:ControllerBase
    {
        [HttpGet]
        [Route("getall")]
        public async Task<ActionResult<dynamic>> GetUser()
        {
            
            var conta = new CustomerDemografics().GetAll();
            var conta2 = new CustomerWishListRepository().GetAll();

            var conta3 = conta.Join(conta2,conta=>conta.Id,conta2 =>conta2.Id,(conta,conta2)=> new {Id = conta.Id,Nome = conta.Nome,conta.Endereco,conta2.Produto});

            return Ok(conta3);
            

        }
    }
}