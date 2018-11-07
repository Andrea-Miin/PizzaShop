using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infrastructure
{
    class ContextPizzashop : DbContext, IContextPizzashop
    {
        public Pizza Add(PizzaCreate pizzaCreate)
        {
            
        }
    }
}
