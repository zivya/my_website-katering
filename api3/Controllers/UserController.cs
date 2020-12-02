using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Cors;
using System.Web.Http;
namespace api3.Controllers
    
{
    [EnableCors("*","*","*")]
[RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("register/{tz}/{firstname}/{lastname}/{tel}/{email}/{permi}/{pass}")]
        public IHttpActionResult Register(string tz, string firstname, string lastname, string tel, string email, string permi, string pass)
        {
            //bool b= Bl.CustBl.Register(cust);
            // if(b==true)
            return Ok();
            // return BadRequest();
        }
        [Route("login/{id}/{password}")]
        public IHttpActionResult Login(string id, string password)
        {
            Dto.CustDto c = Bl.CustBl.Login(id, password);
            if (c != null)
                return Ok(c);
            return BadRequest();
        }
    }
}
