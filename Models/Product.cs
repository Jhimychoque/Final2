using System;
namespace final.Models
{
    public class Product
    {
        
        public int ID {get; set;} 
        public int Precio{get; set;}
        public String Titulo {get; set;}
        public String Descripcion{get; set;}
        public Categoria Categoria{get; set;}


    }
}