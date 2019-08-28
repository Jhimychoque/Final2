using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final.Models;
using Microsoft.EntityFrameworkCore;

namespace final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
         private BloggingContext context;
        public ClientesController(BloggingContext dbContext)
        {
            context = dbContext;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return context.Clientes.ToList();
        }

        // GET api/values/5
        [HttpGet("{UserName}")]
        public ActionResult<Cliente> Get(string username)
        {
            var cli = context.Clientes.FirstOrDefault (x => x.UserName == username);
            if(cli !=null)
            {
              return cli;
            }else{
                return NotFound();
            }  
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
           context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cliente cliente)
        {
            
            var cli = context.Clientes.Find(id);
            if(cli !=null)
            {
            cli.UserName = cliente.UserName;
            cli.Nombre = cliente.Nombre;
            cli.Apellido = cliente.Apellido;
            cli.Gmail = cliente.Gmail;
            context.SaveChanges();
            return Ok();
            }else{
                return NotFound();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cli = context.Clientes.Find(id);
            if(cli !=null)
            {
           context.Clientes.Remove(cli);
           context.SaveChanges();
           return Ok();
            }else{
                return NotFound();
            }
        }
        
    }
}
