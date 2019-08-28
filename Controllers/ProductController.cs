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
    public class ProductController : ControllerBase
    {
        private BloggingContext context;
       
        public ProductController(BloggingContext dbContext)
        {
            context = dbContext;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return context.Products.Include(x => x.Categoria).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var prod = context.Products.Find(id);
            if(prod !=null)
            {
            return context.Products.FirstOrDefault (x => x.ID == id);

            }else{
                return NotFound();
            }    
        
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            
            context.Products.Add(product);
            context.SaveChanges();
           

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product product)
        {
            var prod = context.Products.Find(id);
            if(prod !=null)
            {
                prod.ID = product.ID;
                prod.Precio = product.Precio;
                prod.Titulo = product.Titulo;
                prod.Descripcion = product.Descripcion;
                prod.Categoria = product.Categoria;
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
           var prod = context.Products.Find(id);
            if(prod !=null)
            {
           context.Products.Remove(prod);
           context.SaveChanges();   
           return Ok();
            }else{
                return NotFound();
            }

        }
        
    }
}
