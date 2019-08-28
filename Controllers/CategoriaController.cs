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
    public class CategoriaController : ControllerBase
    {
         private BloggingContext context;
        public CategoriaController(BloggingContext dbContext)
        {
            context = dbContext;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return context.Categorias.Include(x => x.ID).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            var prod = context.Products.Find(id);
            if(prod !=null)
            {
              return context.Categorias.FirstOrDefault (x => x.ID == id);
            }else{
                return NotFound();
            }  
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Categoria categoria)
        {
           context.Categorias.Add(categoria);
            context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Categoria categoria)
        {
            
            var cat = context.Categorias.Find(id);
            if(cat !=null)
            {
            cat.ID = categoria.ID;
            cat.Nombre = categoria.Nombre;
            return Ok();
            }else{
                return NotFound();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cat = context.Categorias.Find(id);
            if(cat !=null)
            {
           context.Categorias.Remove(cat);
           context.SaveChanges();
           return Ok();
            }else{
                return NotFound();
            }
        }
        
    }
}
