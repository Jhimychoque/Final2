using System;
using System.Collections.Generic;
namespace final.Models
{
    public class Categoria
    {
        
        public int ID {get; set;} 
        public String Nombre{get; set;}

        public IEnumerable<Product> Productos {get; set;}
    }
}