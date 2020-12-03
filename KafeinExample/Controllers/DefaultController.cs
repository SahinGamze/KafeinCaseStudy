using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KafeinExample.CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KafeinExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private IUser _user;
        private IProduct _product;
        public DefaultController(IUser user, IProduct product)
        {
            _user = user;
            _product = product;
        }

        [HttpGet]
        [Route("getUser/")]
        public ActionResult GetUser()
        {
            var users = _user.GetAll();
            return Ok(users);
        }

        [HttpGet]
        [Route("getProduct/")]
        public ActionResult GetProduct()
        {
            var prd = _product.GetAll();
            return Ok(prd);
        }


    }
}
