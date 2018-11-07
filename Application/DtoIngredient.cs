using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class DtoIngredient
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Pizza Pizza { get; set; }
        static void create() { }
    }

    /*public abstract class DtoIngredient : Ingredient
   {
       public DtoIngredient = Ingredient ingredient
       {
           this.Name = ingredient.Name
           this.Price = ingredient.Price
           this.Pizza = ingredient.Pizza
           this.Create = ingredient.Create
       }

   }*/
}

